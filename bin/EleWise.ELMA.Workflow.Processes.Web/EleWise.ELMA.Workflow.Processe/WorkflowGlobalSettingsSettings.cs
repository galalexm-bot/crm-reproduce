using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

[Component(Order = 100)]
public class WorkflowGlobalSettingsSettings : IModuleSettingsProcessesPageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.Workflow.Processes.Web";

	public string Image => "#setting_outline.svg";

	public string Text => SR.T("Общие настройки модуля «Бизнес-процессы»");

	public string Description => SR.T("Общие настройки, влияющие на работу модуля «Бизнес-процессы»");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Index", "Settings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			module = "EleWise.ELMA.Workflow",
			currentMenu = "EleWise.ELMA.Workflow.Processes.Web.Controllers.ProcessHeaderController.Settings",
			title = SR.T("Общие настройки модуля «Бизнес-процессы»")
		});
	}
}
