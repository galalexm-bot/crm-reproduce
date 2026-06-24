using System;

namespace EleWise.ELMA.Web.Service;

public static class Targets
{
	public const AttributeTargets ParamReturnTargets = AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter;

	public const AttributeTargets MethodsContractTargets = AttributeTargets.Method | AttributeTargets.Interface;

	public const AttributeTargets DataTargets = AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Interface;
}
