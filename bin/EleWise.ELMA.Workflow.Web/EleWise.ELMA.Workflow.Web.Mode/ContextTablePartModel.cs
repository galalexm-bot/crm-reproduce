using System;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class ContextTablePartModel
{
	public WorkflowInstanceContext Context { get; set; }

	public long InstanceId { get; set; }

	public Guid ProcessHeaderUid { get; set; }

	public FormView View { get; set; }
}
