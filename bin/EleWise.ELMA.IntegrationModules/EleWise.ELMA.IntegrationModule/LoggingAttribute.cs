using System;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class LoggingAttribute : Attribute
{
	private bool logging;

	public bool Value
	{
		get
		{
			return logging;
		}
		set
		{
			logging = value;
		}
	}

	public LoggingAttribute(bool value)
	{
		logging = value;
	}
}
