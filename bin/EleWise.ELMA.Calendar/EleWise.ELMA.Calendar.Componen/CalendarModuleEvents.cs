using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Calendar.Components;

[Component(Order = 500, Type = ComponentType.Server, EnableInterceptiors = true)]
public class CalendarModuleEvents : IModuleContainerEvents
{
	public ISecurityService SecurityService => Locator.GetService<ISecurityService>();

	private void CalendarEventFeedInfoUpdate()
	{
		IBLOBDataManager bLOBManager = DataAccessManager.BLOBManager;
		int num = bLOBManager.GetBLOB<int?>(CalendarConstants.ProjectAssemblyUid, "CalendarEventFeedInfoUpdate") ?? 0;
		if (num != 1)
		{
			if (num != 0)
			{
			}
			bLOBManager.SetBLOB(CalendarConstants.ProjectAssemblyUid, "CalendarEventFeedInfoUpdate", (int?)1);
		}
	}

	public void Activated()
	{
		SecurityService.RunWithElevatedPrivilegies(CalendarEventFeedInfoUpdate);
	}

	public void Terminating()
	{
	}
}
