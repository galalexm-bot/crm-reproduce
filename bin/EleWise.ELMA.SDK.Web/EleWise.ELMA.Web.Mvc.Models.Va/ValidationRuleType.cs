namespace EleWise.ELMA.Web.Mvc.Models.Validation;

public enum ValidationRuleType
{
	custom = -1,
	required,
	remote,
	minlength,
	maxlength,
	rangelength,
	min,
	max,
	range,
	email,
	url,
	date,
	dateISO,
	dateDE,
	number,
	numberDE,
	digits,
	creditcard,
	accept,
	equalTo
}
