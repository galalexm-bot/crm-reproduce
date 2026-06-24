namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskChangeModel
{
	public long TaskId { get; set; }

	public string RedirectUrl { get; set; }

	public bool RequiredStartDate { get; set; }

	public bool RequiredEndDate { get; set; }

	public bool HideStartDate { get; set; }

	public bool HideEndDate { get; set; }
}
