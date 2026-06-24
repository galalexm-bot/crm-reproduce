using System;

namespace EleWise.ELMA.Messages.DTO;

public sealed class ChatHeader
{
	public Guid Uid { get; set; }

	public string Subject { get; set; }
}
