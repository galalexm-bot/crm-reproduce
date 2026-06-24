using System;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.History.Db.MsSql;

internal sealed class HistoryDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.History.Db.HistoryDbStructure);
}
