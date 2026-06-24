using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using NHibernate.Engine;

namespace EleWise.ELMA.History.Db.MsSql;

internal sealed class MsSqlQueryTableType : QueryTableType
{
	public MsSqlQueryTableType(string typeName, Func<string, string> getSysObjectName)
		: base(typeName, getSysObjectName)
	{
	}

	public override void NullSafeSet(DbCommand st, object value, int index, ISessionImplementor session)
	{
		if (st is SqlCommand sqlCommand && value is DataTable dataTable)
		{
			TransformIntoServerDateTime(dataTable);
			sqlCommand.Parameters[index].SqlDbType = SqlDbType.Structured;
			sqlCommand.Parameters[index].TypeName = SysObjectNameFunc(TypeName);
			sqlCommand.Parameters[index].Value = dataTable;
			return;
		}
		throw new NotImplementedException();
	}
}
