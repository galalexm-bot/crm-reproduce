using System;
using System.Collections.Generic;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messaging;

public interface IMessage : IMessageBase
{
	object Recipient { get; set; }

	object Author { get; set; }

	string AuthorText { get; set; }

	bool SendToAuthor { get; set; }

	Guid? ObjectUid { get; set; }

	Guid? ActionUid { get; set; }

	int Priority { get; set; }

	string URL { get; set; }

	string Subject { get; set; }

	string ShortMessageText { get; set; }

	string ShortMessageHtml { get; set; }

	string FullMessageText { get; set; }

	string FullMessageHtml { get; set; }

	string ObjectId { get; set; }

	string[] AttachmentIds { get; set; }

	bool AttachmentsBySingleFile { get; set; }

	MessageAttachment[] MessageAttachments { get; set; }

	bool Delayed { get; set; }

	CustomMessage[] CustomMessages { get; set; }

	IEnumerable<IUser> GetRecipients();
}
