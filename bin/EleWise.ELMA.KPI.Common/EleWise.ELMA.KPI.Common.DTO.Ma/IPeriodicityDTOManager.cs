using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.KPI.Common.DTO.Models;

namespace EleWise.ELMA.KPI.Common.DTO.Managers;

public interface IPeriodicityDTOManager : IConfigurationService
{
	PeriodicityDTO Save(PeriodicityDTO periodicity);

	PeriodicityDTO Publish(PeriodicityDTO periodicity);

	PeriodicityDTO LoadOrNull(Guid id);

	ICollection<PeriodicityDTO> FindAll();
}
