using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Calendar.Export.Managers;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Components;

[Component(EnableInterceptiors = false, InjectProerties = false)]
public class ScheduleTabViewExtension : ITabProviderExtension
{
	public IEnumerable<TabPanelItem> Items(HtmlHelper html)
	{
		if (html.get_ViewData().get_Model() is ISchedule schedule)
		{
			ExternalCalendarManager instance = ExternalCalendarManager.Instance;
			InstanceOf<IExternalCalendarFilter> instanceOf = new InstanceOf<IExternalCalendarFilter>();
			instanceOf.New.SharedOnly = true;
			long value = instance.Count(instanceOf.New);
			TabPanelItem tabPanelItem = new TabPanelItem();
			((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Text(SR.T("Внешние календари"));
			((TabStripItem)tabPanelItem).set_Counter((long?)value);
			((TabStripItem)tabPanelItem).set_ContentUrl(html.Url().Action("ExternalCalendarTab", "ExternalCalendar", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar.Export",
				scheduleId = schedule.Id
			}));
			TabPanelItem tabPanelItem2 = tabPanelItem;
			((NavigationItem<TabStripItem>)(object)tabPanelItem2).get_HtmlAttributes().Add("id", "externalCalendarTab");
			yield return tabPanelItem2;
		}
	}

	public string IdTabPanal(HtmlHelper htmlHelper)
	{
		return "ScheduleTabView";
	}
}
