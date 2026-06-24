using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models.Chats;

internal interface IChatMessage
{
	Guid Uid { get; set; }

	string Text { get; set; }

	ICollection<ChatAttachmentDTO> Attachments { get; set; }

	IUser Author { get; set; }

	Guid ChatUid { get; set; }

	DateTime? Date { get; set; }

	string Hash { get; set; }
}
