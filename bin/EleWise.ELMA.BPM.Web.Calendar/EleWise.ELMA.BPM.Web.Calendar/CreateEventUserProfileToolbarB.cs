using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Security;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(EnableInterceptors = false, InjectProerties = false, Order = 2)]
internal sealed class CreateEventUserProfileToolbarButton : IActionItemProvider
{
	private readonly ISecurityService securityService;

	public const string CREATEEVENT_GUID = "Calendar_CreateEventUserProfileToolbarButton";

	private const string CREATE_GUID = "Tasks_CreateTaskUserProfileToobarButton";

	public CreateEventUserProfileToolbarButton(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && securityService.HasPermission(EleWise.ELMA.Calendar.PermissionProvider.CalendarAccessPermission) && rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "UserProfileButtonActionsGroup") is ActionToolbarGroup actionToolbarGroup)
		{
			actionToolbarGroup.Items.FirstOrDefault((IActionItem m) => m.Uid == "Tasks_CreateTaskUserProfileToobarButton")?.Items.AddSequense(GetItems(rootItem, htmlHelper));
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		EleWise.ELMA.Security.Models.IUser userFromModel = htmlHelper.GetUserFromModel();
		if (userFromModel != null)
		{
			yield return new ActionToolbarItem("Calendar_CreateEventUserProfileToolbarButton")
			{
				Text = SR.T("Событие"),
				IconUrl = "#add_event.svg",
				ToolTip = SR.T("Создать событие в календаре"),
				Url = htmlHelper.Url().Action("Create", "Event", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Calendar" },
					{ "idUsers[0]", userFromModel.Id }
				})
			};
		}
	}
}
