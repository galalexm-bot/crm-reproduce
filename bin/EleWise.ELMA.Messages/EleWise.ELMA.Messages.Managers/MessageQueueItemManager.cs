using System;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using NHibernate;

namespace EleWise.ELMA.Messages.Managers;

public class MessageQueueItemManager : EntityManager<IMessageQueueItem, long>, IMessageQueueItemManager, IEntityManager<IMessageQueueItem, long>, IEntityManager<IMessageQueueItem>, IEntityManager
{
	private readonly string F_MessageQueueChannelItem_Item = LinqUtils.NameOf((Expression<Func<IMessageQueueChannelItem, object>>)((IMessageQueueChannelItem p) => p.Item));

	private readonly string F_MessageQueueItem_Id = LinqUtils.NameOf((Expression<Func<IMessageQueueItem, object>>)((IMessageQueueItem p) => p.Id));

	public ITransformationProvider TransformationProvider { get; set; }

	public void DeleteProcessedQueueItems()
	{
		string text = TransformationProvider.Dialect.QuoteIfNeeded("MessageQueueItem");
		string text2 = TransformationProvider.Dialect.QuoteIfNeeded("MessageQueueChannelItem");
		((IQuery)base.Session.CreateSQLQuery("delete from " + text + " where not exists (select * from " + text2 + " where " + F_MessageQueueChannelItem_Item + " = " + text + "." + TransformationProvider.Dialect.QuoteIfNeeded(F_MessageQueueItem_Id) + ")")).ExecuteUpdate();
	}
}
