using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.Messages.Services;

[Service]
internal sealed class ChatAttachmentsPreparator : IChatAttachmentPreparator
{
	private readonly IEnumerable<ILinkTypeProvider> linkTypeProviders;

	public ChatAttachmentsPreparator(IEnumerable<ILinkTypeProvider> linkTypeProviders)
	{
		this.linkTypeProviders = linkTypeProviders;
	}

	public ICollection<ChatAttachmentDTO> PrepareAttachments(ICollection<ChatAttachmentDTO> attachments)
	{
		return PrepareAttachments("", attachments).attachments;
	}

	public (string message, ICollection<ChatAttachmentDTO> attachments) PrepareAttachmentsWithMessage(string messageText, ICollection<ChatAttachmentDTO> attachments)
	{
		return PrepareAttachments(messageText, attachments, replaceAttachmentId: true);
	}

	private (string message, ICollection<ChatAttachmentDTO> attachments) PrepareAttachments(string messageText, ICollection<ChatAttachmentDTO> attachments, bool replaceAttachmentId = false)
	{
		List<ChatAttachmentDTO> list = new List<ChatAttachmentDTO>();
		string text = messageText;
		if (attachments != null && attachments.Any())
		{
			using (SafeHttpContext.Create())
			{
				RequestContext requestContext = GetRequestContext();
				foreach (ChatAttachmentDTO attachment in attachments)
				{
					ChatAttachmentDTO chatAttachmentDTO = PrepareAttachment(attachment, requestContext);
					list.Add(chatAttachmentDTO);
					if (replaceAttachmentId)
					{
						text = text.Replace(attachment.Id, chatAttachmentDTO.Id);
					}
				}
			}
		}
		return (text, list);
	}

	private ChatAttachmentDTO PrepareAttachment(ChatAttachmentDTO attachment, RequestContext requestContext)
	{
		ChatAttachmentDTO chatAttachmentDTO = new ChatAttachmentDTO
		{
			Id = Guid.NewGuid().ToString("N"),
			Type = attachment.Type,
			ObjectUid = attachment.ObjectUid,
			Name = attachment.Name,
			InText = attachment.InText,
			Link = attachment.Link
		};
		if (!string.IsNullOrEmpty(attachment.Type) && attachment.InText)
		{
			chatAttachmentDTO.Link = GetAttachmentHref(attachment, requestContext);
		}
		return chatAttachmentDTO;
	}

	private string GetAttachmentHref(ChatAttachmentDTO attachment, RequestContext requestContext)
	{
		ILinkTypeProvider linkTypeProvider = linkTypeProviders.FirstOrDefault((ILinkTypeProvider p) => p.Id == attachment.Type);
		if (linkTypeProvider != null)
		{
			return linkTypeProvider.Get(string.Format("'{0}'", attachment.ObjectUid.ToString("N"))).GetHref(requestContext);
		}
		return string.Empty;
	}

	private RequestContext GetRequestContext()
	{
		HttpContextWrapper httpContext = new HttpContextWrapper(HttpContext.Current);
		RouteData routeData = new RouteData();
		return new RequestContext(httpContext, routeData);
	}
}
