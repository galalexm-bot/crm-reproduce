using System;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Documents.DTO.Models;

[Serializable]
public class LifeCycleTransitionDTO : EntityDTO<long>
{
	public string Name { get; set; }

	public string Description { get; set; }

	public LifeCycleStatusDTO Start { get; set; }

	public LifeCycleStatusDTO Finish { get; set; }
}
