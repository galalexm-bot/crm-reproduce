using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 50)]
public class ScoringCommonHomePageProvider : ICommonHomePageProvider, IModuleSettingsPageProvider
{
	public string Description => SR.T("Раздел позволяет настроить скоринг для различных объектов системы.");

	public string Image => "#checked.svg";

	public string ModuleUid => "EleWise.ELMA.Common";

	public string Text => SR.T("Глобальные настройки скоринга");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Index", "ScoringSettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}
}
