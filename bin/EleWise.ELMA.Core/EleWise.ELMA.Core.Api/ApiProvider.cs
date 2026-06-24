using System;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Api;

public class ApiProvider
{
	public const string AreaName = "EleWise.ELMA.SDK.Web";

	public const string UrlRestSubPath = "REST";

	public static string GetServiceKey(System.Type serviceType)
	{
		CoreWebServiceAttribute attribute = AttributeHelper<CoreWebServiceAttribute>.GetAttribute(serviceType, inherited: false);
		if (attribute != null)
		{
			return string.Join("/", new string[3] { "API", "REST", attribute.ServiceName });
		}
		InternalWebServiceAttribute attribute2 = AttributeHelper<InternalWebServiceAttribute>.GetAttribute(serviceType, inherited: false);
		if (attribute2 != null)
		{
			return string.Join("/", new string[4]
			{
				InternalWebServiceAttribute.Prefix,
				"REST",
				GetAreaName(attribute2),
				attribute2.ServiceName
			});
		}
		PublicApiServiceAttribute attribute3 = AttributeHelper<PublicApiServiceAttribute>.GetAttribute(serviceType, inherited: false);
		if (attribute3 != null)
		{
			return string.Join("/", new string[4]
			{
				"PublicAPI",
				"REST",
				GetAreaName(attribute3),
				attribute3.ServiceName
			});
		}
		WebServiceAttribute attribute4 = AttributeHelper<WebServiceAttribute>.GetAttribute(serviceType, inherited: false);
		if (attribute4 != null)
		{
			return string.Join("/", new string[2]
			{
				GetAreaName(attribute4),
				attribute4.ServiceName
			});
		}
		if (AttributeHelper<BaseWebServiceAttribute>.GetAttribute(serviceType, inherited: false) == null)
		{
			throw new System.Exception(SR.T("Веб-сервис должен иметь один из атрибутов: {0}, {1}, {2}, {3}, {4}", "BaseWebServiceAttribute", "WebServiceAttribute", "InternalWebServiceAttribute", "CoreWebServiceAttribute", "PublicApiServiceAttribute"));
		}
		return "";
	}

	public static string GetServicePath(System.Type serviceType, MethodInfo method, string baseUrl)
	{
		if (!IsTask(method.get_ReturnType()))
		{
			throw new System.Exception(SR.T("Метод должен Возвращать System.Threading.Tasks.Task`1"));
		}
		OperationAttribute attribute = AttributeHelper<OperationAttribute>.GetAttribute((MemberInfo)(object)method, inherited: false);
		if (attribute == null)
		{
			throw new System.Exception(SR.T("Метод должен иметь атрибут {0}", "OperationAttribute"));
		}
		string text = GetServiceKey(serviceType);
		if (!baseUrl.EndsWith("/") && !text.StartsWith("/"))
		{
			text = "/" + text;
		}
		return $"{baseUrl}{text}{attribute.UriTemplate}";
	}

	public static WebMethod GetWebMethod(MethodInfo method)
	{
		OperationAttribute attribute = AttributeHelper<OperationAttribute>.GetAttribute((MemberInfo)(object)method, inherited: false);
		if (attribute == null)
		{
			throw new System.Exception(SR.T("Метод должен иметь атрибут {0}", "OperationAttribute"));
		}
		return attribute.Method;
	}

	public static string GetBodyType(MethodInfo method)
	{
		OperationAttribute attribute = AttributeHelper<OperationAttribute>.GetAttribute((MemberInfo)(object)method, inherited: false);
		if (attribute == null)
		{
			throw new System.Exception(SR.T("Метод должен иметь атрибут {0}", "OperationAttribute"));
		}
		return attribute.BodyContentType;
	}

	public static bool IsTask(System.Type t)
	{
		return typeof(System.Threading.Tasks.Task).IsAssignableFrom(t);
	}

	private static string GetAreaName(WebServiceAttribute attribute)
	{
		string areaName = attribute.AreaName;
		if (!string.IsNullOrWhiteSpace(areaName))
		{
			return areaName;
		}
		return "EleWise.ELMA.SDK.Web";
	}
}
