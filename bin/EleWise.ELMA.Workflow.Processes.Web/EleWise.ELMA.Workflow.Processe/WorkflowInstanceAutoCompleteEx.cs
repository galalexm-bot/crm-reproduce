using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkflowInstanceAutoCompleteExtension : IAutoCompleteExtension
{
	public bool CheckFilter(IEntityManager manager, IEntityFilter filter)
	{
		if (!(filter is IWorkflowInstanceFilter filter2))
		{
			return false;
		}
		WorkflowInstanceManager.Instance.CheckFilterUsingContext(filter2);
		return true;
	}
}
