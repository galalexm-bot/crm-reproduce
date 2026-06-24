using System;

namespace EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;

public interface IWorkLogObjectSearchPermissionExtension : IWorkLogObjectSearchExtension
{
	bool HasPermission(Guid typeUid);
}
