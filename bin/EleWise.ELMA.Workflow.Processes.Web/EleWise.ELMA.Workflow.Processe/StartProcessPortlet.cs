using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Security;

namespace EleWise.ELMA.Workflow.Processes.Web.Portlets;

[Component]
public class StartProcessPortlet : Portlet<StartProcessPortletPersonalization>
{
	public static string UID_S = "{FCEDD0AF-0C42-4606-AE79-1C06E27E709C}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Запуск процесса");

	public override string Description => SR.T("Портлет для запуска процессов");

	public override IPortletProfile Profile => _profile;

	public override bool GoodExternalSupported => true;

	public StartProcessPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#process.svg";
		_profile.Customizable = true;
	}

	public override MvcHtmlString Content(HtmlHelper html, StartProcessPortletPersonalization data)
	{
		return RenderContentAction(html, "StartProcessPortlet", "ProcessHeader", "EleWise.ELMA.Workflow.Processes.Web", data);
	}

	protected override Permission PortletPermission()
	{
		return WorkflowGlobalPermissionProvider.WorkflowAccessPermission;
	}
}
