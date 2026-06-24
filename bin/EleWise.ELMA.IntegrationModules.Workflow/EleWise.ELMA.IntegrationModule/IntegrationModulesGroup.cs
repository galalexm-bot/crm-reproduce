using System;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

namespace EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Toolbox;

internal class IntegrationModulesGroup : IBPMNToolboxItemGroup, IToolboxItemGroup
{
	private Guid groupUid;

	private Guid parentGroupUid;

	private string name;

	public static readonly Guid UID = new Guid("{991EE39A-DDDB-4009-AF72-17B645003E0D}");

	public Guid PanelUid => IntegrationModulesPanel.UID;

	public Guid GroupUid => groupUid;

	public Guid ParentGroupUid => parentGroupUid;

	public string Name => name;

	public IntegrationModulesGroup(Guid groupUid, Guid parentGroupUid, string name)
	{
		this.groupUid = groupUid;
		this.parentGroupUid = parentGroupUid;
		this.name = name;
	}
}
