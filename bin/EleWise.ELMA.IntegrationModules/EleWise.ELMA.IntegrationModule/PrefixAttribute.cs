using System;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class PrefixAttribute : Attribute
{
	private string prefix;

	public string Value
	{
		get
		{
			return prefix;
		}
		set
		{
			prefix = value;
		}
	}

	public PrefixAttribute(string value)
	{
		prefix = value;
	}
}
