using System.Collections.Generic;
using System.Data.Common;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using NHibernate.Dialect.Schema;

namespace EleWise.ELMA.Extensions.PostgreSQL;

public class NHPostgreSQLDataBaseSchema : PostgreSQLDataBaseMetadata
{
	private HashSet<string> reservedWords = new HashSet<string>();

	private bool init;

	public NHPostgreSQLDataBaseSchema(DbConnection connection)
		: base(connection)
	{
	}

	public override ISet<string> GetReservedWords()
	{
		if (init)
		{
			return reservedWords;
		}
		reservedWords = new HashSet<string>();
		IRuntimeApplication serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
		reservedWords.AddAll(serviceNotNull.TransformationProvider.Dialect.ReservedWords);
		init = true;
		return reservedWords;
	}
}
