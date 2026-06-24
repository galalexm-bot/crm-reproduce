using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.API.Feed.Models;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.API.Extensions;

[ExtensionPoint(ComponentType.All)]
internal interface IChannelMessageHandler
{
	Guid TypeUid { get; }

	void Handle(IChannelMessage channelMessage, MessageAttachmentInfo[] attachments);
}
