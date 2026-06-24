using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.RPA.DTO.Models;
using EleWise.ELMA.RPA.Services;

namespace EleWise.ELMA.RPA.DTO.Managers;

public interface IRPAProcessDTOManager : IConfigurationService
{
	TaskDTO CreateTask(TaskDTO task);

	RPAProcessDTO FindProcess(Guid processToken, int version = 0);

	IEnumerable<RPAProcessDTO> GetActualProcesses();

	IEnumerable<ContextVariableDTO> GetContextVariables(Guid processVersionUid);

	RegistrationStatusResponseDTO GetRegistrationStatus(Guid token);

	TaskDTO GetTaskStatus(int taskId);

	RegistrationResponseDTO Register(RPAClientSettings settings);
}
