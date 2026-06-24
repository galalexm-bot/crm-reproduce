using System;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Workflow.Db.MsSql;

internal class WorkflowDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Workflow.Db.WorkflowDbStructure);
}
