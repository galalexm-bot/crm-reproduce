using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public interface IReplacementIntersection
{
	IList<IReplacement> IntersectionReplacement { get; set; }

	IList<IReplacementRule> IntersectionReplacementRule { get; set; }
}
