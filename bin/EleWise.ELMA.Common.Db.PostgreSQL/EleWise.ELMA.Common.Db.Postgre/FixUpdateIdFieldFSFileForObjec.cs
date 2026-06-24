using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.Common.Db.PostgreSQL;

[Component]
internal class FixUpdateIdFieldFSFileForObjectExtension : IFixUpdateIdFieldFSFileForObjectExtension
{
	private readonly ITransformationProvider transformationProvider;

	private int? previousTimeout;

	private const string TemporaryTableName = "FixUpdateIdFieldFSFileForObjectTemp";

	private const string TemporaryTableIdFiledName = "Id";

	private const string TemporaryTableUidFiledName = "Uid";

	private const string FilesTableName = "FS_FILES";

	private const string IdFieldName = "Id";

	private const string UidFieldName = "Uid";

	public Guid ProviderUid => PostgreSQLTransformationProvider.ProviderUID;

	public FixUpdateIdFieldFSFileForObjectExtension(ITransformationProvider transformationProvider)
	{
		this.transformationProvider = transformationProvider;
	}

	public void CreateTemplateTable()
	{
		previousTimeout = transformationProvider.SetCurrentContextTimeout(null);
		transformationProvider.ExecuteNonQuery(string.Format("CREATE TABLE {0} ({1} int, {2} varchar(36))", transformationProvider.Dialect.QuoteIfNeeded("FixUpdateIdFieldFSFileForObjectTemp"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.QuoteIfNeeded("Uid")));
		transformationProvider.ExecuteNonQuery(string.Format("CREATE UNIQUE INDEX {0} ON {1} ({2})", transformationProvider.Dialect.QuoteIfNeeded("IX_FieldId"), transformationProvider.Dialect.QuoteIfNeeded("FixUpdateIdFieldFSFileForObjectTemp"), transformationProvider.Dialect.QuoteIfNeeded("Id")));
	}

	public void RemoveTemplateTable()
	{
		transformationProvider.ExecuteNonQuery("DROP TABLE " + transformationProvider.Dialect.QuoteIfNeeded("FixUpdateIdFieldFSFileForObjectTemp"));
		transformationProvider.SetCurrentContextTimeout(previousTimeout);
	}

	public void UpdateData(string tableName, string fieldName)
	{
		transformationProvider.ExecuteNonQuery("delete from " + transformationProvider.Dialect.QuoteIfNeeded("FixUpdateIdFieldFSFileForObjectTemp"));
		string sql = string.Format("INSERT INTO {0} ({1}, {2}) select t.{3}, {4} {5} from {6} t inner join {7} fs on {8} < 32 and {9} = {10}", transformationProvider.Dialect.QuoteIfNeeded("FixUpdateIdFieldFSFileForObjectTemp"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.QuoteIfNeeded("Uid"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.CastToString("fs." + transformationProvider.Dialect.QuoteIfNeeded("Uid")), transformationProvider.Dialect.QuoteIfNeeded("fileUid"), transformationProvider.Dialect.QuoteIfNeeded(tableName), transformationProvider.Dialect.QuoteIfNeeded("FS_FILES"), transformationProvider.Dialect.Length(transformationProvider.Dialect.QuoteIfNeeded(fieldName)), transformationProvider.Dialect.CastToString("fs." + transformationProvider.Dialect.QuoteIfNeeded("Id")), transformationProvider.Dialect.QuoteIfNeeded(fieldName));
		transformationProvider.ExecuteNonQuery(sql);
		sql = string.Format("WITH cte AS (select t1.{6}, t1.{0} {1}, t2.{2} {3} from {4} t1 inner join {5} t2 on t2.{6} = t1.{7}) update {4} tt2 set {0} = cte.{3} FROM cte WHERE tt2.{6} = cte.{6}", transformationProvider.Dialect.QuoteIfNeeded(fieldName), transformationProvider.Dialect.QuoteIfNeeded("IdOriginal"), transformationProvider.Dialect.QuoteIfNeeded("Uid"), transformationProvider.Dialect.QuoteIfNeeded("IdNew"), transformationProvider.Dialect.QuoteIfNeeded(tableName), transformationProvider.Dialect.QuoteIfNeeded("FixUpdateIdFieldFSFileForObjectTemp"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.QuoteIfNeeded("Id"));
		transformationProvider.ExecuteNonQuery(sql);
	}
}
