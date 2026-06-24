using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IDuplicate))]
public interface IDuplicateFilter : IEntityFilter
{
	Int64Range Weight { get; set; }

	ReferenceOnEntity EntityReference { get; set; }

	ReferenceOnEntity EntityDuplicateReference { get; set; }
}
