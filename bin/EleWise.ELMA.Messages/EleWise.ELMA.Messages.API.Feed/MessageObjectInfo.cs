using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class MessageObjectInfo
{
	[DataMember]
	public Guid TypeUid;

	[DataMember]
	public string Id;

	[DataMember]
	public string Name;

	public static MessageObjectInfo CreateMessageObjectInfo(MessageObject model)
	{
		return new MessageObjectInfo
		{
			Id = model.Id,
			Name = model.Name,
			TypeUid = model.TypeUid
		};
	}
}
