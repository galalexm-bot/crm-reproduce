using System;

namespace EleWise.ELMA.Api.Attributes;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
internal sealed class InternalWebServiceAttribute : WebServiceAttribute
{
	public static string Prefix => "InternalAPI";

	public InternalWebServiceAttribute(string serviceName, string areaName = "")
		: base(serviceName, areaName)
	{
	}
}
