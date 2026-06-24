using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.KPI.Common.DTO.Models;

[Serializable]
[Component]
public class CustomPeriodDTO : IIdentity, IGenericIdentity<Guid>, IEntityDTO<Guid, IPersistedCustomPeriod>, IEntityDTO<Guid>, IEntityDTO
{
	public Guid Id { get; set; }

	public virtual DateTime PeriodStart { get; set; }

	public virtual DateTime PeriodEnd { get; set; }

	public virtual string TextRepr { get; set; }

	object IEntityDTO.Id
	{
		get
		{
			return Id;
		}
		set
		{
			Id = Id;
		}
	}

	protected CustomPeriodDTO()
	{
	}

	public CustomPeriodDTO(bool isNew)
	{
		if (isNew)
		{
			Id = Guid.NewGuid();
		}
	}
}
