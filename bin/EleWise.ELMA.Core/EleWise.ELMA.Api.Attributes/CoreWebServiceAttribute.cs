using System;

namespace EleWise.ELMA.Api.Attributes;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
internal sealed class CoreWebServiceAttribute : WebServiceAttribute
{
	public const string Prefix = "API";

	public CoreWebServiceAttribute(string serviceName)
		: base(serviceName)
	{
	}
}
