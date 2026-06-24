using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;

namespace EleWise.ELMA.Messages.Web.Extensions;

public static class ToolbarExtensions
{
	public const string BackToToolbarGroupUid = "channel_back_to_toolbargroup";

	[NotNull]
	public static ToolbarGroupBuilder ChannelMessageBackTo([NotNull] this ToolbarBuilder builder, long? channelId)
	{
		return builder.Group("channel_back_to_toolbargroup").ChannelMessageBackTo(channelId);
	}

	[NotNull]
	public static ToolbarGroupBuilder ChannelMessageBackTo([NotNull] this ToolbarGroupBuilder builder, long? channelId)
	{
		if (!channelId.HasValue)
		{
			return builder;
		}
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return BackToExt(InformationChannelManager.Instance.LoadOrNull(channelId.Value), builder);
	}

	public static ToolbarGroupBuilder ChannelMessageBackTo(this ToolbarBuilder builder, List<IInformationChannel> channels)
	{
		return builder.Group("channel_back_to_toolbargroup").ChannelMessageBackTo(channels);
	}

	public static ToolbarGroupBuilder ChannelMessageBackTo(this ToolbarGroupBuilder builder, List<IInformationChannel> channels)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return BackToExt(channels, builder);
	}

	private static ToolbarGroupBuilder BackToExt(IInformationChannel channel, ToolbarGroupBuilder b)
	{
		return BackToExt(new List<IInformationChannel> { channel }, b);
	}

	private static ToolbarGroupBuilder BackToExt(List<IInformationChannel> channels, ToolbarGroupBuilder b)
	{
		if (channels == null || !channels.Any())
		{
			return b;
		}
		List<IChannelMesagesToolbarExtension> list = ComponentManager.Current.GetExtensionPoints<IChannelMesagesToolbarExtension>().ToList();
		if (list.Any())
		{
			foreach (IChannelMesagesToolbarExtension item in list)
			{
				item.BackToExt(channels, b);
			}
			return b;
		}
		return b;
	}
}
