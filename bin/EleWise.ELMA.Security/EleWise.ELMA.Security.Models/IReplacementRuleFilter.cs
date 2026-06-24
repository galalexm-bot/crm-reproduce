using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IReplacementRule))]
public interface IReplacementRuleFilter : IEntityFilter
{
	IUser TargetUser { get; set; }

	Guid? PropertyUid { get; set; }

	IReplacement Replacement { get; set; }
}
