using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Validation;

public class ValidationRule
{
	public string Input { get; set; }

	public ValidationRuleType ValidationRuleType { get; set; }

	public string Name { get; set; }

	public string ErrorMessage { get; set; }

	public Dictionary<string, string> Params { get; set; }

	public string GetRuleName()
	{
		string text = "";
		ValidationRuleType validationRuleType = ValidationRuleType;
		if (validationRuleType == ValidationRuleType.custom)
		{
			return Name;
		}
		return ValidationRuleType.ToString();
	}

	public ValidationRule()
	{
		Params = new Dictionary<string, string> { 
		{
			GetRuleName(),
			"true"
		} };
	}
}
