using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SummaryTableRow
{
	public IWorkLogActivity Activity { get; set; }

	public IUser Author { get; set; }

	public WorkTime WorkTime { get; set; }

	public WorkTime ConfirmTime { get; set; }

	public WorkTime UnconfirmTime { get; set; }

	public SummaryTableRow()
	{
		WorkTime = new WorkTime(0);
		ConfirmTime = new WorkTime(0);
		UnconfirmTime = new WorkTime(0);
	}
}
