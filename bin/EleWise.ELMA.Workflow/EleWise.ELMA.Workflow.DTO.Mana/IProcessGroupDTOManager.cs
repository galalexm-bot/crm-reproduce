using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IProcessGroupDTOManager : IConfigurationService
{
	ProcessGroupDTO LoadRootGroup(long updateProcess = 0L);

	ProcessGroupDTO LoadRootGroupByRuntime(RuntimeVersion? runtimeVersion = null);

	IEnumerable<ProcessGroupDTO> GetChildGroups(long parentGroupId);

	IEnumerable<ProcessGroupDTO> GetNestedChildGroups(long parentGroupId);

	ProcessGroupDTO Save(ProcessGroupDTO group);

	void Delete(long groupId);
}
