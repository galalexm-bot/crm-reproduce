using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.IntegrationModules.Workflow.Models;

[FilterFor(typeof(IWorkflowIntegrationBookmark))]
public interface IWorkflowIntegrationBookmarkFilter : IEntityFilter
{
	[Uid("df95e299-dacd-424f-8494-cb257cd0a6f3")]
	Guid? ElementUid { get; set; }

	[Uid("a83049f3-62e5-4520-8fcb-2abca94413ca")]
	long? WorkflowInstanceId { get; set; }
}
