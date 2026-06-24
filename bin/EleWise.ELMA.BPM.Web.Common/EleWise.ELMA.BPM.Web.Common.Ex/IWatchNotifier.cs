using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWatchNotifier
{
	bool IsAvailable(Guid TypeUid);

	void Notify(object entityId, IEnumerable<IUser> addUsers, IEnumerable<IUser> deleteUsers);
}
