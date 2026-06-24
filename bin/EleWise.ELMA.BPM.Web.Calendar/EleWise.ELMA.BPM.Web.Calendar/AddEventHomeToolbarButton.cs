using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 5)]
public class AddEventHomeToolbarButton : IActionItemProvider
{
	public const string ADDEVENT_GUID = "Calendar_AddEventHomeToolbarButton";

	private readonly string TOOLBARCREATE_UID = "HomePageToolbarGroup";

	public const string CREATE_GUID = "Tasks_CreateTaskToobarButton";

	private readonly ISecurityService securityService;

	public AddEventHomeToolbarButton(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar")
		{
			return;
		}
		ActionToolbarGroup actionToolbarGroup = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == TOOLBARCREATE_UID) as ActionToolbarGroup;
		if (securityService.HasPermission(EleWise.ELMA.Calendar.PermissionProvider.CalendarAccessPermission))
		{
			actionToolbarGroup?.Items.FirstOrDefault((IActionItem m) => m.Uid == "Tasks_CreateTaskToobarButton")?.Items.AddSequense(GetItems(rootItem, htmlHelper));
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && rootItem.Items.Any((IActionItem item) => item is ActionToolbarGroup && item.Uid == TOOLBARCREATE_UID))
		{
			yield return new ActionToolbarItem("Calendar_AddEventHomeToolbarButton")
			{
				Text = SR.T("Событие"),
				IconUrl = "#add_event.svg",
				ToolTip = SR.T("Создать событие в календаре"),
				Url = htmlHelper.Url().Action("Create", "Event", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Calendar"
				})
			};
		}
	}
}
