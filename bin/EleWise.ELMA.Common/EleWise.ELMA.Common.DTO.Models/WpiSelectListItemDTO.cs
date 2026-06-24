using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Common.DTO.Models;

[Serializable]
public class WpiSelectListItemDTO : EntityDTO<long, IWpiSelectListItem>
{
	public bool IsDefault { get; set; }

	public double PercentValue { get; set; }
}
