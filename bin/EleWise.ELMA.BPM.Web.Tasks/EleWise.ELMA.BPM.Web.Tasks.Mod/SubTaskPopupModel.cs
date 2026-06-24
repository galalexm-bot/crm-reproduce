namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SubTaskPopupModel
{
	public long ParentId { get; set; }

	public string ReturnUrl { get; set; }

	public string PopupId { get; set; }

	public bool IsAjax { get; set; }
}
