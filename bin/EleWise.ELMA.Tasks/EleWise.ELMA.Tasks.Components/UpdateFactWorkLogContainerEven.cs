using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Managers;

namespace EleWise.ELMA.Tasks.Components.WorkLog;

[Component(Order = 400, Type = ComponentType.Server)]
internal class UpdateFactWorkLogContainerEvents : IModuleContainerEvents
{
	public void Activated()
	{
		IBLOBDataManager bLOBManager = DataAccessManager.BLOBManager;
		int num = bLOBManager.GetBLOB<int?>(TaskConstants.TaskAssemblyUid, "UpdateFactWorkLog") ?? 0;
		if (num != 4)
		{
			bLOBManager.SetBLOB(TaskConstants.TaskAssemblyUid, "UpdateFactWorkLog", (int?)4);
		}
	}

	public void Terminating()
	{
	}
}
