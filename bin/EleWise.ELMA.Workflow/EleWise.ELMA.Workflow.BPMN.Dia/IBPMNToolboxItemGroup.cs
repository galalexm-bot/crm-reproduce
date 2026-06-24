using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams.Toolbox;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

[ExtensionPoint(ComponentType.All)]
public interface IBPMNToolboxItemGroup : IToolboxItemGroup
{
	Guid PanelUid { get; }
}
