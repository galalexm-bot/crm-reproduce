using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

public class ActionInsertRuleSet
{
	public string ItemUid { get; set; }

	public IList<ActionInsertRule> Rules { get; set; }

	public ActionInsertRuleSet(string itemUid)
	{
		ItemUid = itemUid;
		Rules = new List<ActionInsertRule>();
	}
}
