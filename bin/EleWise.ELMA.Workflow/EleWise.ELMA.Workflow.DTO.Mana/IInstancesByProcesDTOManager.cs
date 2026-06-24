using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IInstancesByProcesDTOManager : IConfigurationService
{
	Dictionary<long, InstancesByProcesDTO> LoadInstanse(long id);
}
