using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.DTO;

namespace EleWise.ELMA.Messages.Models.Chats;

internal interface IChat
{
	Guid Uid { get; set; }

	string Subject { get; set; }

	ChatTypeEnum Type { get; set; }

	DateTime CreationDate { get; set; }

	ParticipantsDTO Participants { get; set; }

	ICollection<InformationChannelDTO> Channels { get; set; }
}
