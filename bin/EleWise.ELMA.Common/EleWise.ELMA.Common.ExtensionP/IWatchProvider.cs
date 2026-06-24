using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IWatchProvider
{
	IEnumerable<Guid> TypeUid { get; }

	IEnumerable<Guid> ActionUids { get; }

	string GlobalWatchDescription { get; }

	string WatchDescription { get; }

	IEnumerable<Guid> ParentTypeUid { get; }

	bool NeedConfirmFromDelete(Guid entityTypeUid, [NotNull] object entityId);

	string TextConfirmFromDelete(Guid entityTypeUid, [NotNull] object entityId);

	bool IsAvailable(Guid entityTypeUid, object entityId);

	IEnumerable<Guid> GetParentTypeUid(IEntity entity);

	long? GetParentEntityId(IEntity entity);

	bool CanSendToUser(IEntity entity, IUser user);
}
