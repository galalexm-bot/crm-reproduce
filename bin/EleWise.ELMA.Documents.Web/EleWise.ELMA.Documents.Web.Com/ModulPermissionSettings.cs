using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Components.Settings;

[Component(Order = 20)]
public class ModulPermissionSettings : ModuleSettingsDmsPageProvider
{
	public override string ModuleUid => "EleWise.ELMA.Documents.Web";

	public override string Image => "#access.svg";

	public override string Text => SR.T("Права доступа к модулю «Документооборот»");

	public override string Description => SR.T("Перечень прав доступа к модулю «Документооборот».");

	public override string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("GlobalPermissions", "PermissionManagment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			module = "EleWise.ELMA.BPM.Web.Documents",
			currentMenu = "document_module_settings",
			title = SR.T("Права доступа к модулю «Документы»")
		});
	}
}
