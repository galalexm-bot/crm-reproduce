using System;

namespace EleWise.ELMA.Messages.DTO;

public sealed class ChatAttachmentDTO
{
	public string Id { get; set; }

	public string Type { get; set; }

	public Guid ObjectUid { get; set; }

	public string Name { get; set; }

	public string Link { get; set; }

	public bool InText { get; set; }
}
