using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Workflow.BPMN;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IWorkflowProcessDTOManager : IConfigurationService
{
	WorkflowProcessDTO Save(WorkflowProcessDTO process);

	WorkflowProcessDTO LoadOrNull(long id);

	WorkflowProcessDTO Load(long id);

	WorkflowProcessDTO LoadWithFillDependencies(long id);

	bool Exist(Guid uid);

	WorkflowProcessDTO LoadAsDraft(long id);

	WorkflowProcessDTO LoadDraft(long id);

	List<WorkflowHistoryItemDTO> LoadHistory(long processHeadId);

	List<WorkflowProcessDTO> LoadPublishedProcesses(string searchString);

	ScriptModuleDTO LoadScriptModuleForEdit(long processId);

	void SaveScriptModule(ScriptModuleDTO scriptModule);

	void PublishScriptModule(long processId, ScriptModuleDTO scriptModule);

	List<string> Documentation(ref GenerationSettings settings, bool isPublishing);

	byte[] GetFile(string path);

	string GetFormDisplayInfo(Guid objectUid, Guid formUid, FormDependencyDataType type);

	void RenameItem(long processId, long? draftId, string name);
}
