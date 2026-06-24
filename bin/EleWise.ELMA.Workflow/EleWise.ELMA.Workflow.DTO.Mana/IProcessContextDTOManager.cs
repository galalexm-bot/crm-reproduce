using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IProcessContextDTOManager : IConfigurationService
{
	ProcessContext Load(Guid uid);

	ProcessContext LoadFullContext(long processHeadId);

	string AllHaveUids();

	IDictionary<ProcessInfoDTO, IEnumerable<ProcessPropertyInfoDTO>> GetChildPropertyNames(long processHeaderId);

	void UpdateContextTableUids();
}
