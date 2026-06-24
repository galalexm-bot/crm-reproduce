using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;

namespace EleWise.ELMA.BPM.Web.Calendar.Menu;

[Component(Order = 300)]
public class UserPanelCalendarAction : CurrentUserPanelAction, ICurrentUserPanelActionDisable, ICurrentUserPanelAction
{
	public override string Id => "UserPanelAction_Calendar";

	public string PropertyName => "UserPanelCalendar";

	public override string GetIconUrl(HtmlHelper html)
	{
		return html.Url().GetIcon("#calendar.svg");
	}

	public override string GetActionUrl(HtmlHelper html)
	{
		return "/Calendar";
	}

	public override bool IsVisible()
	{
		if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(EleWise.ELMA.Calendar.PermissionProvider.CalendarAccessPermission))
		{
			return false;
		}
		return IsEnabled(WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true));
	}

	public bool IsEnabled(IWorkPlace workPlace)
	{
		return ((IWorkPlaceCalendar)workPlace).UserPanelCalendar ?? true;
	}
}
