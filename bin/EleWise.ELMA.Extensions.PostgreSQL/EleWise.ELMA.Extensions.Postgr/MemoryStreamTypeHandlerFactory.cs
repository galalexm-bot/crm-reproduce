using Npgsql;
using Npgsql.PostgresTypes;
using Npgsql.TypeHandling;

namespace EleWise.ELMA.Extensions.PostgreSQL.TypeHandlers;

internal sealed class MemoryStreamTypeHandlerFactory : NpgsqlTypeHandlerFactory<byte[]>
{
	public override NpgsqlTypeHandler<byte[]> Create(PostgresType pgType, NpgsqlConnection conn)
	{
		return (NpgsqlTypeHandler<byte[]>)(object)new MemoryStreamTypeHandler(pgType);
	}
}
