using System;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Content.Db.PostgreSQL;

public class ContentDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => PostgreSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Content.Db.ContentDbStructure);
}
