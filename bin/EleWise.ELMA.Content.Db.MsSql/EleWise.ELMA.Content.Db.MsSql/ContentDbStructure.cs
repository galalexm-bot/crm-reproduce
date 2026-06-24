using System;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Content.Db.MsSql;

public class ContentDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Content.Db.ContentDbStructure);
}
