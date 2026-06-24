using System;
using EleWise.ELMA.CAB.Events;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.BuilderStrategies;

public class EventBrokerStrategy : BuilderStrategy
{
	public override object BuildUp(IBuilderContext context, Type t, object existing, string id)
	{
		WorkItem workItem = GetWorkItem(context, existing);
		if (workItem != null)
		{
			EventInspector.Register(existing, workItem);
		}
		return ((BuilderStrategy)this).BuildUp(context, t, existing, id);
	}

	public override object TearDown(IBuilderContext context, object item)
	{
		WorkItem workItem = GetWorkItem(context, item);
		if (workItem != null)
		{
			EventInspector.Unregister(item, workItem);
		}
		return ((BuilderStrategy)this).TearDown(context, item);
	}

	private static WorkItem GetWorkItem(IBuilderContext context, object item)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		if (item is WorkItem)
		{
			return item as WorkItem;
		}
		return ((IReadableLocator)context.get_Locator()).Get<WorkItem>((object)new DependencyResolutionLocatorKey(typeof(WorkItem), (string)null));
	}
}
