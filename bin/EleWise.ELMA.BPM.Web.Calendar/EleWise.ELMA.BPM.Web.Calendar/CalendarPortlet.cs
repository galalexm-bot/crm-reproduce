using System;
using System.Web.Mvc;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Calendar.Portlets;

[Component]
public class CalendarPortlet : Portlet<PortletPersonalization>
{
	public static string UID_S = "{48AD2E1E-3799-486F-BBDC-DDB61EC90905}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override IPortletProfile Profile => _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Календарь");

	public override string Description => null;

	public CalendarPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#calendar.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, PortletPersonalization data)
	{
		return RenderContentAction(html, "Portlet", "Scheduler", "EleWise.ELMA.BPM.Web.Calendar", data);
	}

	protected override Permission PortletPermission()
	{
		return EleWise.ELMA.Calendar.PermissionProvider.CalendarAccessPermission;
	}

	[Obsolete("Use GetNameUrl(UrlHelper, PortletPersonalization)", false)]
	public override string GetNameUrl(UrlHelper urlHelper)
	{
		return urlHelper.Action("Index", "Scheduler", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Calendar"
		});
	}
}
