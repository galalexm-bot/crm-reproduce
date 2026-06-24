using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IRegulationResourceTypeDTOManager : IConfigurationService
{
	RegulationResourceTypeDTO Load(Guid uid);

	RegulationResourceTypeDTO Load(long id);

	RegulationResourceTypeDTO Save(RegulationResourceTypeDTO resourceType);

	List<RegulationResourceTypeDTO> LoadAll();

	bool Delete(long id);

	bool Delete(Guid uid);
}
