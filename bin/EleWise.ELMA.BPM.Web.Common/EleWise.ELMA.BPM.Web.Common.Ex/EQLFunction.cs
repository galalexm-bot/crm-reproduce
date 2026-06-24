using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

public class EQLFunction : EQLSuggestion
{
	public IEnumerable<string> types { get; set; }

	public bool isInFunction { get; set; }
}
