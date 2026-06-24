using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowProcessMap
{
	Type EntityType { get; }

	Type DTOType { get; }
}
