using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

namespace EleWise.ELMA.RPA.BPMN.Diagrams.Toolbox;

[Component(Order = 350)]
public class RPAProcessesElements : IBPMNToolboxItemGroup, IToolboxItemGroup
{
	public static readonly Guid UID = new Guid("{DB00E63F-7D26-41A0-B785-31BB2B651199}");

	public Guid PanelUid => BPMNGroups.BPMNPanel.UID;

	public Guid GroupUid => UID;

	public Guid ParentGroupUid => Guid.Empty;

	public string Name => SR.T("Процессы RPA");
}
