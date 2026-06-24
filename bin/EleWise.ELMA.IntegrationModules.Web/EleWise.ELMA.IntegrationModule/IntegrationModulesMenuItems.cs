using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Web.Controllers;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.IntegrationModules.Web.Menu;

[Component]
internal class IntegrationModulesMenuItems : IMenuItemsProvider
{
	private const string IMAdminMenu = "integrationModules-admin-menu";

	private const string IMAdminMenuMain = "integrationModules-admin-menu-Index";

	private const string IMAdminMenuMonitor = "integrationModules-admin-menu-Monitor";

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action<IntegrationModulesController>((Expression<Action<IntegrationModulesController>>)((IntegrationModulesController a) => a.Index())).Code("integrationModules-admin-menu").Image24("#integration.svg")
			.Order(101)
			.Parent("admin")
			.Container("left");
		factory.Action<IntegrationModulesController>((Expression<Action<IntegrationModulesController>>)((IntegrationModulesController a) => a.Index())).Name(SR.T("Настройки интеграций")).Image24("#setting_outline.svg")
			.Code("integrationModules-admin-menu-Index")
			.Order(101)
			.Parent("integrationModules-admin-menu")
			.Container("left");
		factory.Action<IntegrationModulesController>((Expression<Action<IntegrationModulesController>>)((IntegrationModulesController a) => a.IntegrationsList())).Code("integrationModules-admin-menu-Monitor").Image24("#Integrations_monitor.svg")
			.Order(102)
			.Parent("integrationModules-admin-menu")
			.Container("left");
	}
}
