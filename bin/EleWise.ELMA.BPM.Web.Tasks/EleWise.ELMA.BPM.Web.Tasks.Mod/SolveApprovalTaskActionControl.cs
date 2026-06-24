using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SolveApprovalTaskActionControlsModel : SolveTaskActionControlsModel<IApprovalTask>
{
	public static string ApprovementApprovalTaskPopup = "ApprovementApprovalTaskPopup";

	public CommentWithAttachments CommentModel { get; set; }

	public bool Approve { get; set; }

	public override string PopupId
	{
		get
		{
			if (base.Entity == null || base.Settings == null)
			{
				return string.Empty;
			}
			return $"SolveTaskAction_{base.Entity.Id}_{UIExtensions.PrepareId(base.Settings.InstanceId.ToString())}_{Approve}";
		}
	}

	public override string ActionFunctionName
	{
		get
		{
			if (base.Entity == null || base.Settings == null)
			{
				return string.Empty;
			}
			return $"ActionFunction_{base.Entity.Id}_{UIExtensions.PrepareId(base.Settings.InstanceId.ToString())}_{Approve}";
		}
	}
}
