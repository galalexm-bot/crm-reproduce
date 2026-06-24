using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[Component]
public abstract class FeedCommentExtensionBase : IFeedCommentExtension
{
	private Guid attachmentUid = InterfaceActivator.UID<IAttachment>();

	private Guid binaryFileUid = new Guid("692F9F96-DD18-4477-A632-E145C53291E5");

	public abstract bool CommentIsSupported(Guid objectUid);

	public abstract bool IsCommentAction(Guid objectUid, Guid actionUid);

	public abstract void CanCreateComment(Guid objectUid, Dictionary<long, bool> items);

	public virtual bool CanAddCommentAttachment(Guid objectUid)
	{
		return false;
	}

	public virtual void CanCreateComment(List<CanCreateCommentItemMessage> objects)
	{
		CanCreateCommentItemMessage[] source = objects.Where((CanCreateCommentItemMessage o) => CommentIsSupported(o.Message.ParentObjectUid.Value)).ToArray();
		foreach (Guid uid in source.Select((CanCreateCommentItemMessage o) => o.Message.ParentObjectUid.Value).Distinct())
		{
			Dictionary<long, bool> dict = (from o in source.Where((CanCreateCommentItemMessage o) => o.Message.ParentObjectUid.Value == uid).Distinct()
				select o.Message.ParentObjectId.Value).Distinct().ToDictionary((long id) => id, (long v) => false);
			CanCreateComment(uid, dict);
			source.Where((CanCreateCommentItemMessage o) => dict.ContainsKey(o.Message.ParentObjectId.Value) && dict[o.Message.ParentObjectId.Value]).ForEach(delegate(CanCreateCommentItemMessage ob)
			{
				ob.CanCreateComment = true;
				ob.CanAddCommentAttachment = CanAddCommentAttachment(ob.Message.ParentObjectUid.Value);
			});
		}
	}

	protected virtual List<IAttachment> ConvertAttachments(MessageAttachment[] messageAttachments)
	{
		List<IAttachment> list = new List<IAttachment>();
		if (messageAttachments != null && messageAttachments.Any())
		{
			for (int i = 0; i < messageAttachments.Length; i++)
			{
				MessageAttachment messageAttachment = messageAttachments[i];
				if (messageAttachment.TypeUid == binaryFileUid && Guid.TryParse(messageAttachment.Id, out var result))
				{
					IAttachment attachment = GetAttachment(result);
					if (attachment != null && attachment.File != null)
					{
						list.Add(attachment);
					}
				}
			}
		}
		return list;
	}

	private IAttachment GetAttachment(Guid fileUid)
	{
		IAttachment attachment = InterfaceActivator.Create<IAttachment>();
		attachment.File = BinaryFileDescriptor.Download(fileUid);
		attachment.CreationAuthor = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		attachment.CreationDate = DateTime.Now;
		return attachment;
	}

	public abstract Guid CreateComment(Guid objectUid, long objectId, string text, MessageAttachment[] messageAttachments);
}
