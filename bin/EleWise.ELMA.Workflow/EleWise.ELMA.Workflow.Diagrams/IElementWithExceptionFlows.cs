using System;
using System.Collections.Generic;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Diagrams.Elements;

public interface IElementWithExceptionFlows : IWorkflowElement
{
	List<FlowConnectorElement> ExceptionOutputFlows { get; }

	bool QueueExecutionTimeoutSupported { get; }

	bool CanHandleException(Exception exception);

	TimeSpan? GetQueueExecutionTimeout(IWorkflowInstance instance);
}
