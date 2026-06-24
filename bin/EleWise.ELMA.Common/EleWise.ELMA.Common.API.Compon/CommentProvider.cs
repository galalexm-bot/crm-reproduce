using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.API.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.API.Components;

[Component(Order = int.MinValue)]
internal sealed class CommentProvider : ICommentProvider
{
	private readonly IAuthenticationService authenticationService;

	public CommentProvider(IAuthenticationService authenticationService)
	{
		this.authenticationService = authenticationService;
	}

	public void Process(ICommentActionModel commentActionModel, WebData parameters)
	{
		if (commentActionModel != null)
		{
			WebDataItem webDataItem = parameters.FindItem("Comment");
			if (webDataItem != null && webDataItem.Data != null)
			{
				WebDataItem attachItem = webDataItem.Data.FindItem("Attachments");
				commentActionModel.Attachments = GetAttachments(attachItem);
			}
			IComment comment = GetComment(webDataItem);
			if (comment != null)
			{
				commentActionModel.Comment = comment;
			}
		}
	}

	private IList<IAttachment> GetAttachments(WebDataItem attachItem)
	{
		List<IAttachment> list = new List<IAttachment>();
		if (attachItem == null || attachItem.DataArray == null)
		{
			return list;
		}
		list.AddRange(from a in attachItem.DataArray.Select(GetAttachment)
			where a != null
			select a);
		return list;
	}

	private IAttachment GetAttachment(WebData data)
	{
		IAttachment attachment = InterfaceActivator.Create<IAttachment>();
		string value = data.FindItem("Uid").Value;
		attachment.File = BinaryFileDescriptor.Download(Guid.Parse(value));
		attachment.CreationAuthor = authenticationService.GetCurrentUser<IUser>();
		attachment.CreationDate = DateTime.Now;
		return attachment;
	}

	private IComment GetComment(WebDataItem commentItem)
	{
		if (commentItem == null || commentItem.Data == null)
		{
			return null;
		}
		IComment comment = CommentManager.Instance.Create();
		comment.Text = commentItem.Data.FindItem("Text").Value;
		comment.CreationAuthor = authenticationService.GetCurrentUser<IUser>();
		comment.CreationDate = DateTime.Now;
		return comment;
	}
}
