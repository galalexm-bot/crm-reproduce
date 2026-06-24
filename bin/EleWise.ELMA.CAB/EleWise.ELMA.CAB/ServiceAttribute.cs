using System;

namespace EleWise.ELMA.CAB;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class ServiceAttribute : Attribute
{
	private readonly Type registerAs;

	public Type RegisterAs => registerAs;

	public bool AddOnDemand { get; set; }

	public ServiceAttribute()
	{
	}

	public ServiceAttribute(Type registerAs)
	{
		this.registerAs = registerAs;
	}
}
