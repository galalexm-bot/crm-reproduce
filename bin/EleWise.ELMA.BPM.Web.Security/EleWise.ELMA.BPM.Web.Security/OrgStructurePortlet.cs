using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Security.Portlets;

[Component]
public class OrgStructurePortlet : Portlet<OrgStructurePersonalization>
{
	public static string UID_S = "{38BDDBEE-7997-45D5-BAD9-DDC9615F33B3}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Организационная структура");

	public override string Description => SR.T("Портлет для отображения данных по оргструктуре");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public OrgStructurePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#company.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, OrgStructurePersonalization data)
	{
		return RenderContentAction(html, "Tree", "OrgStructure", "EleWise.ELMA.BPM.Web.Security", data);
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
