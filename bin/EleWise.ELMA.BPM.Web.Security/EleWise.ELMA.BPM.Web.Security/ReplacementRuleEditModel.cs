using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class ReplacementRuleEditModel : EntityModel<IReplacementRule>, IReplacementIntersection
{
	public IList<IReplacement> IntersectionReplacement { get; set; }

	public IList<IReplacementRule> IntersectionReplacementRule { get; set; }
}
