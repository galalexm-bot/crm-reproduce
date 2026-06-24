using System;
using DevComponents.AdvTree;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams.Toolbox;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

[ExtensionPoint(ComponentType.All)]
public interface IBPMNToolboxNodeGroup : IToolboxNodeGroup
{
	Guid PanelUid { get; }

	new NodeCollection Nodes { get; }
}
