using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions.PostgreSQL.NH;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.Components.PostgreSQL;
using EleWise.ELMA.Packaging.Components.PostgreSQL.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Db.Proxies;
using EleWise.ELMA.Services;
using Npgsql;
using NpgsqlTypes;

namespace EleWise.ELMA.Extensions.PostgreSQL;

public class PostgreSQLTransformationProvider : TransformationProvider
{
	private const string BulkDataUpdateTempTable = "dataUpdate";

	public static string UidString = "{9B1803BE-F66E-4F59-B687-1654BA9735C9}";

	public static Guid ProviderUID = new Guid(UidString);

	private const string SqlGetAllPrimaryKeys = "select t.relname as table_name, i.relname as constraint_name, a.attname as column_name\r\nfrom pg_class t, pg_index ix, pg_class i,  pg_attribute a\r\nwhere t.oid = ix.indrelid and i.oid= ix.indexrelid and a.attrelid = t.oid and a.attnum = ANY(ix.indkey)\r\n and t.relkind = 'r' and ix.indisprimary";

	private static readonly string SqlGetPrimaryKeyByTable = "select t.relname as table_name, i.relname as constraint_name, a.attname as column_name\r\nfrom pg_class t, pg_index ix, pg_class i,  pg_attribute a\r\nwhere t.oid = ix.indrelid and i.oid= ix.indexrelid and a.attrelid = t.oid and a.attnum = ANY(ix.indkey)\r\n and t.relkind = 'r' and ix.indisprimary" + " and lower(t.relname) = lower(:TableName)";

	private const string SqlGetAllForeignKeys = "SELECT\r\n    tc.table_name as TABLE_NAME,\r\n    tc.constraint_name as FK_CONSTRAINT_NAME, kcu.column_name as FK_COLUMN_NAME, \r\n    ccu.table_name AS REFERENCED_TABLE_NAME,\r\n    ccu.column_name AS REFERENCED_COLUMN_NAME \r\nFROM \r\n    information_schema.table_constraints AS tc \r\n    JOIN information_schema.key_column_usage AS kcu\r\n      ON tc.constraint_name = kcu.constraint_name\r\n    JOIN information_schema.constraint_column_usage AS ccu\r\n      ON ccu.constraint_name = tc.constraint_name\r\nWHERE constraint_type = 'FOREIGN KEY'";

	private static readonly string SqlGetForeignKeys = "SELECT\r\n    tc.table_name as TABLE_NAME,\r\n    tc.constraint_name as FK_CONSTRAINT_NAME, kcu.column_name as FK_COLUMN_NAME, \r\n    ccu.table_name AS REFERENCED_TABLE_NAME,\r\n    ccu.column_name AS REFERENCED_COLUMN_NAME \r\nFROM \r\n    information_schema.table_constraints AS tc \r\n    JOIN information_schema.key_column_usage AS kcu\r\n      ON tc.constraint_name = kcu.constraint_name\r\n    JOIN information_schema.constraint_column_usage AS ccu\r\n      ON ccu.constraint_name = tc.constraint_name\r\nWHERE constraint_type = 'FOREIGN KEY'" + " AND upper(tc.table_name)=:tableName";

	private Dialect dialect;

	private AbstractDbMetadataProvider dbMetadataProvider;

	private string schemaName;

	private string pathToBackupUtil;

	public override Guid Uid => ProviderUID;

	public override Dialect Dialect => dialect ?? (dialect = new PostgreSQLDialect(GetReservedWords()));

	public override AbstractDbMetadataProvider DbMetadataProvider => dbMetadataProvider ?? (dbMetadataProvider = new PostgreSQLDbMetadataProvider(this));

	public override string ParameterSeparator => ":";

	public override bool CheckParameterBinding => true;

	public override int TableRecordMaxSize => 500;

	public override bool HasFullAutoBackupSupport => false;

	[Obsolete("Не использовать", true)]
	public PostgreSQLTransformationProvider()
	{
	}

	public PostgreSQLTransformationProvider(Func<IDbConnection> connectionCreateFunc)
		: base(connectionCreateFunc)
	{
	}

	public PostgreSQLTransformationProvider(Func<IDbConnection> connectionCreateFunc, string pathToPgDump)
		: base(connectionCreateFunc)
	{
		pathToBackupUtil = pathToPgDump ?? "";
	}

	public PostgreSQLTransformationProvider(string connectionString)
		: base(() => (IDbConnection)new NpgsqlConnection(connectionString))
	{
	}

	public override ITransformationProvider CreateWithNewConnection()
	{
		return new PostgreSQLTransformationProvider(this);
	}

	private PostgreSQLTransformationProvider(PostgreSQLTransformationProvider other)
		: base(other.ConnectionCreateFunc)
	{
		dialect = other.dialect;
		schemaName = other.schemaName;
		pathToBackupUtil = other.pathToBackupUtil;
	}

	protected override bool CanRetryAfterException(Exception ex)
	{
		Contract.ArgumentNotNull(ex, "ex");
		Exception innerPostgresException = GetInnerPostgresException(ex);
		PostgresException val = (PostgresException)(object)((innerPostgresException is PostgresException) ? innerPostgresException : null);
		if (val == null)
		{
			return false;
		}
		if (val.get_SqlState() != "40P01")
		{
			return false;
		}
		return true;
	}

	public override bool IsUnrecoverableException(Exception ex)
	{
		if (ex == null)
		{
			return false;
		}
		Exception innerPostgresException = GetInnerPostgresException(ex);
		PostgresException val = (PostgresException)(object)((innerPostgresException is PostgresException) ? innerPostgresException : null);
		if (val == null)
		{
			return false;
		}
		return val.get_SqlState() == "40P01";
	}

	public override void ProcessException(Exception ex, IDbConnection dbConnection)
	{
		if (ex == null)
		{
			return;
		}
		Exception innerPostgresException = GetInnerPostgresException(ex);
		PostgresException val = (PostgresException)(object)((innerPostgresException is PostgresException) ? innerPostgresException : null);
		if (val == null)
		{
			return;
		}
		if (val.get_SqlState() == "08006")
		{
			try
			{
				if (dbConnection != null && dbConnection.State == ConnectionState.Closed)
				{
					dbConnection.Open();
				}
			}
			catch (Exception)
			{
			}
		}
		if (!(val.get_SqlState() == "23503"))
		{
			return;
		}
		throw new Exception(SR.T("Нарушение ссылочной целостности. Нельзя удалить запись из таблицы, на которую ссылается другая запись!"), ex);
	}

	public override string GuidQuerySintaxis(Guid guid)
	{
		return GuidQuerySintaxisStatic(guid);
	}

	public override string GetCurrentSchemaName()
	{
		return schemaName ?? (schemaName = GetSchemaName());
	}

	internal static string GuidQuerySintaxisStatic(Guid guid)
	{
		return $"'{guid.ToString().ToLower()}'";
	}

	public override string GetDatabaseServerVersion()
	{
		return Convert.ToString(ExecuteScalar("SELECT version()")).Trim('\r', '\n');
	}

	public override Version GetEngineVersion()
	{
		Version.TryParse(Convert.ToString(ExecuteScalar("show SERVER_VERSION")).Trim('\r', '\n'), out var result);
		return result;
	}

	public override bool SavePoint(string key, IDbTransaction dbTransaction)
	{
		NpgsqlTransaction val = GetTransaction(dbTransaction);
		if (val == null || string.IsNullOrWhiteSpace(key))
		{
			return false;
		}
		try
		{
			val.Save(key);
			return true;
		}
		catch (Exception exception)
		{
			Logger.Log.Warn("SavePoint", exception);
		}
		return false;
	}

	public override void ReleaseSavePoint(string key, IDbTransaction dbTransaction)
	{
		NpgsqlTransaction val = GetTransaction(dbTransaction);
		if (val == null || string.IsNullOrWhiteSpace(key))
		{
			return;
		}
		try
		{
			val.Release(key);
		}
		catch (Exception exception)
		{
			Logger.Log.Warn("ReleaseSavePoint", exception);
		}
	}

	public override void RollBackSavePoint(string key, IDbTransaction dbTransaction)
	{
		NpgsqlTransaction val = GetTransaction(dbTransaction);
		if (val == null || string.IsNullOrWhiteSpace(key))
		{
			return;
		}
		try
		{
			val.Rollback(key);
		}
		catch (Exception exception)
		{
			Logger.Log.Warn("RollbackSavePoint", exception);
		}
	}

	private NpgsqlTransaction GetTransaction(IDbTransaction dbTransaction)
	{
		NpgsqlTransaction val = (NpgsqlTransaction)((dbTransaction is NpgsqlTransaction) ? dbTransaction : null);
		if (val == null && dbTransaction is DbTransactionProxy dbTransactionProxy)
		{
			DbTransaction realTransaction = dbTransactionProxy.RealTransaction;
			val = (NpgsqlTransaction)(object)((realTransaction is NpgsqlTransaction) ? realTransaction : null);
		}
		return val;
	}

	public override string SetupFetchOptions(string query, FetchOptions fetchOptions, bool quoteIfNeededSortExpression)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("SELECT");
		bool num = fetchOptions != null && fetchOptions != FetchOptions.All;
		bool num2 = fetchOptions != null && (!string.IsNullOrEmpty(fetchOptions.SortExpression) || fetchOptions.SortDescriptors.Any());
		stringBuilder.Append(" ");
		stringBuilder.Append(query);
		if (num2)
		{
			stringBuilder.Append(" ORDER BY ");
			if (!fetchOptions.SortDescriptors.Any())
			{
				fetchOptions.SortDescriptors.Add(new FetchOptionsSortDescriptor(fetchOptions.SortExpression, fetchOptions.SortDirection));
			}
			IEnumerable<string> values = fetchOptions.SortDescriptors.Select((FetchOptionsSortDescriptor sd) => string.Format("{0} {1}", quoteIfNeededSortExpression ? Dialect.QuoteIfNeeded(sd.SortExpression) : sd.SortExpression, (sd.SortDirection == ListSortDirection.Descending) ? "DESC" : ""));
			stringBuilder.Append(string.Join(", ", values));
		}
		if (num)
		{
			stringBuilder.Append(" LIMIT ");
			stringBuilder.Append(fetchOptions.MaxResults);
			stringBuilder.Append(" OFFSET  ");
			stringBuilder.Append(fetchOptions.FirstResult);
		}
		return stringBuilder.ToString();
	}

	public override string Count(string query)
	{
		return string.Format("SELECT COUNT(*) FROM ({0}) {1}", query, Dialect.QuoteIfNeeded("count_tabl"));
	}

	public override string GetSqlOrderBy(PropertyMetadata propertyMetadata, string columnName)
	{
		return columnName;
	}

	public override string GetSqlHierarchicalChilds(string tableName, string parentColumnName, string nameColumnName, long? parentId, int indent, int deep)
	{
		if (!TableExists(tableName))
		{
			throw new Exception(SR.T("Таблица {0} не существует", tableName));
		}
		if (!ColumnExists(tableName, parentColumnName))
		{
			throw new Exception(SR.T("Колонка {1} в таблице {0} не существует", tableName, parentColumnName));
		}
		if (!string.IsNullOrWhiteSpace(nameColumnName) && !ColumnExists(tableName, nameColumnName))
		{
			throw new Exception(SR.T("Колонка {1} в таблице {0} не существует", tableName, parentColumnName));
		}
		long num = parentId ?? 0;
		return string.Format("WITH RECURSIVE Rec(Id, Lvl) as (     SELECT tLvl0.{0}, 0 lvl     FROM {2} tLvl0 " + ((!parentId.HasValue) ? "WHERE tLvl0.{1} is NULL " : "WHERE tLvl0.{1} = {4} ") + "    UNION ALL     SELECT tLvl1.{0}, lvl + 1 lvl     FROM {2} tLvl1     INNER JOIN Rec on Rec.{0} = tLvl1.{1} ) " + ((!string.IsNullOrWhiteSpace(nameColumnName)) ? "SELECT tM.{0}, tM.{5} " : "SELECT tM.{0} ") + "FROM {2} tM WHERE tM.{0} in ( SELECT Id FROM Rec WHERE Lvl >= {6} and Lvl < {3} )", Dialect.QuoteIfNeeded("Id"), Dialect.QuoteIfNeeded(parentColumnName), Dialect.QuoteIfNeeded(tableName), deep + indent, num, (!string.IsNullOrWhiteSpace(nameColumnName)) ? Dialect.QuoteIfNeeded(nameColumnName) : "", indent);
	}

	public override string BitAndExpression(string idcolumn, long mask)
	{
		return BitAndExpression(idcolumn, mask.ToString());
	}

	public override string BitAndExpression(string idcolumn, string mask)
	{
		return $"{idcolumn} | {mask}";
	}

	public override int Insert(string table, string[] columns, object[] values, bool isNeedInsertId)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return InsertAsync(table, columns, values, isNeedInsertId, isAsync: false).GetAwaiter().GetResult();
	}

	public override Task<int> InsertAsync(string table, string[] columns, object[] values, bool isNeedInsertId, CancellationToken cancellationToken = default(CancellationToken))
	{
		return InsertAsync(table, columns, values, isNeedInsertId, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CInsertAsync_003Ed__35))]
	private System.Threading.Tasks.ValueTask<int> InsertAsync(string table, string[] columns, object[] values, bool isNeedInsertId, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		_003CInsertAsync_003Ed__35 _003CInsertAsync_003Ed__ = default(_003CInsertAsync_003Ed__35);
		_003CInsertAsync_003Ed__._003C_003E4__this = this;
		_003CInsertAsync_003Ed__.table = table;
		_003CInsertAsync_003Ed__.columns = columns;
		_003CInsertAsync_003Ed__.values = values;
		_003CInsertAsync_003Ed__.isNeedInsertId = isNeedInsertId;
		_003CInsertAsync_003Ed__.isAsync = isAsync;
		_003CInsertAsync_003Ed__.cancellationToken = cancellationToken;
		_003CInsertAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CInsertAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CInsertAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CInsertAsync_003Ed__35>(ref _003CInsertAsync_003Ed__);
		return _003CInsertAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public override int Insert(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues = null)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return InsertAsync(table, columns, selectColName, selectFrom, isNeedInsertId, paramValues, isAsync: false).GetAwaiter().GetResult();
	}

	public override Task<int> InsertAsync(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return InsertAsync(table, columns, selectColName, selectFrom, isNeedInsertId, paramValues, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CInsertAsync_003Ed__38))]
	private System.Threading.Tasks.ValueTask<int> InsertAsync(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		_003CInsertAsync_003Ed__38 _003CInsertAsync_003Ed__ = default(_003CInsertAsync_003Ed__38);
		_003CInsertAsync_003Ed__._003C_003E4__this = this;
		_003CInsertAsync_003Ed__.table = table;
		_003CInsertAsync_003Ed__.columns = columns;
		_003CInsertAsync_003Ed__.selectColName = selectColName;
		_003CInsertAsync_003Ed__.selectFrom = selectFrom;
		_003CInsertAsync_003Ed__.isNeedInsertId = isNeedInsertId;
		_003CInsertAsync_003Ed__.paramValues = paramValues;
		_003CInsertAsync_003Ed__.isAsync = isAsync;
		_003CInsertAsync_003Ed__.cancellationToken = cancellationToken;
		_003CInsertAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CInsertAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CInsertAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CInsertAsync_003Ed__38>(ref _003CInsertAsync_003Ed__);
		return _003CInsertAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	protected override void AddTable(string table, string columns, bool sequence)
	{
		base.AddTable(table, columns, sequence);
		if (sequence)
		{
			AddTableSequence(table);
		}
	}

	protected override void AddTable(string table, string columns, bool sequence, bool isTemporary)
	{
		base.AddTable(table, columns, sequence, isTemporary);
		if (sequence)
		{
			AddTableSequence(table);
		}
	}

	public override void BackupTables(string[] tableNames, string[] newTableNames)
	{
		for (int i = 0; i < tableNames.Length; i++)
		{
			string name = tableNames[i];
			string name2 = newTableNames[i];
			string sql = $"select * into {Dialect.QuoteIfNeeded(name2)} from {Dialect.QuoteIfNeeded(name)}";
			ExecuteWithTimeout(0, delegate
			{
				ExecuteNonQuery(sql);
			});
		}
	}

	protected override List<string> GetReservedWords()
	{
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery("select word from pg_get_keywords() where word is not null");
		while (dataReader.Read())
		{
			list.Add(((string)dataReader["word"]).Trim());
		}
		return list;
	}

	public override bool TableExists(string table)
	{
		Contract.ArgumentNotNull(table, "table");
		Contract.ArgumentNotNullOrEmpty(table, "table");
		string sql = $"select count(*) from information_schema.tables where table_name = '{SysObjectName(table)}' and table_schema = 'public'";
		return Convert.ToInt32(ExecuteScalar(sql)) > 0;
	}

	public override void RenameTable(string oldTableName, string newTableName)
	{
		ExecuteNonQuery($"ALTER TABLE {QuoteIfNeeded(oldTableName)} RENAME TO {QuoteIfNeeded(newTableName)}");
		RenameSequence(oldTableName, newTableName);
	}

	public override void RenameSequence(string oldTableName, string newTableName)
	{
		ExecuteNonQuery($"ALTER SEQUENCE G_{QuoteIfNeeded(oldTableName)} RENAME TO G_{QuoteIfNeeded(newTableName)}");
	}

	public override int GetTableColumnsSize(string table)
	{
		int result = 0;
		string sql = "select count(*) FROM information_schema.columns WHERE table_schema = 'public' AND lower(table_name) = lower('" + table.ToLower() + "')";
		using IDataReader dataReader = ExecuteQuery(sql);
		if (dataReader.Read())
		{
			return Convert.ToInt32(dataReader[0]);
		}
		return result;
	}

	public override int GetColumnSize(Column column)
	{
		return 1;
	}

	public override List<string> GetTables()
	{
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery("select tablename from pg_tables where schemaname = 'public' order by tablename");
		while (dataReader.Read())
		{
			list.Add(((string)dataReader["tablename"]).Trim());
		}
		return list;
	}

	public override void RemoveTable(string tableName, bool removeSequence)
	{
		ExecuteNonQuery("DROP TABLE " + QuoteIfNeeded(tableName));
		if (removeSequence)
		{
			RemoveTableSequence(tableName);
		}
	}

	public override void AddTableSequence(string tableName)
	{
		ExecuteNonQuery($"CREATE SEQUENCE g_{tableName.ToLower()}");
	}

	public override void RemoveTableSequence(string tableName)
	{
		ExecuteNonQuery($"DROP SEQUENCE g_{tableName.ToLower()}");
	}

	public override bool ColumnExists(string table, string column)
	{
		Contract.ArgumentNotNull(table, "table");
		Contract.ArgumentNotNull(column, "column");
		Contract.ArgumentNotNullOrEmpty(table, "table");
		Contract.ArgumentNotNullOrEmpty(column, "column");
		string sql = $"\r\nselect count(*) from information_schema.columns \r\nwhere  table_name = '{SysObjectName(table)}' and column_name = '{SysObjectName(column)}' and table_schema = 'public'";
		return Convert.ToInt32(ExecuteScalar(sql)) > 0;
	}

	protected override void AddColumn(string table, string sqlColumn, string columnName)
	{
		ExecuteNonQuery($"ALTER TABLE {QuoteIfNeeded(table)} ADD COLUMN {sqlColumn}");
	}

	public override void RenameColumn(string table, string oldColumnName, string newColumnName)
	{
		RemoveColumnConstraints(table, oldColumnName);
		ExecuteNonQuery($"ALTER TABLE {QuoteIfNeeded(table)} RENAME COLUMN {QuoteIfNeeded(oldColumnName)} TO {QuoteIfNeeded(newColumnName)}");
	}

	public override void RemoveColumn(string table, string column)
	{
		Contract.ArgumentNotNull(table, "table");
		Contract.ArgumentNotNull(column, "column");
		Contract.ArgumentNotNullOrEmpty(table, "table");
		Contract.ArgumentNotNullOrEmpty(column, "column");
		if (ColumnExists(table, column))
		{
			RemoveColumnConstraints(table, column);
			string sql = $"ALTER TABLE {QuoteIfNeeded(table)} DROP COLUMN {QuoteIfNeeded(column)} ";
			ExecuteNonQuery(sql);
		}
		base.RemoveColumn(table, column);
	}

	public override void RemoveColumnConstraints(string table, string column)
	{
		Contract.ArgumentNotNull(table, "table");
		Contract.ArgumentNotNull(column, "column");
		Contract.ArgumentNotNullOrEmpty(table, "table");
		Contract.ArgumentNotNullOrEmpty(column, "column");
		string sql = "select tc.constraint_name from information_schema.table_constraints as tc join information_schema.key_column_usage as kcu on tc.constraint_name = kcu.constraint_name join information_schema.constraint_column_usage as ccu on ccu.constraint_name = tc.constraint_name where  tc.constraint_schema = 'public' and tc.constraint_type = 'FOREIGN KEY' and upper(tc.table_name) = '" + table.ToUpper() + "' and upper(kcu.column_name) = '" + column.ToUpper() + "'";
		List<string> list = new List<string>();
		using (IDataReader dataReader = ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				list.Add(((string)dataReader["constraint_name"]).Trim());
			}
		}
		foreach (string item in list)
		{
			RemoveForeignKey(table, item);
		}
	}

	public override bool ConstraintExists(string tableName, string name)
	{
		return GetConstraints(tableName, name).Count > 0;
	}

	private List<string> GetConstraints(string tableName, string indexName)
	{
		List<string> list = new List<string>();
		string sql = $"select constraint_name from information_schema.table_constraints where constraint_schema = 'public' and table_name = '{SysObjectName(tableName)}' and upper(constraint_name) = '{indexName.ToUpper()}'";
		using IDataReader dataReader = ExecuteQuery(sql);
		while (dataReader.Read())
		{
			list.Add(dataReader["constraint_name"].ToString());
		}
		return list;
	}

	public override IDictionary<string, PrimaryKey> GetAllPrimaryKeys()
	{
		Dictionary<string, PrimaryKey> dictionary = new Dictionary<string, PrimaryKey>();
		using IDataReader dataReader = ExecuteQuery("select t.relname as table_name, i.relname as constraint_name, a.attname as column_name\r\nfrom pg_class t, pg_index ix, pg_class i,  pg_attribute a\r\nwhere t.oid = ix.indrelid and i.oid= ix.indexrelid and a.attrelid = t.oid and a.attnum = ANY(ix.indkey)\r\n and t.relkind = 'r' and ix.indisprimary");
		while (dataReader.Read())
		{
			string text = ((string)dataReader["table_name"]).Trim();
			if (!dictionary.TryGetValue(text, out var value))
			{
				value = new PrimaryKey
				{
					TableName = text,
					Name = ((string)dataReader["constraint_name"]).Trim(),
					Columns = new List<string>()
				};
				dictionary.Add(text, value);
			}
			value.Columns.Add(((string)dataReader["column_name"]).Trim());
		}
		return dictionary;
	}

	public override PrimaryKey GetPrimaryKeyByTable(string table)
	{
		using (IDataReader dataReader = ExecuteQuery(SqlGetPrimaryKeyByTable, new Dictionary<string, object> { { "TableName", table } }))
		{
			if (dataReader.Read())
			{
				return new PrimaryKey
				{
					TableName = table,
					Name = ((string)dataReader["constraint_name"]).Trim(),
					Columns = { ((string)dataReader["column_name"]).Trim() }
				};
			}
		}
		return null;
	}

	public override void AddForeignKey(ForeignKey foreignKey)
	{
		if (!ConstraintExists(foreignKey.TableName, foreignKey.Name))
		{
			base.AddForeignKey(foreignKey);
			AddIndex(new Index
			{
				Name = GetIndexNameByForeignKey(foreignKey.Name),
				TableName = foreignKey.TableName,
				Columns = foreignKey.Columns.ToList()
			});
		}
	}

	public override void RemoveForeignKey(string tableName, string fkName)
	{
		base.RemoveForeignKey(tableName, fkName);
		string indexNameByForeignKey = GetIndexNameByForeignKey(fkName);
		RemoveIndex(tableName, indexNameByForeignKey);
	}

	public override List<ForeignKey> GetForeignKeys(string tableName)
	{
		Contract.ArgumentNotNullOrEmpty(tableName, "tableName");
		List<ForeignKey> list = new List<ForeignKey>();
		using IDataReader dataReader = ExecuteQuery(SqlGetForeignKeys, new Dictionary<string, object> { 
		{
			"tableName",
			tableName.ToUpper()
		} });
		while (dataReader.Read())
		{
			ForeignKey foreignKey = new ForeignKey
			{
				Name = ((string)dataReader["FK_CONSTRAINT_NAME"]).Trim(),
				TableName = tableName,
				RefTableName = ((string)dataReader["REFERENCED_TABLE_NAME"]).Trim()
			};
			foreignKey.Columns.Add(((string)dataReader["FK_COLUMN_NAME"]).Trim());
			foreignKey.RefColumns.Add(((string)dataReader["REFERENCED_COLUMN_NAME"]).Trim());
			list.Add(foreignKey);
		}
		return list;
	}

	public override IList<ForeignKey> GetForeignKeys()
	{
		List<ForeignKey> list = new List<ForeignKey>();
		using IDataReader dataReader = ExecuteQuery("SELECT\r\n    tc.table_name as TABLE_NAME,\r\n    tc.constraint_name as FK_CONSTRAINT_NAME, kcu.column_name as FK_COLUMN_NAME, \r\n    ccu.table_name AS REFERENCED_TABLE_NAME,\r\n    ccu.column_name AS REFERENCED_COLUMN_NAME \r\nFROM \r\n    information_schema.table_constraints AS tc \r\n    JOIN information_schema.key_column_usage AS kcu\r\n      ON tc.constraint_name = kcu.constraint_name\r\n    JOIN information_schema.constraint_column_usage AS ccu\r\n      ON ccu.constraint_name = tc.constraint_name\r\nWHERE constraint_type = 'FOREIGN KEY'");
		while (dataReader.Read())
		{
			string tableName = ((string)dataReader["TABLE_NAME"]).Trim();
			ForeignKey foreignKey = new ForeignKey
			{
				Name = ((string)dataReader["FK_CONSTRAINT_NAME"]).Trim(),
				TableName = tableName,
				RefTableName = ((string)dataReader["REFERENCED_TABLE_NAME"]).Trim()
			};
			foreignKey.Columns.Add(((string)dataReader["FK_COLUMN_NAME"]).Trim());
			foreignKey.RefColumns.Add(((string)dataReader["REFERENCED_COLUMN_NAME"]).Trim());
			list.Add(foreignKey);
		}
		return list;
	}

	public override string[] GetTableColumnsNames(string tableName)
	{
		string sql = $"select column_name \"ColName\" from information_schema.columns where lower(table_name) = '{tableName.ToLower()}'";
		List<string> list = new List<string>();
		using (IDataReader dataReader = ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				list.Add(dataReader["ColName"].ToString());
			}
		}
		return list.ToArray();
	}

	public override void RemoveTrigger(string tableName, string triggerName)
	{
		ExecuteNonQuery("drop trigger " + QuoteIfNeeded(triggerName) + " on " + QuoteIfNeeded(tableName));
	}

	protected override List<KeyValuePair<string, string>> GetTriggers()
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		using IDataReader dataReader = ExecuteQuery("select pt.tgname, pc.relname from pg_trigger pt left join pg_proc pp on pt.tgfoid = pp.oid left join pg_class pc on pt.tgrelid = pc.oid join pg_namespace ns on ns.oid = pp.pronamespace and ns.nspname = 'public' where not pt.tgisinternal and pc.relname is not null");
		while (dataReader.Read())
		{
			list.Add(new KeyValuePair<string, string>(((string)dataReader["relname"]).Trim(), ((string)dataReader["tgname"]).Trim()));
		}
		return list;
	}

	public override void RemoveProcedure(string procedureName)
	{
		ExecuteNonQuery("drop function if exists " + procedureName);
	}

	protected override List<string> GetProcedures()
	{
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery("select pp.proname ,pg_get_function_identity_arguments(pp.oid) fia from pg_proc pp join pg_namespace ns on ns.oid = pp.pronamespace and ns.nspname = 'public' where pp.probin is null ");
		while (dataReader.Read())
		{
			list.Add(string.Format("{0}({1})", ((string)dataReader["proname"]).Trim(), ((string)dataReader["fia"]).Trim()));
		}
		return list;
	}

	public override void RemoveView(string viewName)
	{
		ExecuteNonQuery("drop view if exists " + QuoteIfNeeded(viewName));
	}

	public override List<string> GetViews()
	{
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery("select viewname from pg_views where schemaname = 'public'");
		while (dataReader.Read())
		{
			list.Add(((string)dataReader["viewname"]).Trim());
		}
		return list;
	}

	public override List<string> GetIndexes(string tableName)
	{
		string sql = $"select distinct(i.relname)\r\nfrom pg_class t, pg_index ix, pg_class i,  pg_attribute a\r\nwhere t.oid = ix.indrelid and i.oid= ix.indexrelid and a.attrelid = t.oid and a.attnum = ANY(ix.indkey)\r\n and t.relkind = 'r' and lower(t.relname) = lower('{tableName}') and not ix.indisprimary ";
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery(sql);
		while (dataReader.Read())
		{
			list.Add(dataReader[0].ToString());
		}
		return list;
	}

	private void DoAddIndex(Index index, bool isUnique = false)
	{
		if (IndexExists(index.TableName, index.Name))
		{
			return;
		}
		string indexName = QuoteIfNeeded(index.Name);
		string tableName = QuoteIfNeeded(index.TableName);
		string columns = string.Join(", ", index.Columns.Select(QuoteIfNeeded).ToArray());
		try
		{
			ExecuteWithTimeout(0, delegate
			{
				ExecuteNonQuery(string.Format("create {3} index {0} on {1} ( {2} )", indexName, tableName, columns, isUnique ? "UNIQUE " : ""));
			});
		}
		catch (Exception exception)
		{
			Logger.Log.Error($"Can't create index {indexName} for table {tableName}", exception);
			throw new DbStructureException(string.Format(SR.T("Не удалось создать индекс \"{0}\" ({1}.{2})"), indexName, tableName, columns));
		}
	}

	public override void AddUniqueIndex(Index index)
	{
		DoAddIndex(index, isUnique: true);
	}

	public override void AddIndex(Index index)
	{
		DoAddIndex(index);
	}

	public override bool IndexExists(string tableName, string indexName)
	{
		string sql = FindIndexes(tableName, indexName, selectCount: true);
		return Convert.ToInt32(ExecuteScalar(sql)) > 0;
	}

	public override string GetDisableIndexOnTable(string tableName)
	{
		return "";
	}

	public override string GetRebuildIndexOnTable(string tableName)
	{
		return $"REINDEX TABLE {tableName}";
	}

	public override void RemoveIndex(string tableName, string indexName)
	{
		string sql = FindIndexes(tableName, indexName, selectCount: true);
		bool isIndex = Convert.ToInt32(ExecuteScalar(sql)) > 0;
		ExecuteWithTimeout(0, delegate
		{
			if (isIndex)
			{
				List<string> constraints = GetConstraints(tableName, indexName);
				if (constraints.Count > 0)
				{
					foreach (string item in constraints)
					{
						ExecuteNonQuery($"alter table {QuoteIfNeeded(tableName)} drop constraint if exists \"{item}\"");
					}
				}
				ExecuteNonQuery($"drop index if exists {QuoteIfNeeded(indexName)}");
			}
		});
	}

	protected override List<KeyValuePair<string, string>> GetIndexes()
	{
		string sql = FindIndexes();
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		using IDataReader dataReader = ExecuteQuery(sql);
		while (dataReader.Read())
		{
			list.Add(new KeyValuePair<string, string>(((string)dataReader["tablename"]).Trim(), ((string)dataReader["indexname"]).Trim()));
		}
		return list;
	}

	public override string BackupDatabase(string connectionString, string outputPath)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		if (string.IsNullOrEmpty(connectionString))
		{
			throw new ArgumentNullException("connectionString");
		}
		if (string.IsNullOrEmpty(outputPath))
		{
			outputPath = Path.Combine(Path.GetDirectoryName((Locator.GetService<IRuntimeApplication>() ?? throw new ArgumentNullException("outputPath")).Configuration.Config.FilePath), "Backups");
			if (!Directory.Exists(outputPath))
			{
				Directory.CreateDirectory(outputPath);
			}
		}
		string pgDumpExecutable = GetPgDumpExecutable(connectionString);
		if (string.IsNullOrEmpty(pgDumpExecutable))
		{
			return "";
		}
		connectionString = PostgreSQLProvider.UpdateConnectionString(connectionString);
		NpgsqlConnectionStringBuilder val = new NpgsqlConnectionStringBuilder(connectionString);
		string host = val.get_Host();
		if (host == "localhost" || host == "127.0.0.1")
		{
			try
			{
				string text = Path.Combine(outputPath, val.get_Database() + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".dump");
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat(" --host={0}", val.get_Host());
				stringBuilder.AppendFormat(" --port={0}", val.get_Port().ToString());
				stringBuilder.AppendFormat(" --dbname={0}", val.get_Database());
				stringBuilder.AppendFormat(" --username={0}", val.get_Username());
				stringBuilder.AppendFormat(" --file={0}", text);
				stringBuilder.Append(" --format=c");
				Logger.Log.Info("Start backup database \"" + val.get_Database() + "\". Output file: " + text);
				Process process = new Process();
				process.StartInfo.FileName = pgDumpExecutable;
				process.StartInfo.Arguments = stringBuilder.ToString();
				process.StartInfo.EnvironmentVariables["PGPASSWORD"] = val.get_Password();
				process.StartInfo.UseShellExecute = false;
				process.Start();
				process.WaitForExit();
				if (process.ExitCode != 0)
				{
					Logger.Log.Error("Error backup database. Process exit code is " + process.ExitCode);
					throw new InvalidOperationException(SR.T("Не удалось создать резервную копию базы данных в файл {0}. Процесс завершился с кодом {1}.", text, process.ExitCode));
				}
				Logger.Log.Info("Backup database done.");
				return text;
			}
			catch (Win32Exception)
			{
				throw new InvalidOperationException(SR.T("Ошибка при запуске утилиты \"{0}\" - исполняемый файл недоступен.", pathToBackupUtil));
			}
		}
		return "";
	}

	public override DateTime GetDateTimeNow()
	{
		return Convert.ToDateTime(ExecuteScalar("select " + Dialect.CurrentTimestamp));
	}

	public override DateTime GetUtcDateTimeNow()
	{
		return Convert.ToDateTime(ExecuteScalar("select " + Dialect.CurrentUtcTimestamp + " at time zone 'UTC'"));
	}

	private bool? IsUsingBuiltinPostgreSQL(string connectionString)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		if (!ComponentManager.Initialized)
		{
			return null;
		}
		PackageService packageService = ComponentManager.Current.PackageService;
		PostgreSQLComponent postgreSQLComponent = (packageService.Initialized ? (packageService.GetComponent("PostgreSQL") as PostgreSQLComponent) : null);
		if (postgreSQLComponent != null && postgreSQLComponent.IsInstalled())
		{
			PostgreSQLSettings postgreSQLSettings = postgreSQLComponent.LoadSettings();
			connectionString = PostgreSQLProvider.UpdateConnectionString(connectionString);
			NpgsqlConnectionStringBuilder val = new NpgsqlConnectionStringBuilder(connectionString);
			return new string[2] { "localhost", "127.0.0.1" }.Contains(val.get_Host().ToLower()) && val.get_Port() == postgreSQLSettings.Port;
		}
		return false;
	}

	private string GetBuiltinPgDumpPath()
	{
		if (ComponentManager.Initialized)
		{
			PackageService packageService = ComponentManager.Current.PackageService;
			PostgreSQLComponent postgreSQLComponent = (packageService.Initialized ? (packageService.GetComponent("PostgreSQL") as PostgreSQLComponent) : null);
			if (postgreSQLComponent != null && postgreSQLComponent.IsInstalled())
			{
				return Path.Combine(postgreSQLComponent.ComponentRoot, "bin", "pg_dump.exe");
			}
		}
		return "";
	}

	private string GetPgDumpExecutable(string connectionString)
	{
		bool? flag = IsUsingBuiltinPostgreSQL(connectionString);
		if (!flag.HasValue)
		{
			return "";
		}
		if (!flag.Value)
		{
			return pathToBackupUtil;
		}
		return GetBuiltinPgDumpPath();
	}

	private string FindIndexes(string tableName = null, string indexName = null, bool selectCount = false)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(selectCount ? "select count(*) " : "select ci.relname as indexname, ct.relname as tablename ");
		stringBuilder.Append("from pg_index i\r\n                            left join pg_class ct on i.indrelid = ct.oid\r\n                            left join pg_class ci on i.indexrelid = ci.oid\r\n                            join pg_namespace ns on ct.relnamespace = ns.oid\r\n                        where not i.indisprimary and ns.nspname = 'public' ");
		if (tableName != null && !string.IsNullOrWhiteSpace(tableName))
		{
			stringBuilder.Append($" and upper(ct.relname) = '{tableName.ToUpper()}' ");
		}
		if (indexName != null && !string.IsNullOrWhiteSpace(indexName))
		{
			stringBuilder.Append($" and upper(ci.relname) = '{indexName.ToUpper()}' ");
		}
		return stringBuilder.ToString();
	}

	private string GetSchemaName()
	{
		string result = "";
		string sql = "SELECT CURRENT_SCHEMA()";
		using IDataReader dataReader = ExecuteQuery(sql);
		if (dataReader.Read())
		{
			return dataReader[0].ToString();
		}
		return result;
	}

	private Exception GetInnerPostgresException(Exception exception)
	{
		while (exception != null && !(exception is PostgresException))
		{
			exception = exception.InnerException;
		}
		return exception;
	}

	private string SysObjectName(string name)
	{
		if (name.StartsWith("^^") && name.EndsWith("^^"))
		{
			name = Dialect.RemoveUnQuote(name).ToLower();
		}
		else if (!Dialect.IsReservedWord(name))
		{
			name = name.ToLower();
		}
		return name;
	}

	public override long[] ReserveIds(int count, string tableName)
	{
		return ReserveIds(count, tableName, null, delegate
		{
			long[] array = new long[count];
			string sql = $"select nextval('G_{tableName}') from generate_series(1, :cnt)";
			using IDataReader dataReader = ExecuteQuery(sql, new Dictionary<string, object> { { "cnt", count } });
			int num = 0;
			while (dataReader.Read())
			{
				long num2 = Convert.ToInt64(dataReader[0]);
				array[num++] = num2;
			}
			return array;
		});
	}

	public override void BulkInsert(string tableName, DataTable data)
	{
		TransformIntoServerDateTime(data);
		BulkInsert(tableName, data, shouldGenerateId: true);
	}

	public override void BulkInsert(string tableName, DataTable data, bool shouldGenerateId)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		ValueTaskAwaiter awaiter = BulkInsertAsync(tableName, data, shouldGenerateId, isAsync: false).GetAwaiter();
		((ValueTaskAwaiter)(ref awaiter)).GetResult();
	}

	public override Task BulkInsertAsync(string tableName, DataTable data, CancellationToken cancellationToken = default(CancellationToken))
	{
		cancellationToken.ThrowIfCancellationRequested();
		TransformIntoServerDateTime(data);
		return BulkInsertAsync(tableName, data, shouldGenerateId: true, cancellationToken);
	}

	public override Task BulkInsertAsync(string tableName, DataTable data, bool shouldGenerateId, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkInsertAsync(tableName, data, shouldGenerateId, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CBulkInsertAsync_003Ed__112))]
	private System.Threading.Tasks.ValueTask BulkInsertAsync(string tableName, DataTable data, bool shouldGenerateId, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		_003CBulkInsertAsync_003Ed__112 _003CBulkInsertAsync_003Ed__ = default(_003CBulkInsertAsync_003Ed__112);
		_003CBulkInsertAsync_003Ed__._003C_003E4__this = this;
		_003CBulkInsertAsync_003Ed__.tableName = tableName;
		_003CBulkInsertAsync_003Ed__.data = data;
		_003CBulkInsertAsync_003Ed__.shouldGenerateId = shouldGenerateId;
		_003CBulkInsertAsync_003Ed__.isAsync = isAsync;
		_003CBulkInsertAsync_003Ed__.cancellationToken = cancellationToken;
		_003CBulkInsertAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
		_003CBulkInsertAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder _003C_003Et__builder = _003CBulkInsertAsync_003Ed__._003C_003Et__builder;
		((AsyncValueTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CBulkInsertAsync_003Ed__112>(ref _003CBulkInsertAsync_003Ed__);
		return ((AsyncValueTaskMethodBuilder)(ref _003CBulkInsertAsync_003Ed__._003C_003Et__builder)).get_Task();
	}

	public override void BulkUpdate(string tableName, DataTable data)
	{
		BulkUpdate(tableName, data, "Uid");
	}

	public override void BulkUpdate(string tableName, DataTable data, string keyColumn)
	{
		BulkUpdate(tableName, data, new List<ColumnLink>
		{
			new ColumnLink(keyColumn)
		});
	}

	public override void BulkUpdate(string tableName, DataTable data, List<ColumnLink> keyColumns)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		ValueTaskAwaiter awaiter = BulkUpdateAsync(tableName, data, keyColumns, isAsync: false).GetAwaiter();
		((ValueTaskAwaiter)(ref awaiter)).GetResult();
	}

	public override Task BulkUpdateAsync(string tableName, DataTable data, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkUpdateAsync(tableName, data, "Uid", cancellationToken);
	}

	public override Task BulkUpdateAsync(string tableName, DataTable data, string keyColumn, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkUpdateAsync(tableName, data, new List<ColumnLink>
		{
			new ColumnLink(keyColumn)
		}, cancellationToken);
	}

	public override Task BulkUpdateAsync(string tableName, DataTable data, List<ColumnLink> keyColumns, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkUpdateAsync(tableName, data, keyColumns, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CBulkUpdateAsync_003Ed__119))]
	private System.Threading.Tasks.ValueTask BulkUpdateAsync(string tableName, DataTable data, List<ColumnLink> keyColumns, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		_003CBulkUpdateAsync_003Ed__119 _003CBulkUpdateAsync_003Ed__ = default(_003CBulkUpdateAsync_003Ed__119);
		_003CBulkUpdateAsync_003Ed__._003C_003E4__this = this;
		_003CBulkUpdateAsync_003Ed__.tableName = tableName;
		_003CBulkUpdateAsync_003Ed__.data = data;
		_003CBulkUpdateAsync_003Ed__.keyColumns = keyColumns;
		_003CBulkUpdateAsync_003Ed__.isAsync = isAsync;
		_003CBulkUpdateAsync_003Ed__.cancellationToken = cancellationToken;
		_003CBulkUpdateAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
		_003CBulkUpdateAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder _003C_003Et__builder = _003CBulkUpdateAsync_003Ed__._003C_003Et__builder;
		((AsyncValueTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CBulkUpdateAsync_003Ed__119>(ref _003CBulkUpdateAsync_003Ed__);
		return ((AsyncValueTaskMethodBuilder)(ref _003CBulkUpdateAsync_003Ed__._003C_003Et__builder)).get_Task();
	}

	private void BulkUpdateProcessColumn(string tableName, NpgsqlCommand cmd, string columnName, NpgsqlDbType valueType, object[] valueArray, List<string> sets, List<string> clauses, List<string> values, List<ColumnLink> keyColumns, string valuesPgType, int paramName)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		string text = CreateParamName(paramName);
		cmd.get_Parameters().Add(text, (NpgsqlDbType)(int.MinValue | valueType));
		((DbParameter)(object)cmd.get_Parameters().get_Item(text)).Value = valueArray;
		if (keyColumns.FirstOrDefault((ColumnLink a) => a.Column == columnName) == null)
		{
			sets.Add(string.Format("{0} = {1}.{0}", Dialect.QuoteIfNeeded(columnName), "dataUpdate"));
			values.Add($"unnest(:{text}::{valuesPgType}) as {Dialect.QuoteIfNeeded(columnName)}");
		}
		else
		{
			clauses.Add(string.Format("{0}.{1} = {2}.{1}", tableName, Dialect.QuoteIfNeeded(columnName), "dataUpdate"));
			values.Add($"unnest(:{text}::{valuesPgType}) as {Dialect.QuoteIfNeeded(columnName)}");
		}
	}

	public override int BulkDelete(BulkDeleteArg arg)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		return BulkDeleteAsync(arg, isAsync: false).GetAwaiter().GetResult();
	}

	public override Task<int> BulkDeleteAsync(BulkDeleteArg arg, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkDeleteAsync(arg, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CBulkDeleteAsync_003Ed__123))]
	private System.Threading.Tasks.ValueTask<int> BulkDeleteAsync(BulkDeleteArg arg, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CBulkDeleteAsync_003Ed__123 _003CBulkDeleteAsync_003Ed__ = default(_003CBulkDeleteAsync_003Ed__123);
		_003CBulkDeleteAsync_003Ed__._003C_003E4__this = this;
		_003CBulkDeleteAsync_003Ed__.arg = arg;
		_003CBulkDeleteAsync_003Ed__.isAsync = isAsync;
		_003CBulkDeleteAsync_003Ed__.cancellationToken = cancellationToken;
		_003CBulkDeleteAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CBulkDeleteAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CBulkDeleteAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CBulkDeleteAsync_003Ed__123>(ref _003CBulkDeleteAsync_003Ed__);
		return _003CBulkDeleteAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	protected override void BeforeOpenConnection(IDbConnection dbConnection)
	{
		((DbConnection)dbConnection).StateChange += PostgreSqlDriver.Connection_OnStateChange;
	}

	protected override void SetParameterValue(IDbDataParameter param, object val)
	{
		if (val != null && val.GetType().IsEnum)
		{
			int? num = val as int?;
			if (num.HasValue)
			{
				param.Value = num.Value;
				param.DbType = DbType.Int32;
				return;
			}
		}
		base.SetParameterValue(param, val);
	}
}
