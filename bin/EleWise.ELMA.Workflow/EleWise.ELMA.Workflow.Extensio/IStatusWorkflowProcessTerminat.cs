using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Extensions;

[ExtensionPoint(ComponentType.All)]
public interface IStatusWorkflowProcessTerminateAction
{
	string Name { get; }

	Guid Uid { get; }

	void Execute(IWorkflowInstance instance);
}
