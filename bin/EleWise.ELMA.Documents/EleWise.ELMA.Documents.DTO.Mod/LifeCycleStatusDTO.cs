using System;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Documents.DTO.Models;

[Serializable]
public class LifeCycleStatusDTO : EntityDTO<long>
{
	public string Name { get; set; }

	public Guid Uid { get; set; }

	public string Description { get; set; }

	public override string ToString()
	{
		if (!string.IsNullOrEmpty(Name))
		{
			return Name;
		}
		return base.ToString();
	}

	public LifeCycleStatusDTO()
	{
		Uid = Guid.NewGuid();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is LifeCycleStatusDTO lifeCycleStatusDTO))
		{
			return false;
		}
		return Uid == lifeCycleStatusDTO.Uid;
	}
}
