using System;
using EleWise.ELMA.IntegrationModules.Models;

namespace EleWise.ELMA.IntegrationModules.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class IntegrationModuleTypeAttribute : Attribute
{
	private IntegrationModuleType type;

	public IntegrationModuleType Type => type;

	public IntegrationModuleTypeAttribute(IntegrationModuleType value)
	{
		type = value;
	}
}
