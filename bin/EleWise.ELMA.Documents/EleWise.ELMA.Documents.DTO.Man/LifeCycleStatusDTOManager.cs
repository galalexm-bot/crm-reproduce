using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Documents.DTO.Managers;

public class LifeCycleStatusDTOManager : DTOManager, ILifeCycleStatusDTOManager, IConfigurationService
{
	public LifeCycleStatusManager Manager { get; set; }

	public virtual List<LifeCycleStatusDTO> FindAll()
	{
		return (from m in Manager.FindAll()
			select Mapper.Map<ILifeCycleStatus, LifeCycleStatusDTO>(m, new LifeCycleStatusDTO())).ToList();
	}

	public virtual LifeCycleStatusDTO Save(LifeCycleStatusDTO status)
	{
		ILifeCycleStatus lifeCycleStatus = Mapper.Map<LifeCycleStatusDTO, ILifeCycleStatus>(status, Manager.Create());
		lifeCycleStatus.Save();
		status.Id = lifeCycleStatus.Id;
		return status;
	}

	public virtual LifeCycleStatusDTO Load(long id)
	{
		return Mapper.Map<ILifeCycleStatus, LifeCycleStatusDTO>(Manager.Load(id), new LifeCycleStatusDTO());
	}

	public virtual LifeCycleStatusDTO Load(Guid uid)
	{
		return Mapper.Map<ILifeCycleStatus, LifeCycleStatusDTO>(Manager.Load(uid), new LifeCycleStatusDTO());
	}
}
