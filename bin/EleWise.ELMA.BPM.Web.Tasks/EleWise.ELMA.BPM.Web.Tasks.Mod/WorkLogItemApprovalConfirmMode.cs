using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogItemApprovalConfirmModel : CommentWithAttachments
{
	public WorkTime? ApprovalWorkTime { get; set; }

	public bool ApprovalWorkTimeEnabled { get; set; }

	public bool CommentEnabled { get; set; }

	public bool CommentRequired { get; set; }

	public IUser Harmonizator { get; set; }

	public bool ChangeHarmonizator { get; set; }

	public IWorkLogActivity WorkLogActivity { get; set; }

	public bool CanChangeWorkLogActivity { get; set; }
}
