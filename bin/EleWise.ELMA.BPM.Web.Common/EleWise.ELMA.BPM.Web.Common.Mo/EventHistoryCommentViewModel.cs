using System;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EventHistoryCommentViewModel : EntityHistoryPanelViewModel
{
	public string PopupId { get; set; }

	public Guid AddCommentActionUid { get; set; }

	public string RedirectUrl { get; set; }

	public string HistoryCommentsClass { get; set; }

	public bool NeedComment { get; set; }

	public bool ShowAttachment { get; set; }

	public EventHistoryCommentViewModel()
	{
		NeedComment = true;
		PopupId = "AddCommentPopup";
	}
}
