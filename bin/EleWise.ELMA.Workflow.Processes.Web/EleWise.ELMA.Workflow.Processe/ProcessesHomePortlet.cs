using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Workflow.Processes.Web.Portlets;

[Component]
public class ProcessesHomePortlet : Portlet<ProcessesHomePortletPersonalization>
{
	public static string UID_S = "{4E76BCCA-CC65-498A-8905-34CA8D59FE86}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Процессы");

	public override string Description => SR.T("Домашний портлет со ссылками на разделы администрирования модуля Бизнес-процессы");

	public override IPortletProfile Profile => profile;

	public override bool AllowMultipleInstance => false;

	public ProcessesHomePortlet()
	{
		profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		profile.ImageUrl = "#process.svg";
		profile.Customizable = false;
	}

	public override MvcHtmlString Content(HtmlHelper html, ProcessesHomePortletPersonalization data)
	{
		return RenderContentAction(html, "HomePortlet", "ProcessHeader", "EleWise.ELMA.Workflow.Processes.Web", data);
	}

	protected override Permission PortletPermission()
	{
		return PermissionProvider.AccessManagmentPermission;
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		ProcessesHomePortletPersonalization processesHomePortletPersonalization = base.CreateDefaultSettings(path) as ProcessesHomePortletPersonalization;
		if (processesHomePortletPersonalization != null)
		{
			processesHomePortletPersonalization.HeaderColor = "#C4EA96";
			processesHomePortletPersonalization.Frame = PortletFrame.HeaderLine;
		}
		return processesHomePortletPersonalization;
	}
}
