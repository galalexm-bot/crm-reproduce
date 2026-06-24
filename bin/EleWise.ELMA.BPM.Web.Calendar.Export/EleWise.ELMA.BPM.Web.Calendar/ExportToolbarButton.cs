using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 5)]
public class ExportToolbarButton : IActionItemProvider
{
	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		IEnumerable<IActionItem> items = GetItems(rootItem, htmlHelper);
		if (items == null || !items.Any() || !(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "MoreButtonToolbarGroup") is ActionToolbarGroup actionToolbarGroup))
		{
			return;
		}
		IActionItem additionalButton = actionToolbarGroup.Items.FirstOrDefault((IActionItem m) => m.Uid == "more_btn");
		if (additionalButton != null)
		{
			items.ForEach(delegate(IActionItem item)
			{
				additionalButton.Items.Add(item);
			});
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null)
		{
			return null;
		}
		if (rootItem.Uid != "DefaultActionsToolbar")
		{
			return null;
		}
		if (htmlHelper == null || htmlHelper.get_ViewContext() == null || ((ControllerContext)htmlHelper.get_ViewContext()).get_RouteData() == null || ((ControllerContext)htmlHelper.get_ViewContext()).get_RouteData().Values == null)
		{
			return null;
		}
		RouteValueDictionary values = ((ControllerContext)htmlHelper.get_ViewContext()).get_RouteData().Values;
		if (values.Any((KeyValuePair<string, object> r) => r.Key == "controller" && r.Value != null && r.Value.ToString().ToUpper() == "Scheduler".ToUpper()) && values.Any((KeyValuePair<string, object> r) => r.Key == "action" && r.Value != null && r.Value.ToString().ToUpper() == "View".ToUpper()) && values.Any((KeyValuePair<string, object> r) => r.Key == "area" && r.Value != null && r.Value.Equals("EleWise.ELMA.BPM.Web.Calendar")))
		{
			return new IActionItem[2]
			{
				new ActionToolbarItem("calendar-export")
				{
					Text = SR.T("Экспорт"),
					Click = ((object)htmlHelper.OpenPopup("ExportSchedulePopup")).ToString()
				},
				new ActionToolbarItem("internet-calendars")
				{
					Text = SR.T("Интернет-календари"),
					Url = htmlHelper.Url().Action("List", "InternetCalendar", (object)new
					{
						area = "EleWise.ELMA.BPM.Web.Calendar.Export"
					})
				}
			};
		}
		return null;
	}
}
