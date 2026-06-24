using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.Common.DTO.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Common.DTO.Managers;

public class UnitMeasureDTOManager : DTOManager, IUnitMeasureDTOManager, IConfigurationService
{
	public UnitMeasureManager Manager { get; set; }

	public virtual UnitMeasureDTO Load(long id)
	{
		return Mapper.Map<IUnitMeasure, UnitMeasureDTO>(Manager.Load(id), new UnitMeasureDTO());
	}

	public virtual UnitMeasureDTO LoadOrNull(long id)
	{
		IUnitMeasure unitMeasure = Manager.LoadOrNull(id);
		if (unitMeasure == null)
		{
			return null;
		}
		return Mapper.Map<IUnitMeasure, UnitMeasureDTO>(unitMeasure, new UnitMeasureDTO());
	}

	public virtual UnitMeasureDTO Load(Guid uid)
	{
		return Mapper.Map<IUnitMeasure, UnitMeasureDTO>(Manager.Load(uid), new UnitMeasureDTO());
	}

	public virtual UnitMeasureDTO LoadOrNull(Guid uid)
	{
		IUnitMeasure unitMeasure = Manager.LoadOrNull(uid);
		if (unitMeasure == null)
		{
			return null;
		}
		return Mapper.Map<IUnitMeasure, UnitMeasureDTO>(unitMeasure, new UnitMeasureDTO());
	}

	public virtual ICollection<UnitMeasureDTO> FindAll()
	{
		return (from entity in Manager.FindAll()
			select Mapper.Map<IUnitMeasure, UnitMeasureDTO>(entity, new UnitMeasureDTO())).ToList();
	}
}
