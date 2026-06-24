using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.Diagrams.Activities;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowActivityInfo
{
	Type ActivityType { get; }

	Type DiagramElementType { get; }
}
