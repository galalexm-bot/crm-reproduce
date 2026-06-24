using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
public class WorkflowTaskPropertyReadOnlyFormViewItemTransformate : IFormViewItemTransformate
{
	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		if (formViewItem.MetadataUid != new Guid("c4dc0ccc-c1a3-45d6-b794-e23152342c3d") && formViewItem.MetadataUid != new Guid("555a587d-25c1-4f99-ade6-3176b4fc9a6c"))
		{
			return formViewItem;
		}
		return formViewItem.Transformate(delegate(FormViewItemTransformationBuilder<IWorkflowTask> t)
		{
			t.ForItem<DefaultContainerViewItem>(DefaultContainerViewItem.ItemUid).SetPropertyValue((DefaultContainerViewItem i) => i.OnlyUserProperties, value: true);
			t.ForItem<DefaultContainerViewItem>(DefaultContainerViewItem.ItemUid).SetPropertyValue((DefaultContainerViewItem i) => i.ReadOnly, value: true);
		});
	}
}
