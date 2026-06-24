using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Security;

namespace EleWise.ELMA.Workflow.Processes.Web.Portlets;

[Component]
public class MyProcessesPortlet : Portlet<MyProcessesPortletPersonalization>
{
	public static string UID_S = "{FAC6D43C-1F95-4A20-A82C-65FED5A35973}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Мои процессы");

	public override string Description => SR.T("Портлет со списком моих процессов");

	public override IPortletProfile Profile => _profile;

	public override bool AllowMultipleInstance => true;

	public MyProcessesPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#process.svg";
		_profile.Customizable = true;
	}

	public override MvcHtmlString Content(HtmlHelper html, MyProcessesPortletPersonalization data)
	{
		return RenderContentAction(html, "MyProcessesPortlet", "ProcessHeader", "EleWise.ELMA.Workflow.Processes.Web", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, MyProcessesPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "ProcessHeader/MyProcessesPortletSettings", data);
	}

	public override string GetNameUrl(UrlHelper urlHelper)
	{
		return urlHelper.Action("Index", "MyProcesses", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		});
	}

	protected override Permission PortletPermission()
	{
		return WorkflowGlobalPermissionProvider.WorkflowAccessPermission;
	}
}
