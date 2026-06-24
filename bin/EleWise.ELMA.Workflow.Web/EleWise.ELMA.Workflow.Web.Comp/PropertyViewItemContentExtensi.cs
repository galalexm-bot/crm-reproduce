using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Components.ViewItemExtensions;

internal sealed class PropertyViewItemContentExtension : BaseWorkflowViewItemContentExtension<PropertyViewItem>
{
	public override bool Check(ViewItem viewItem, IEntity entity)
	{
		if (base.Check(viewItem, entity))
		{
			return entity is IWorkflowTaskBase;
		}
		return false;
	}

	public override object GetModel(params object[] parameters)
	{
		object model = base.GetModel(parameters);
		if (model is WorkflowTaskInfo workflowTaskInfo)
		{
			return workflowTaskInfo.Entity;
		}
		return model;
	}
}
