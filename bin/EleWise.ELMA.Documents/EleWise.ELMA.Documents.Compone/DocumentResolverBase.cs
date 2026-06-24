using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Components;

public abstract class DocumentResolverBase : IDocumentResolver
{
	public abstract IEnumerable<IDocument> GetDocuments(object value);

	public abstract IEnumerable<Guid> GetContextVarTypes();

	public virtual IEnumerable<IDocument> ExtractDocuments(object value, Func<object, IDocument> func)
	{
		List<IDocument> list = new List<IDocument>();
		if (value.GetType().IsGenericType)
		{
			foreach (object item in (IEnumerable)value)
			{
				IDocument document = func(item);
				if (document != null)
				{
					list.Add(document);
				}
			}
			return list;
		}
		IDocument document2 = func(value);
		if (document2 != null)
		{
			list.Add(document2);
		}
		return list;
	}
}
