using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface IExternalWorkflowRuntimeService
{
	bool TryRun(IWorkflowInstance workflowInstance, bool initiatorSwimlaneUser, bool isEmulation);

	bool TryExecute(IWorkflowBookmark workflowBookmark, string typeName, Dictionary<string, string> data);

	bool TryTerminate(IWorkflowInstance workflowInstance, string reason);
}
