using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IRegulationTemplateDTOManager : IConfigurationService
{
	RegulationTemplateDTO Load(Guid uid);

	RegulationTemplateDTO Load(long id);

	RegulationTemplateDTO LoadSystemTemlate();

	RegulationTemplateDTO Save(RegulationTemplateDTO template, bool saveFromPath = true);

	List<RegulationTemplateDTO> LoadAll(bool fileTemplateWithContent = true);

	bool Delete(long id);
}
