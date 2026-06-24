using System;
using System.Web.Mvc;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Messages.Web.Portlets;

public class LinePortlet : Portlet<PortletPersonalization>
{
	public static string UID_S = "{063CFCAB-B7F4-4C7C-8F89-2BFAB097346F}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Лента");

	public override string Description => SR.T("Портлет отображения ленты");

	public override IPortletProfile Profile => _profile;

	public LinePortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#messages.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, PortletPersonalization data)
	{
		return RenderContentAction(html, "Line", "BaseMessage", "EleWise.ELMA.Messages.Web", data);
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
