using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWatchExtension
{
	bool Can(Guid objectUid);

	List<IUser> GetWatchUsers(Guid objectUid, Guid actionUid, IEntity entity);

	List<IWatch> GetWatches(Guid objectUid, object entityId);

	bool CanSendToUser(IEntity entity, IUser user);

	bool CanSendToUser(IWatch watch);
}
