using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.History.Constants;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.History.Db;

internal sealed class HistoryDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => Guid.Empty;

	internal void CreateHistoryUpdateQueueItemTable()
	{
		if (base.Transformation.TableExists(HistoryUpdateQueueItemConstants.TableName))
		{
			return;
		}
		try
		{
			Table table = new Table
			{
				Sequence = true,
				Name = HistoryUpdateQueueItemConstants.TableName,
				Columns = new List<Column>
				{
					new Column(HistoryUpdateQueueItemConstants.Id, DbType.Int64, ColumnProperty.PrimaryKey),
					new Column(HistoryUpdateQueueItemConstants.ObjectId, DbType.Int64),
					new Column(HistoryUpdateQueueItemConstants.ObjectTypeUid, DbType.Guid),
					new Column(HistoryUpdateQueueItemConstants.LastActionDate, DbType.Int64),
					new Column(HistoryUpdateQueueItemConstants.DeleteRelated, DbType.Boolean),
					new Column(HistoryUpdateQueueItemConstants.CreationDate, DbType.DateTime),
					new Column(HistoryUpdateQueueItemConstants.Attempt, DbType.Int32),
					new Column(HistoryUpdateQueueItemConstants.LastUpdateDate, DbType.DateTime),
					new Column(HistoryUpdateQueueItemConstants.NextUpdateDate, DbType.DateTime),
					new Column(HistoryUpdateQueueItemConstants.ServerConnectionUid, DbType.Guid)
				}
			};
			base.Transformation.AddTable(table);
		}
		catch (Exception ex)
		{
			base.Transformation.RollbackTransaction();
			Logger.Log.Error(ex, "Initialize HistoryUpdateQueueItemTable error");
			throw ex;
		}
	}
}
