using System;

namespace EleWise.ELMA.Web.Service;

public class ParameterDocumentationElement : SimpleDocumentationElement
{
	public ParameterDocumentationElement(string summary, Type type, string name)
		: base(summary, type, name)
	{
	}
}
