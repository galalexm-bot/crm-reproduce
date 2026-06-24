using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Workflow.Processes.Web.Extensions;

namespace EleWise.ELMA.Workflow.Processes.Web.Security;

[Component(Order = 20)]
public class ModulePermissionsPageProvider : IModulePermissionsPageProvider, IModuleSettingsPageProvider, IModuleSettingsProcessesPageProvider
{
	public string ModuleUid => "EleWise.ELMA.Workflow.Processes.Web";

	public string Image => "#access.svg";

	public string Text => SR.T("Процессы");

	public string Description => SR.T("Раздел содержит перечень опубликованных бизнес-процессов. Здесь вы можете настроить параметры доступа к экземплярам бизнес-процессов (кто может видеть экземпляры, редактировать, приостанавливать бизнес-процесс и т.д.)");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Permissions", "ProcessHeader", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		});
	}
}
