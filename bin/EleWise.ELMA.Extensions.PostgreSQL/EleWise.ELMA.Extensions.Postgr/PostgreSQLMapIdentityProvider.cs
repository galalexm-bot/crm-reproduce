using System;
using EleWise.ELMA.Runtime.Db;
using NHibernate.Mapping.ByCode;

namespace EleWise.ELMA.Extensions.PostgreSQL;

internal class PostgreSQLMapIdentityProvider : MapIdentityProvider
{
	public override void SetGenerator(IIdMapper mapping, string tableName, string idColumnName)
	{
		mapping.Generator(Generators.get_Sequence(), (Action<IGeneratorMapper>)delegate(IGeneratorMapper g)
		{
			g.Params((object)new
			{
				sequence = "G_" + tableName
			});
		});
	}
}
