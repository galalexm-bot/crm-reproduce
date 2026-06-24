using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Helpers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models.Chats;

internal sealed class ChatMessage : IChatMessage
{
	public Guid Uid { get; set; }

	public string Text { get; set; }

	public ICollection<ChatAttachmentDTO> Attachments { get; set; }

	public IUser Author { get; set; }

	public Guid ChatUid { get; set; }

	public DateTime? Date { get; set; }

	public string Hash { get; set; }

	public ChatMessage(IChannelMessage message, ICollection<ChatAttachmentDTO> attachments = null)
	{
		Uid = message.Uid;
		Text = message.FullMessage;
		Author = message.CreationAuthor;
		Date = message.CreationDate;
		ChatUid = message.Parent.Uid;
		Hash = MessageHashHelper.GenerateHash(message.Id, Date.Value);
		Attachments = attachments;
	}
}
