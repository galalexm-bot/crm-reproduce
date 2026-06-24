using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class PortletsController : BPMController
{
	public PortletManager PortletManager { get; set; }

	[ContentItem(Name = "SR.M('Портлеты')", Description = "SR.M('Список доступных в системе портетов')", Image24 = "#portlet.svg")]
	[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		List<IPortlet> list = new List<IPortlet>();
		if (PortletManager.Portlets != null)
		{
			list.AddRange(PortletManager.Portlets);
		}
		foreach (IPortletProvider portletProvider in PortletManager.PortletProviders)
		{
			list.AddRange(portletProvider.GetPortlets());
		}
		GridData<IPortlet> gridData = list.CreateGridData("Category");
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	public ActionResult DefaultSettings(Guid id)
	{
		IPortlet portlet = PortletManager.GetPortlet(id);
		return (ActionResult)(object)((Controller)this).RedirectToAction("PortletSettings", "Personalization", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			portletId = id,
			instanceId = PortletManager.DefaultSettingsInstanceId(portlet),
			path = PortletManager.DefaultSettingsPath(portlet),
			addIfNotExists = true,
			scope = PersonalizationScope.Shared
		});
	}
}
