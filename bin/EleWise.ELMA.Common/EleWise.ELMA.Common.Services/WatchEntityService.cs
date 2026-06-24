using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Services;

[Service]
public class WatchEntityService : IWatchEntityService
{
	public const string WatchEntityServiceDescription = "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем управлять списками наблюдателей:\r\n    /// //очищать списки наблюдателей и создавать наблюдателей    /// \r\n    /// \r\n    /// //Чтобы очистить список наблюдателей для определённого объекта используйте функцию ClearForObject(objectUid, entityId).\r\n    /// //Чтобы очистить список наблюдателей для типа объекта вместо entityId передавайте значение null.\r\n    /// PublicAPI.Services.WatchEntity.ClearForObject(objectUid, entityId)\r\n    /// \r\n    /// //Чтобы добавить пользователя в список наблюдателей используйте функцию CreateWatchByUser(typeUid, entityId, user), где\r\n    /// //Guid typeUid - идентификатор типа сущности;\r\n    /// //long? entityId - идентификатор сущности;\r\n    /// //IUser user - пользователь.\r\n    /// PublicAPI.Services.WatchEntity.CreateWatchByUser(typeUid, entityId, user);\r\n    /// </code>')";

	private Dictionary<WatchKey, List<IUser>> watchesUsers = new Dictionary<WatchKey, List<IUser>>();

	private ConcurrentDictionary<Type, List<IWatchProvider>> parentProviders = new ConcurrentDictionary<Type, List<IWatchProvider>>();

	public List<IUser> GetWatches(Guid objectUid, Guid actionUid, IEntity entity)
	{
		List<IUser> list = new List<IUser>();
		foreach (IWatchExtension item in (from p in ComponentManager.Current.GetExtensionPoints<IWatchExtension>()
			where p.Can(objectUid)
			select p).ToList())
		{
			IWatchExtension extension = item;
			IEnumerable<IUser> enumerable = from u in item.GetWatchUsers(objectUid, actionUid, entity)
				where u != null && extension.CanSendToUser(entity, u)
				select u;
			if (enumerable != null)
			{
				list.AddRange(enumerable);
			}
		}
		WatchKey key = new WatchKey
		{
			ObjectUid = objectUid,
			ActionUid = actionUid,
			EntityId = entity.GetId()
		};
		if (watchesUsers.ContainsKey(key))
		{
			list.AddRange(watchesUsers[key]);
			return list.Distinct().ToList();
		}
		IWatchProvider watchProvider = ComponentManager.Current.GetExtensionPoints<IWatchProvider>().FirstOrDefault((IWatchProvider p) => (p.ParentTypeUid.Any((Guid t) => t == objectUid) || p.TypeUid.Any((Guid t) => t == objectUid)) && (p.ActionUids.Any((Guid a) => a == actionUid) || ParentProviders(p).SelectMany((IWatchProvider pp) => pp.ActionUids).Any((Guid a) => a == actionUid)));
		if (watchProvider != null)
		{
			List<IUser> list2 = (from watch in WatchManager.Instance.BuildWatchList(objectUid, Convert.ToInt64(entity.GetId()), watchProvider.GetParentTypeUid(entity).ToArray(), watchProvider.GetParentEntityId(entity))
				where watch.User != null
				select watch.User.CastAsRealType()).Distinct().ToList();
			if (list2.Any())
			{
				watchesUsers.Add(key, list2);
			}
			list.AddRange(list2);
		}
		return list.Distinct().ToList();
	}

	private List<IWatchProvider> ParentProviders(IWatchProvider provider)
	{
		Type type = provider.GetType();
		if (parentProviders.TryGetValue(type, out var value))
		{
			return value;
		}
		value = (from p in ComponentManager.Current.GetExtensionPoints<IWatchProvider>()
			where provider.ParentTypeUid.Any((Guid pt) => p.TypeUid.Any((Guid t) => t == pt))
			select p).ToList();
		parentProviders[type] = value;
		return value;
	}

	[PublicApiNodeId("WatchEntityServicesApi")]
	public void ClearForObject(Guid objectUid, object entityId = null)
	{
		List<KeyValuePair<WatchKey, List<IUser>>> source = watchesUsers.Where((KeyValuePair<WatchKey, List<IUser>> k) => k.Key.ObjectUid == objectUid).ToList();
		if (entityId != null)
		{
			source = source.Where((KeyValuePair<WatchKey, List<IUser>> k) => k.Key.EntityId != null && k.Key.EntityId.Equals(entityId)).ToList();
		}
		source.Select((KeyValuePair<WatchKey, List<IUser>> i) => i.Key).ToList().ForEach(delegate(WatchKey key)
		{
			watchesUsers.Remove(key);
		});
	}

	[PublicApiNodeId("WatchEntityServicesApi")]
	public virtual void CreateWatchByUser(Guid typeUid, long? entityId, IUser user)
	{
		WatchManager.Instance.CreateWatchByUser(typeUid, entityId, user);
	}
}
