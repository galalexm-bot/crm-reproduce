using System.Globalization;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.Messages.Web.Menu;

[Component]
public class MessagesMenuItemCountEvaluator : IMenuItemCountEvaluator
{
	public bool HasCountEvaluator(MenuItemNode item)
	{
		return item.Code == "messages";
	}

	public bool NeedUpdate(MenuItemNode item)
	{
		return true;
	}

	public MenuItemCount Evaluate(MenuItemNode item)
	{
		return Evaluate(useClientUpdateFunction: true);
	}

	public static MenuItemCount Evaluate(bool useClientUpdateFunction)
	{
		FeedCounter[] unreadCount = FeedManager.Instance.GetUnreadCount();
		long count = unreadCount.FirstOrDefault((FeedCounter m) => m.WithPriority).Count;
		long count2 = unreadCount.FirstOrDefault((FeedCounter m) => !m.WithPriority).Count;
		bool flag = count > 0;
		long num = ((count > 0) ? count : count2);
		return new MenuItemCount
		{
			Count = ((num > 0) ? num.ToString(CultureInfo.InvariantCulture) : null),
			CssClass = (flag ? "important " : "") + "messages-counter",
			ClientUpdateFunction = (useClientUpdateFunction ? "elma.messagesCountUpdated" : null)
		};
	}

	public static MenuItemCount GetCountRed()
	{
		long count = FeedManager.Instance.GetUnreadCount().FirstOrDefault((FeedCounter m) => m.WithPriority).Count;
		return new MenuItemCount
		{
			Count = ((count > 0) ? count.ToString(CultureInfo.InvariantCulture) : null),
			ClientUpdateFunction = "messagesCountRedUpdatedInFeed"
		};
	}

	public static MenuItemCount GetCountBlue()
	{
		FeedCounter[] unreadCount = FeedManager.Instance.GetUnreadCount();
		long num = unreadCount.FirstOrDefault((FeedCounter m) => !m.WithPriority).Count - unreadCount.FirstOrDefault((FeedCounter m) => m.WithPriority).Count;
		return new MenuItemCount
		{
			Count = ((num > 0) ? num.ToString(CultureInfo.InvariantCulture) : null),
			ClientUpdateFunction = "messagesCountBlueUpdatedInFeed"
		};
	}
}
