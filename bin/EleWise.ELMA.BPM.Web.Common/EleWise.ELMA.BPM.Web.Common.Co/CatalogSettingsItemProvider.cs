using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Models.Buttons;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
internal sealed class CatalogSettingsItemProvider : IModuleSettingsItemProvider
{
	private SecurityService securityService;

	public CatalogSettingsItemProvider(SecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool Check(string id)
	{
		return id == "catalog-admin-settings";
	}

	public IEnumerable<LinkButton> GetItems(UrlHelper urlHelper)
	{
		List<LinkButton> list = new List<LinkButton>();
		list.Add(new LinkButton
		{
			Href = urlHelper.Action("Permissions", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common"
			}),
			Image = "#objects.svg",
			Text = SR.T("Настройки доступа к модулю «Справочники»")
		});
		if (securityService.HasPermission(PermissionProvider.AccessManagmentPermission))
		{
			list.Add(new LinkButton
			{
				Href = urlHelper.Action("GlobalPermissions", "PermissionManagment", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Security",
					module = "EleWise.ELMA.BPM.Web.Common.Catalogs",
					currentMenu = "catalog-admin-settings",
					title = SR.T("Права доступа к модулю «Справочники»")
				}),
				Image = "#access.svg",
				Text = SR.T("Права доступа к модулю «Справочники»")
			});
		}
		return list;
	}
}
