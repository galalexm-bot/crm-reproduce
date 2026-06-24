using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.DTO.Managers;

public class LifeCycleDTOManager : DTOManager, ILifeCycleDTOManager, IConfigurationService
{
	public LifeCycleManager Manager { get; set; }

	public virtual LifeCycleDTO LoadOrNull(Type documentType)
	{
		ILifeCycle lifeCycle = Manager.LoadOrNull(documentType);
		if (lifeCycle == null)
		{
			return null;
		}
		return Mapper.Map<ILifeCycle, LifeCycleDTO>(lifeCycle, new LifeCycleDTO());
	}

	public virtual LifeCycleDTO LoadOrNull(Guid typeUid)
	{
		ILifeCycle lifeCycle = Manager.LoadOrNull(typeUid);
		if (lifeCycle == null)
		{
			return null;
		}
		return Mapper.Map<ILifeCycle, LifeCycleDTO>(lifeCycle, new LifeCycleDTO());
	}

	public virtual LifeCycleDTO Save(LifeCycleDTO lifeCycle)
	{
		ILifeCycle lifeCycle2 = Manager.LoadOrNull(lifeCycle.DocumentType);
		if (lifeCycle2 != null && lifeCycle2.Id != lifeCycle.Id)
		{
			lifeCycle2.Delete();
		}
		ILifeCycle lifeCycle3 = Mapper.Map<LifeCycleDTO, ILifeCycle>(lifeCycle, (lifeCycle.Id > 0) ? Manager.Load(lifeCycle.Id) : Manager.Create());
		lifeCycle3?.Save();
		return Mapper.Map<ILifeCycle, LifeCycleDTO>(lifeCycle3, new LifeCycleDTO());
	}

	public virtual List<LifeCycleStatusDTO> GetAvaliableStatuses(LifeCycleDTO cycle)
	{
		ILifeCycle cycle2 = Mapper.Map<LifeCycleDTO, ILifeCycle>(cycle, InterfaceActivator.Create<ILifeCycle>());
		return (from s in Manager.GetAvaliableStatuses(cycle2)
			select Mapper.Map<ILifeCycleStatus, LifeCycleStatusDTO>(s, new LifeCycleStatusDTO())).ToList();
	}
}
