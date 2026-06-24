using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Events;

[Serializable]
public class EventTopicException : Exception
{
	private readonly ReadOnlyCollection<Exception> exceptions = new ReadOnlyCollection<Exception>(new List<Exception>());

	private readonly EventTopic topic;

	public ReadOnlyCollection<Exception> Exceptions => exceptions;

	public EventTopic Topic => topic;

	public override string Message
	{
		get
		{
			string text = base.Message + string.Join("\n\r", exceptions.Select((Exception e) => e.ToString()).ToArray());
			string text2 = text;
			__ContractsRuntime.Ensures(text2 != null, null, "Contract.Result<string>() != null");
			return text2;
		}
	}

	public EventTopicException()
	{
	}

	public EventTopicException(string message)
		: base(message)
	{
	}

	public EventTopicException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected EventTopicException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public EventTopicException(EventTopic topic, ReadOnlyCollection<Exception> exceptions)
		: base(string.Format(CultureInfo.CurrentCulture, Resources.EventTopicFireException, new object[1] { topic.Name }))
	{
		if (exceptions == null)
		{
			throw new ArgumentNullException("exceptions");
		}
		this.topic = topic;
		this.exceptions = exceptions;
	}
}
