using System;
using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogTypeSettingsModel : FormViewModel
{
	public TreeModel Tree { get; set; }

	public List<Guid> Uids { get; set; }

	public string PopupId { get; set; }

	public bool ReadOnly { get; set; }
}
