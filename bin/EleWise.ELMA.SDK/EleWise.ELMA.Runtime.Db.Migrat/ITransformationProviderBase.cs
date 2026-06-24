using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public interface ITransformationProviderBase : IDisposable
{
	IDbConnection Connection { get; }

	string ParameterSeparator { get; }

	Dialect Dialect { get; }

	void BeginTransaction();

	void RollbackTransaction();

	void CommitTransaction();

	string SetupFetchOptions(string query, FetchOptions fetchOptions);

	string SetupFetchOptions(string query, FetchOptions fetchOptions, bool quoteIfNeededSortExpression);

	string GuidQuerySintaxis(Guid guid);

	IDataReader ExecuteQuery(string sql, Dictionary<string, object> paramValues = null);

	void ExecuteWithTimeout(int timeout, Action action);

	object ExecuteScalar(string sql, Dictionary<string, object> paramValues = null);

	string Count(string query);

	bool IsSortableDataColumn(DataColumn column);
}
