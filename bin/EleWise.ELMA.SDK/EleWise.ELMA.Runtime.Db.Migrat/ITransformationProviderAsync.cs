using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public interface ITransformationProviderAsync : ITransformationProvider, ITransformationProviderBase, IDisposable
{
	Task<IDataReader> ExecuteQueryAsync(string sql, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken));

	Task<int> ExecuteNonQueryAsync(string sql, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken));

	Task<object> ExecuteScalarAsync(string sql, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken));

	Task<int> InsertAsync(string table, string[] columns, object[] values, CancellationToken cancellationToken = default(CancellationToken));

	Task<int> InsertAsync(string table, string[] columns, object[] values, bool isNeedInsertId, CancellationToken cancellationToken = default(CancellationToken));

	Task<int> InsertAsync(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken));

	Task<int> UpdateAsync(string table, string[] columns, object[] values, string where, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken));

	Task ExecuteWithTimeoutAsync(int timeout, Func<Task> action);

	Task BulkInsertAsync(string tableName, DataTable data, CancellationToken cancellationToken = default(CancellationToken));

	Task BulkInsertAsync(string tableName, DataTable data, bool shouldGenerateId, CancellationToken cancellationToken = default(CancellationToken));

	Task BulkUpdateAsync(string tableName, DataTable data, CancellationToken cancellationToken = default(CancellationToken));

	Task BulkUpdateAsync(string tableName, DataTable data, string keyColumn, CancellationToken cancellationToken = default(CancellationToken));

	Task BulkUpdateAsync(string tableName, DataTable data, List<ColumnLink> keyColumns, CancellationToken cancellationToken = default(CancellationToken));

	Task<int> BulkDeleteAsync(string table, string where, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken));

	Task<int> BulkDeleteAsync(BulkDeleteArg arg, CancellationToken cancellationToken = default(CancellationToken));
}
