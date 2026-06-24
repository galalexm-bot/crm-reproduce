using System;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Tasks.Db.PostgreSQL;

public class TasksDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => PostgreSQLProvider.UID;

	public override Type Parent => typeof(TaskDbStructure);
}
