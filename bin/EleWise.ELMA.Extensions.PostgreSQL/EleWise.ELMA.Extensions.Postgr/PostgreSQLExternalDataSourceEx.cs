using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataSource;
using EleWise.ELMA.DataSource.ExtensionPoints;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using Npgsql;

namespace EleWise.ELMA.Extensions.PostgreSQL;

public class PostgreSQLExternalDataSourceExecutor : DataBaseExternalDataSourceExecutor
{
	protected override string Name => "PostgreSQL";

	protected override string RetrieveSchemaQuery => "SELECT C.TABLE_NAME, C.COLUMN_NAME FROM INFORMATION_SCHEMA.TABLES AS T JOIN INFORMATION_SCHEMA.COLUMNS AS C ON T.TABLE_NAME=C.TABLE_NAME WHERE T.TABLE_TYPE='BASE TABLE' ORDER BY 1, C.ORDINAL_POSITION";

	public PostgreSQLExternalDataSourceExecutor(string connectionString)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Logger.Log.Debug($"Checking connection string on {Name} executor");
			if (string.IsNullOrEmpty(connectionString))
			{
				throw new Exception(SR.T("Connection string is null or empty"));
			}
			connectionString = PostgreSQLProvider.UpdateConnectionString(connectionString);
			new NpgsqlConnectionStringBuilder(connectionString);
			Logger.Log.Debug("Connection string is valid");
		}
		catch (Exception ex)
		{
			Logger.Log.Error($"Connection string error on {Name} executor", ex);
			throw new ExternalDataSourceExecutorConnectionStringException(Name, ex);
		}
		try
		{
			Logger.Log.Debug($"Checking {Name} executor connection...");
			base.TransformationProvider = new PostgreSQLTransformationProvider(() => (IDbConnection)new NpgsqlConnection(connectionString));
			Logger.Log.Debug("Connection OK");
		}
		catch (Exception ex2)
		{
			Logger.Log.Error($"Error {Name} executor connection", ex2);
			throw new ExternalDataSourceExecutorConnectionException(Name, ex2);
		}
	}

	public PostgreSQLExternalDataSourceExecutor(ITransformationProvider transformationProvider)
		: base(transformationProvider)
	{
	}

	protected override Dictionary<string, object> GetPreparedParameters(string query, Dictionary<string, object> paramValues)
	{
		Dictionary<string, object> preparedParameters = base.GetPreparedParameters(query, paramValues);
		IEnumerable<string> usedParams = GetUsedParam(query);
		return preparedParameters.Where((KeyValuePair<string, object> p) => usedParams.Contains(p.Key)).ToDictionary((KeyValuePair<string, object> p) => p.Key, (KeyValuePair<string, object> p) => p.Value);
	}
}
[Component]
public class PostgreSQLExternalDataSourceExecutorCreator : IExternalDataSourceExecutorCreator
{
	public string Name => "PostgreSQL";

	public Guid TypeUid => new Guid("{C3361C79-473A-4823-BD6F-96B72089BE50}");

	public IExternalDataSourceExecutor Create(string connectionString)
	{
		return new PostgreSQLExternalDataSourceExecutor(connectionString);
	}
}
