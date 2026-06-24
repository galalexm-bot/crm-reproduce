using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.Impl.Actors.ActorStates;

namespace EleWise.ELMA.Messages.DTO;

public sealed class MessageDTO
{
	public Guid Uid { get; set; }

	public string Text { get; set; }

	public ICollection<ChatAttachmentDTO> Attachments { get; set; }

	public UserDTO Author { get; set; }

	public DateTime? CreationDate { get; set; }

	public string Hash { get; set; }

	public ChatHeader Chat { get; set; }

	internal MessageDTO(MessageActorState message, Guid chatUid, string chatSubject)
	{
		Uid = message.Uid;
		Text = message.Text;
		Author = message.Author;
		CreationDate = message.Date;
		Hash = message.Hash;
		Attachments = message.Attachments;
		Chat = new ChatHeader
		{
			Uid = chatUid,
			Subject = chatSubject
		};
	}
}
