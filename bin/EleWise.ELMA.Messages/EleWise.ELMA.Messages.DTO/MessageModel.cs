using System.Collections.Generic;

namespace EleWise.ELMA.Messages.DTO;

public sealed class MessageModel
{
	public MessageDTO Message { get; set; }

	public IList<string> Recipients { get; set; }
}
