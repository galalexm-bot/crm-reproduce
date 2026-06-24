using System;

namespace EleWise.ELMA.Messages.Models;

[Obsolete("Статусы сообщений больше не используются и они будут удалены в будущих версиях.", true)]
public class BaseMessageStatus
{
	public long MessageId { get; set; }

	public MessageStatus? Status { get; set; }
}
