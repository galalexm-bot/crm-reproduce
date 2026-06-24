using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ComponentType.All)]
public interface ITypeOperations
{
	Type Type { get; }

	Guid[] Operations { get; }
}
