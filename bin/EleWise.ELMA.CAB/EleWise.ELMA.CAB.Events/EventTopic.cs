#define TRACE
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using EleWise.ELMA.CAB.Instrumentation;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Events;

public class EventTopic : IDisposable, IBuilderAware
{
	private class ClassNameTraceSourceAttribute : TraceSourceAttribute
	{
		public ClassNameTraceSourceAttribute()
			: base(typeof(EventTopic).FullName)
		{
		}
	}

	private readonly List<Publication> publications = new List<Publication>();

	private readonly List<WorkItemSubscriptions> workItemSubscriptions = new List<WorkItemSubscriptions>();

	private bool enabled = true;

	private string name;

	private TraceSource traceSource;

	[ClassNameTraceSource]
	public TraceSource TraceSource
	{
		protected get
		{
			return traceSource;
		}
		set
		{
			traceSource = value;
		}
	}

	public string Name => name;

	public bool Enabled
	{
		get
		{
			return enabled;
		}
		set
		{
			enabled = value;
		}
	}

	public virtual int PublicationCount
	{
		get
		{
			Clean();
			return publications.Count;
		}
	}

	public virtual int SubscriptionCount
	{
		get
		{
			Clean();
			return workItemSubscriptions.Sum((WorkItemSubscriptions wis) => wis.SubscriptionCount);
		}
	}

	public virtual void OnBuiltUp(string id)
	{
		name = id;
	}

	public virtual void OnTearingDown()
	{
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void AddPublication(object publisher, string eventName, WorkItem workItem, PublicationScope scope)
	{
		Guard.ArgumentNotNull(publisher, "publisher");
		Guard.ArgumentNotNullOrEmptyString(eventName, "eventName");
		Guard.ArgumentNotNull(workItem, "workItem");
		Guard.EnumValueIsDefined(typeof(PublicationScope), scope, "scope");
		Clean();
		ThrowIfRepeatedPublication(publisher, eventName);
		Publication item = new Publication(this, publisher, eventName, workItem, scope);
		publications.Add(item);
		if (traceSource != null)
		{
			traceSource.TraceInformation(Resources.EventTopicTracePublicationAdded, name, eventName, publisher.GetType().ToString());
		}
	}

	public virtual bool ContainsPublication(object publisher, string eventName)
	{
		Guard.ArgumentNotNull(publisher, "publisher");
		Guard.ArgumentNotNull(eventName, "eventName");
		Clean();
		return FindPublication(publisher, eventName) != null;
	}

	public virtual void RemovePublication(object publisher, string eventName)
	{
		Guard.ArgumentNotNull(publisher, "publisher");
		Guard.ArgumentNotNull(eventName, "eventName");
		Clean();
		Publication publication = FindPublication(publisher, eventName);
		if (publication != null)
		{
			publications.Remove(publication);
			publication.Dispose();
			if (traceSource != null)
			{
				traceSource.TraceInformation(Resources.EventTopicTracePublicationRemoved, name, eventName, publisher.GetType().ToString());
			}
		}
	}

	public virtual void Fire(object sender, EventArgs e, WorkItem workItem, PublicationScope scope)
	{
		Guard.EnumValueIsDefined(typeof(PublicationScope), scope, "scope");
		if (enabled)
		{
			if (traceSource != null)
			{
				traceSource.TraceInformation(Resources.EventTopicTraceFireStarted, name);
			}
			Clean();
			switch (scope)
			{
			case PublicationScope.WorkItem:
				CallSubscriptionHandlers(sender, e, GetWorkItemHandlers(workItem));
				break;
			case PublicationScope.Global:
				CallSubscriptionHandlers(sender, e, GetAllHandlers());
				break;
			case PublicationScope.Descendants:
				CallSubscriptionHandlers(sender, e, GetDescendantsHandlers(workItem));
				break;
			default:
				throw new ArgumentException(Resources.InvalidPublicationScope);
			}
			if (traceSource != null)
			{
				traceSource.TraceInformation(Resources.EventTopicTraceFireCompleted, name);
			}
		}
	}

	public virtual void AddSubscription(object subscriber, string handlerMethodName, WorkItem workItem, ThreadOption threadOption)
	{
		AddSubscription(subscriber, handlerMethodName, null, workItem, threadOption);
	}

	public virtual void AddSubscription(object subscriber, string handlerMethodName, Type[] parameterTypes, WorkItem workItem, ThreadOption threadOption)
	{
		Guard.ArgumentNotNull(subscriber, "subscriber");
		Guard.ArgumentNotNullOrEmptyString(handlerMethodName, "handlerMethodName");
		Guard.EnumValueIsDefined(typeof(ThreadOption), threadOption, "threadOption");
		Clean();
		WorkItemSubscriptions workItemSubscriptions = FindWorkItemSubscription(workItem);
		if (workItemSubscriptions == null)
		{
			workItemSubscriptions = new WorkItemSubscriptions(workItem);
			this.workItemSubscriptions.Add(workItemSubscriptions);
		}
		workItemSubscriptions.AddSubscription(subscriber, handlerMethodName, parameterTypes, threadOption);
		if (traceSource != null)
		{
			traceSource.TraceInformation(Resources.EventTopicTraceSubscriptionAdded, name, handlerMethodName, subscriber.GetType().ToString());
		}
	}

	public virtual void RemoveSubscription(object subscriber, string handlerMethodName)
	{
		Guard.ArgumentNotNull(subscriber, "subscriber");
		Guard.ArgumentNotNull(handlerMethodName, "handlerMethodName");
		Clean();
		foreach (WorkItemSubscriptions workItemSubscription in workItemSubscriptions)
		{
			workItemSubscription.RemoveSubscription(subscriber, handlerMethodName);
		}
		if (traceSource != null)
		{
			traceSource.TraceInformation(Resources.EventTopicTraceSubscriptionRemoved, name, handlerMethodName, subscriber.GetType().ToString());
		}
	}

	public virtual bool ContainsSubscription(object subscriber, string handlerMethodName)
	{
		Guard.ArgumentNotNull(subscriber, "subscriber");
		Guard.ArgumentNotNull(handlerMethodName, "handlerMethodName");
		Clean();
		return FindSubscription(subscriber, handlerMethodName) != null;
	}

	private void Clean()
	{
		WorkItemSubscriptions[] array = this.workItemSubscriptions.ToArray();
		foreach (WorkItemSubscriptions workItemSubscriptions in array)
		{
			workItemSubscriptions.Clean();
			if (workItemSubscriptions.SubscriptionCount == 0)
			{
				this.workItemSubscriptions.Remove(workItemSubscriptions);
			}
		}
		Publication[] array2 = publications.ToArray();
		foreach (Publication publication in array2)
		{
			if (publication.Publisher == null || publication.WorkItem == null || publication.WorkItem.Status == WorkItemStatus.Terminated)
			{
				publications.Remove(publication);
				publication.Dispose();
			}
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposing)
		{
			return;
		}
		foreach (Publication publication in publications)
		{
			publication.Dispose();
		}
		publications.Clear();
		workItemSubscriptions.Clear();
	}

	private void CallSubscriptionHandlers(object sender, EventArgs e, IEnumerable<EventTopicFireDelegate> handlers)
	{
		if (handlers == null)
		{
			throw new ArgumentNullException("handlers");
		}
		List<Exception> list = new List<Exception>();
		foreach (EventTopicFireDelegate handler in handlers)
		{
			handler(sender, e, list, traceSource);
		}
		if (list.Count > 0)
		{
			TraceExceptions(list);
			throw new EventTopicException(this, new ReadOnlyCollection<Exception>(list));
		}
	}

	private void TraceExceptions(IEnumerable<Exception> exceptions)
	{
		if (traceSource == null)
		{
			return;
		}
		traceSource.TraceInformation(Resources.EventTopicTraceFireExceptions, name);
		foreach (Exception exception in exceptions)
		{
			traceSource.TraceInformation(exception.ToString());
		}
	}

	private IEnumerable<EventTopicFireDelegate> GetDescendantsHandlers(WorkItem workItem)
	{
		List<WorkItem> list = new List<WorkItem>();
		List<EventTopicFireDelegate> list2 = new List<EventTopicFireDelegate>();
		list.Add(workItem);
		for (int i = 0; i < list.Count; i++)
		{
			list2.AddRange(GetWorkItemHandlers(list[i]));
			foreach (KeyValuePair<string, WorkItem> workItem2 in list[i].WorkItems)
			{
				list.Add(workItem2.Value);
			}
		}
		return list2.ToArray();
	}

	private IEnumerable<EventTopicFireDelegate> GetWorkItemHandlers(WorkItem workItem)
	{
		WorkItemSubscriptions workItemSubscriptions = FindWorkItemSubscription(workItem);
		if (workItemSubscriptions != null)
		{
			return workItemSubscriptions.GetHandlers();
		}
		return new EventTopicFireDelegate[0];
	}

	private IEnumerable<EventTopicFireDelegate> GetAllHandlers()
	{
		List<EventTopicFireDelegate> list = new List<EventTopicFireDelegate>();
		foreach (WorkItemSubscriptions workItemSubscription in workItemSubscriptions)
		{
			list.AddRange(workItemSubscription.GetHandlers());
		}
		return list.ToArray();
	}

	internal void Fire(Publication publication, object sender, EventArgs e)
	{
		WorkItem workItem = publication.WorkItem;
		if (workItem == null || workItem.Status == WorkItemStatus.Terminated)
		{
			publications.Remove(publication);
			publication.Dispose();
		}
		else
		{
			Fire(sender, e, publication.WorkItem, publication.Scope);
		}
	}

	private void ThrowIfRepeatedPublication(object publisher, string eventName)
	{
		if (FindPublication(publisher, eventName) != null)
		{
			throw new EventBrokerException(Resources.OnlyOnePublicationIsAllowed);
		}
	}

	private Publication FindPublication(object publisher, string eventName)
	{
		return publications.Find((Publication match) => match.Publisher == publisher && match.EventName == eventName);
	}

	private WorkItemSubscriptions FindWorkItemSubscription(WorkItem workItem)
	{
		return workItemSubscriptions.Find((WorkItemSubscriptions match) => match.WorkItem == workItem);
	}

	private Subscription FindSubscription(object subscriber, string handlerMethodName)
	{
		return workItemSubscriptions.Select((WorkItemSubscriptions wis) => wis.FindSubscription(subscriber, handlerMethodName)).FirstOrDefault((Subscription subscription) => subscription != null);
	}
}
