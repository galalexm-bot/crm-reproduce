using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.Validation;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowProcessValidate
{
	IEnumerable<ProcessValidationMessage> Validate(WorkflowProcessDTO process);
}
