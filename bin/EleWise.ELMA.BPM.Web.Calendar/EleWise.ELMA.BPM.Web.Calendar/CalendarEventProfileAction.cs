using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

[Component]
public class CalendarEventProfileAction : IProfileActionProviderPoint
{
	public IEnumerable<IProfileAction> GetProfileActions(HtmlHelper html, EleWise.ELMA.Security.Models.IUser user)
	{
		List<IProfileAction> list = new List<IProfileAction>();
		if (user.Status != UserStatus.Blocked && Locator.GetServiceNotNull<ISecurityService>().HasPermission(EleWise.ELMA.Calendar.PermissionProvider.CalendarAccessPermission))
		{
			list.Add(new SimpleProfileAction
			{
				ImageUrl = "#add_event.svg",
				ActionUrl = html.Url().Action("Create", "Event", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Calendar" },
					{ "idUsers[0]", user.Id }
				}),
				Caption = SR.T("Событие"),
				Tooltip = SR.T("Создать событие с участием данного пользователя"),
				Order = 20
			});
		}
		return list;
	}
}
