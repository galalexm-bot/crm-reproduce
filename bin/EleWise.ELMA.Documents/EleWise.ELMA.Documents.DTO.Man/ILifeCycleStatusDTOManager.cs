using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Documents.DTO.Managers;

public interface ILifeCycleStatusDTOManager : IConfigurationService
{
	List<LifeCycleStatusDTO> FindAll();

	LifeCycleStatusDTO Save(LifeCycleStatusDTO status);

	LifeCycleStatusDTO Load(long id);

	LifeCycleStatusDTO Load(Guid uid);
}
