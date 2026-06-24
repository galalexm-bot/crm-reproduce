using System;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Security.Db.MsSql;

internal class SecurityDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Security.Db.SecurityDbStructure);
}
