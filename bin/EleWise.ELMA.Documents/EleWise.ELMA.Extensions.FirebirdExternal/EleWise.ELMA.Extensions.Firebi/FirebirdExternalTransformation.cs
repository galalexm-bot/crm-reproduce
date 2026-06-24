using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using FirebirdSql.Data.FirebirdClient;

namespace EleWise.ELMA.Extensions.FirebirdExternal;

public class FirebirdExternalTransformationProvider : ExternalTransformationProvider
{
	private Dialect dialect;

	private static IUnitOfWorkManager unitOfWorkManager;

	private const int DeadlockErrorNumber = 335544336;

	private const string SqlGetAllForeignKeys = "SELECT\r\n    detail_relation_constraints.rdb$relation_name AS table_name,\r\n    detail_relation_constraints.rdb$constraint_name AS fk_name,\r\n    detail_index_segments.rdb$field_name AS field_name,\r\n    master_relation_constraints.rdb$relation_name AS ref_table,\r\n    master_index_segments.rdb$field_name AS ref_field\r\n\r\nFROM\r\n    rdb$relation_constraints detail_relation_constraints\r\n    JOIN rdb$index_segments detail_index_segments ON detail_relation_constraints.rdb$index_name = detail_index_segments.rdb$index_name \r\n    JOIN rdb$ref_constraints ON detail_relation_constraints.rdb$constraint_name = rdb$ref_constraints.rdb$constraint_name -- Master indeksas\r\n    JOIN rdb$relation_constraints master_relation_constraints ON rdb$ref_constraints.rdb$const_name_uq = master_relation_constraints.rdb$constraint_name\r\n    JOIN rdb$index_segments master_index_segments ON master_relation_constraints.rdb$index_name = master_index_segments.rdb$index_name \r\n\r\nWHERE\r\n    detail_relation_constraints.rdb$constraint_type = 'FOREIGN KEY'";

	private const string SqlGetAllPrimaryKeys = "SELECT DISTINCT RDB$RELATION_CONSTRAINTS.rdb$relation_name, RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_NAME\r\nFROM RDB$RELATION_CONSTRAINTS\r\nINNER JOIN RDB$INDEX_SEGMENTS ON RDB$INDEX_SEGMENTS.rdb$index_name =  RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME\r\nWHERE RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE='PRIMARY KEY'";

	private static IUnitOfWorkManager UnitOfWorkManager => unitOfWorkManager ?? (unitOfWorkManager = (Locator.Initialized ? Locator.GetService<IUnitOfWorkManager>() : null));

	public override Dialect Dialect => dialect ?? (dialect = new FirebirdDialect(GetReservedWords()));

	[Obsolete("Не использовать", true)]
	public FirebirdExternalTransformationProvider()
	{
	}

	public FirebirdExternalTransformationProvider(Func<IDbConnection> connectionCreateFunc)
		: base(connectionCreateFunc)
	{
	}

	public FirebirdExternalTransformationProvider(string connectionString)
		: base(() => (IDbConnection)new FbConnection(connectionString))
	{
	}

	public override string GuidQuerySintaxis(Guid guid)
	{
		return GuidQuerySintaxisStatic(guid);
	}

	internal static string GuidQuerySintaxisStatic(Guid guid)
	{
		string text = guid.ToString();
		string arg = $"{new string(new char[2]
		{
			text[6],
			text[7]
		})}{new string(new char[2]
		{
			text[4],
			text[5]
		})}{new string(new char[2]
		{
			text[2],
			text[3]
		})}{new string(new char[2]
		{
			text[0],
			text[1]
		})}-{new string(new char[2]
		{
			text[11],
			text[12]
		})}{new string(new char[2]
		{
			text[9],
			text[10]
		})}-{new string(new char[2]
		{
			text[16],
			text[17]
		})}{new string(new char[2]
		{
			text[14],
			text[15]
		})}-{text.Split('-')[3]}-{text.Split('-')[4]}";
		return $"char_to_uuid('{arg}')";
	}

	public override List<string> GetTables()
	{
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery("SELECT RDB$RELATIONS.RDB$RELATION_NAME\r\nFROM RDB$RELATIONS\r\nWHERE RDB$RELATIONS.RDB$SYSTEM_FLAG = 0  AND RDB$RELATION_TYPE = 0\r\norder by RDB$RELATION_NAME");
		while (dataReader.Read())
		{
			list.Add(((string)dataReader["RDB$RELATION_NAME"]).Trim());
		}
		return list;
	}

	public override int ExecuteNonQuery(string sql, Dictionary<string, object> paramValues = null)
	{
		Contract.ArgumentNotNull(sql, "sql");
		Contract.ArgumentNotNullOrEmpty(sql, "sql");
		paramValues = paramValues ?? new Dictionary<string, object>();
		return ExecuteNonQuery(sql, paramValues.Keys.ToArray(), paramValues.Values.ToArray());
	}

	public override string SetupFetchOptions(string query, FetchOptions fetchOptions, bool quoteIfNeededSortExpression)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("SELECT");
		bool num = fetchOptions != null && fetchOptions != FetchOptions.All;
		bool flag = fetchOptions != null && (!string.IsNullOrEmpty(fetchOptions.SortExpression) || fetchOptions.SortDescriptors.Any());
		if (num)
		{
			stringBuilder.Append(" FIRST ");
			stringBuilder.Append(fetchOptions.MaxResults);
			stringBuilder.Append(" SKIP ");
			stringBuilder.Append(fetchOptions.FirstResult);
		}
		stringBuilder.Append(" ");
		stringBuilder.Append(query);
		if (flag)
		{
			stringBuilder.Append(" ORDER BY ");
			if (!fetchOptions.SortDescriptors.Any())
			{
				fetchOptions.SortDescriptors.Add(new FetchOptionsSortDescriptor(fetchOptions.SortExpression, fetchOptions.SortDirection));
			}
			IEnumerable<string> values = fetchOptions.SortDescriptors.Select((FetchOptionsSortDescriptor sd) => string.Format("{0} {1}", quoteIfNeededSortExpression ? QuoteIfNeeded(sd.SortExpression) : sd.SortExpression, (sd.SortDirection == ListSortDirection.Descending) ? "DESC" : ""));
			stringBuilder.Append(string.Join(", ", values));
		}
		return stringBuilder.ToString();
	}

	public override string Count(string query)
	{
		return string.Format("SELECT COUNT(*) FROM ({0}) {1}", query, QuoteIfNeeded("count_tabl"));
	}

	private bool IsUnrecoverableException(Exception ex)
	{
		if (ex == null)
		{
			return false;
		}
		Exception ex2 = ex;
		while (ex2 != null && !(ex2 is FbException))
		{
			ex2 = ex2.InnerException;
		}
		FbException val = (FbException)(object)((ex2 is FbException) ? ex2 : null);
		if (val == null)
		{
			return false;
		}
		return ((ExternalException)(object)val).ErrorCode == 335544336;
	}

	protected virtual int ExecuteNonQuery(string sql, IReadOnlyList<string> paramNames, IReadOnlyList<object> paramValues)
	{
		Contract.ArgumentNotNullOrEmpty(sql, "sql");
		using IDbCommand dbCommand = BuildCommand(sql);
		if (paramNames != null && paramValues != null)
		{
			for (int i = 0; i < paramNames.Count; i++)
			{
				if (paramValues.Count > i)
				{
					string text = paramNames[i];
					object obj = paramValues[i];
					if (paramValues[i] == null || !(obj is Generator generator))
					{
						AddParameter(dbCommand, text, obj);
					}
					else
					{
						dbCommand.CommandText = dbCommand.CommandText.Replace(ParameterSeparator + text, generator.SqlCode);
					}
				}
			}
		}
		try
		{
			return dbCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProcessException(ex);
			throw new DataException(SR.T("Не удалось выполнить запрос {0}", sql), ex);
		}
	}

	private void ProcessException(Exception ex)
	{
		if (IsUnrecoverableException(ex) && UnitOfWorkManager != null)
		{
			UnitOfWorkManager.ThrowExceptionOnCommit(ex);
		}
	}

	public override IDictionary<string, PrimaryKey> GetAllPrimaryKeys()
	{
		Dictionary<string, PrimaryKey> dictionary = new Dictionary<string, PrimaryKey>();
		using IDataReader dataReader = ExecuteQuery("SELECT DISTINCT RDB$RELATION_CONSTRAINTS.rdb$relation_name, RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_NAME\r\nFROM RDB$RELATION_CONSTRAINTS\r\nINNER JOIN RDB$INDEX_SEGMENTS ON RDB$INDEX_SEGMENTS.rdb$index_name =  RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME\r\nWHERE RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE='PRIMARY KEY'");
		while (dataReader.Read())
		{
			string text = ((string)dataReader["RDB$RELATION_NAME"]).Trim();
			if (!dictionary.TryGetValue(text, out var value))
			{
				value = new PrimaryKey
				{
					TableName = text,
					Name = ((string)dataReader["RDB$CONSTRAINT_NAME"]).Trim(),
					Columns = new List<string>()
				};
				dictionary.Add(text, value);
			}
			value.Columns.Add(((string)dataReader["RDB$RELATION_NAME"]).Trim());
		}
		return dictionary;
	}

	public override IList<ForeignKey> GetForeignKeys()
	{
		List<ForeignKey> list = new List<ForeignKey>();
		using IDataReader dataReader = ExecuteQuery("SELECT\r\n    detail_relation_constraints.rdb$relation_name AS table_name,\r\n    detail_relation_constraints.rdb$constraint_name AS fk_name,\r\n    detail_index_segments.rdb$field_name AS field_name,\r\n    master_relation_constraints.rdb$relation_name AS ref_table,\r\n    master_index_segments.rdb$field_name AS ref_field\r\n\r\nFROM\r\n    rdb$relation_constraints detail_relation_constraints\r\n    JOIN rdb$index_segments detail_index_segments ON detail_relation_constraints.rdb$index_name = detail_index_segments.rdb$index_name \r\n    JOIN rdb$ref_constraints ON detail_relation_constraints.rdb$constraint_name = rdb$ref_constraints.rdb$constraint_name -- Master indeksas\r\n    JOIN rdb$relation_constraints master_relation_constraints ON rdb$ref_constraints.rdb$const_name_uq = master_relation_constraints.rdb$constraint_name\r\n    JOIN rdb$index_segments master_index_segments ON master_relation_constraints.rdb$index_name = master_index_segments.rdb$index_name \r\n\r\nWHERE\r\n    detail_relation_constraints.rdb$constraint_type = 'FOREIGN KEY'");
		while (dataReader.Read())
		{
			string tableName = ((string)dataReader["table_name"]).Trim();
			ForeignKey foreignKey = new ForeignKey
			{
				Name = ((string)dataReader["fk_name"]).Trim(),
				TableName = tableName,
				RefTableName = ((string)dataReader["ref_table"]).Trim()
			};
			foreignKey.Columns.Add(((string)dataReader["field_name"]).Trim());
			foreignKey.RefColumns.Add(((string)dataReader["ref_field"]).Trim());
			list.Add(foreignKey);
		}
		return list;
	}

	public override List<string> GetViews()
	{
		List<string> list = new List<string>();
		using IDataReader dataReader = ExecuteQuery("SELECT RDB$RELATIONS.RDB$RELATION_NAME\r\nFROM RDB$RELATIONS\r\nWHERE RDB$RELATIONS.RDB$SYSTEM_FLAG = 0 AND RDB$RELATIONS.RDB$VIEW_SOURCE IS NOT NULL");
		while (dataReader.Read())
		{
			list.Add(((string)dataReader["RDB$RELATION_NAME"]).Trim());
		}
		return list;
	}
}
