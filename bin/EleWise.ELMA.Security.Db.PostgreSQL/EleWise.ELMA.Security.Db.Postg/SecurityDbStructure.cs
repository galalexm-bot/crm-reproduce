using System;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Security.Db.PostgreSQL;

internal class SecurityDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => PostgreSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Security.Db.SecurityDbStructure);
}
