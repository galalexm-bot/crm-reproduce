using System;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.API.Extensions;
using EleWise.ELMA.Messages.API.Feed.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Messages.API.Components;

[Component]
internal class AttachmentChannelMessageHandler : IChannelMessageHandler
{
	private readonly Guid binaryFileUid = new Guid("692F9F96-DD18-4477-A632-E145C53291E5");

	public Guid TypeUid => binaryFileUid;

	public void Handle(IChannelMessage channelMessage, MessageAttachmentInfo[] attachments)
	{
		if (channelMessage == null || attachments == null || !attachments.Any())
		{
			return;
		}
		foreach (string item in from a in attachments
			where a.TypeUid == TypeUid
			select a.ObjectId)
		{
			if (Guid.TryParse(item, out var result))
			{
				IAttachment attachment = InterfaceActivator.Create<IAttachment>();
				attachment.File = BinaryFileDescriptor.Download(result);
				channelMessage.Attachments.Add(attachment);
			}
		}
	}
}
