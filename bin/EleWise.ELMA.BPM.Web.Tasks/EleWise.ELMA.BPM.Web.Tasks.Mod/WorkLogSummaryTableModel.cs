using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Tasks.Components;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogSummaryTableModel
{
	public WorkLogItemGridParams Parameters { get; set; }

	public string PrefixId { get; set; }

	public List<SummaryTableRow> Rows { get; private set; }

	public WorkLogSummaryTableGroup Group { get; set; }

	public bool EnabledLink { get; set; }

	public string FilterDataFunction { get; set; }

	public string FilterDataFunctionParam { get; set; }

	public long? FilterId { get; set; }

	public string Ids { get; set; }

	public WorkLogSummaryTableModel()
	{
		Rows = new List<SummaryTableRow>();
	}
}
