using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models.Regulation;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowRegulationOperationExtension
{
	bool CheckTypeElement(object obj);

	void GetRegulationOperationFromElement(object obj, WorkflowProcessDTO process, ref Dictionary<Guid, string> numberElemArtDict, ref RegulationOperation regulationOperation);
}
