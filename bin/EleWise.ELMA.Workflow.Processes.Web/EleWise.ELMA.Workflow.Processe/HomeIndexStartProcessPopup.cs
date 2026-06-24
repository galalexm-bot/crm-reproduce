using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Workflow.Security;

namespace EleWise.ELMA.Workflow.Processes.Web.Integration.Common;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class HomeIndexStartProcessPopup : IExtensionZone
{
	private const string ZONE_ID = "EleWise.ELMA.BPM.Web.Common.Home.Index.ZoneBefore";

	private readonly ISecurityService securityService;

	public HomeIndexStartProcessPopup(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "EleWise.ELMA.BPM.Web.Common.Home.Index.ZoneBefore";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "EleWise.ELMA.BPM.Web.Common.Home.Index.ZoneBefore" && securityService.HasPermission(WorkflowGlobalPermissionProvider.WorkflowAccessPermission))
		{
			html.RegisterContent("StartProcessSelectorWindow", (dynamic d) => ChildActionExtensions.Action(html, "TreeWindow", "ProcessHeader", (object)new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web",
				treeId = "MainProcessTree"
			}));
		}
	}
}
