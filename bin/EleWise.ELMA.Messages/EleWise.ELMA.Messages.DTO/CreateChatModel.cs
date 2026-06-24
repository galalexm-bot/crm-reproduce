using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Messages.DTO;

public sealed class CreateChatModel
{
	public string Subject { get; set; }

	public Guid Avatar { get; set; }

	public ICollection<Guid> Channels { get; set; }
}
