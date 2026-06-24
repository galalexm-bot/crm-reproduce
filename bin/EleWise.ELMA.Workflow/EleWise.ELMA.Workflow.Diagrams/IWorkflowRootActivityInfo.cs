using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.Diagrams.Activities;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowRootActivityInfo
{
	Type ActivityType { get; }

	Type DiagramType { get; }
}
