using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

[ExtensionPoint(ComponentType.All)]
public interface IBPMNToolboxItemPanel
{
	Guid PanelUid { get; }

	string Title { get; }

	Image Image { get; }
}
