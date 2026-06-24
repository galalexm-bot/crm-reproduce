using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentResolver : DocumentResolverBase
{
	public override IEnumerable<IDocument> GetDocuments(object value)
	{
		return ExtractDocuments(value, GetDocumentFromObject);
	}

	public override IEnumerable<Guid> GetContextVarTypes()
	{
		List<Guid> list = MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>().SelectMany((DocumentMetadata d) => new List<Guid> { d.Uid, d.ImplementationUid })
			.ToList();
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocument>();
		list.Add(entityMetadata.Uid);
		list.Add(entityMetadata.ImplementationUid);
		return list;
	}

	public IDocument GetDocumentFromObject(object value)
	{
		if (value is IDocument result)
		{
			return result;
		}
		return null;
	}
}
