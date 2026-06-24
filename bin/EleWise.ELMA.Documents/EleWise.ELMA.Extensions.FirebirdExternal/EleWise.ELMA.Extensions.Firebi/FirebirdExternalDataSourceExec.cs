using System;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataSource;
using EleWise.ELMA.DataSource.ExtensionPoints;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using FirebirdSql.Data.FirebirdClient;

namespace EleWise.ELMA.Extensions.FirebirdExternal;

public class FirebirdExternalDataSourceExecutor : DataBaseExternalDataSourceExecutor
{
	protected override string Name => "Firebird";

	protected override string RetrieveSchemaQuery => "SELECT F.RDB$RELATION_NAME, F.RDB$FIELD_NAME FROM RDB$RELATION_FIELDS F JOIN RDB$RELATIONS R ON F.RDB$RELATION_NAME = R.RDB$RELATION_NAME AND R.RDB$VIEW_BLR IS NULL  AND (R.RDB$SYSTEM_FLAG IS NULL OR R.RDB$SYSTEM_FLAG = 0) ORDER BY 1, F.RDB$FIELD_POSITION;";

	public FirebirdExternalDataSourceExecutor(string connectionString)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Logger.Log.Debug($"Checking connection string on {Name} executor");
			if (string.IsNullOrEmpty(connectionString))
			{
				throw new Exception(SR.T("Connection string is null or empty"));
			}
			new FbConnectionStringBuilder(connectionString);
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
			base.TransformationProvider = new FirebirdExternalTransformationProvider(() => (IDbConnection)new FbConnection(connectionString));
			Logger.Log.Debug("Connection OK");
		}
		catch (Exception ex2)
		{
			Logger.Log.Error($"Error {Name} executor connection", ex2);
			throw new ExternalDataSourceExecutorConnectionException(Name, ex2);
		}
	}

	public FirebirdExternalDataSourceExecutor(ITransformationProviderBase transformationProvider)
		: base(transformationProvider)
	{
	}
}
[Component]
public class FirebirdExternalDataSourceExecutorCreator : IExternalDataSourceExecutorCreator
{
	public string Name => "Firebird";

	public Guid TypeUid => new Guid("{8EA66767-3F99-4919-BF45-4FDDC2FFA33E}");

	public IExternalDataSourceExecutor Create(string connectionString)
	{
		return new FirebirdExternalDataSourceExecutor(connectionString);
	}
}
