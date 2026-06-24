using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentNamePropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		Guid guid = InterfaceActivator.PropertyUid((IDmsObject m) => m.Name);
		if (!(propertyViewItem.PropertyUid != guid))
		{
			FormViewItem formViewItem = propertyViewItem.FormViewItem;
			DocumentMetadata documentMetadata = (formViewItem.MetadataUid.HasValue ? (MetadataLoader.LoadMetadata(formViewItem.MetadataUid.Value) as DocumentMetadata) : null);
			if (documentMetadata != null && !documentMetadata.IsAllowRename)
			{
				propertyViewItem.Attributes.ReadOnly = true;
			}
		}
	}
}
