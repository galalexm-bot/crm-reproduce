using System.Data;
using System.Data.Common;
using EleWise.ELMA.Extensions.PostgreSQL.TypeHandlers;
using NHibernate.Driver;
using Npgsql;
using Npgsql.TypeMapping;

namespace EleWise.ELMA.Extensions.PostgreSQL.NH;

internal sealed class PostgreSqlDriver : PostgreSqlDriver
{
	public override DbConnection CreateConnection()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Expected O, but got Unknown
		NpgsqlConnection val = (NpgsqlConnection)((ReflectionBasedDriver)this).CreateConnection();
		((DbConnection)val).StateChange += Connection_OnStateChange;
		return (DbConnection)val;
	}

	internal static void Connection_OnStateChange(object sender, StateChangeEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		if (e.CurrentState == ConnectionState.Open)
		{
			NpgsqlConnection val = (NpgsqlConnection)sender;
			NpgsqlTypeMapping[] mappings = MemoryStreamTypeHandlerHelper.Mappings;
			foreach (NpgsqlTypeMapping val2 in mappings)
			{
				val.get_TypeMapper().AddMapping(val2);
			}
			((DbConnection)(object)val).StateChange -= Connection_OnStateChange;
		}
	}
}
