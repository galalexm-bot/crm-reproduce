using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Messages.Web.Components;

public class FeedRenderService
{
	private readonly Dictionary<Guid, IFeedObjectGroupExtension> extensions = new Dictionary<Guid, IFeedObjectGroupExtension>();

	private readonly Dictionary<Pair<Guid, Guid>, IFeedCommentActionRenderExtension> actionExtensions = new Dictionary<Pair<Guid, Guid>, IFeedCommentActionRenderExtension>();

	public IFeedObjectGroupExtension GetExtension(Guid objectTypeUid)
	{
		if (extensions.Keys.Contains(objectTypeUid))
		{
			return extensions[objectTypeUid];
		}
		IFeedObjectGroupExtension feedObjectGroupExtension = ComponentManager.Current.GetExtensionPoints<IFeedObjectGroupExtension>().FirstOrDefault((IFeedObjectGroupExtension e) => e.IsSupport(objectTypeUid));
		extensions.Add(objectTypeUid, feedObjectGroupExtension);
		return feedObjectGroupExtension;
	}

	public IFeedCommentActionRenderExtension GetActionExtension(Guid actionUid, Guid objectTypeUid)
	{
		Pair<Guid, Guid> key = new Pair<Guid, Guid>(actionUid, objectTypeUid);
		IFeedCommentActionRenderExtension feedCommentActionRenderExtension;
		if (actionExtensions.ContainsKey(key))
		{
			feedCommentActionRenderExtension = actionExtensions[key];
		}
		else
		{
			feedCommentActionRenderExtension = ComponentManager.Current.GetExtensionPoints<IFeedCommentActionRenderExtension>().FirstOrDefault((IFeedCommentActionRenderExtension e) => e.IsSupport(objectTypeUid, actionUid));
			actionExtensions.Add(key, feedCommentActionRenderExtension);
		}
		return feedCommentActionRenderExtension;
	}

	public Dictionary<MessageAttachment, object> GetAttachments(List<FeedModel> messages)
	{
		MessageAttachment[] messageAttachments = messages.SelectMany(delegate(FeedModel m)
		{
			List<MessageAttachment> list = m.MessageAttachments.ToList();
			list.AddRange(m.Messages.SelectMany((FeedModel c) => c.MessageAttachments));
			return list;
		}).ToArray();
		return GetAttachments(messageAttachments);
	}

	public Dictionary<MessageAttachment, object> GetAttachments(MessageAttachment[] messageAttachments)
	{
		Dictionary<Guid, List<MessageAttachment>> dictionary = (from m in messageAttachments
			group m by m.TypeUid).ToDictionary((IGrouping<Guid, MessageAttachment> m) => m.Key, (IGrouping<Guid, MessageAttachment> m) => m.ToList());
		Dictionary<MessageAttachment, object> dictionary2 = new Dictionary<MessageAttachment, object>();
		foreach (Guid typeUid in dictionary.Keys)
		{
			IFeedAttachmentsRenderExtension feedAttachmentsRenderExtension = ComponentManager.Current.GetExtensionPoints<IFeedAttachmentsRenderExtension>().FirstOrDefault((IFeedAttachmentsRenderExtension e) => e.TypeUid == typeUid);
			if (feedAttachmentsRenderExtension == null)
			{
				continue;
			}
			Dictionary<MessageAttachment, object> attachments = feedAttachmentsRenderExtension.GetAttachments(dictionary[typeUid].Distinct().ToList());
			foreach (MessageAttachment key in attachments.Keys)
			{
				dictionary2.Add(key, attachments[key]);
			}
		}
		return dictionary2;
	}

	public Dictionary<MessageObject, object> GetMessageObjects(List<FeedModel> messages)
	{
		Dictionary<Guid, List<MessageObject>> dictionary = (from m in messages.SelectMany(delegate(FeedModel m)
			{
				List<MessageObject> list = m.MessageObjects.ToList();
				list.AddRange(m.Messages.SelectMany((FeedModel c) => c.MessageObjects));
				return list;
			})
			group m by m.TypeUid).ToDictionary((IGrouping<Guid, MessageObject> m) => m.Key, (IGrouping<Guid, MessageObject> m) => m.ToList());
		Dictionary<MessageObject, object> dictionary2 = new Dictionary<MessageObject, object>();
		foreach (Guid typeUid in dictionary.Keys)
		{
			IFeedMessageObjectsExtension feedMessageObjectsExtension = ComponentManager.Current.GetExtensionPoints<IFeedMessageObjectsExtension>().FirstOrDefault((IFeedMessageObjectsExtension e) => e.IsSupport(typeUid));
			if (feedMessageObjectsExtension == null)
			{
				continue;
			}
			Dictionary<MessageObject, object> messageObjects = feedMessageObjectsExtension.GetMessageObjects(dictionary[typeUid].Distinct().ToList());
			foreach (MessageObject key in messageObjects.Keys)
			{
				dictionary2.Add(key, messageObjects[key]);
			}
		}
		return dictionary2;
	}

	public MvcHtmlString Attachment(HtmlHelper html, MessageAttachment messageAttachment, object attachment)
	{
		IFeedAttachmentsRenderExtension feedAttachmentsRenderExtension = ComponentManager.Current.GetExtensionPoints<IFeedAttachmentsRenderExtension>().FirstOrDefault((IFeedAttachmentsRenderExtension e) => e.TypeUid == messageAttachment.TypeUid);
		if (feedAttachmentsRenderExtension == null)
		{
			return MvcHtmlString.Empty;
		}
		return feedAttachmentsRenderExtension.Attachement(html, messageAttachment, attachment);
	}

	public MvcHtmlString MessageObjectsTitle(HtmlHelper html, FeedModel message, MessageObject messageObject)
	{
		return MessageObjectsTitle(html, message.ParentObjectUid.Value, messageObject);
	}

	public MvcHtmlString MessageObjectsTitle(HtmlHelper html, Guid parentObjectUid, MessageObject messageObject)
	{
		IFeedMessageObjectsRenderExtension feedMessageObjectsRenderExtension = ComponentManager.Current.GetExtensionPoints<IFeedMessageObjectsRenderExtension>().FirstOrDefault((IFeedMessageObjectsRenderExtension e) => e.IsSupport(parentObjectUid, messageObject));
		if (feedMessageObjectsRenderExtension == null)
		{
			return MvcHtmlString.Empty;
		}
		return MvcHtmlString.Create(feedMessageObjectsRenderExtension.Name(parentObjectUid, messageObject));
	}

	public MvcHtmlString MessageObjects(HtmlHelper html, FeedModel message, MessageObject messageObject, object objectModel)
	{
		return MessageObjects(html, message.ParentObjectUid.Value, messageObject, objectModel);
	}

	public MvcHtmlString MessageObjects(HtmlHelper html, Guid parentObjectUid, MessageObject messageObject, object objectModel)
	{
		IFeedMessageObjectsRenderExtension feedMessageObjectsRenderExtension = ComponentManager.Current.GetExtensionPoints<IFeedMessageObjectsRenderExtension>().FirstOrDefault((IFeedMessageObjectsRenderExtension e) => e.IsSupport(parentObjectUid, messageObject));
		if (feedMessageObjectsRenderExtension == null)
		{
			return MvcHtmlString.Empty;
		}
		return feedMessageObjectsRenderExtension.MessageObject(html, messageObject, objectModel);
	}

	public static string FormatTextToHtml(string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return text;
		}
		text = FormatTextTagBracket(text.Trim("\r\n\t".ToCharArray()));
		string text2 = string.Format("{0}*{1}", "[-\\w+&@#/%?=~_|!:,.;()]", "[\\w+&@#/%=~_|]");
		text = Regex.Replace(text, "\\b(https?|ftp|file)://" + text2, (Match match) => string.Format("<a href='{0}'>{0}</a>", match.Value), RegexOptions.IgnoreCase);
		return text;
	}

	private static string FormatTextTagBracket(string text)
	{
		return text.Replace("<", "&lt;").Replace(">", "&gt;").Nl2Br();
	}
}
