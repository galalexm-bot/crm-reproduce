using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Common.Models;

public class PossibleDuplicate
{
	public ReferenceOnEntity DuplicateReference { get; set; }

	public long Weight { get; set; }

	public List<Guid> PropertyList { get; set; }
}
