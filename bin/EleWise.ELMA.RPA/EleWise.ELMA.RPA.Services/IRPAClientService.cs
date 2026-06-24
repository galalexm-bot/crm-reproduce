using System;
using EleWise.ELMA.RPA.DTO.Models;

namespace EleWise.ELMA.RPA.Services;

public interface IRPAClientService
{
	TaskCreateResponseDTO CreateTask(Guid authToken, TaskDTO task);

	FindProcessResponseDTO FindProcess(Guid processToken, Guid authToken, int version = 0);

	ActualProcessesResponseDTO GetActualProcesses(Guid authToken);

	ProcessContextResponseDTO GetContextVariables(Guid processVersionUid, Guid authToken);

	RegistrationStatusResponseDTO GetRegistrationStatus(RegistrationStatusRequestBodyDTO body);

	TaskStatusResponseDTO GetTaskStatus(Guid authToken, int taskId);

	RegistrationResponseDTO Register(RegistrationRequestBodyDTO registrationDTO);
}
