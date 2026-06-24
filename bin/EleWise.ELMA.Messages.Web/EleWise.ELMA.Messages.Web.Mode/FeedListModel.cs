using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Messages.Web.Models;

public class FeedListModel
{
	private Dictionary<MessageAttachment, object> feedAttachments;

	private Dictionary<MessageObject, object> feedMessageObjects;

	private Dictionary<Pair<Guid, long>, string> favoriteList;

	public int MaxDaysAutoLoading { get; set; }

	public FeedPriority CurrentPriority { get; set; }

	public List<FeedModel> Messages { get; set; }

	public string ChangeDateHashLast { get; set; }

	public bool OnlyUnread { get; set; }

	public bool IsAjax { get; set; }

	public bool IsSearch { get; set; }

	public bool IsPortlet { get; set; }

	public List<CanCreateCommentItem> CanCreateCommentList { get; set; }

	public List<CanCreateQuestionItem> CanCreateQuestionList { get; set; }

	public bool PriorityEnabled { get; set; }

	public bool Favorites { get; set; }

	public FeedCounter[] UnreadCounter => FeedManager.Instance.GetUnreadCount();

	public FeedFilter Filter { get; set; }

	public List<FeedMessageInfoModel> FeedMessageInfoAllMessages { get; set; }

	public FeedListModel()
	{
		Messages = new List<FeedModel>();
		Filter = new FeedFilter();
	}

	public Dictionary<MessageAttachment, object> FeedAttachments()
	{
		if (feedAttachments != null && feedAttachments.Any())
		{
			return feedAttachments;
		}
		FeedRenderService feedRenderService = new FeedRenderService();
		feedAttachments = feedRenderService.GetAttachments(Messages);
		return feedAttachments;
	}

	public Dictionary<MessageObject, object> FeedMessageObjects()
	{
		if (feedMessageObjects != null && feedMessageObjects.Any())
		{
			return feedMessageObjects;
		}
		FeedRenderService feedRenderService = new FeedRenderService();
		feedMessageObjects = feedRenderService.GetMessageObjects(Messages);
		return feedMessageObjects;
	}

	public Dictionary<Pair<Guid, long>, string> FavoriteList()
	{
		if (favoriteList != null)
		{
			return favoriteList;
		}
		favoriteList = FeedManager.Instance.FavoriteHashList(Messages.Select((FeedModel m) => new Pair<Guid, long>(m.ActionObjectUid, m.ActionObjectId)).ToList());
		return favoriteList;
	}

	public string FavoriteHash(FeedModel message)
	{
		return FavoriteList()[new Pair<Guid, long>(message.ActionObjectUid, message.ActionObjectId)];
	}
}
