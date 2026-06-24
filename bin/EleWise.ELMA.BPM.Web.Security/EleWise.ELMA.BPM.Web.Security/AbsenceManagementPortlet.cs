using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Security.Portlets;

[Component]
public class AbsenceManagementPortlet : Portlet<AbsenceManagementPortletPersonalization>
{
	private readonly PortletProfile _profile;

	public override IPortletProfile Profile => _profile;

	public override string Description => SR.T("Портлет для отображения отсутсвующих на рабочем месте");

	public override string Name => SR.T("Отсутствие на рабочем месте");

	public override Guid Uid => new Guid("2cf2756a-2316-4796-a24e-6d90350e5057");

	public AbsenceManagementPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#absence_management.svg";
		_profile.Customizable = true;
	}

	public override MvcHtmlString Content(HtmlHelper html, AbsenceManagementPortletPersonalization data)
	{
		return RenderContentAction(html, "AbsenceManagementPortlet", "Absence", "EleWise.ELMA.BPM.Web.Security", data);
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
