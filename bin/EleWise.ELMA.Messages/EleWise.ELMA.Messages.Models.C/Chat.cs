using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models.Chats;

internal sealed class Chat : IChat
{
	private const string PrivateKey = "private";

	public Guid Uid { get; set; }

	public string Subject { get; set; }

	public ChatTypeEnum Type { get; set; }

	public ParticipantsDTO Participants { get; set; }

	public ICollection<InformationChannelDTO> Channels { get; set; }

	public DateTime CreationDate { get; set; }

	public Chat(IChannelMessage message)
	{
		Uid = message.Uid;
		Type = ((!(message.Subject == "private")) ? ChatTypeEnum.Public : ChatTypeEnum.Private);
		Subject = ((Type == ChatTypeEnum.Private) ? "" : message.Subject);
		if (Type == ChatTypeEnum.Private)
		{
			Participants = new ParticipantsDTO
			{
				Users = ((IEnumerable<IUser>)message.Recipients).Select((IUser r) => Mapper.Map<IUser, UserDTO>(r)).ToList(),
				ParticipantsCount = ((ICollection<IUser>)message.Recipients).Count
			};
		}
		if (message.Channels != null && ((IEnumerable<IInformationChannel>)message.Channels).Any())
		{
			Channels = ((IEnumerable<IInformationChannel>)message.Channels).Select((IInformationChannel c) => Mapper.Map<IInformationChannel, InformationChannelDTO>(c)).ToList();
		}
		CreationDate = message.CreationDate.Value;
	}
}
