using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component(Order = 500)]
public class ChannelMessagesFeedObjectGroupExtension : DefaultFeedObjectGroupExtension
{
	public override string MessageTypeCssClass => "FeedTypeChannelMessage";

	public override bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IChannelMessage>(objectTypeUid);
	}

	public override string MessageTypeName(Guid objectTypeUid)
	{
		return SR.T("Сообщение");
	}
}
