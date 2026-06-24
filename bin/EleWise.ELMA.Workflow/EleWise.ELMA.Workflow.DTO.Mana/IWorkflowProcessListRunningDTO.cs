using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IWorkflowProcessListRunningDTOManager : IConfigurationService
{
	List<WorkflowProcessListRunningDTO> Load(Guid typeId);

	List<WorkflowProcessListRunningDTO> Load(EntityMetadata metadata, bool objectUser);

	void Save(List<WorkflowProcessListRunningDTO> data, Guid typeId);

	void Save(List<WorkflowProcessListRunningDTO> data, EntityMetadata metadata, bool objectUser);
}
