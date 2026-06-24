using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
internal interface IWorkflowExecuteDataHandler
{
	string TypeName { get; }

	bool Check(IWorkflowExecuteData data);

	Dictionary<string, string> ConvertData(IWorkflowExecuteData data);
}
