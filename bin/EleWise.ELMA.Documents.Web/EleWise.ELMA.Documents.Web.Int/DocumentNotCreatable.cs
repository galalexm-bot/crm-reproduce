using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Integration.Views;

[Component(Order = 100)]
public class DocumentNotCreatable : INotCreatable
{
	public bool CheckType(Type type)
	{
		if (!(InterfaceActivator.TypeOf<IDocument>() == type))
		{
			if (MetadataLoader.LoadMetadata(type) is DocumentMetadata documentMetadata)
			{
				IDocumentMetadataHeadFilter documentMetadataHeadFilter = InterfaceActivator.Create<IDocumentMetadataHeadFilter>();
				documentMetadataHeadFilter.DocumentTypeUid = documentMetadata.ImplementationUid;
				IDocumentMetadataHead documentMetadataHead = DocumentMetadataHeadManager.Instance.Find(documentMetadataHeadFilter, FetchOptions.First).FirstOrDefault();
				if (documentMetadataHead != null && !documentMetadataHead.IsDeleted)
				{
					return documentMetadata.DisableCreate;
				}
				return true;
			}
			return false;
		}
		return true;
	}
}
