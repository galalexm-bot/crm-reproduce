using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Workflow.Models.ConditionTable;

namespace EleWise.ELMA.Workflow.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface ITypeDescriptorOperationsService
{
	bool CheckOperations(ITypeDescriptor descriptor);

	IEnumerable<IOperation> GetOperations(ITypeDescriptor descriptor);

	IOperation GetOperation(ITypeDescriptor descriptor, Guid operationUid);

	IOperation GetOperationByUid(Guid operationUid);

	IEnumerable<IOperation> GetOperations();
}
