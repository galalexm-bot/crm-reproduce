using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Components.ViewItemExtensions;

[Component]
internal abstract class BaseWorkflowViewItemContentExtension<T> : IViewItemContentExtension
{
	public virtual bool Check(ViewItem viewItem, IEntity entity)
	{
		return viewItem is T;
	}

	public virtual object GetModel(params object[] parameters)
	{
		if (parameters.Length == 0 || !(parameters[0] is IWorkflowTaskBase workflowTaskBase))
		{
			return parameters[0];
		}
		return new WorkflowTaskInfo(workflowTaskBase.Id);
	}
}
