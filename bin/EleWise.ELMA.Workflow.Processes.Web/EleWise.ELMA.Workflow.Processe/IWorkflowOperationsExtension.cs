using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Panels;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkflowOperationsExtension
{
	IGridData GetOperationsGrid(IEnumerable<IWorkflowInstance> instanceList, bool allowSubInstances = false);

	CollapsiblePanel GetCollapsiblePanel();

	void RenderOperations(HtmlHelper helper, IGridData operations);

	string OperationToString(WorkflowOperationInfo operationInfo);
}
