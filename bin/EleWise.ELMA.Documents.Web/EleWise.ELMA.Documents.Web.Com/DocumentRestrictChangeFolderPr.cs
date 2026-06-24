using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentRestrictChangeFolderPropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		Guid guid = InterfaceActivator.PropertyUid((IDmsObject m) => m.Folder);
		if (propertyViewItem.PropertyUid != guid)
		{
			return;
		}
		FormViewItem formViewItem = propertyViewItem.FormViewItem;
		if ((formViewItem.MetadataUid.HasValue ? (MetadataLoader.LoadMetadata(formViewItem.MetadataUid.Value) as DocumentMetadata) : null) == null)
		{
			return;
		}
		IDocument document = (model as IDocument) ?? ((model is DocumentInfo) ? ((DocumentInfo)model).Entity : null);
		if (document == null || document.Folder == null)
		{
			return;
		}
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
		bool restrictChangeFolder;
		if (!(model is DocumentInfo))
		{
			if (documentMetadataProfile == null)
			{
				return;
			}
			restrictChangeFolder = documentMetadataProfile.RestrictChangeFolder;
		}
		else
		{
			restrictChangeFolder = ((DocumentInfo)model).RestrictChangeFolder;
		}
		if (restrictChangeFolder)
		{
			propertyViewItem.Attributes.ReadOnly = true;
		}
	}
}
