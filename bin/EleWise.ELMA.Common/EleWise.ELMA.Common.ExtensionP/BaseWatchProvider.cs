using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.ExtensionPoints;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class BaseWatchProvider : IWatchProvider
{
	public abstract IEnumerable<Guid> TypeUid { get; }

	public abstract IEnumerable<Guid> ActionUids { get; }

	public virtual string GlobalWatchDescription => string.Empty;

	public virtual string WatchDescription => string.Empty;

	public virtual IEnumerable<Guid> ParentTypeUid
	{
		get
		{
			yield break;
		}
	}

	public virtual bool NeedConfirmFromDelete(Guid entityTypeUid, object entityId)
	{
		return false;
	}

	public virtual string TextConfirmFromDelete(Guid entityTypeUid, object entityId)
	{
		return "";
	}

	public virtual bool IsAvailable(Guid entityTypeUid, object entityId)
	{
		bool result = TypeUid?.Contains(entityTypeUid) ?? false;
		if (entityId == null)
		{
			return result;
		}
		List<IWatchExtension> list = (from p in ComponentManager.Current.GetExtensionPoints<IWatchExtension>()
			where p.Can(entityTypeUid)
			select p).ToList();
		if (!list.Any())
		{
			return result;
		}
		Type entityType = ModelHelper.GetEntityType(entityTypeUid);
		if (entityType == null)
		{
			return result;
		}
		IEntityManager entityManager = ModelHelper.GetEntityManager(entityType);
		if (entityManager == null)
		{
			return result;
		}
		if (entityManager.LoadOrNull(ModelHelper.TryConvertEntityId(entityType, entityId)).CastAsRealType() is IEntity entity)
		{
			return IsAvailableWatching(entity, list);
		}
		return result;
	}

	private static bool IsAvailableWatching(IEntity entity, List<IWatchExtension> extensions)
	{
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		return extensions.Any((IWatchExtension watchExtension) => watchExtension.CanSendToUser(entity, currentUser));
	}

	public virtual IEnumerable<Guid> GetParentTypeUid(IEntity entity)
	{
		return ParentTypeUid;
	}

	public virtual long? GetParentEntityId(IEntity entity)
	{
		return null;
	}

	public virtual bool CanSendToUser(IEntity entity, IUser user)
	{
		return true;
	}
}
