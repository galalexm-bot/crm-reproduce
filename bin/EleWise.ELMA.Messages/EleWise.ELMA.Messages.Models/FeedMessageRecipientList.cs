using System;
using System.Collections.Generic;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Messages.Models;

[Serializable]
public sealed class FeedMessageRecipientList : PackSerializableEnumerable<MessageRecipient>
{
	public FeedMessageRecipientList(byte[] packSource)
		: base(packSource)
	{
	}

	public FeedMessageRecipientList(IEnumerable<MessageRecipient> source)
		: base(source)
	{
	}
}
