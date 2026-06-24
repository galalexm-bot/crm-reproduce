using System;
using System.Globalization;
using System.Reflection;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Events;

internal class Publication : IDisposable
{
	private readonly string eventName;

	private readonly PublicationScope scope;

	private readonly EventTopic topic;

	private readonly WeakReference wrPublisher;

	private readonly WeakReference wrWorkItem;

	public object Publisher => wrPublisher.Target;

	public WorkItem WorkItem => (WorkItem)wrWorkItem.Target;

	public string EventName => eventName;

	public PublicationScope Scope => scope;

	public Publication(EventTopic topic, object publisher, string eventName, WorkItem workItem, PublicationScope scope)
	{
		if (publisher == null)
		{
			throw new ArgumentNullException("publisher");
		}
		if (eventName == null)
		{
			throw new ArgumentNullException("eventName");
		}
		this.topic = topic;
		wrPublisher = new WeakReference(publisher);
		this.scope = scope;
		this.eventName = eventName;
		wrWorkItem = new WeakReference(workItem);
		EventInfo @event = publisher.GetType().GetEvent(eventName, EventInspector.SearchFlags);
		if (@event == null)
		{
			throw new EventBrokerException(string.Format(CultureInfo.CurrentCulture, Resources.CannotFindPublishedEvent, new object[1] { eventName }));
		}
		ThrowIfInvalidEventHandler(@event);
		ThrowIfEventIsStatic(@event);
		Delegate handler = Delegate.CreateDelegate(@event.EventHandlerType, this, GetType().GetMethod("PublicationHandler"));
		@event.AddEventHandler(publisher, handler);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void ThrowIfEventIsStatic(EventInfo publishedEvent)
	{
		if (publishedEvent == null)
		{
			throw new ArgumentNullException("publishedEvent");
		}
		if (publishedEvent.GetAddMethod().IsStatic || publishedEvent.GetRemoveMethod().IsStatic)
		{
			throw new EventBrokerException(string.Format(CultureInfo.CurrentCulture, Resources.StaticPublisherNotAllowed, new object[1] { EventName }));
		}
	}

	private static void ThrowIfInvalidEventHandler(EventInfo info)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (typeof(EventHandler).IsAssignableFrom(info.EventHandlerType) || (info.EventHandlerType.IsGenericType && typeof(EventHandler<>).IsAssignableFrom(info.EventHandlerType.GetGenericTypeDefinition())))
		{
			return;
		}
		throw new EventBrokerException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidPublicationSignature, new object[2]
		{
			info.DeclaringType.FullName,
			info.Name
		}));
	}

	public void PublicationHandler(object sender, EventArgs e)
	{
		topic.Fire(this, sender, e);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			object publisher = Publisher;
			if (publisher != null)
			{
				EventInfo @event = publisher.GetType().GetEvent(eventName);
				@event.RemoveEventHandler(publisher, Delegate.CreateDelegate(@event.EventHandlerType, this, GetType().GetMethod("PublicationHandler")));
			}
		}
	}
}
