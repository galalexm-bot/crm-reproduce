using System;
using System.Collections.Generic;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Messages.Models;

[Serializable]
public sealed class FeedMessageObjectList : PackSerializableEnumerable<MessageObject>
{
	public FeedMessageObjectList(byte[] packSource)
		: base(packSource)
	{
	}

	public FeedMessageObjectList(IEnumerable<MessageObject> source)
		: base(source)
	{
	}
}
