using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IMetricValueData))]
public interface IMetricValueDataFilter : IEntityFilter
{
	IWorkflowInstance WorkflowInstance { get; set; }

	Guid? MetricUid { get; set; }
}
