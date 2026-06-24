using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.DTO;

namespace EleWise.ELMA.Messages.Impl.Actors.ActorStates;

internal sealed class MessageActorState
{
	public Guid Uid { get; set; }

	public string Text { get; set; }

	public ICollection<ChatAttachmentDTO> Attachments { get; set; }

	public UserDTO Author { get; set; }

	public DateTime? Date { get; set; }

	public string Hash { get; set; }
}
