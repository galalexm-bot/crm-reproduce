using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class MessageRecipientInfo
{
	[DataMember]
	public Guid TypeUid;

	[DataMember]
	public string Id;

	[DataMember]
	public string Name;

	public static MessageRecipientInfo CreateMessageRecipientInfo(MessageRecipient model)
	{
		return new MessageRecipientInfo
		{
			Id = model.Id,
			Name = model.Name,
			TypeUid = model.TypeUid
		};
	}

	public static MessageRecipient CreateMessageRecipientModel(MessageRecipientInfo info)
	{
		MessageRecipient result = default(MessageRecipient);
		result.Id = info.Id;
		result.Name = info.Name;
		result.TypeUid = info.TypeUid;
		return result;
	}
}
