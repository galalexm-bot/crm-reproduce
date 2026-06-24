using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

[ExtensionPoint(ComponentType.All)]
public interface IToolboxElementGroup
{
	ICollection<IBPMNToolboxItemGroup> GetGroups();

	ICollection<ToolboxElement> GetElements();
}
