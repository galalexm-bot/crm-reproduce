using System;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH.CustomTypes;

namespace EleWise.ELMA.Extensions.PostgreSQL.NH;

internal sealed class PostgreSqlStreamNHType : StreamNHType
{
	internal sealed class PostgreSqlStreamNHTypeRegistrar : NHProviderDependentUserTypeRegistrar<PostgreSqlStreamNHType, StreamNHType>
	{
		public override Guid ProviderUid { get; } = PostgreSQLProvider.UID;

	}
}
