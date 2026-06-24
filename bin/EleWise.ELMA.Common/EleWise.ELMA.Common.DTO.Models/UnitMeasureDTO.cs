using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.Common.DTO.Models;

[Serializable]
public class UnitMeasureDTO : EntityDTO<long, IUnitMeasure>, IIdentity, IGenericIdentity<Guid>
{
	public Guid Uid { get; set; }

	public string Name { get; set; }

	public string Shortening { get; set; }

	public UnitMeasurePropertiesDTO Properties { get; set; }

	public bool IsWPI { get; set; }

	public bool IsSelectList { get; set; }

	public IList<WpiSelectListItemDTO> WpiSelectList { get; set; }

	Guid IGenericIdentity<Guid>.Id => Uid;
}
