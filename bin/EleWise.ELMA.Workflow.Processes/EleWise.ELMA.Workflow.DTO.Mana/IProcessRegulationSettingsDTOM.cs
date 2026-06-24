using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IProcessRegulationSettingsDTOManager : IConfigurationService
{
	ProcessRegulation LoadRegulationGlobalSettings();

	void SaveRegulationGlobalSettings(ProcessRegulation regulation);
}
