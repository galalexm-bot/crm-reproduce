using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

namespace EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Toolbox;

[Component(Order = 110)]
internal class IntegrationModulesPanel : IBPMNToolboxItemPanel
{
	public static readonly Guid UID = new Guid("{B0DD84C4-B355-4639-BC8C-EAF5BCB9BAB3}");

	public Guid PanelUid => UID;

	public string Title => SR.T("Интеграции");

	public Image Image => null;
}
