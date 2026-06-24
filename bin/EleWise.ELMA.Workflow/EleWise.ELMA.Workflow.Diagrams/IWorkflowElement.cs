using System;

namespace EleWise.ELMA.Workflow.Diagrams.Elements;

public interface IWorkflowElement
{
	Guid Uid { get; }

	string Name { get; }
}
