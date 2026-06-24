using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Messages.Web.Extensions;

[Component(Order = 9999999)]
public class ArchiveInformationChannelGroup : IInformationChannelGroup
{
	public Guid Uid => MessagesConstants.ArchiveInformationChannelGroup;

	public string Name => SR.T("Архив");

	public string FullName => SR.T("Архив");

	public string IdItem => "information_channels_archive_tree_node";

	public string ImageUrl => "#channel.svg";

	public string BigImageUrl => "#channel.svg";

	public bool Expanded => false;

	public int Order => 9999999;

	public string Description => SR.T("Управление архивными информационными каналами");

	public string GetUrl(HtmlHelper html)
	{
		return html.Url().Action("Channels", "ChannelMessage", (object)new
		{
			area = "EleWise.ELMA.Messages.Web",
			groupId = Uid
		});
	}
}
