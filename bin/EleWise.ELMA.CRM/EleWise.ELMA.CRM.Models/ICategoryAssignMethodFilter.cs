using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ICategoryAssignMethod))]
public interface ICategoryAssignMethodFilter : IEntityFilter
{
	ICategory Category { get; set; }

	long? EntityId { get; set; }

	Guid? TypeUid { get; set; }

	bool? AutoAssign { get; set; }
}
