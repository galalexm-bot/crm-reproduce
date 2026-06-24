using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Component]
public class TaskInformToFilterPortlet : ITaskBaseFilterPortlet
{
	public bool CheckGridId(string gridId)
	{
		return gridId.Equals("MyTasksInformToPortletGrid");
	}

	public ITaskBaseFilter GetTaskBaseFilter()
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.InformTo.Add(AuthenticationService.GetCurrentUser<IUser>());
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.CompleteStatus = TaskCompleteStatus.Active;
		return taskBaseFilter;
	}
}
