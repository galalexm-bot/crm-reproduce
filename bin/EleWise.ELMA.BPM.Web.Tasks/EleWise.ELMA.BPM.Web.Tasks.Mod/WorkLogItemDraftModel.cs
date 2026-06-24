using System;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogItemDraftModel
{
	public WorkLogReportItem Item { get; set; }

	[DateTimeSettings(WithoutOffset = true, FieldName = "Date")]
	public DateTime? Date { get; set; }
}
