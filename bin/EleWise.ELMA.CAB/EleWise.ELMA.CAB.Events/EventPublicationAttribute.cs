using System;

namespace EleWise.ELMA.CAB.Events;

[AttributeUsage(AttributeTargets.Event, AllowMultiple = true)]
public sealed class EventPublicationAttribute : Attribute
{
	private readonly PublicationScope scope;

	private readonly string topic;

	public string Topic => topic;

	public PublicationScope Scope => scope;

	public EventPublicationAttribute(string topic)
		: this(topic, PublicationScope.Global)
	{
	}

	public EventPublicationAttribute(string topic, PublicationScope scope)
	{
		this.topic = topic;
		this.scope = scope;
	}
}
