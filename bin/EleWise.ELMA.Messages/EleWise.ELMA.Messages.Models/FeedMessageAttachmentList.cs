using System;
using System.Collections.Generic;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Messages.Models;

[Serializable]
public sealed class FeedMessageAttachmentList : PackSerializableEnumerable<MessageAttachment>
{
	public FeedMessageAttachmentList(byte[] packSource)
		: base(packSource)
	{
	}

	public FeedMessageAttachmentList(IEnumerable<MessageAttachment> source)
		: base(source)
	{
	}
}
