using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Managers;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;

namespace EleWise.ELMA.Messages.Managers;

public class MessageQueueChannelItemManager : EntityManager<IMessageQueueChannelItem, long>, IMessageQueueChannelItemManager, IEntityManager<IMessageQueueChannelItem, long>, IEntityManager<IMessageQueueChannelItem>, IEntityManager
{
	private ICriteria CreateGetItemsCriteria(IReadOnlyCollection<IMessageChannel> channels)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.In("ChannelUid", (ICollection)channels.Select((IMessageChannel channel) => channel.Uid).ToArray()), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("NextSendDate"), (ICriterion)(object)Restrictions.Lt("NextSendDate", (object)DateTime.Now))));
		if (channels != null)
		{
			int num = 0;
			IProjection val2 = null;
			int count = channels.Count;
			IType val3 = TypeFactory.Basic("Int32");
			foreach (IMessageChannel channel in channels)
			{
				IProjection val4 = val2 ?? Projections.Cast(val3, Projections.Constant((object)count));
				val2 = Projections.Conditional((ICriterion)(object)Restrictions.Eq("ChannelUid", (object)channel.Uid), Projections.Cast(val3, Projections.Constant((object)num)), val4);
				num++;
			}
			if (val2 != null)
			{
				val.AddOrder(Order.Asc(val2));
			}
		}
		return val.AddOrder(Order.Asc("Attempt")).AddOrder(Order.Asc("NextSendDate"));
	}

	IReadOnlyCollection<(long messageQueueItemId, long messageQueueChannelItemId, Guid messageChannelUid)> IMessageQueueChannelItemManager.FindIdsAndChannelToSend(int maxCount, IReadOnlyCollection<IMessageChannel> channels)
	{
		return (IReadOnlyCollection<(long messageQueueItemId, long messageQueueChannelItemId, Guid messageChannelUid)>)(object)(from arr in CreateGetItemsCriteria(channels.ToReadOnlyCollection()).SetMaxResults(maxCount).SetProjection((IProjection[])(object)new IProjection[3]
			{
				(IProjection)Projections.Property("Item"),
				(IProjection)Projections.Property("Id"),
				(IProjection)Projections.Property("ChannelUid")
			}).List<object[]>()
			select (((IMessageQueueItem)arr[0]).Id, (long)arr[1], (Guid)arr[2])).ToArray();
	}
}
