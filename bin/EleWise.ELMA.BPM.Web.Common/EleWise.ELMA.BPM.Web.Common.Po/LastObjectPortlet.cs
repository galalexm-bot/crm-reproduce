using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Portlets;

[Component]
public class LastObjectPortlet : Portlet<LastObjectPortletPersonalization>
{
	public static string UID_S = "{3D2B0C6F-FB1D-4574-A6CC-8F75FA702E3E}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Последняя активность");

	public override string Description => SR.T("Портлет для отображения объектов, с которыми Вы работали в последнее время");

	public override bool AllowMultipleInstance => true;

	public LastObjectPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#activity.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, LastObjectPortletPersonalization data)
	{
		return RenderContentAction(html, "Portlet", "LastObjectInfo", "EleWise.ELMA.BPM.Web.Common", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, LastObjectPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "LastObjectInfo/PortletSettings", data);
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		LastObjectPortletPersonalization lastObjectPortletPersonalization = base.CreateDefaultSettings(path) as LastObjectPortletPersonalization;
		if (lastObjectPortletPersonalization != null)
		{
			lastObjectPortletPersonalization.ObjectCount = 15;
			lastObjectPortletPersonalization.Version = "LastObject";
		}
		return lastObjectPortletPersonalization;
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
