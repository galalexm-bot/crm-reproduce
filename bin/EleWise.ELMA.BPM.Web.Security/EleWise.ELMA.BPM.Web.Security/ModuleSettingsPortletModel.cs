using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class ModuleSettingsPortletModel
{
	public string PortletName { get; set; }

	public string PortletCssClass { get; set; }

	public IEnumerable<IModuleSettingsPageProvider> Providers { get; set; }

	public Func<UrlHelper, string> ImageUrl { get; set; }

	public Func<UrlHelper, string> HeaderUrl { get; set; }

	public string HeaderText { get; set; }
}
