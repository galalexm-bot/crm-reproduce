using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IWorkflowProcessListRunning))]
public interface IWorkflowProcessListRunningFilter : IEntityFilter
{
	Guid? TypeObject { get; set; }

	IProcessHeader ProcessHeader { get; set; }

	bool? IsParent { get; set; }

	Guid? RootMetadata { get; set; }
}
