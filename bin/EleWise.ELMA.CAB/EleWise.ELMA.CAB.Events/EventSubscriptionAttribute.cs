using System;
using System.ComponentModel;

namespace EleWise.ELMA.CAB.Events;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class EventSubscriptionAttribute : Attribute
{
	private readonly string topic;

	public string Topic => topic;

	[DefaultValue(ThreadOption.Publisher)]
	public ThreadOption Thread { get; set; }

	public EventSubscriptionAttribute(string topic)
		: this(topic, ThreadOption.Publisher)
	{
	}

	public EventSubscriptionAttribute(string topic, ThreadOption threadOption)
	{
		this.topic = topic;
		Thread = threadOption;
	}
}
