using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.RPA.DTO.Models;
using EleWise.ELMA.RPA.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.RPA.DTO.Managers;

public class RPAProcessDTOManager : DTOManager, IRPAProcessDTOManager, IConfigurationService
{
	private RPAClientSettingsModule settingsModule;

	private readonly IRPAClientService rpaClient;

	private RPAClientSettingsModule SettingsModule
	{
		get
		{
			if (settingsModule == null)
			{
				settingsModule = Locator.GetServiceNotNull<RPAClientSettingsModule>();
			}
			return settingsModule;
		}
	}

	public RPAProcessDTOManager(IRPAClientService rpaClient)
	{
		this.rpaClient = rpaClient;
	}

	public virtual IEnumerable<RPAProcessDTO> GetActualProcesses()
	{
		return rpaClient.GetActualProcesses(SettingsModule.Settings.AuthToken).Processes;
	}

	public virtual IEnumerable<ContextVariableDTO> GetContextVariables(Guid processVersionUid)
	{
		List<ContextVariableDTO> list = rpaClient.GetContextVariables(processVersionUid, SettingsModule.Settings.AuthToken).ContextVariables;
		if (list == null)
		{
			list = new List<ContextVariableDTO>();
		}
		return list;
	}

	public virtual RPAProcessDTO FindProcess(Guid processToken, int version = 0)
	{
		return rpaClient.FindProcess(processToken, SettingsModule.Settings.AuthToken, version).Process;
	}

	public virtual TaskDTO CreateTask(TaskDTO task)
	{
		return rpaClient.CreateTask(SettingsModule.Settings.AuthToken, task).Task;
	}

	public virtual TaskDTO GetTaskStatus(int taskId)
	{
		return rpaClient.GetTaskStatus(SettingsModule.Settings.AuthToken, taskId).Task;
	}

	public virtual RegistrationResponseDTO Register(RPAClientSettings settings)
	{
		return rpaClient.Register(new RegistrationRequestBodyDTO
		{
			Token = settings.AuthToken,
			Name = settings.SystemName
		});
	}

	public virtual RegistrationStatusResponseDTO GetRegistrationStatus(Guid token)
	{
		return rpaClient.GetRegistrationStatus(new RegistrationStatusRequestBodyDTO
		{
			Token = token
		});
	}
}
