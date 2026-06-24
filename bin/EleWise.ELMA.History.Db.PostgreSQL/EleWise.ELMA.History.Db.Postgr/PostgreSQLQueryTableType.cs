using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Serialization;
using NHibernate.Engine;
using Npgsql;
using NpgsqlTypes;

namespace EleWise.ELMA.History.Db.PostgreSQL;

internal sealed class PostgreSQLQueryTableType : QueryTableType
{
	public PostgreSQLQueryTableType(string typeName, Func<string, string> getSysObjectName)
		: base(typeName, getSysObjectName)
	{
	}

	public override void NullSafeSet(DbCommand st, object value, int index, ISessionImplementor session)
	{
		NpgsqlCommand val;
		if ((val = (NpgsqlCommand)(object)((st is NpgsqlCommand) ? st : null)) != null && value is DataTable dataTable)
		{
			TransformIntoServerDateTime(dataTable);
			val.get_Parameters().get_Item(index).set_NpgsqlDbType((NpgsqlDbType)35);
			((DbParameter)(object)val.get_Parameters().get_Item(index)).Value = SerializeDataTableToJson(dataTable);
			return;
		}
		throw new NotImplementedException();
	}

	private string SerializeDataTableToJson(DataTable dataTable)
	{
		List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
		foreach (DataRow row in dataTable.Rows)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			foreach (DataColumn column in dataTable.Columns)
			{
				dictionary.Add(SysObjectNameFunc(column.ColumnName), row[column]);
			}
			list.Add(dictionary);
		}
		return ClassSerializationHelper.SerializeObjectByJsonNet(list);
	}
}
