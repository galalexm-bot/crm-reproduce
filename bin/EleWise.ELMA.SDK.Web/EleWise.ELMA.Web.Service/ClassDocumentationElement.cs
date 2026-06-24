using System;

namespace EleWise.ELMA.Web.Service;

public class ClassDocumentationElement : SimpleDocumentationElement
{
	public MethodDocumentationElement[] Methods { get; set; }

	public ClassDocumentationElement(string summary, Type type, string name)
		: base(summary, type, name)
	{
	}
}
