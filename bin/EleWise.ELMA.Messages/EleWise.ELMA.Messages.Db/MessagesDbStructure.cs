using System;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Db;

public class MessagesDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(SecurityDbStructure) };

	public void CreateFeedTable()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (!serviceNotNull.TableExists("Feed"))
		{
			Table table = FeedManager.Instance.CreateFeedTable("Feed");
			serviceNotNull.AddTableSequence(table.Name);
		}
	}

	public void CreateFeedArchiveTable()
	{
		if (!Locator.GetServiceNotNull<ITransformationProvider>().TableExists("FeedArchive"))
		{
			FeedManager.Instance.CreateFeedTable("FeedArchive");
		}
	}

	public void CreateFavoriteTable()
	{
		if (!Locator.GetServiceNotNull<ITransformationProvider>().TableExists("FeedFavorite"))
		{
			FeedManager.Instance.CreateFavoriteTable();
		}
	}

	public void CreateDataInfoTable()
	{
		if (!Locator.GetServiceNotNull<ITransformationProvider>().TableExists("FeedInfo"))
		{
			FeedManager.Instance.CreateInfoTable();
		}
	}

	[Obsolete("Метод устарел. Индексы создаются в xml структурах в тегах index.", true)]
	public void CreateFeedIndexes()
	{
	}
}
