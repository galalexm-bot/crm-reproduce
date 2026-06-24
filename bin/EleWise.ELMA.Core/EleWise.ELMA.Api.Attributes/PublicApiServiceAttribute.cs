using System;

namespace EleWise.ELMA.Api.Attributes;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public sealed class PublicApiServiceAttribute : WebServiceAttribute
{
	public const string Prefix = "PublicAPI";

	public PublicApiServiceAttribute(string serviceName, string areaName = "")
		: base(serviceName, areaName)
	{
	}
}
