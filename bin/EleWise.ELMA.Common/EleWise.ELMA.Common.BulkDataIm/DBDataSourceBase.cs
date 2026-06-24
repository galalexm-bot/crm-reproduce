using System;
using System.Collections.Generic;
using System.Data;

namespace EleWise.ELMA.Common.BulkDataImport.DataSources;

public abstract class DBDataSourceBase : DataSourceBase
{
	private IDbConnection connection;

	private long count = -1L;

	protected abstract IDbConnection CreateConnection();

	protected abstract string CommandText();

	protected virtual string CountCommandText()
	{
		return string.Empty;
	}

	private void InitConnection()
	{
		if (connection == null)
		{
			connection = CreateConnection();
			if (connection == null)
			{
				throw new Exception(SR.T("Не установлено соединение к базе данных"));
			}
			connection.Open();
		}
	}

	protected override DataTable ReadPackage()
	{
		InitConnection();
		DataTable dataTable = new DataTable();
		new Dictionary<string, object>();
		using IDbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = CommandText();
		dataTable.Load(dbCommand.ExecuteReader());
		return dataTable;
	}

	protected override long GetCount()
	{
		if (count >= 0)
		{
			return count;
		}
		string text = CountCommandText();
		if (string.IsNullOrEmpty(text))
		{
			return count;
		}
		InitConnection();
		using IDbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = text;
		long.TryParse(dbCommand.ExecuteScalar().ToString(), out count);
		return count;
	}

	public override void CleanUpAll()
	{
		if (connection != null)
		{
			connection.Close();
			connection.Dispose();
		}
	}
}
