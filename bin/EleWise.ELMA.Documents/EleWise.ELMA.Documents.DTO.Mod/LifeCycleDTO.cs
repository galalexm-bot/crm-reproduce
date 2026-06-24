using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Documents.DTO.Models;

[Serializable]
public class LifeCycleDTO : EntityDTO<long>
{
	public List<LifeCycleStatusDTO> Statuses { get; set; }

	public List<LifeCycleTransitionDTO> Transitions { get; set; }

	public LifeCycleStatusDTO DefaultStatus { get; set; }

	public Guid DocumentType { get; set; }

	public bool IsCustomChangeStatus { get; set; }

	public LifeCycleDTO()
	{
		IsCustomChangeStatus = true;
		Statuses = new List<LifeCycleStatusDTO>();
		Transitions = new List<LifeCycleTransitionDTO>();
	}
}
