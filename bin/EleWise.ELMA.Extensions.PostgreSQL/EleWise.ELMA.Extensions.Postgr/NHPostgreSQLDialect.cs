using System.Collections.Generic;
using System.Data.Common;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using NHibernate.Dialect;
using NHibernate.Dialect.Schema;

namespace EleWise.ELMA.Extensions.PostgreSQL;

public class NHPostgreSQLDialect : PostgreSQL82Dialect
{
	public NHPostgreSQLDialect()
	{
		IRuntimeApplication serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
		RegisterExtendedKeywords(serviceNotNull.TransformationProvider.Dialect.ReservedWords);
	}

	private void RegisterExtendedKeywords(List<string> keywords)
	{
		((Dialect)this).get_Keywords().Clear();
		((Dialect)this).get_Keywords().IntersectWith(keywords);
	}

	public override IDataBaseSchema GetDataBaseSchema(DbConnection connection)
	{
		return (IDataBaseSchema)(object)new NHPostgreSQLDataBaseSchema(connection);
	}
}
