using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Security.Portlets;

[Component]
public class EmployeesListPortlet : Portlet<EmployeesListPortletPersonalization>
{
	public static string UID_S = "{7CBF845E-9201-47F4-981B-06956F81859B}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Сотрудники компании");

	public override string Description => SR.T("Портлет для отображения сотрудников компании");

	public override IPortletProfile Profile => _profile;

	public EmployeesListPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#users.svg";
		_profile.Customizable = true;
	}

	public override MvcHtmlString Content(HtmlHelper html, EmployeesListPortletPersonalization data)
	{
		return RenderContentAction(html, "EmployeesListPortlet", "EmployeesList", "EleWise.ELMA.BPM.Web.Security", data);
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
