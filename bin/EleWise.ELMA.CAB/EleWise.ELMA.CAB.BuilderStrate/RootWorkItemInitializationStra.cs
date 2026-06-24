using System;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.BuilderStrategies;

internal class RootWorkItemInitializationStrategy : BuilderStrategy
{
	public delegate void RootWorkItemInitializationCallback();

	private readonly RootWorkItemInitializationCallback callback;

	public RootWorkItemInitializationStrategy(RootWorkItemInitializationCallback callback)
	{
		this.callback = callback;
	}

	public override object BuildUp(IBuilderContext context, Type typeToBuild, object existing, string idToBuild)
	{
		if (existing is WorkItem workItem && workItem.Parent == null)
		{
			callback();
		}
		return ((BuilderStrategy)this).BuildUp(context, typeToBuild, existing, idToBuild);
	}
}
