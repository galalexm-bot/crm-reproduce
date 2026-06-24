using System;
using EleWise.ELMA.Common;

namespace EleWise.ELMA.Web.Service;

public abstract class TypedDocumentationElement : AbstractDocumentationElement, ITypedDocumentationElement, IDocumentationElement
{
	public Type Type { get; set; }

	public TypeSerializationDescriptor TypeDescriptor { get; set; }

	protected TypedDocumentationElement(string summary, Type type)
		: base(summary)
	{
		Type = type;
	}
}
