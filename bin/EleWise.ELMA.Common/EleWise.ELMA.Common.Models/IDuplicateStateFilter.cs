using System.Collections.Generic;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IDuplicateState))]
public interface IDuplicateStateFilter : IEntityFilter
{
	ReferenceOnEntity EntityReference { get; set; }

	List<DuplicateStatus> DuplicateStatus { get; set; }

	ReferenceOnEntity OriginalEntityReference { get; set; }

	DateTimeRange DateOfScoring { get; set; }
}
