using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Tasks.Models;

public static class WorkLogItemExtensions
{
	public static WorkTime GetActualWorkTime(this IWorkLogItem workLogItem)
	{
		if (workLogItem == null)
		{
			return 0L;
		}
		if (workLogItem.Status != WorkLogItemStatus.Confirm)
		{
			if (!workLogItem.FactWorkTime.HasValue)
			{
				return 0L;
			}
			return workLogItem.FactWorkTime.Value;
		}
		if (!workLogItem.ApprovalWorkTime.HasValue)
		{
			return 0L;
		}
		return workLogItem.ApprovalWorkTime.Value;
	}
}
