using System;

namespace EleWise.ELMA.Web.Service;

[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
internal class WebdataParamOrReturnDocumentationAttribute : WsdlParamOrReturnDocumentationAttribute
{
	public Type DescriptorProviderType { get; private set; }

	public WebdataParamOrReturnDocumentationAttribute(Type staticResourceType, string propertyName, Type descriptorProviderType)
		: base(staticResourceType, propertyName)
	{
		DescriptorProviderType = descriptorProviderType;
	}

	public WebdataParamOrReturnDocumentationAttribute(string docComment, Type descriptorProviderType)
		: base(docComment)
	{
		DescriptorProviderType = descriptorProviderType;
	}
}
