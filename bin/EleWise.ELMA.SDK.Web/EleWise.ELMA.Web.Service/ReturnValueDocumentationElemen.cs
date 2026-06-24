using System;

namespace EleWise.ELMA.Web.Service;

public class ReturnValueDocumentationElement : TypedDocumentationElement
{
	public ReturnValueDocumentationElement(string summary, Type type)
		: base(summary, type)
	{
	}
}
