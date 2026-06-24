using System.ComponentModel.DataAnnotations;
using Orchard.Localization;

namespace Orchard.Mvc.DataAnnotations;

public class LocalizedRequiredAttribute : RequiredAttribute
{
	public Localizer T { get; set; }

	public LocalizedRequiredAttribute(RequiredAttribute attribute, Localizer t)
	{
		base.AllowEmptyStrings = attribute.AllowEmptyStrings;
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
			return T(base.ErrorMessage, name).Text;
		}
		return T("The {0} field is required.", name).Text;
	}
}
