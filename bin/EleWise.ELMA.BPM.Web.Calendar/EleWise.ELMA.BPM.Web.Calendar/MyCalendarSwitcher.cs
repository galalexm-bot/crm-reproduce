using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(Order = 20)]
public class MyCalendarSwitcher : IActionItemProvider
{
	public const string CalendarBreadcrumbs = "calendar-breadcrumbs";

	public const string MyCalendarClassName = "my-calendar-item";

	public IAuthenticationService AuthenticationService { get; set; }

	public ScheduleManager ScheduleManager { get; set; }

	public ScheduleLogManager ScheduleLogManager { get; set; }

	[NotNull]
	public ISecurityService SecurityService { get; set; }

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || !(rootItem.Uid == "calendar-breadcrumbs") || !(htmlHelper.get_ViewData().get_Model() is ScheduleModel))
		{
			return;
		}
		foreach (IActionItem item in GetItems(rootItem, htmlHelper))
		{
			rootItem.Items.Add(item);
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (!(htmlHelper.get_ViewData().get_Model() is ScheduleModel scheduleModel))
		{
			return Enumerable.Empty<IActionItem>();
		}
		ActionButton actionButton = new ActionButton("my-calendar-switcher");
		actionButton.AsSwitcher = true;
		ActionButton actionButton2 = new ActionButton("my-calendar")
		{
			Text = SR.T("Мой календарь"),
			Url = htmlHelper.Url().Action("My", "Scheduler"),
			Attributes = new
			{
				@class = "my-calendar-item"
			}
		};
		List<ActionButton> favorites = GetFavorites(htmlHelper);
		actionButton2.IsChecked = !favorites.Any((ActionButton a) => a.IsChecked);
		actionButton.Items.Add(actionButton2);
		actionButton.Items.AddSequense(favorites);
		if (scheduleModel.ShowSharedSchedulesPopup)
		{
			actionButton.Items.Add(new ActionButton("calendars")
			{
				Text = SR.T("Другие..."),
				Click = ((object)htmlHelper.OpenPopup("SharedSchedulesPopup")).ToString()
			});
		}
		return new IActionItem[1] { actionButton };
	}

	private List<ActionButton> GetFavorites(HtmlHelper htmlHelper)
	{
		InstanceOf<IScheduleLogFilter> instanceOf = new InstanceOf<IScheduleLogFilter>();
		instanceOf.New.User = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		IScheduleLogFilter @new = instanceOf.New;
		long num = ((((string)((ControllerContext)htmlHelper.get_ViewContext()).get_Controller().get_ValueProvider().GetValue("action")
			.get_RawValue()).ToLower() == "view" && ((string)((ControllerContext)htmlHelper.get_ViewContext()).get_Controller().get_ValueProvider().GetValue("controller")
			.get_RawValue()).ToLower() == "scheduler") ? long.Parse((string)((ControllerContext)htmlHelper.get_ViewContext()).get_Controller().get_ValueProvider().GetValue("id")
			.get_RawValue()) : 0);
		List<IScheduleLog> list = (from sl in ScheduleLogManager.Find(@new, FetchOptions.All)
			where sl.Schedule != null && SecurityService.CanCheckPermission(EleWise.ELMA.Calendar.PermissionProvider.ScheduleViewPermission, sl.Schedule) && SecurityService.HasPermission(EleWise.ELMA.Calendar.PermissionProvider.ScheduleViewPermission, sl.Schedule)
			select sl).Distinct().ToList();
		List<ActionButton> list2 = new List<ActionButton>();
		List<ActionButton> list3 = new List<ActionButton>();
		EleWise.ELMA.Security.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.IUser>();
		foreach (IScheduleLog item2 in list)
		{
			ActionButton item = new ActionButton("calendar" + item2.Id)
			{
				Text = item2.Schedule.Name,
				Url = htmlHelper.Url().Action("View", "Scheduler", (object)new
				{
					id = item2.Schedule.Id,
					area = "EleWise.ELMA.BPM.Web.Calendar"
				}),
				IsChecked = (item2.Schedule.Id == num)
			};
			if (item2.Favorite)
			{
				list2.Add(item);
			}
			else if (item2.Schedule.Owner != currentUser && list3.Count < 5)
			{
				list2.Add(item);
			}
		}
		if (list3.Count > 0)
		{
			list2.AddRange(list3);
		}
		return list2.OrderBy((ActionButton a) => a.Text).ToList();
	}
}
