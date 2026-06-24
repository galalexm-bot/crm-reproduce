using System;
using System.Diagnostics.CodeAnalysis;

namespace EleWise.ELMA.Orleans.CodeGeneration;

[ExcludeFromCodeCoverage]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class GrainWrapperForAttribute : Attribute
{
	public Type ActorInterface { get; private set; }

	public GrainWrapperForAttribute(Type actorInterface)
	{
		ActorInterface = actorInterface;
	}
}
