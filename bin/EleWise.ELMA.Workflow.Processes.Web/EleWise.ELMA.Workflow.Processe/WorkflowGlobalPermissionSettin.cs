using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

[Component(Order = 50)]
public class WorkflowGlobalPermissionSettings : IModuleSettingsProcessesPageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.Workflow.Processes.Web";

	public string Image => "#access.svg";

	public string Text => SR.T("Права доступа к модулю «Бизнес-процессы»");

	public string Description => SR.T("Перечень прав доступа к модулю «Бизнес-процессы».");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("GlobalPermissions", "PermissionManagment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			module = "EleWise.ELMA.Workflow",
			currentMenu = "EleWise.ELMA.Workflow.Processes.Web.Controllers.ProcessHeaderController.Settings",
			title = SR.T("Права доступа к модулю «Бизнес-процессы»")
		});
	}
}
