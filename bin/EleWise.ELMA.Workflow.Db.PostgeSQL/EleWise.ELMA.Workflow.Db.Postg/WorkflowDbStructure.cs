using System;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Workflow.Db.PostgeSQL;

public class WorkflowDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => PostgreSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Workflow.Db.WorkflowDbStructure);
}
