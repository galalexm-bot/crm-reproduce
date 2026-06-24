using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.Messages.Web.Extensions;

public static class UrlExtensions
{
	public static string InformationChannel(this UrlHelper url, long channelId)
	{
		return url.Action("List", "BaseMessage", new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.Messages.Web" },
			{ "BaseMessageFilter.ChannelMessages", true },
			{ "BaseMessageFilter.ChannelId", channelId }
		});
	}
}
