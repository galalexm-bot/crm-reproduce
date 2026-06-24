using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Models;

public class InfoChannelMessageParent : InfoChannelMessageChild
{
	private bool isAssignMessage = true;

	private readonly Lazy<bool> anyAttachment;

	public bool IsAssignMessage
	{
		get
		{
			return isAssignMessage;
		}
		set
		{
			isAssignMessage = value;
		}
	}

	public new List<InfoChannelMessageChild> Messages { get; set; }

	public string PrefixId { get; set; }

	public bool IsFavorite { get; set; }

	public bool HasOldComments { get; set; }

	public bool HasAttachments => anyAttachment.Value;

	public InfoChannelMessageParent()
	{
		PrefixId = Guid.NewGuid().ToString();
		anyAttachment = new Lazy<bool>(() => base.Message != null && Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyAttachments(base.Message.TypeUid, base.Message));
	}

	public string MessagesIds()
	{
		string text = ((Messages == null || Messages.Count == 0) ? "" : string.Join(",", Messages.Select((InfoChannelMessageChild m) => m.Id.ToString(CultureInfo.InvariantCulture)).ToArray()));
		if (base.Id != 0L)
		{
			return base.Id.ToString(CultureInfo.InvariantCulture) + ((text == "") ? "" : ("," + text));
		}
		return text;
	}

	public static InfoChannelMessageParent CreateFromFeedMessage(InfoChannelMessageChild infoChannelMessageChild)
	{
		InfoChannelMessageParent infoChannelMessageParent = new InfoChannelMessageParent
		{
			AllowComment = infoChannelMessageChild.AllowComment,
			AllowDelete = infoChannelMessageChild.AllowDelete,
			AllowEdit = infoChannelMessageChild.AllowEdit,
			CommentModel = infoChannelMessageChild.CommentModel,
			CompactView = infoChannelMessageChild.CompactView,
			CreationAuthor = infoChannelMessageChild.CreationAuthor,
			CreationDate = infoChannelMessageChild.CreationDate,
			FullMessageHtml = infoChannelMessageChild.FullMessageHtml,
			FullMessageText = infoChannelMessageChild.FullMessageText,
			ShortMessageHtml = infoChannelMessageChild.ShortMessageHtml,
			ShortMessageText = infoChannelMessageChild.ShortMessageText,
			Id = infoChannelMessageChild.Id,
			Messages = infoChannelMessageChild.Messages,
			ObjectId = infoChannelMessageChild.ObjectId,
			Parent = infoChannelMessageChild.Parent,
			Subject = infoChannelMessageChild.Subject,
			URL = infoChannelMessageChild.URL,
			Recipients = infoChannelMessageChild.Recipients,
			Message = infoChannelMessageChild.Message,
			DiscussionObjects = infoChannelMessageChild.DiscussionObjects,
			DiscussionObjectsOriginal = infoChannelMessageChild.DiscussionObjectsOriginal
		};
		if (infoChannelMessageChild.Messages != null)
		{
			foreach (InfoChannelMessageChild message in infoChannelMessageChild.Messages)
			{
				message.Parent = infoChannelMessageParent;
			}
			return infoChannelMessageParent;
		}
		return infoChannelMessageParent;
	}
}
