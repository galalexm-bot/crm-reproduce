using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.KPI.Common.DTO.Models;
using EleWise.ELMA.KPI.Common.Managers;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.KPI.Common.DTO.Managers;

public class PeriodicityDTOManager : DTOManager, IPeriodicityDTOManager, IConfigurationService
{
	public PeriodicityManager Manager { get; set; }

	public virtual PeriodicityDTO LoadOrNull(Guid id)
	{
		return Mapper.Map<IPeriodicity, PeriodicityDTO>(Manager.Load(id), new PeriodicityDTO(id));
	}

	public virtual PeriodicityDTO Save(PeriodicityDTO indicator)
	{
		Contract.ArgumentNotNull(indicator, "indicator");
		return indicator;
	}

	public virtual PeriodicityDTO Publish(PeriodicityDTO indicator)
	{
		Contract.ArgumentNotNull(indicator, "indicator");
		return indicator;
	}

	public virtual ICollection<PeriodicityDTO> FindAll()
	{
		Collection<PeriodicityDTO> collection = new Collection<PeriodicityDTO>();
		foreach (IPeriodicity item in Manager.FindAll())
		{
			collection.Add(Mapper.Map<IPeriodicity, PeriodicityDTO>(item, new PeriodicityDTO(item.Uid)));
		}
		return collection;
	}
}
