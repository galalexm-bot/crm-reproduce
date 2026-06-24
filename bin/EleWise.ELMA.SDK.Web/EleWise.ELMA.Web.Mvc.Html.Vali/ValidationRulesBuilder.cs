using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Web.Mvc.Html.Validation;

public class ValidationRulesBuilder
{
	private List<ValidationRuleBuilder> rules;

	private string form;

	private string callback = "";

	private ValidatorType validatorType;

	public ValidationRulesBuilder(string form)
		: this(form, "", ValidatorType.NEW)
	{
	}

	public ValidationRulesBuilder(string form, string callback)
		: this(form, callback, ValidatorType.NEW)
	{
	}

	public ValidationRulesBuilder(string form, string callback, ValidatorType validatorType)
	{
		rules = new List<ValidationRuleBuilder>();
		this.form = form;
		this.callback = callback;
		this.validatorType = validatorType;
	}

	public ValidationRulesBuilder Rule(Action<ValidationRuleBuilder> rulesBuilder)
	{
		ValidationRuleBuilder validationRuleBuilder = new ValidationRuleBuilder();
		rulesBuilder(validationRuleBuilder);
		rules.Add(validationRuleBuilder);
		return this;
	}

	public string Script()
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (IGrouping<string, ValidationRuleBuilder> item in from r in rules
			group r by r.Rule.Input)
		{
			string text = string.Format((validatorType == ValidatorType.NEW) ? "{0}: {{ {1} }}" : "{{ {1} }}", item.Key, string.Join(",", item.Select((ValidationRuleBuilder vrb) => vrb.RuleMessage()).ToArray()));
			list.Add(string.Format((validatorType == ValidatorType.NEW) ? "{0}: {{ {1} }}" : "$('#{0}').rules('add', {{ {1}, messages: {2} }});", item.Key, string.Join(",", item.Select((ValidationRuleBuilder vrb) => vrb.RuleScript()).ToArray()), text));
			list2.Add(text);
		}
		string text2 = string.Join((validatorType == ValidatorType.NEW) ? "," : " ", list);
		string text3 = string.Join(",", list2);
		if (string.IsNullOrEmpty(text2))
		{
			return "";
		}
		List<string> list3 = new List<string>();
		foreach (IGrouping<string, ValidationRuleBuilder> item2 in from r in rules
			group r by r.Rule.Input)
		{
			list3.Add(item2.First().ErrorMessagePlacement());
		}
		string text4 = string.Join(" ", list3);
		if (validatorType == ValidatorType.ADD)
		{
			return $"\r\n                    {text4}\r\n                    {text2}\r\n                ";
		}
		return string.Format("\r\n            {0}\r\n            $('#{1}').validate({{ \r\n                dataType: 'json',\r\n                submitHandler: function(form) {{\r\n                    Ext.get('{1}').mask();\r\n    \t            $(form).ajaxSubmit(function(responseText) {{ \r\n                        Ext.get('{1}').unmask();\r\n                        if (responseText.success) {{\r\n                            {4} \r\n                        }}\r\n                        else {{\r\n                            Ext.MessageBox.show({{\r\n                                msg: responseText.error,\r\n                                icon: Ext.MessageBox.ERROR\r\n                            }});\r\n                        }}\r\n                    }});\r\n\t            }},\r\n                errorClass: 'input-validation-error',\r\n                errorElement: 'span',\r\n                errorPlacement: function(error, element) {{\r\n                    var messageSpan = '#' + element.attr('name') + '_validationMessage';\r\n                    $(messageSpan).empty();\r\n                    $(messageSpan).removeClass('field-validation-valid');\r\n                    $(messageSpan).addClass('field-validation-error');\r\n                    error.removeClass('input-validation-error');\r\n                    error.attr('_for_validation_message', messageSpan);\r\n                    error.appendTo(messageSpan);\r\n                }},\r\n                success: function(label) {{\r\n                    var messageSpan = $(label.attr('_for_validation_message'));\r\n                    $(messageSpan).empty();\r\n                    $(messageSpan).addClass('field-validation-valid');\r\n                    $(messageSpan).removeClass('field-validation-error');\r\n                }},\r\n                rules: {{ {2} }}\r\n                {3} \r\n                }});", text4, form, text2, (!string.IsNullOrEmpty(text3)) ? $",messages: {{ {text3} }}" : "", (!string.IsNullOrEmpty(callback)) ? callback : "");
	}
}
