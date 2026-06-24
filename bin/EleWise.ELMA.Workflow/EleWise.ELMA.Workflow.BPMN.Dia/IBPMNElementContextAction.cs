using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IBPMNElementContextAction
{
	Guid ActionUid { get; }

	string Text { get; }

	string Image { get; }

	bool IsSupported(Type type);
}
