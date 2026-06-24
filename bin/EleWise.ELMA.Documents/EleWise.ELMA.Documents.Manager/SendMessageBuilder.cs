using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Messages;
using EleWise.ELMA.Files;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Documents.Managers;

public class SendMessageBuilder
{
	private readonly IChannelMessage message;

	private readonly IUser currentUser;

	public SendMessageBuilder(string messageSubject)
	{
		if (string.IsNullOrEmpty(messageSubject) || string.IsNullOrWhiteSpace(messageSubject))
		{
			throw new ArgumentException(SR.T("Тема сообщения не может быть null, пустой или состоять только из пробелов"));
		}
		message = InterfaceActivator.Create<IChannelMessage>();
		message.Subject = messageSubject;
		message.MessageType = ChannelMessageType.Post;
		message.CreationDate = DateTime.Now;
		currentUser = AuthenticationService.GetCurrentUser<IUser>();
		message.CreationAuthor = currentUser;
	}

	public SendMessageBuilder MessageText(string messageText)
	{
		message.FullMessage = messageText;
		return this;
	}

	public SendMessageBuilder MessageAuthor(IUser messageAuthor)
	{
		if (messageAuthor != null)
		{
			message.CreationAuthor = messageAuthor;
		}
		return this;
	}

	public SendMessageBuilder Attachments(params IAttachment[] attachment)
	{
		if (attachment == null)
		{
			return this;
		}
		return Attachments(attachment.AsEnumerable());
	}

	public SendMessageBuilder Attachments(IEnumerable<IAttachment> attachments)
	{
		if (attachments != null)
		{
			foreach (IAttachment attachment in attachments)
			{
				message.Attachments.Add(attachment);
			}
			return this;
		}
		return this;
	}

	public SendMessageBuilder Attachments(params BinaryFile[] file)
	{
		if (file == null)
		{
			return this;
		}
		return Attachments(file.AsEnumerable());
	}

	public SendMessageBuilder Attachments(IEnumerable<BinaryFile> files)
	{
		if (files != null)
		{
			foreach (BinaryFile file in files)
			{
				message.Attachments.Add(AttachmentManager.Instance.Create(file, currentUser));
			}
			return this;
		}
		return this;
	}

	public SendMessageBuilder Channels(params IInformationChannel[] channel)
	{
		if (channel == null)
		{
			return this;
		}
		return Channels(channel.AsEnumerable());
	}

	public SendMessageBuilder Channels(IEnumerable<IInformationChannel> channels)
	{
		if (channels != null)
		{
			foreach (IInformationChannel channel in channels)
			{
				message.Channels.Add(channel);
			}
			return this;
		}
		return this;
	}

	public SendMessageBuilder DocumentAttachments(params IDocumentAttachment[] documentAttachment)
	{
		if (documentAttachment == null)
		{
			return this;
		}
		return DocumentAttachments(documentAttachment.AsEnumerable());
	}

	public SendMessageBuilder DocumentAttachments(IEnumerable<IDocumentAttachment> documentAttachments)
	{
		if (documentAttachments != null)
		{
			foreach (IDocumentAttachment documentAttachment in documentAttachments)
			{
				((IChannelMessageDocumentsExtension)message).DocumentAttachments.Add(documentAttachment);
			}
			return this;
		}
		return this;
	}

	public SendMessageBuilder DocumentAttachments(params IDocument[] document)
	{
		if (document == null)
		{
			return this;
		}
		return DocumentAttachments(document.AsEnumerable());
	}

	public SendMessageBuilder DocumentAttachments(IEnumerable<IDocument> documents)
	{
		if (documents != null)
		{
			foreach (IDocument document in documents)
			{
				((IChannelMessageDocumentsExtension)message).DocumentAttachments.Add(DocumentAttachmentManager.Instance.Create(document, currentUser));
			}
			return this;
		}
		return this;
	}

	public SendMessageBuilder Recipients(params IUser[] user)
	{
		if (user != null && user.Any())
		{
			((ISet<IUser>)message.Recipients).AddAll(user.Where((IUser u) => u != null));
		}
		return this;
	}

	public SendMessageBuilder Recipients(params IUserGroup[] userGroup)
	{
		List<IUser> list = new List<IUser>();
		if (userGroup != null && userGroup.Any())
		{
			foreach (IUserGroup userGroup2 in userGroup)
			{
				list.AddRange((IEnumerable<IUser>)userGroup2.Users);
			}
		}
		return Recipients(list.ToArray());
	}

	public SendMessageBuilder Recipients(params IOrganizationItem[] orgItem)
	{
		List<IUser> list = new List<IUser>();
		if (orgItem != null && orgItem.Any())
		{
			foreach (IOrganizationItem orgItem2 in orgItem)
			{
				list.AddRange(UserManager.Instance.GetUsersByDepartament(orgItem2));
			}
		}
		return Recipients(list.ToArray());
	}

	public void SendMessage()
	{
		if (!((IEnumerable<IUser>)message.Recipients).Any())
		{
			throw new Exception(SR.T("Получатели не заполнены"));
		}
		message.Save();
	}
}
