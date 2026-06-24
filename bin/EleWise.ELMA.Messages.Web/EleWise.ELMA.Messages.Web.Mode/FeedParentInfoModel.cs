using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class FeedParentInfoModel
{
	private IFeedMessageRenderExtension actionExtension;

	public FeedMessageRecipientList ObjectRecipients { get; set; }

	public string ObjectTypeTitleText { get; set; }

	public IUser CreationAuthor { get; set; }

	public FeedModel Message { get; set; }

	public List<FeedMessageInfoModel> FeedMessageInfo { get; set; }

	public string CreationDate { get; set; }

	public string ChangeDate { get; set; }

	public IFeedMessageRenderExtension ActionExtension()
	{
		if (actionExtension == null && Message != null && FeedMessageInfo != null)
		{
			FeedRenderService feedRenderService = new FeedRenderService();
			actionExtension = feedRenderService.GetActionExtension(Message.ActionUid, Message.ActionObjectUid) as IFeedMessageRenderExtension;
		}
		return actionExtension;
	}

	public MvcHtmlString ParentAddInfo(HtmlHelper html)
	{
		IFeedMessageRenderExtension feedMessageRenderExtension = ActionExtension();
		if (feedMessageRenderExtension == null)
		{
			return MvcHtmlString.Empty;
		}
		List<WebData> source = FeedMessageInfo.Where(delegate(FeedMessageInfoModel o)
		{
			Guid actionObjectUid = o.ActionObjectUid;
			Guid? parentObjectUid = Message.ParentObjectUid;
			return actionObjectUid == parentObjectUid && o.ActionObjectId == Message.ParentObjectId;
		}).SelectMany((FeedMessageInfoModel o) => o.Data.Where((WebData d) => d != null)).ToList();
		return feedMessageRenderExtension.ParentAddInfo(html, Message, source.Select((WebData m) => new Pair<string, List<WebDataItem>>(m.Value, m.Items.ToList())).ToList());
	}
}
