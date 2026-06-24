using System;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface IInstanceMetricService
{
	void UpdateWithExecutionTime(IWorkflowInstance instance, ProcessInstanceMetric metric, TimeSpan? time);
}
