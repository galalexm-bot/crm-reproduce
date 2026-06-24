using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public sealed class TaskApprovalStatusPopover
{
	public string ApproveDate { get; set; }

	public IComment Comment { get; set; }

	public IUser User { get; set; }

	public TaskApprovalStatusPopover(string approveDate, IComment comment, IUser user)
	{
		ApproveDate = approveDate;
		Comment = comment;
		User = user;
	}
}
