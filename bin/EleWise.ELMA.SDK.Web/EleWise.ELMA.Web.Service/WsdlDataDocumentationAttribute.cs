using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Service;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Interface)]
internal class WsdlDataDocumentationAttribute : LocalizedStringAttribute
{
	public WsdlDataDocumentationAttribute(string docComment)
		: base(docComment)
	{
	}

	public WsdlDataDocumentationAttribute(Type staticResourceType, string propertyName)
		: base(staticResourceType, propertyName)
	{
	}
}
