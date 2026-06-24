using System.Collections.Generic;

namespace EleWise.ELMA.Messaging;

public interface IMessageBase
{
	string Channels { get; set; }

	IEnumerable<IMessage> GetMessages();
}
