using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.IntegrationModules.Workflow.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Panels;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.ExtensionPoints;

namespace EleWise.ELMA.IntegrationModules.Workflow.Web.Components;

[Component]
internal class WorkflowIntegrationActivityOperationsExtension : IWorkflowOperationsExtension
{
	private WorkflowIntegrationBookmarkManager workflowIntegrationBookmarkManager;

	public WorkflowIntegrationActivityOperationsExtension(WorkflowIntegrationBookmarkManager workflowIntegrationBookmarkManager)
	{
		this.workflowIntegrationBookmarkManager = workflowIntegrationBookmarkManager;
	}

	public IGridData GetOperationsGrid(IEnumerable<IWorkflowInstance> instanceList, bool allowSubInstances = false)
	{
		IEnumerable<WorkflowIntegrationActivityBookmarkInfo> activeIntegrationActivityBookmarkInfos = workflowIntegrationBookmarkManager.GetActiveIntegrationActivityBookmarkInfos(instanceList, allowSubInstances);
		return new GridData<WorkflowIntegrationActivityBookmarkInfo>
		{
			Count = activeIntegrationActivityBookmarkInfos.Count(),
			DataSource = activeIntegrationActivityBookmarkInfos,
			IsPageable = false
		};
	}

	public CollapsiblePanel GetCollapsiblePanel()
	{
		return new CollapsiblePanel
		{
			Id = "InstanceCurrentInterationsActivityBookmarks",
			Header = SR.T("Интеграции"),
			Expanded = true,
			SaveState = false,
			Class = "separator-gray"
		};
	}

	public void RenderOperations(HtmlHelper helper, IGridData operations)
	{
		RenderPartialExtensions.RenderPartial(helper, "IntegrationBookmarks", (object)operations);
	}

	public string OperationToString(WorkflowOperationInfo operationInfo)
	{
		if (!(operationInfo is WorkflowIntegrationActivityBookmarkInfo workflowIntegrationActivityBookmarkInfo))
		{
			return operationInfo.ElementName;
		}
		return string.Format("{0} ({1})", workflowIntegrationActivityBookmarkInfo.ElementName, SR.T("Статус: {0}", workflowIntegrationActivityBookmarkInfo.Status.GetDisplayName()));
	}
}
