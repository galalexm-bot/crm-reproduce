using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Documents.Descriptors;

public class DocumentAttachmentDescriptor : EntitySubTypeDescriptor<IDocumentAttachment>
{
	protected static string DocumentPropertyName = LinqUtils.NameOf((Expression<Func<IDocumentAttachment, object>>)((IDocumentAttachment a) => a.Document));

	protected static string CreationAuthorPropertyName = LinqUtils.NameOf((Expression<Func<IDocumentAttachment, object>>)((IDocumentAttachment a) => a.CreationAuthor));

	protected static string CreationDatePropertyName = LinqUtils.NameOf((Expression<Func<IDocumentAttachment, object>>)((IDocumentAttachment a) => a.CreationDate));

	public DateTimeDescriptor DateTimeDescriptor { get; set; }

	public EntityDescriptor EntityDescriptor { get; set; }

	public DocumentTypeDescriptor DocumentTypeDescriptor { get; set; }

	public override Guid SubTypeUid => InterfaceActivator.UID<IDocumentAttachment>();

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		if (val is IEnumerable<IDocumentAttachment> source)
		{
			return source.All((IDocumentAttachment p) => p.Document == null);
		}
		if (val is IDocumentAttachment documentAttachment)
		{
			return documentAttachment.Document == null;
		}
		return false;
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		if (typeof(IDocumentAttachment).IsAssignableFrom(valueType))
		{
			IDictionary<string, object> dictionary = base.SerializeSimple(value, valueType, settings) as IDictionary<string, object>;
			if (value != null && value is IDocumentAttachment documentAttachment && dictionary != null)
			{
				if (!dictionary.ContainsKey(DocumentPropertyName))
				{
					IDocument document = documentAttachment.Document;
					object value2 = DocumentTypeDescriptor.SerializeSimple(document);
					dictionary.Add(DocumentPropertyName, value2);
				}
				if (!dictionary.ContainsKey(CreationAuthorPropertyName) && documentAttachment.CreationAuthor != null)
				{
					object value3 = EntityDescriptor.SerializeSimple(documentAttachment.CreationAuthor);
					dictionary.Add(CreationAuthorPropertyName, value3);
				}
				if (!dictionary.ContainsKey(CreationDatePropertyName) && documentAttachment.CreationDate != default(DateTime))
				{
					object value4 = DateTimeDescriptor.SerializeSimple(documentAttachment.CreationDate);
					dictionary.Add(CreationDatePropertyName, value4);
				}
			}
			return dictionary;
		}
		return base.SerializeSimple(value, valueType, settings);
	}
}
