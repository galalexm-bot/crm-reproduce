using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface ICustomActivityDTOManager : IConfigurationService
{
	CustomActivityDTO Save(CustomActivityDTO ca, bool isDraft);

	CustomActivityDTO Publish(CustomActivityDTO ca);

	CustomActivityDTO LoadOrNull(Guid id);

	CustomActivityDTO LoadOrNull(long id);

	CustomActivityDTO Load(long id);

	ScriptModuleDTO LoadScriptModuleForEdit(long caId);

	void SaveScriptModule(ScriptModuleDTO scriptModule);

	CustomActivityDTO DoNew(CustomActivityDTO oldCa, string newPrefix = "", bool copy = false);

	List<CustomActivityDTO> LoadHistory(long customActivityHeadId);

	CustomActivityDTO LoadAsDraft(long id);

	IDictionary<long, IEnumerable<CustomActivityDTO>> LoadHistories(IEnumerable<long> customActivityHeadIds);
}
