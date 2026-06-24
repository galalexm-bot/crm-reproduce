using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Extensions;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Messages.Web.Components;

[Component]
public class MessagesSwitcher : IActionItemProvider
{
	public const string Uid = "toolbar-feed-extension";

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		object model = htmlHelper.get_ViewData().get_Model();
		FeedListModel feedListModel = model as FeedListModel;
		MessageList messageList = model as MessageList;
		InformationChannelList informationChannelList = model as InformationChannelList;
		bool flag = messageList != null;
		bool flag2 = feedListModel != null;
		bool flag3 = informationChannelList != null;
		if (!flag2 && !flag && !flag3)
		{
			return Enumerable.Empty<IActionItem>();
		}
		ActionButton actionButton = new ActionButton("messages-switcher");
		actionButton.AsSwitcher = true;
		bool flag4 = !flag && flag2 && feedListModel.Favorites;
		bool flag5 = !flag && flag2 && !feedListModel.Favorites && !feedListModel.OnlyUnread;
		if (UnreadButtonIsAvailable())
		{
			actionButton.Items.Add(new ActionButton
			{
				Uid = "Feed-Unread",
				Text = SR.T("Непрочитанные"),
				Url = htmlHelper.Url().Action("List", "Feed", (object)new
				{
					area = "EleWise.ELMA.Messages.Web"
				}),
				IsChecked = (!flag && !flag4 && !flag5 && !flag3)
			});
		}
		actionButton.Items.Add(new ActionButton
		{
			Uid = "Feed-All",
			Text = SR.T("Все сообщения"),
			Url = htmlHelper.Url().Action("List", "Feed", (object)new
			{
				area = "EleWise.ELMA.Messages.Web",
				OnlyUnread = false
			}),
			IsChecked = (!flag && flag2 && !feedListModel.Favorites && !feedListModel.OnlyUnread)
		});
		actionButton.Items.Add(new ActionButton
		{
			Uid = "BaseMessage-Sended",
			Text = SR.T("Отправленные"),
			Url = htmlHelper.Url().Action("List", "BaseMessage", new RouteValueDictionary
			{
				{ "area", "EleWise.ELMA.Messages.Web" },
				{ "BaseMessageFilter.Sended", true }
			}),
			IsChecked = (flag && !messageList.BaseMessageFilter.ChannelId.HasValue)
		});
		actionButton.Items.Add(new ActionButton
		{
			Uid = "Feed-Favorite",
			Text = SR.T("Избранное"),
			Url = htmlHelper.Url().Action("List", "Feed", (object)new
			{
				area = "EleWise.ELMA.Messages.Web",
				favorites = true
			}),
			IsChecked = flag4
		});
		if (flag3)
		{
			actionButton.Items.Add(ChannelGroup(informationChannelList, !flag && !flag2, htmlHelper));
		}
		else if (flag)
		{
			long? channelId = messageList.BaseMessageFilter.ChannelId;
			if (channelId.HasValue)
			{
				actionButton.Items.Add(Channel(channelId.Value, isChecked: true, htmlHelper));
			}
		}
		return new IActionItem[1] { actionButton };
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || !(rootItem.Uid == "toolbar-feed-extension"))
		{
			return;
		}
		foreach (IActionItem item in GetItems(rootItem, htmlHelper))
		{
			rootItem.Items.Add(item);
		}
	}

	private bool UnreadButtonIsAvailable()
	{
		return FeedManager.Instance.GetUnreadCount()?.Any((FeedCounter a) => a.Count > 0) ?? false;
	}

	private ActionButton Channel(long channelId, bool isChecked, HtmlHelper htmlHelper)
	{
		return new ActionButton
		{
			Uid = $"channel_{channelId}",
			Text = htmlHelper.HeaderByRoute(),
			Url = htmlHelper.Url().InformationChannel(channelId),
			IsChecked = isChecked
		};
	}

	private ActionButton ChannelGroup(InformationChannelList model, bool isChecked, HtmlHelper htmlHelper)
	{
		return new ActionButton
		{
			Uid = model.GroupId.ToString(),
			Text = model.GroupName,
			Url = htmlHelper.Url().Action("Channels", "ChannelMessage", (object)new
			{
				area = "EleWise.ELMA.Messages.Web",
				groupId = model.GroupId
			}),
			IsChecked = isChecked
		};
	}
}
