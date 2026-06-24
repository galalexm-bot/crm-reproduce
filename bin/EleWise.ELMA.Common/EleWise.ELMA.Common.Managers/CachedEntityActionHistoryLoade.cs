using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Common.Managers;

public sealed class CachedEntityActionHistoryLoader : IEntityActionHistoryLoader
{
	internal class EntityHistoryRowKey : IStructuralEquatable, IStructuralComparable, IComparable
	{
		public IUser CreationAuthor { get; set; }

		public DateTime ActionDate { get; set; }

		public Guid ActionObjectUid { get; set; }

		public Guid ActionTypeUid { get; set; }

		public long? ActionObjectId { get; set; }

		public Guid UnitOfWorkUid { get; set; }

		public Guid? SessionUid { get; set; }

		public Guid EventArgsUid { get; set; }

		public Guid Uid { get; set; }

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			if (other is EntityHistoryRowKey entityHistoryRowKey)
			{
				return Uid == entityHistoryRowKey.Uid;
			}
			return false;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return base.GetHashCode();
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (!(other is EntityHistoryRowKey entityHistoryRowKey))
			{
				throw new ArgumentNullException("other");
			}
			return comparer.Compare(ActionDate, entityHistoryRowKey.ActionDate);
		}

		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
		}

		public static EntityHistoryRowKey Create(EntityActionEventArgs args)
		{
			return new EntityHistoryRowKey
			{
				CreationAuthor = args.ActionAuthor,
				ActionDate = args.ActionDate,
				UnitOfWorkUid = args.UnitOfWorkUid,
				Uid = (Guid)(args.ExtendedProperties.ContainsKey("EntityActionHistory_Uid") ? args.ExtendedProperties["EntityActionHistory_Uid"] : ((object)Guid.Empty)),
				SessionUid = (Guid?)(args.ExtendedProperties.ContainsKey("EntityActionHistory_SessionUid") ? args.ExtendedProperties["EntityActionHistory_SessionUid"] : null),
				ActionTypeUid = args.Action.Uid,
				ActionObjectId = (long?)(args.Old ?? args.New).GetId(),
				ActionObjectUid = args.Object.Uid,
				EventArgsUid = AttributeHelper<UidAttribute>.GetAttribute(args.GetType(), inherited: false).Uid
			};
		}
	}

	private readonly IDictionary<Tuple<Guid, long?, Guid?>, bool> cachedByObjectTypeId = new Dictionary<Tuple<Guid, long?, Guid?>, bool>();

	private readonly IDictionary<KeyValuePair<Guid, Guid>, List<EntityActionEventArgs>> cachedByUoWObjectType = new Dictionary<KeyValuePair<Guid, Guid>, List<EntityActionEventArgs>>();

	private readonly IDictionary<Tuple<Guid, Guid, Guid, long?>, bool> cachedByTuple = new Dictionary<Tuple<Guid, Guid, Guid, long?>, bool>();

	private readonly IDictionary<Guid, List<EntityActionEventArgs>> cachedByUoW = new Dictionary<Guid, List<EntityActionEventArgs>>();

	private readonly IDictionary<EntityHistoryRowKey, EntityActionEventArgs> cachedEventArgs = new Dictionary<EntityHistoryRowKey, EntityActionEventArgs>();

	private readonly IList<EntityActionEventArgs> cachedCollection;

	private EntityActionHistoryManager Manager => EntityActionHistoryManager.Instance;

	public CachedEntityActionHistoryLoader(IEnumerable<EntityActionEventArgs> cachedCollection)
	{
		EntityActionEventArgs[] array = (cachedCollection as EntityActionEventArgs[]) ?? cachedCollection.ToArray();
		this.cachedCollection = ((cachedCollection == null) ? new List<EntityActionEventArgs>() : new List<EntityActionEventArgs>(array));
		cachedEventArgs = array.ToDictionary(EntityHistoryRowKey.Create);
	}

	public IEnumerable<EntityActionEventArgs> LoadHistory(IEntity<long> entity)
	{
		Guid actionObject = InterfaceActivator.UID(entity.GetType());
		return LoadHistory(actionObject, entity.Id);
	}

	public IEnumerable<EntityActionEventArgs> LoadHistory(Guid actionObject, long? objectId, Guid? actionType = null)
	{
		Tuple<Guid, long?, Guid?> key = new Tuple<Guid, long?, Guid?>(actionObject, objectId, actionType);
		List<EntityActionEventArgs> list = ((!objectId.HasValue && !actionType.HasValue) ? (from kv in cachedEventArgs
			where kv.Key.ActionObjectUid == actionObject
			select kv.Value).ToList() : ((!actionType.HasValue) ? (from kv in cachedEventArgs
			where kv.Key.ActionObjectUid == actionObject && kv.Key.ActionObjectId == objectId
			select kv.Value).ToList() : (objectId.HasValue ? (from kv in cachedEventArgs
			where kv.Key.ActionObjectUid == actionObject && kv.Key.ActionObjectId == objectId && kv.Key.ActionTypeUid == actionType.Value
			select kv.Value).ToList() : (from kv in cachedEventArgs
			where kv.Key.ActionObjectUid == actionObject && kv.Key.ActionTypeUid == actionType.Value
			select kv.Value).ToList())));
		if (cachedByObjectTypeId.ContainsKey(key) || list.Count > 0)
		{
			cachedByObjectTypeId[key] = true;
		}
		else
		{
			list = Manager.LoadHistory(actionObject, objectId, actionType).ToList();
			CacheResult(list);
			cachedByObjectTypeId.Add(key, value: true);
		}
		return list;
	}

	public IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject)
	{
		if (cachedByUoWObjectType.TryGetValue(new KeyValuePair<Guid, Guid>(unitOfWorkUid, actionObject), out var value))
		{
			return value;
		}
		value = cachedCollection.Where((EntityActionEventArgs e) => e.UnitOfWorkUid == unitOfWorkUid && e.Object.Uid == actionObject).ToList();
		if (value != null && value.Count > 0)
		{
			cachedByUoWObjectType.Add(new KeyValuePair<Guid, Guid>(unitOfWorkUid, actionObject), value);
			return value;
		}
		value = Manager.LoadHistory(unitOfWorkUid, actionObject).ToList();
		cachedByUoWObjectType.Add(new KeyValuePair<Guid, Guid>(unitOfWorkUid, actionObject), value);
		return value;
	}

	public IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject, Guid actionTypeUid, long? objectId = null)
	{
		Tuple<Guid, Guid, Guid, long?> key = new Tuple<Guid, Guid, Guid, long?>(unitOfWorkUid, actionObject, actionTypeUid, objectId);
		List<EntityActionEventArgs> list = (objectId.HasValue ? (from kv in cachedEventArgs
			where kv.Key.ActionObjectUid == actionObject && kv.Key.ActionTypeUid == actionTypeUid && kv.Key.UnitOfWorkUid == unitOfWorkUid && kv.Key.ActionObjectId == objectId
			select kv.Value).ToList() : (from kv in cachedEventArgs
			where kv.Key.ActionObjectUid == actionObject && kv.Key.ActionTypeUid == actionTypeUid && kv.Key.UnitOfWorkUid == unitOfWorkUid
			select kv.Value).ToList());
		if (cachedByTuple.ContainsKey(key) || list.Count > 0)
		{
			cachedByTuple[key] = true;
		}
		else
		{
			list = Manager.LoadHistory(unitOfWorkUid, actionObject, actionTypeUid, objectId).ToList();
			CacheResult(list);
			cachedByTuple.Add(key, value: true);
		}
		return list;
	}

	public IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid)
	{
		if (cachedByUoW.TryGetValue(unitOfWorkUid, out var value))
		{
			return value;
		}
		value = cachedCollection.Where((EntityActionEventArgs e) => e.UnitOfWorkUid == unitOfWorkUid).ToList();
		if (value != null && value.Count > 0)
		{
			cachedByUoW.Add(unitOfWorkUid, value);
			return value;
		}
		value = Manager.LoadHistory(unitOfWorkUid).ToList();
		cachedByUoW.Add(unitOfWorkUid, value);
		return value;
	}

	private void CacheResult(IEnumerable<EntityActionEventArgs> result)
	{
		foreach (EntityActionEventArgs item in result)
		{
			cachedEventArgs.Add(EntityHistoryRowKey.Create(item), item);
		}
	}
}
