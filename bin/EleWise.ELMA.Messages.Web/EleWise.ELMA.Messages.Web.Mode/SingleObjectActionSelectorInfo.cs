using System;
using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Messages.Web.Models;

public class SingleObjectActionSelectorInfo : FormViewModel
{
	public string PopupId { get; set; }

	public Guid ObjectUid { get; set; }

	public List<ActionSettingsInfo> ActionsInfo { get; set; }

	public SingleObjectActionSelectorInfo()
	{
		ActionsInfo = new List<ActionSettingsInfo>();
		base.PostAction = "AddExceptions";
		base.PostController = "MessageException";
		base.PostArea = "EleWise.ELMA.Messages.Web";
	}
}
