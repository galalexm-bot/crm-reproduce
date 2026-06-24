using System;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class WorkIntervalEditModel : FormViewModel
{
	public IWorkTimeInterval Entity { get; set; }

	public string Prefix { get; set; }

	public int? WeekDayIndex { get; set; }

	public DateTime? ExceptionalDate { get; set; }
}
