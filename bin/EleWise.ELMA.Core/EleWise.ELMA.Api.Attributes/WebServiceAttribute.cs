using System;

namespace EleWise.ELMA.Api.Attributes;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public class WebServiceAttribute : BaseWebServiceAttribute
{
	private readonly string _003CServiceName_003Ek__BackingField;

	private readonly string _003CAreaName_003Ek__BackingField;

	public string ServiceName => _003CServiceName_003Ek__BackingField;

	public string AreaName => _003CAreaName_003Ek__BackingField;

	public WebServiceAttribute(string serviceName, string areaName = "")
	{
		_003CServiceName_003Ek__BackingField = serviceName;
		_003CAreaName_003Ek__BackingField = areaName;
	}
}
