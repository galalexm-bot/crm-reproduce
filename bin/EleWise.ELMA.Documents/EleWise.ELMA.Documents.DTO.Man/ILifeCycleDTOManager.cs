using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Documents.DTO.Managers;

public interface ILifeCycleDTOManager : IConfigurationService
{
	LifeCycleDTO LoadOrNull(Type documentType);

	LifeCycleDTO LoadOrNull(Guid typeUid);

	LifeCycleDTO Save(LifeCycleDTO lifeCycle);

	List<LifeCycleStatusDTO> GetAvaliableStatuses(LifeCycleDTO cycle);
}
