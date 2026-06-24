using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Nodes;

namespace EleWise.ELMA.DataSource;

public interface IExternalDataSourceExecutor : IDisposable
{
	IEnumerable<SchemaNode> LoadSchema();

	DataTable ExecuteQuery(string query, Dictionary<string, object> paramValues = null, FetchOptions fetchOptions = null, int? commandTimeout = null);

	long? Count(string query, Dictionary<string, object> paramValues = null);
}
