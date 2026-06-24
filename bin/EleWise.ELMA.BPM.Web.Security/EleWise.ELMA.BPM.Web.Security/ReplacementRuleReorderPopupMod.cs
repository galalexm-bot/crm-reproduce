using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class ReplacementRuleReorderPopupModel : EntityModel<IReplacement>
{
	public List<IReplacementRule> ReplacementRuleList { get; set; }

	public string PopupId { get; set; }

	public string CallBackFunctionName { get; set; }
}
