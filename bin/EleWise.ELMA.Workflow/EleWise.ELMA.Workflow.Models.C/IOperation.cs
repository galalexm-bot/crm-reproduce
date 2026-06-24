using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Workflow.Models.Enums;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ComponentType.All)]
public interface IOperation
{
	Guid Uid { get; }

	string Name { get; }

	string Description { get; }

	string OperationString { get; }

	bool CanShow { get; }

	TypeOperationEnum OperationType { get; }

	bool CanExecute(ITypeDescriptor descriptor, object left, object right);

	bool Execute(ITypeDescriptor descriptor, object left, object right);
}
