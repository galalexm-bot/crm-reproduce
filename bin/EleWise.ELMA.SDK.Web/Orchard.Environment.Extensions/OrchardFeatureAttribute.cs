using System;

namespace Orchard.Environment.Extensions;

[AttributeUsage(AttributeTargets.Class)]
public class OrchardFeatureAttribute : Attribute
{
	public string FeatureName { get; set; }

	public OrchardFeatureAttribute(string text)
	{
		FeatureName = text;
	}
}
