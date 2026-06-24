using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 50)]
internal sealed class CatalogCommonHomePageProvider : ICommonHomePageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.BPM.Web.Common.Catalogs";

	public string Image => "#objects.svg";

	public string Text => SR.T("Справочники");

	public string Description => SR.T("Раздел позволяет настроить доступ к элементам справочника");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("CatalogSettingsPage", "Settings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}
}
