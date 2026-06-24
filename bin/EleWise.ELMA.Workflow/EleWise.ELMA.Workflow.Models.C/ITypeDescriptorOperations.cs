using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[ExtensionPoint(ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ITypeDescriptorOperations
{
	ITypeDescriptor Descriptor { get; }

	IEnumerable<IOperation> Operations { get; }
}
