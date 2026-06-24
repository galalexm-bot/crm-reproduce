using System.Collections.Generic;

namespace EleWise.ELMA.Messages.DTO;

public sealed class ChatModel
{
	public ChatDTO Chat { get; set; }

	public IList<string> Recipients { get; set; }
}
