using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Messages.Managers;

internal interface IMessageQueueChannelItemManager : IEntityManager<IMessageQueueChannelItem, long>, IEntityManager<IMessageQueueChannelItem>, IEntityManager
{
	IReadOnlyCollection<(long messageQueueItemId, long messageQueueChannelItemId, Guid messageChannelUid)> FindIdsAndChannelToSend(int maxCount, IReadOnlyCollection<IMessageChannel> channels);
}
