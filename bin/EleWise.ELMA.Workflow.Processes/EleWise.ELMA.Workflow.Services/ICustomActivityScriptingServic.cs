using System.Collections.Generic;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.CustomActivity;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface ICustomActivityScriptingService
{
	object GetScriptInstance(ICustomActivityHeader customActivityHeader);

	object ExecuteScript(ICustomActivityHeader customActivityHeader, string scriptName, Dictionary<string, object> parameters = null, WorkflowInstanceContext wfContext = null, CustomActivityElement caElement = null);
}
