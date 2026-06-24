using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Component]
public class MyWorkLogPortlet : Portlet<MyWorkLogPortletPersonalization>
{
	public static string UID_S = "{C7E4A9EA-2C83-4514-9C3F-F6178984CC54}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Мои трудозатраты");

	public override string Description => SR.T("Портлет для отображения сводной таблицы по поданным трудозатратам.");

	public override bool AllowMultipleInstance => true;

	public override IPortletProfile Profile => _profile;

	public MyWorkLogPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#clock_user.svg";
		_profile.Customizable = true;
	}

	public override bool HasPermission()
	{
		return WorkLogSettingsHelper.WorkLogEnabled();
	}

	[Obsolete("Use GetNameUrl(UrlHelper, MyWorkLogPortletPersonalization)", false)]
	public override string GetNameUrl(UrlHelper urlHelper)
	{
		return urlHelper.Action("Index", "WorkLogReport", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		});
	}

	public override MvcHtmlString Content(HtmlHelper html, MyWorkLogPortletPersonalization data)
	{
		return RenderContentAction(html, "MyWorkLogPortlet", "WorkLogReport", "EleWise.ELMA.BPM.Web.Tasks", data);
	}

	protected override Permission PortletPermission()
	{
		return null;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		return new MyWorkLogPortletPersonalization
		{
			Mode = WorkLogSummaryTableMode.LastWeek
		};
	}
}
