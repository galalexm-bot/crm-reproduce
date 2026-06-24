using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;

[ExtensionPoint(ComponentType.All)]
public interface IBusinessRoleType
{
	Guid Uid { get; }

	string DisplayName { get; }

	Image Image { get; }
}
