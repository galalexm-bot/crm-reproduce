using System;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[Component]
internal sealed class MessageHistoryIdentifier : IHistoryIdentifierExtensionPoint
{
	private static readonly Guid MessageTypeUid = InterfaceActivator.UID<IChannelMessage>();

	public bool Check(IHistoryIdParams parameters)
	{
		return parameters.TypeUid == MessageTypeUid;
	}

	public string GetKey(IHistoryIdParams parameters)
	{
		return "ChannelMessageInfoHistory" + parameters.Id;
	}
}
