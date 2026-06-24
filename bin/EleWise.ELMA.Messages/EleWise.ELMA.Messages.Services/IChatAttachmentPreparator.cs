using System.Collections.Generic;
using EleWise.ELMA.Messages.DTO;

namespace EleWise.ELMA.Messages.Services;

internal interface IChatAttachmentPreparator
{
	ICollection<ChatAttachmentDTO> PrepareAttachments(ICollection<ChatAttachmentDTO> attachments);

	(string message, ICollection<ChatAttachmentDTO> attachments) PrepareAttachmentsWithMessage(string messageText, ICollection<ChatAttachmentDTO> attachments);
}
