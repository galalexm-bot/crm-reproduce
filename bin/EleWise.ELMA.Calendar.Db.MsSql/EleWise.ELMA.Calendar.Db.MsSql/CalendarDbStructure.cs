using System;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Calendar.Db.MsSql;

internal class CalendarDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Calendar.Db.CalendarDbStructure);
}
