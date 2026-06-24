using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IEmulationMessages))]
public interface IEmulationMessagesFilter : IEntityFilter
{
	Guid? ObjectUid { get; set; }

	IWorkflowInstance WorkflowInstance { get; set; }
}
