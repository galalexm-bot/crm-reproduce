using System;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.BuilderStrategies;

public class ObjectBuiltNotificationStrategy : BuilderStrategy
{
	private ObjectBuiltNotificationPolicy policy;

	public override object BuildUp(IBuilderContext context, Type typeToBuild, object existing, string idToBuild)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		WorkItem workItem = ((IReadableLocator)context.get_Locator()).Get<WorkItem>((object)new DependencyResolutionLocatorKey(typeof(WorkItem), (string)null));
		if (policy == null)
		{
			policy = context.get_Policies().Get<ObjectBuiltNotificationPolicy>((Type)null, (string)null);
		}
		if (workItem != null && !object.ReferenceEquals(workItem, existing) && policy.AddedDelegates.TryGetValue(workItem, out var value))
		{
			value(existing);
		}
		return ((BuilderStrategy)this).BuildUp(context, typeToBuild, existing, idToBuild);
	}

	public override object TearDown(IBuilderContext context, object item)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		WorkItem workItem = ((IReadableLocator)context.get_Locator()).Get<WorkItem>((object)new DependencyResolutionLocatorKey(typeof(WorkItem), (string)null));
		if (workItem != null && policy.RemovedDelegates.TryGetValue(workItem, out var value))
		{
			value(item);
		}
		return ((BuilderStrategy)this).TearDown(context, item);
	}
}
