using System;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogCreateModel
{
	[DateTimeSettings(WithoutOffset = true, FieldName = "dayForWeek")]
	public DateTime? dayForWeek { get; set; }

	public bool allWeeks { get; set; }
}
