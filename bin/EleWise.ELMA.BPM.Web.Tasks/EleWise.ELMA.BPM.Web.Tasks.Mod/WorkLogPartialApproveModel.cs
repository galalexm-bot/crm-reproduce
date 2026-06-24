namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogPartialApproveModel : TaskCommentModel
{
	public string Ids { get; set; }

	public string WorkTime { get; set; }

	public string PartialIds { get; set; }

	public bool HideApproveButton { get; set; }

	public bool WorkTimeIsZero { get; set; }

	public WorkLogPartialApproveModel()
	{
		HideApproveButton = false;
		WorkTimeIsZero = false;
	}
}
