using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Messaging;

public interface IMessageManager
{
	IMessage Create();

	void Send(IMessageBase message);

	void Send(IMessageBase message, IEnumerable<IMessageChannel> channels);

	void Send(IMessageBase message, IEnumerable<string> channelNames);

	void Send(IMessageBase message, IEnumerable<Guid> channelUids);

	void Delay(Guid objectUid, string objectId, Guid actionUid);

	bool IsDelayed(Guid objectUid, string objectId, Guid actionUid);

	void CancelSend(Guid objectUid, string objectId, long? recipientId = null);

	bool IsCancelledSend(Guid objectUid, string objectId, long recipientId);
}
