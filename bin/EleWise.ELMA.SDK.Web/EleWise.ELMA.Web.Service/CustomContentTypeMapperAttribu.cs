using System;
using System.ServiceModel.Channels;

namespace EleWise.ELMA.Web.Service;

[AttributeUsage(AttributeTargets.Class)]
public class CustomContentTypeMapperAttribute : Attribute
{
	public Type ContentTypeMapperType { get; }

	public CustomContentTypeMapperAttribute(Type type)
	{
		Contract.ArgumentNotNull(type, "type");
		if (!typeof(WebContentTypeMapper).IsAssignableFrom(type))
		{
			throw new ArgumentException(SR.T("Неверный тип WebContentTypeMapper"));
		}
		ContentTypeMapperType = type;
	}
}
