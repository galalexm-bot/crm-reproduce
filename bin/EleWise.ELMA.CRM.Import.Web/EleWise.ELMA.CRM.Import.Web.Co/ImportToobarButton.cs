using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 5)]
public class ImportToobarButton : IActionItemProvider
{
	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar" || htmlHelper == null || htmlHelper.get_ViewContext() == null || ((ControllerContext)htmlHelper.get_ViewContext()).get_RouteData() == null || ((ControllerContext)htmlHelper.get_ViewContext()).get_RouteData().Values == null)
		{
			return;
		}
		ISecurityService service = Locator.GetService<ISecurityService>();
		if (service == null || !service.HasPermission(CRMPermissionProvider.CRMImportPermission))
		{
			return;
		}
		RouteValueDictionary values = ((ControllerContext)htmlHelper.get_ViewContext()).get_RouteData().Values;
		if (!values.Any((KeyValuePair<string, object> r) => r.Key == "controller" && r.Value != null && (r.Value.Equals("Contractor") || r.Value.Equals("Lead"))) || !values.Any((KeyValuePair<string, object> r) => r.Key == "action" && r.Value != null && r.Value.Equals("Index")) || !values.Any((KeyValuePair<string, object> r) => r.Key == "area" && r.Value != null && r.Value.Equals("EleWise.ELMA.CRM.Web")))
		{
			return;
		}
		ActionToolbarGroup actionToolbarGroup = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "MoreButtonToolbarGroup") as ActionToolbarGroup;
		IActionItem[] enumeration = new IActionItem[1]
		{
			new ActionToolbarItem
			{
				Text = SR.T("Импорт из Excel"),
				ToolTip = SR.T("Импорт клиентов из файла формата Excel"),
				IconUrl = "#excel.svg",
				Url = htmlHelper.Url().Action("Index", "Import", (object)new
				{
					area = "EleWise.ELMA.CRM.Import.Web"
				}),
				Visible = true
			}
		};
		if (actionToolbarGroup == null)
		{
			return;
		}
		IActionItem additionalButton = actionToolbarGroup.Items.FirstOrDefault((IActionItem m) => m.Uid == "more_btn");
		if (additionalButton != null)
		{
			enumeration.ForEach(delegate(IActionItem item)
			{
				additionalButton.Items.Add(item);
			});
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		return null;
	}
}
