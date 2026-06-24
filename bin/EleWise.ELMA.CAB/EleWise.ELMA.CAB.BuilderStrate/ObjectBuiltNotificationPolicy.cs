using System.Collections.Generic;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.BuilderStrategies;

public class ObjectBuiltNotificationPolicy : IBuilderPolicy
{
	public delegate void ItemNotification(object item);

	public Dictionary<WorkItem, ItemNotification> AddedDelegates = new Dictionary<WorkItem, ItemNotification>();

	public Dictionary<WorkItem, ItemNotification> RemovedDelegates = new Dictionary<WorkItem, ItemNotification>();
}
