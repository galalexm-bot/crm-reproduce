using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Components;

[Component]
internal class MessagesModelHistoryFilter : EntityModelHistoryEventsFilterBase
{
	protected override Type[] ExcludeTypes => new Type[2]
	{
		typeof(IMessageQueueItem),
		typeof(IMessageQueueChannelItem)
	};
}
