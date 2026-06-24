using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IUpdateFactWorkLogExtension
{
	bool Can(Guid objectUid);

	void UpdateFactWorkLog(long objectId, Guid objectUid, long deltaFactWorkLog, bool fullSumma = false);
}
