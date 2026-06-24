using System;
using System.Data;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.Messages.Db.MsSql;

internal class MessagesDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Messages.Db.MessagesDbStructure);

	public void UpdateFeedTablesColumnId()
	{
		ConvertContextTableIdColumn("FeedFavorite");
		ConvertContextTableIdColumn("FeedInfo");
	}

	private void ConvertContextTableIdColumn(string tableName)
	{
		ITransformationProvider transformation = base.Transformation;
		if (transformation.TableExists(tableName))
		{
			PrimaryKey primaryKeyByTable = transformation.GetPrimaryKeyByTable(tableName);
			transformation.AddColumn(tableName, new Column("New_Id", DbType.Int64, ColumnProperty.NotNull, 0L));
			transformation.Update(tableName, new string[1] { "New_Id" }, new object[1]
			{
				new SqlExpressionParameter(transformation.Dialect.QuoteIfNeeded("Id"))
			}, null);
			if (primaryKeyByTable != null)
			{
				transformation.RemovePrimaryKey(tableName, primaryKeyByTable.Name);
			}
			transformation.RemoveColumn(tableName, "Id");
			transformation.RenameColumn(tableName, "New_Id", "Id");
			if (primaryKeyByTable != null)
			{
				transformation.AddPrimaryKey(new PrimaryKey
				{
					Name = primaryKeyByTable.Name,
					TableName = tableName,
					Columns = { "Id" }
				});
			}
			transformation.AddTableSequence(tableName);
		}
	}
}
