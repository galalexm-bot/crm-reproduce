using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Messages.Audit;

[Component(Order = 1000000)]
internal sealed class MessageEventActionEventAggregator : IEntityActionEventAggregator
{
	private readonly Guid channelMessageUid = InterfaceActivator.UID<IChannelMessage>();

	private readonly Guid entityModelHistoryUid = InterfaceActivator.UID<IEntityModelHistory>();

	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		ActionEventAggregatorResult actionEventAggregatorResult = previousResults.FirstOrDefault((ActionEventAggregatorResult e) => e.EventArgs.Action != null && e.EventArgs.Object != null && e.EventArgs.Action.Uid == ChannelMessageActions.CreateTestMessageGuid && e.EventArgs.New != null && e.EventArgs.New is IEntity<long> && e.EventArgs.Object.Uid == channelMessageUid);
		if (actionEventAggregatorResult != null)
		{
			long num = (long)actionEventAggregatorResult.EventArgs.New.GetId();
			foreach (ActionEventAggregatorResult previousResult in previousResults)
			{
				if (actionEventAggregatorResult != previousResult && previousResult.EventArgs.Action != null && (!(previousResult.EventArgs.Action.Uid != DefaultEntityActions.CreateGuid) || !(previousResult.EventArgs.Action.Uid != ChannelMessageActions.CreateTestMessageGuid)) && previousResult.EventArgs.Object != null && (!(previousResult.EventArgs.Object.Uid != channelMessageUid) || !(previousResult.EventArgs.Object.Uid != entityModelHistoryUid)) && previousResult.EventArgs.New != null && previousResult.EventArgs.New is IEntity<long> && ((previousResult.EventArgs.Object.Uid == channelMessageUid && (long)previousResult.EventArgs.New.GetId() == num) || (previousResult.EventArgs.Object.Uid == entityModelHistoryUid && (previousResult.EventArgs.New as IEntityModelHistory).ObjectId == num)))
				{
					previousResult.Persist = false;
				}
			}
		}
		return Enumerable.Empty<ActionEventAggregatorResult>();
	}
}
