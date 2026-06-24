using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;

[ExtensionPoint(ComponentType.All)]
public interface IWorklogItemAccess
{
	bool HasPermission(Guid typeUid, long id);
}
