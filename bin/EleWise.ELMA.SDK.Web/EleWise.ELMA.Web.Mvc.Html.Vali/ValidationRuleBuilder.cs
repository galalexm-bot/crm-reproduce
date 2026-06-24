using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Web.Mvc.Models.Validation;

namespace EleWise.ELMA.Web.Mvc.Html.Validation;

public class ValidationRuleBuilder
{
	private readonly ValidationRule _rule;

	public ValidationRule Rule => _rule;

	public ValidationRuleBuilder()
	{
		_rule = new ValidationRule();
	}

	public ValidationRuleBuilder Input(string selector)
	{
		_rule.Input = selector;
		return this;
	}

	public ValidationRuleBuilder Type(ValidationRuleType ruleType)
	{
		_rule.ValidationRuleType = ruleType;
		return this;
	}

	public ValidationRuleBuilder Name(string name)
	{
		_rule.Name = name;
		return this;
	}

	public ValidationRuleBuilder ErrorMessage(string message)
	{
		_rule.ErrorMessage = message;
		return this;
	}

	public ValidationRuleBuilder Param(string key, string value)
	{
		if (!_rule.Params.ContainsKey(key))
		{
			_rule.Params.Add(key, value);
		}
		return this;
	}

	public string RuleScript()
	{
		string ruleName = _rule.GetRuleName();
		IEnumerable<KeyValuePair<string, string>> source = _rule.Params.Where((KeyValuePair<string, string> p) => p.Key.Equals(ruleName, StringComparison.OrdinalIgnoreCase));
		return string.Format("{0}:{1}", ruleName, (source.Count() <= 0) ? "" : ((source.Count() == 1) ? source.First().Value : string.Format("{{ {0} }}", string.Join(",", (from p in _rule.Params.Keys
			where p.Equals(ruleName)
			select p into k
			select $"{k}:{_rule.Params[k]}").ToArray()))));
	}

	public string RuleMessage()
	{
		if (!string.IsNullOrEmpty(_rule.ErrorMessage))
		{
			string ruleName = _rule.GetRuleName();
			return $"{ruleName}:'{_rule.ErrorMessage}'";
		}
		return "";
	}

	public string ErrorMessagePlacement()
	{
		return string.Format("\r\n            if (Ext.get('{0}_validationMessage') == null) {{\r\n                $('#{0}').after( $('<span/>', {{\r\n                    id : '{0}_validationMessage',\r\n                    'class': 'field-validation-valid'\r\n                }}));\r\n            }}", _rule.Input);
	}
}
