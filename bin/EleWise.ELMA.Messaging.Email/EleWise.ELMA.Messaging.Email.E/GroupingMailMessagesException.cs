using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Messaging.Email.Exceptions;

[Serializable]
public class GroupingMailMessagesException : Exception
{
	private SerializableDictionary<MailMessage, Exception> _exceptions = new SerializableDictionary<MailMessage, Exception>();

	public IDictionary<MailMessage, Exception> Exceptions => _exceptions;

	public GroupingMailMessagesException()
	{
	}

	public GroupingMailMessagesException(string message)
		: base(message)
	{
	}

	public GroupingMailMessagesException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public GroupingMailMessagesException(IDictionary<MailMessage, Exception> exceptions)
	{
		exceptions.ForEach(delegate(KeyValuePair<MailMessage, Exception> e)
		{
			Exceptions.Add(e.Key, e.Value);
		});
	}

	public GroupingMailMessagesException(string message, IDictionary<MailMessage, Exception> exceptions)
		: this(message)
	{
		exceptions.ForEach(delegate(KeyValuePair<MailMessage, Exception> e)
		{
			Exceptions.Add(e.Key, e.Value);
		});
	}

	protected GroupingMailMessagesException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public void AddMailMessageException(MailMessage mailMessage, Exception mailMessagException)
	{
		Exceptions.Add(mailMessage, mailMessagException);
	}
}
