using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Common.Security;

[Component(Order = 70)]
public class CatalogWebPermissionsPage : IModulePermissionsPageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.BPM.Web.Common";

	public string Image => "#objects_access.svg";

	public string Text => SR.T("Справочники");

	public string Description => SR.T("Раздел содержит настройки доступа к справочникам.");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Permissions", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}
}
