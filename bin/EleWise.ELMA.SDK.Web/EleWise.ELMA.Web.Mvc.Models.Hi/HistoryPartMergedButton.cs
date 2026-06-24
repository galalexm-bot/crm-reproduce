using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.History;

public class HistoryPartMergedButton
{
	public List<string> HistoryPartTypes { get; set; }

	public HistoryPartButton Button { get; set; }
}
