using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentAttachmentResolver : DocumentResolverBase
{
	public override IEnumerable<IDocument> GetDocuments(object value)
	{
		return ExtractDocuments(value, GetDocumentFromObject);
	}

	public override IEnumerable<Guid> GetContextVarTypes()
	{
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocumentAttachment>();
		return new List<Guid> { entityMetadata.Uid, entityMetadata.ImplementationUid };
	}

	public IDocument GetDocumentFromObject(object value)
	{
		if (value is IDocumentAttachment documentAttachment && documentAttachment.Document != null)
		{
			return documentAttachment.Document;
		}
		return null;
	}
}
