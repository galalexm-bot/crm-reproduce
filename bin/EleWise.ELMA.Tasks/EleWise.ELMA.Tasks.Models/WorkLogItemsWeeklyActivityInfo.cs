using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Tasks.Models;

public class WorkLogItemsWeeklyActivityInfo
{
	public DateTimeRange Week { get; set; }

	public IWorkLogActivity Activity { get; set; }

	public WorkTime TotalWorkTime { get; set; }
}
