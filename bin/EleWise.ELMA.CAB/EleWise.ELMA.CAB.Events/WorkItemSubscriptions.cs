using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace EleWise.ELMA.CAB.Events;

internal class WorkItemSubscriptions : IEnumerable<Subscription>, IEnumerable
{
	private readonly object lockObject = new object();

	private readonly List<Subscription> subscriptions = new List<Subscription>();

	private readonly WeakReference wrWorkItem;

	public WorkItem WorkItem => (WorkItem)wrWorkItem.Target;

	public int SubscriptionCount => subscriptions.Count;

	public WorkItemSubscriptions(WorkItem workItem)
	{
		wrWorkItem = new WeakReference(workItem);
	}

	public IEnumerator<Subscription> GetEnumerator()
	{
		IEnumerator<Subscription> enumerator = subscriptions.GetEnumerator();
		IEnumerator<Subscription> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerator enumerator = GetEnumerator();
		IEnumerator enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator>() != null");
		return enumerator2;
	}

	public void AddSubscription(object subscriber, string handlerMethodName, ThreadOption threadOption)
	{
		AddSubscription(subscriber, handlerMethodName, null, threadOption);
	}

	public void AddSubscription(object subscriber, string handlerMethodName, Type[] parameterTypes, ThreadOption threadOption)
	{
		lock (lockObject)
		{
			if (FindSubscription(subscriber, handlerMethodName) == null)
			{
				subscriptions.Add(new Subscription(this, subscriber, handlerMethodName, parameterTypes, threadOption));
			}
		}
	}

	public void RemoveSubscription(object subscriber, string handlerMethodName)
	{
		lock (lockObject)
		{
			Subscription subscription = FindSubscription(subscriber, handlerMethodName);
			if (subscription != null)
			{
				RemoveSubscription(subscription);
			}
		}
	}

	public void RemoveSubscription(Subscription subscription)
	{
		lock (lockObject)
		{
			subscriptions.Remove(subscription);
		}
	}

	public EventTopicFireDelegate[] GetHandlers()
	{
		List<EventTopicFireDelegate> list = new List<EventTopicFireDelegate>();
		lock (lockObject)
		{
			list.AddRange(from subscription in subscriptions.ToArray()
				select subscription?.GetHandler() into handler
				where handler != null
				select handler);
			return list.ToArray();
		}
	}

	public Subscription FindSubscription(object subscriber, string handlerMethodName)
	{
		lock (lockObject)
		{
			Clean();
			return subscriptions.Find((Subscription match) => match != null && match.Subscriber == subscriber && match.HandlerMethodName == handlerMethodName);
		}
	}

	public void Clean()
	{
		lock (lockObject)
		{
			if (WorkItem == null || (WorkItem != null && WorkItem.Status == WorkItemStatus.Terminated))
			{
				subscriptions.Clear();
				return;
			}
			Subscription[] array = subscriptions.ToArray();
			foreach (Subscription subscription in array)
			{
				if (subscription.Subscriber == null)
				{
					RemoveSubscription(subscription);
				}
			}
		}
	}
}
