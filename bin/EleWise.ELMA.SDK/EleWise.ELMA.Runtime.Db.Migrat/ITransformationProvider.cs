using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public interface ITransformationProvider : ITransformationProviderBase, IDisposable
{
	Guid Uid { get; }

	new IDbConnection Connection { get; }

	new Dialect Dialect { get; }

	AbstractDbMetadataProvider DbMetadataProvider { get; }

	new string ParameterSeparator { get; }

	bool CheckParameterBinding { get; }

	bool LogsEnabled { get; set; }

	int TableRecordMaxSize { get; }

	bool HasFullAutoBackupSupport { get; }

	new void BeginTransaction();

	void BeginTransaction(IsolationLevel level);

	new void RollbackTransaction();

	ITransformationProvider CreateWithNewConnection();

	object GetLobString(IDataReader rs, string name);

	new string GuidQuerySintaxis(Guid guid);

	string GetCurrentSchemaName();

	new void ExecuteWithTimeout(int timeout, Action action);

	int? SetCurrentContextTimeout(int? timeout);

	new IDataReader ExecuteQuery(string sql, Dictionary<string, object> paramValues = null);

	int ExecuteNonQuery(string sql, Dictionary<string, object> paramValues = null);

	new object ExecuteScalar(string sql, Dictionary<string, object> paramValues = null);

	int Insert(string table, string[] columns, object[] values);

	int Insert(string table, string[] columns, object[] values, bool isNeedInsertId);

	int Insert(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues = null);

	int Update(string table, string[] columns, object[] values, string where, Dictionary<string, object> paramValues = null);

	new string SetupFetchOptions(string query, FetchOptions fetchOptions);

	new string SetupFetchOptions(string query, FetchOptions fetchOptions, bool quoteIfNeededSortExpression);

	new string Count(string query);

	string GetSqlOrderBy(PropertyMetadata propertyMetadata, string columnName);

	string GetSqlHierarchicalChilds(string tableName, string parentColumnName, string nameColumnName, long? parentId, int indent, int deep);

	string BitAndExpression(string idcolumn, long mask);

	string BitAndExpression(string idcolumn, string mask);

	string NoLockTableExpression(string tableName, string alias);

	string GetProcedureNameFromText(string procedureText);

	Index GetIndexInfoFromStatement(string sqlText);

	void RetryOnDeadlock(Action action, int retryCount);

	bool IsUnrecoverableException(Exception ex);

	void ProcessException(Exception ex, IDbConnection dbConnection);

	bool SavePoint(string key, IDbTransaction dbTransaction);

	void ReleaseSavePoint(string key, IDbTransaction dbTransaction);

	void RollBackSavePoint(string key, IDbTransaction dbTransaction);

	bool TableExists(string table);

	void AddTable(Table table);

	void RenameTable(string oldTableName, string newTableName);

	void RenameSequence(string oldTableName, string newTableName);

	int GetTableColumnsSize(string table);

	void RemoveTable(string tableName, bool removeSequence = true);

	void AddTableSequence(string tableName);

	void RemoveTableSequence(string tableName);

	void InitTableGenerators();

	void BackupTables(string[] tableNames, string[] newTableNames);

	bool ColumnExists(string table, string column);

	void AddColumn(string table, Column column);

	void RenameColumn(string table, string oldColumnName, string newColumnName);

	void RemoveColumn(string table, string column);

	void RemoveColumnConstraints(string table, string column);

	int GetColumnSize(Column column);

	bool NeedStringColumnTransform(string tableName, string columnName);

	void ConvertColumnString(string tableName, string columnName, int columnSize);

	void ConvertColumnString(string tableName, string columnName, int columnSize, bool substringStrings);

	void ConvertColumnStringIfNeed(string tableName, string columnName, int columnSize);

	string[] GetTableColumnsNames(string tableName);

	string GenerateColumnTemporaryName(string tableName, string columnName);

	string GenerateDeletingColumnTemporaryName(string tableName, string columnName);

	string GetDeletingColumnTemporaryName(string tableName, string columnName);

	bool ConstraintExists(string table, string name);

	List<ForeignKey> GetForeignKeys(string tableName);

	void AddForeignKey(ForeignKey foreignKey);

	void RemoveForeignKey(string tableName, string fkName);

	void RemoveForeignKeys(IList<string> skipNames = null, IList<string> useNames = null);

	void AddPrimaryKey(PrimaryKey primaryKey);

	List<KeyValuePair<string, string>> GetPrimaryKeys();

	PrimaryKey GetPrimaryKeyByTable(string table);

	void RemovePrimaryKey(string tableName, string pkName);

	void RemovePrimaryKeys(IList<string> skipNames = null, IList<string> useNames = null);

	void RemoveTrigger(string tableName, string triggerName);

	void RemoveTriggers(IList<string> skipNames = null, IList<string> useNames = null);

	void RemoveProcedure(string procedureName);

	void RemoveProcedures(IList<string> skipNames = null, IList<string> useNames = null);

	string TableFunction(string name, string @params);

	void RemoveView(string viewName);

	void RemoveViews(IList<string> skipNames = null, IList<string> useNames = null);

	List<string> GetIndexes(string tableName);

	void AddUniqueIndex(Index index);

	void AddIndex(Index index);

	void AddNvlIndex(Index index);

	void RemoveIndex(string tableName, string indexName);

	void RemoveIndexes(IList<string> skipNames = null, IList<string> useNames = null);

	string GenerateIndexName();

	bool IndexExists(string tableName, string indexName);

	void DisableIndexOnTable(string tableName);

	void RebuildIndexOnTable(string tableName);

	string BackupDatabase(string connectionString, string outputPath);

	DateTime GetDateTimeNow();

	DateTime GetUtcDateTimeNow();

	void BulkInsert(string tableName, DataTable data);

	void BulkInsert(string tableName, DataTable data, bool shouldGenerateId);

	void BulkUpdate(string tableName, DataTable data);

	void BulkUpdate(string tableName, DataTable data, string keyColumn);

	void BulkUpdate(string tableName, DataTable data, List<ColumnLink> keyColumns);

	int BulkDelete(string table, string where, Dictionary<string, object> paramValues = null);

	int BulkDelete(BulkDeleteArg arg);

	[Obsolete("Не атомарен, могут возникать промежутки в отрезке выделения идентификаторов. Используйте ReserveIds")]
	long ReserveId(int count, string tableName);

	long[] ReserveIds(int count, string tableName);

	void CheckPrerequisites();

	string GetDatabaseServerVersion();

	Version GetEngineVersion();

	new bool IsSortableDataColumn(DataColumn column);
}
