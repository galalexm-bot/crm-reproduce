using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Messages.Web.Models;

public class PrioritySettingsModel : FormViewModel
{
	public string PriorityTextScript { get; set; }

	public string CallBackScript { get; set; }

	public string PrePostScript { get; set; }

	public FeedPriority Priority { get; set; }

	public string PopupId { get; set; }
}
