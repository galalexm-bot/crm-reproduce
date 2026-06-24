using System;
using System.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

[Serializable]
public class ActionInsertRule
{
	public string ActionItemUid { get; set; }

	[DefaultValue(ActionInsertRuleType.InsertInto)]
	public ActionInsertRuleType RuleType { get; set; }

	[DefaultValue(100)]
	public int Priority { get; set; }
}
