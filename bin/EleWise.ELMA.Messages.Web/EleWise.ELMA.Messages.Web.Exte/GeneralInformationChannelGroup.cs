using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Messages.Web.Extensions;

[Component(Order = 1)]
public class GeneralInformationChannelGroup : IInformationChannelGroup
{
	public Guid Uid => Guid.Empty;

	public string Name => SR.T("Общие инф. каналы");

	public string FullName => SR.T("Общие информационные каналы");

	public string IdItem => "information_channels_tree_node";

	public string ImageUrl => "#channel.svg";

	public string BigImageUrl => "#channel.svg";

	public bool Expanded => true;

	public int Order => 0;

	public string Description => SR.T("Создание, редактирование общих информационных каналов. Настройка доступа к ним");

	public string GetUrl(HtmlHelper html)
	{
		return html.Url().Action("Channels", "ChannelMessage", (object)new
		{
			area = "EleWise.ELMA.Messages.Web",
			groupId = Uid
		});
	}
}
