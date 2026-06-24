using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Components.Settings;

[Component(Order = 15)]
public class GeneralDocumentsSettings : ModuleSettingsDmsPageProvider
{
	public override string ModuleUid => "EleWise.ELMA.Documents.Web";

	public override string Image => "#setting_outline.svg";

	public override string Text => SR.T("Настройки модуля «Документооборот»");

	public override string Description => SR.T("Общие настройки, влияющие на работу модуля «Документооборот».");

	public override string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Index", "Settings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			module = "EleWise.ELMA.Documents",
			currentMenu = "document_module_settings",
			title = SR.T("Настройки модуля «Документооборот»")
		});
	}
}
