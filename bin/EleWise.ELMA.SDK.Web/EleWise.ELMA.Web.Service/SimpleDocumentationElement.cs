using System;

namespace EleWise.ELMA.Web.Service;

public abstract class SimpleDocumentationElement : TypedDocumentationElement, INamedDocumentationElement, IDocumentationElement
{
	public string Name { get; set; }

	protected SimpleDocumentationElement(string summary, Type type, string name)
		: base(summary, type)
	{
		Name = name;
	}
}
