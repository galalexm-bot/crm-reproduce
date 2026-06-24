using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.ViewItems;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
public class WorkflowTaskPropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		IWorkflowTaskBase workflowTaskBase = model as IWorkflowTaskBase;
		FormViewItem formViewItem = propertyViewItem.FormViewItem;
		if (workflowTaskBase == null || formViewItem == null || (formViewItem.MetadataUid != new Guid("c4dc0ccc-c1a3-45d6-b794-e23152342c3d") && formViewItem.MetadataUid != new Guid("555a587d-25c1-4f99-ade6-3176b4fc9a6c")))
		{
			return;
		}
		WorkflowInstanceContext context = workflowTaskBase.WorkflowBookmark?.Instance.Context;
		ComponentManager.Current.GetExtensionPoints<IPropertyViewItemAdjustment>().Each(delegate(IPropertyViewItemAdjustment p)
		{
			p.Adjust(propertyViewItem, context, viewType);
		});
		for (ViewItem viewItem = propertyViewItem; viewItem != null; viewItem = viewItem.Parent)
		{
			if (viewItem is IContextPropertyViewItem)
			{
				return;
			}
			if (!(viewItem is PropertyViewItem))
			{
				break;
			}
		}
		propertyViewItem.Attributes.ReadOnly = true;
	}
}
