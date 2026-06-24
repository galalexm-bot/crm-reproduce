using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class WorkflowTaskExecuteZone : IExtensionZone
{
	private const string ZONE_ID = "WorkflowTaskExecuteExtensionZone";

	private readonly ISecurityService securityService;

	public WorkflowTaskExecuteZone(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "WorkflowTaskExecuteExtensionZone";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (!(zoneId != "WorkflowTaskExecuteExtensionZone") && html.get_ViewData().get_Model() is IWorkflowExecInfo workflowExecInfo)
		{
			List<long> processHeaderIdList = ImprovementProcessSettingsManager.Instance.GetProcessHeaderIdList();
			IImprovementProcessSettings @default = ImprovementProcessSettingsManager.Instance.GetDefault();
			if (!processHeaderIdList.Contains(workflowExecInfo.HeaderId) && @default != null && @default.Header.Status == WorkflowProcessStatus.Published)
			{
				RenderPartialExtensions.RenderPartial(html, "Improvement/WorkflowTaskExecuteContent", (object)new ImprovementPopupModel
				{
					InstanceId = workflowExecInfo.InstanceId,
					TaskId = workflowExecInfo.TaskId
				});
			}
		}
	}
}
