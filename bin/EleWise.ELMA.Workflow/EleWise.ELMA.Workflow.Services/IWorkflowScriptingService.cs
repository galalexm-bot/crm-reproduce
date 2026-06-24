using System;
using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface IWorkflowScriptingService
{
	object GetScriptInstance(IWorkflowInstance instance);

	object ExecuteScript(IWorkflowInstance instance, string scriptName, Dictionary<string, object> parameters = null, Func<string, Type, object> parameterAccessor = null);
}
