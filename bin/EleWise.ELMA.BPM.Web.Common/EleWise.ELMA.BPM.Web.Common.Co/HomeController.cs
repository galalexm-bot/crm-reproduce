using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Models.Help;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Portlets.Layouts;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class HomeController : BPMController
{
	public PortletManager PortletManager { get; set; }

	public TwoColumn5050Layout TwoColumn5050Layout { get; set; }

	public ActionResult Index(bool? editPortal = null)
	{
		throw new InvalidOperationException(SR.T("Эта страница устарела"));
	}

	public ActionResult Empty()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult About()
	{
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	public ActionResult License()
	{
		ILicensedUnit mainLicensedUnit = ComponentManager.Current.ModuleManager.MainLicensedUnit;
		IWorkplaceLicenseInfo workplaceLicenseInfo = ((mainLicensedUnit != null) ? (mainLicensedUnit.GetLicenseInfo() as IWorkplaceLicenseInfo) : null);
		string count = ((workplaceLicenseInfo == null) ? "" : (workplaceLicenseInfo.WorkplaceCount.HasValue ? workplaceLicenseInfo.WorkplaceCount.ToString() : SR.T("Не ограничено")));
		LicenseInfo licenseInfo = new LicenseInfo
		{
			IsActivated = true,
			Count = count
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)licenseInfo);
	}

	[ContentItem(Name = "SR.M('Справка')", Id = "main_help_item", Image24 = "#help.svg")]
	public ActionResult Help()
	{
		IEnumerable<IHelpPageUrlProvider> enumerable = from p in ComponentManager.Current.GetExtensionPoints<IHelpPageUrlProvider>()
			where p.IsGlobalModuleProvider
			select p;
		return (ActionResult)(object)((Controller)this).View((object)enumerable);
	}

	[ContentItem(Name = "SR.M('Базовые приложения')", Id = "commonhome", Image24 = "#apps.svg")]
	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult CommonHome()
	{
		((ControllerBase)this).get_ViewData().set_Item("Title", (object)SR.T("Базовые приложения"));
		return (ActionResult)(object)((Controller)this).View("ModuleSettingsPage", (object)ComponentManager.Current.GetExtensionPoints<ICommonHomePageProvider>().ToList());
	}

	public PartialViewResult SystemInfoPortlet(SystemInfoPortletPersonalization settings)
	{
		SystemInfoPortletModel systemInfoPortletModel = new SystemInfoPortletModel
		{
			LicenseInfo = new LicenseViewModel(),
			Settings = settings,
			IsPackagesAvailable = false
		};
		systemInfoPortletModel.LicenseInfo.Initialize();
		return ((Controller)this).PartialView("Home/SystemInfoPortlet", (object)systemInfoPortletModel);
	}

	public PartialViewResult CommonHomePortlet(CommonHomePortletPersonalization settings)
	{
		ModuleSettingsPortletModel moduleSettingsPortletModel = new ModuleSettingsPortletModel
		{
			Providers = ComponentManager.Current.GetExtensionPoints<ICommonHomePageProvider>().ToList(),
			PortletCssClass = "border-blue",
			HeaderText = SR.T("Базовые приложения"),
			PortletName = "CommonHome",
			HeaderUrl = (UrlHelper helper) => helper.Action("CommonHome", "Home", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common"
			}),
			ImageUrl = (UrlHelper helper) => "#calendar.svg"
		};
		return ((Controller)this).PartialView("ModuleSettingsPortlet", (object)moduleSettingsPortletModel);
	}

	public PartialViewResult CloseAfterPost(string closeText, string description, string taskUrl, bool useDefaultScript = true)
	{
		((ControllerBase)this).get_ViewData().set_Model((object)new Pair<string, HtmlString>(closeText, new HtmlString(description)));
		((ControllerBase)this).get_ViewData().set_Item("taskUrl", (object)taskUrl);
		((ControllerBase)this).get_ViewData().set_Item("useDefaultScript", (object)useDefaultScript);
		return ((Controller)this).PartialView();
	}
}
