using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using NHibernate.Util;

namespace EleWise.ELMA.Messages.Exceptions;

[Serializable]
public class GroupingUserMailMessagesException : Exception
{
	private SerializableDictionary<IUser, Exception> _exceptions = new SerializableDictionary<IUser, Exception>();

	public IDictionary<IUser, Exception> Exceptions => _exceptions;

	public GroupingUserMailMessagesException()
	{
	}

	public GroupingUserMailMessagesException(string message)
		: base(message)
	{
	}

	public GroupingUserMailMessagesException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public GroupingUserMailMessagesException(IDictionary<IUser, Exception> exceptions)
	{
		EnumerableExtensions.ForEach<KeyValuePair<IUser, Exception>>((IEnumerable<KeyValuePair<IUser, Exception>>)exceptions, (Action<KeyValuePair<IUser, Exception>>)delegate(KeyValuePair<IUser, Exception> e)
		{
			Exceptions.Add(e.Key, e.Value);
		});
	}

	public GroupingUserMailMessagesException(string message, IDictionary<IUser, Exception> exceptions)
		: this(message)
	{
		EnumerableExtensions.ForEach<KeyValuePair<IUser, Exception>>((IEnumerable<KeyValuePair<IUser, Exception>>)exceptions, (Action<KeyValuePair<IUser, Exception>>)delegate(KeyValuePair<IUser, Exception> e)
		{
			Exceptions.Add(e.Key, e.Value);
		});
	}

	protected GroupingUserMailMessagesException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public void AddUserMessageException(IUser user, Exception mailMessagException)
	{
		Exceptions.Add(user, mailMessagException);
	}
}
