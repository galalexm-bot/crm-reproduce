using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

[ExtensionPoint(ComponentType.All)]
public interface ICustomActivityMap
{
	Type EntityType { get; }

	Type DTOType { get; }
}
