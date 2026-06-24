using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IWorkflowMessageTypeDTOManager : IConfigurationService
{
	WorkflowMessageTypeDTO LoadOrNull(long id);

	List<WorkflowMessageTypeDTO> LoadAll(bool includeDeleted = false);

	void Delete(long id);

	void Restore(long id);

	WorkflowMessageTypeDTO Save(WorkflowMessageTypeDTO dto);

	List<WorkflowHistoryItemDTO> SearchOccurrencesInProcesses(long msgTypeId, bool inPublished, bool inDrafts, bool inOld);

	int CountOccurrencesInProcesses(long msgTypeId, bool inPublished, bool inDrafts, bool inOld);
}
