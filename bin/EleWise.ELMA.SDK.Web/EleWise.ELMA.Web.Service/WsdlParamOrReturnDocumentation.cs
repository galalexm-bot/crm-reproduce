using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Service;

[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
public class WsdlParamOrReturnDocumentationAttribute : LocalizedStringAttribute
{
	public WsdlParamOrReturnDocumentationAttribute(string docComment)
		: base(docComment)
	{
	}

	public WsdlParamOrReturnDocumentationAttribute(Type staticResourceType, string propertyName)
		: base(staticResourceType, propertyName)
	{
	}
}
