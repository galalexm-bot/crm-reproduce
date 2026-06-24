using System.Collections.Generic;

namespace EleWise.ELMA.Messages.DTO;

public sealed class MessageCreateDTO
{
	public string Text { get; set; }

	public ICollection<ChatAttachmentDTO> Attachments { get; set; }
}
