using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.Web.Extensions;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Controllers;

internal sealed class ToolbarController : BaseController
{
	private sealed class ConnectorData
	{
		public string Text { get; set; }

		public string ClickCode { get; set; }
	}

	public ActionResult GetConnectorData(long workflowTaskId, string htmlPrefix)
	{
		WorkflowTaskInfo workflowTaskInfo = new WorkflowTaskInfo(workflowTaskId);
		if (!workflowTaskInfo.Task.CanExecute() || (workflowTaskInfo.FormSettings != null && !workflowTaskInfo.FormSettings.ShowConnectorButtons))
		{
			return null;
		}
		HtmlHelper htmlHelper = GetHtmlHelper();
		htmlHelper.get_ViewData().set_Model((object)workflowTaskInfo);
		htmlHelper.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlPrefix);
		List<ConnectorData> list = new List<ConnectorData>();
		foreach (FlowConnectorElement item in workflowTaskInfo.SelectConnector((BPMNFlowElement)workflowTaskInfo.Element))
		{
			ConnectorActionsModel connectorActionsModel = htmlHelper.GenerateConnectorClickCode(workflowTaskInfo, item);
			list.Add(new ConnectorData
			{
				Text = connectorActionsModel.ConnectorName,
				ClickCode = connectorActionsModel.ConnectorCode
			});
		}
		JsonResult obj = ((Controller)this).Json((object)new
		{
			ConnectorData = list
		});
		obj.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)(object)obj;
	}
}
