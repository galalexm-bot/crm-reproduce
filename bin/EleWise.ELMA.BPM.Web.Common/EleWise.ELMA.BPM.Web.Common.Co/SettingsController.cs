using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Buttons;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class SettingsController : BPMController
{
	public IEnumerable<IModuleSettingsItemProvider> ModuleSettingsItemProvider { get; set; }

	[ContentItem(Name = "SR.M('Настройки системы')", Image24 = "#setting.svg")]
	public ActionResult Index(string module, string title, string currentMenu, Guid? moduleGuid = null)
	{
		IEnumerable<IGlobalSettingsModuleController> enumerable = ComponentManager.Current.GetExtensionPoints<IGlobalSettingsModuleController>();
		if (!string.IsNullOrEmpty(module))
		{
			enumerable = enumerable.Where(delegate(IGlobalSettingsModuleController c)
			{
				if (c.Module.ModuleNamespace == module)
				{
					if (moduleGuid.HasValue && !(moduleGuid == Guid.Empty))
					{
						Guid moduleGuid2 = c.Module.ModuleGuid;
						Guid? guid = moduleGuid;
						return moduleGuid2 == guid;
					}
					return true;
				}
				return false;
			});
		}
		if (!string.IsNullOrEmpty(currentMenu))
		{
			((Controller)(object)this).SetCurrentMenuItem(currentMenu);
		}
		((ControllerBase)this).get_ViewData().set_Item("Title", (object)((!string.IsNullOrEmpty(title)) ? title : SR.T("Настройки системы")));
		return (ActionResult)(object)((Controller)this).View((object)enumerable);
	}

	public PartialViewResult SettingsHomePortlet(SettingsHomePortletPersonalization settings)
	{
		return ((Controller)this).PartialView();
	}

	[ContentItem(Name = "SR.M('Справочники')", Image16 = "#objects.svg", Id = "catalog-admin-settings")]
	public ActionResult CatalogSettingsPage()
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("GetSettingsPage", "Settings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			code = "catalog-admin-settings",
			header = SR.T("Справочники")
		});
	}

	public ActionResult GetSettingsPage(string code, string header)
	{
		((Controller)(object)this).SetCurrentMenuItem("commonhome");
		((ControllerBase)this).get_ViewData().set_Item("SettingsHageHeader", (object)header);
		if (!code.IsNullOrWhiteSpace())
		{
			List<LinkButton> list = new List<LinkButton>();
			foreach (IModuleSettingsItemProvider item in ModuleSettingsItemProvider)
			{
				if (item.Check(code))
				{
					IEnumerable<LinkButton> items = item.GetItems(((Controller)this).get_Url());
					if (items.Any())
					{
						list.AddRange(items);
					}
				}
			}
			return (ActionResult)(object)((Controller)this).View((object)list);
		}
		return (ActionResult)(object)((Controller)this).View();
	}
}
