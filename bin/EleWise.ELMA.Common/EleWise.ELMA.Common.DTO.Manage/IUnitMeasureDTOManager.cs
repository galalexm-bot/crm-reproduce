using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.DTO.Models;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Common.DTO.Managers;

public interface IUnitMeasureDTOManager : IConfigurationService
{
	UnitMeasureDTO Load(long id);

	UnitMeasureDTO LoadOrNull(long id);

	UnitMeasureDTO Load(Guid uid);

	UnitMeasureDTO LoadOrNull(Guid uid);

	ICollection<UnitMeasureDTO> FindAll();
}
