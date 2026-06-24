using System;
using System.Reflection;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Events;

public static class EventInspector
{
	public const string EVENT = "event://";

	public static BindingFlags SearchFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

	public static WorkItem MangerRootItem
	{
		get
		{
			if (ManagerRootItemFunc != null)
			{
				return ManagerRootItemFunc();
			}
			throw new Exception("ManagerRootItem not defined");
		}
	}

	public static Func<WorkItem> ManagerRootItemFunc { get; set; }

	public static void Register(object item)
	{
	}

	public static void Register(object item, WorkItem workItem)
	{
		Guard.ArgumentNotNull(item, "item");
		Guard.ArgumentNotNull(workItem, "workItem");
		ProcessPublishers(item, item.GetType(), workItem, register: true);
		ProcessSubscribers(item, item.GetType(), workItem, register: true);
	}

	public static void Fire(string topic, object sender, EventArgs e, PublicationScope scope)
	{
	}

	public static void AddSubscription(string topic, object subscriber, string handlerMethodName, Type[] parameterTypes, ThreadOption threadOption)
	{
	}

	public static void AddPublication(string topic, object publisher, string eventName, PublicationScope scope)
	{
	}

	public static void Unregister(object item, WorkItem workItem)
	{
		Guard.ArgumentNotNull(item, "item");
		Guard.ArgumentNotNull(workItem, "workItem");
		ProcessPublishers(item, item.GetType(), workItem, register: false);
		ProcessSubscribers(item, item.GetType(), workItem, register: false);
	}

	private static void ProcessPublishers(object item, Type itemType, WorkItem workItem, bool register)
	{
		if (itemType == null)
		{
			throw new ArgumentNullException("itemType");
		}
		EventInfo[] events = itemType.GetEvents(SearchFlags);
		foreach (EventInfo eventInfo in events)
		{
			object[] customAttributes = eventInfo.GetCustomAttributes(typeof(EventPublicationAttribute), inherit: true);
			for (int j = 0; j < customAttributes.Length; j++)
			{
				EventPublicationAttribute attr = (EventPublicationAttribute)customAttributes[j];
				HandlePublisher(item, register, eventInfo, attr, workItem);
			}
		}
	}

	private static void HandlePublisher(object item, bool register, EventInfo info, EventPublicationAttribute attr, WorkItem workItem)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (attr == null)
		{
			throw new ArgumentNullException("attr");
		}
		if (workItem == null)
		{
			throw new ArgumentNullException("workItem");
		}
		EventTopic eventTopic = workItem.EventTopics[attr.Topic];
		if (register)
		{
			eventTopic.AddPublication(item, info.Name, workItem, attr.Scope);
		}
		else
		{
			eventTopic.RemovePublication(item, info.Name);
		}
	}

	private static void ProcessSubscribers(object item, Type itemType, WorkItem workItem, bool register)
	{
		if (itemType == null)
		{
			throw new ArgumentNullException("itemType");
		}
		MethodInfo[] methods = itemType.GetMethods(SearchFlags);
		foreach (MethodInfo methodInfo in methods)
		{
			object[] customAttributes = methodInfo.GetCustomAttributes(typeof(EventSubscriptionAttribute), inherit: true);
			for (int j = 0; j < customAttributes.Length; j++)
			{
				EventSubscriptionAttribute attr = (EventSubscriptionAttribute)customAttributes[j];
				HandleSubscriber(item, register, methodInfo, attr, workItem);
			}
		}
	}

	private static void HandleSubscriber(object item, bool register, MethodInfo info, EventSubscriptionAttribute attr, WorkItem workItem)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (attr == null)
		{
			throw new ArgumentNullException("attr");
		}
		if (workItem == null)
		{
			throw new ArgumentNullException("workItem");
		}
		EventTopic eventTopic = workItem.EventTopics[attr.Topic];
		if (register)
		{
			Type[] paramTypes = GetParamTypes(info);
			eventTopic.AddSubscription(item, info.Name, paramTypes, workItem, attr.Thread);
		}
		else
		{
			eventTopic.RemoveSubscription(item, info.Name);
		}
	}

	private static Type[] GetParamTypes(MethodInfo info)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		ParameterInfo[] parameters = info.GetParameters();
		Type[] array = new Type[parameters.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		return array;
	}
}
