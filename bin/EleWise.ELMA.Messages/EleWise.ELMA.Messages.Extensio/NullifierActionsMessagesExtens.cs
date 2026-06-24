using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;

namespace EleWise.ELMA.Messages.Extensions;

[Component]
internal class NullifierActionsMessagesExtension : INullifierActions
{
	private const string FeedTypeUid = "6588BC0C-0FD7-4fe2-B265-7BAAE64EF430";

	private const string FeedFavoriteTypeUid = "57CE9ADA-AF12-45C1-9E3C-AF882F812F66";

	private const string FeedArchiveTypeUid = "37A4A060-25B8-4B3E-BE65-BC4A37A31765";

	private const string CommonInfoChannelsUid = "07A5BE31-C87E-4166-972F-FAEEB7530CF1";

	private const string ArchiveInfoChannelsUid = "AC8230F5-1422-43E3-933F-85D05CE1F87C";

	private readonly string InformationChannelTableName;

	public NullifierActionsMessagesExtension()
	{
		if (InterfaceActivator.LoadMetadata<IInformationChannel>() is EntityMetadata entityMetadata && !string.IsNullOrEmpty(entityMetadata.TableName))
		{
			InformationChannelTableName = entityMetadata.TableName;
			return;
		}
		throw new Exception("Не удалось получить таблицу в БД для сущности IInformationChannel");
	}

	public void CreateTree(Func<string, Guid, object, int, string, Guid, bool, bool, Image, bool> addNode)
	{
	}

	public DeleteFoldersOutput DeleteFolders(DeleteFoldersInput deleteFoldersInput)
	{
		return null;
	}

	public void PostNullifier(PostNullifierParameters postNullifierParameters)
	{
	}

	public void SearchSystemFile()
	{
	}

	public void ClearObject(ClearObjectParameters clearObjectParameters)
	{
		foreach (UnitNullConfig unit in clearObjectParameters.units)
		{
			if (unit.TypeUid == new Guid("6588BC0C-0FD7-4fe2-B265-7BAAE64EF430"))
			{
				clearObjectParameters.AddLog(SR.T("Очистка ленты сообщений."));
				clearObjectParameters.SqlQuery(string.Format("delete from {0}", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Feed")), SR.T("-7- Очистка ленты сообщений"));
				clearObjectParameters.SqlQuery(string.Format("delete from {0}", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("InternalMailMessage")), SR.T("-8- Очистка внутренних сообщений"));
			}
			if (unit.TypeUid == new Guid("57CE9ADA-AF12-45C1-9E3C-AF882F812F66"))
			{
				clearObjectParameters.AddLog(SR.T("Очистка избранного ленты."));
				clearObjectParameters.SqlQuery(string.Format("delete from {0}", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("FeedFavorite")), SR.T("-7- Очистка избранного ленты"));
			}
			if (unit.TypeUid == new Guid("37A4A060-25B8-4B3E-BE65-BC4A37A31765"))
			{
				clearObjectParameters.AddLog(SR.T("Очистка архива ленты."));
				clearObjectParameters.SqlQuery(string.Format("delete from {0}", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("FeedArchive")), SR.T("-7- Очистка архива ленты"));
			}
			if (unit.TypeUid == new Guid("07A5BE31-C87E-4166-972F-FAEEB7530CF1"))
			{
				clearObjectParameters.AddLog(SR.T("Очистка информационных каналов."));
				clearObjectParameters.SqlQuery(string.Format("delete from {0} where {1} in (select {2} from {3} where {4} = 0)", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("M_ChannelMessage_Channels"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("ChannelId"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Id"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded(InformationChannelTableName), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("IsArchive")), SR.T("-7- Очистка информационных каналов"));
			}
			if (unit.TypeUid == new Guid("AC8230F5-1422-43E3-933F-85D05CE1F87C"))
			{
				clearObjectParameters.AddLog(SR.T("Очистка архивных информационных каналов."));
				clearObjectParameters.SqlQuery(string.Format("delete from {0} where {1} in (select {2} from {3} where {4} = 1)", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("M_ChannelMessage_Channels"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("ChannelId"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Id"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded(InformationChannelTableName), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("IsArchive")), SR.T("-7- Очистка архивных информационных каналов"));
			}
		}
	}
}
