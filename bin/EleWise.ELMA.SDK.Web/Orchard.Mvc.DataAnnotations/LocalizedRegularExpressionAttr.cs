using System.ComponentModel.DataAnnotations;
using Orchard.Localization;

namespace Orchard.Mvc.DataAnnotations;

public class LocalizedRegularExpressionAttribute : RegularExpressionAttribute
{
	public Localizer T { get; set; }

	public LocalizedRegularExpressionAttribute(RegularExpressionAttribute attribute, Localizer t)
		: base(attribute.Pattern)
	{
		if (!string.IsNullOrEmpty(attribute.ErrorMessage))
		{
			base.ErrorMessage = attribute.ErrorMessage;
		}
		T = t;
	}

	public override string FormatErrorMessage(string name)
	{
		if (!string.IsNullOrEmpty(base.ErrorMessage))
		{
			return T(base.ErrorMessage, name, base.Pattern).Text;
		}
		return T("The field {0} must match the regular expression '{1}'.", name, base.Pattern).Text;
	}
}
