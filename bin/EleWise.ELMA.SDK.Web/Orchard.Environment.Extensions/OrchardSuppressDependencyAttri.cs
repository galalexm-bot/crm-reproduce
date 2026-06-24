using System;

namespace Orchard.Environment.Extensions;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class OrchardSuppressDependencyAttribute : Attribute
{
	public string FullName { get; set; }

	public OrchardSuppressDependencyAttribute(string fullName)
	{
		FullName = fullName;
	}
}
