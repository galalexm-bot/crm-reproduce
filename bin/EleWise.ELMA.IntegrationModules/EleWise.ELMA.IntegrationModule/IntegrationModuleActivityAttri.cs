using System;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class IntegrationModuleActivityAttribute : Attribute
{
	private Guid value;

	public Guid Value => value;

	public IntegrationModuleActivityAttribute(string uid)
	{
		value = new Guid(uid);
	}
}
