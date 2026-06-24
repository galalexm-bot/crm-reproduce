using System;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Calendar.Db.PostgreSQL;

internal class CalendarDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => PostgreSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Calendar.Db.CalendarDbStructure);
}
