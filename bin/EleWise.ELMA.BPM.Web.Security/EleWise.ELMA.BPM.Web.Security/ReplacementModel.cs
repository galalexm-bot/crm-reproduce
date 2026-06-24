using System.Collections.Generic;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class ReplacementModel : IReplacementIntersection
{
	public IReplacement Replacement { get; set; }

	public ReplacementManagmentType ReplacementManagmentType { get; set; }

	public IList<IReplacement> IntersectionReplacement { get; set; }

	public IList<IReplacementRule> IntersectionReplacementRule { get; set; }

	public GridData<IReplacement> GridData { get; set; }
}
