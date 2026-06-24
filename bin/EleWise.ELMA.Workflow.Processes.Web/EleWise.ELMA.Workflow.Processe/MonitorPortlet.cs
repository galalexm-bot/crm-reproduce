using System;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Security;

namespace EleWise.ELMA.Workflow.Processes.Web.Portlets;

[Component]
public class MonitorPortlet : Portlet<MonitorPortletPersonalization>
{
	public static string UID_S = "{7166D8EE-8EA0-424E-92FF-E4987F77982E}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Монитор процессов");

	public override string Description => SR.T("Портлет со списком процессов для мониторинга");

	public override IPortletProfile Profile => _profile;

	public override bool AllowMultipleInstance => true;

	public MonitorPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#computer.svg";
		_profile.Customizable = true;
	}

	public override MvcHtmlString Content(HtmlHelper html, MonitorPortletPersonalization data)
	{
		return RenderContentAction(html, "PortletView", "Monitor", "EleWise.ELMA.Workflow.Processes.Web", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, MonitorPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "Monitor/PortletSettings", data);
	}

	public override string GetNameUrl(UrlHelper urlHelper, MonitorPortletPersonalization data)
	{
		IFilter filter = data?.GetFilter();
		if (filter == null)
		{
			return urlHelper.Action("Index", "Monitor", (object)new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web"
			});
		}
		return urlHelper.Action("Index", "Monitor", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web",
			FilterId = filter.Id
		}, (string)null);
	}

	protected override Permission PortletPermission()
	{
		return WorkflowGlobalPermissionProvider.WorkflowAccessPermission;
	}
}
