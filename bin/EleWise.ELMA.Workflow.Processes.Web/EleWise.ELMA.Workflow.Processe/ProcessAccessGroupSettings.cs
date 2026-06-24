using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

[Component(Order = 150)]
internal sealed class ProcessAccessGroupSettings : IModuleSettingsProcessesPageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.Workflow.Processes.Web";

	public string Image => "#apps_visibility.svg";

	public string Text => SR.T("Настройки видимости процессов в Дизайнере");

	public string Description => SR.T("Настройки групп доступа, позволяющих редактировать процесс в Дизайнере");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("AccessGroups", "ProcessHeader", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		});
	}
}
