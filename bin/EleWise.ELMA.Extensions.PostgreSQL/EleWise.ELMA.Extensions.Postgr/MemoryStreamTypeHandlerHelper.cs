using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Memory;
using Npgsql.TypeHandling;
using Npgsql.TypeMapping;
using NpgsqlTypes;

namespace EleWise.ELMA.Extensions.PostgreSQL.TypeHandlers;

internal static class MemoryStreamTypeHandlerHelper
{
	public static NpgsqlTypeMapping[] Mappings { get; }

	static MemoryStreamTypeHandlerHelper()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		List<Type> list = (from type in typeof(IComponentManager).Assembly.GetTypes()
			where TypeOf<MemoryStream>.Raw.IsAssignableFrom(type)
			select type).ToList();
		using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
		{
			list.Add(memoryStream.GetType());
		}
		list.Add(typeof(MemoryStream));
		list.Add(typeof(byte[]));
		list.Add(typeof(ArraySegment<byte>));
		NpgsqlTypeMapping[] array = new NpgsqlTypeMapping[1];
		NpgsqlTypeMappingBuilder val = new NpgsqlTypeMappingBuilder();
		val.set_PgTypeName("bytea");
		val.set_NpgsqlDbType((NpgsqlDbType?)(NpgsqlDbType)4);
		val.set_ClrTypes(list.ToArray());
		val.set_InferredDbType((DbType?)DbType.Binary);
		val.set_TypeHandlerFactory((NpgsqlTypeHandlerFactory)(object)new MemoryStreamTypeHandlerFactory());
		array[0] = val.Build();
		Mappings = (NpgsqlTypeMapping[])(object)array;
	}
}
