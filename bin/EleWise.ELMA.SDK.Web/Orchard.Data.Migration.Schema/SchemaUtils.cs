using System;
using System.Data;

namespace Orchard.Data.Migration.Schema;

public static class SchemaUtils
{
	public static DbType ToDbType(Type type)
	{
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.String:
			return DbType.String;
		case TypeCode.Int32:
			return DbType.Int32;
		case TypeCode.DateTime:
			return DbType.DateTime;
		case TypeCode.Boolean:
			return DbType.Boolean;
		default:
		{
			if (type == typeof(Guid))
			{
				return DbType.Guid;
			}
			Enum.TryParse<DbType>(Type.GetTypeCode(type).ToString(), ignoreCase: true, out var result);
			return result;
		}
		}
	}
}
