using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ScoringPageModel
{
	public bool IsGlobalScoringEnabled { get; set; }

	public List<ScoringEntityModel> Entities { get; set; }
}
