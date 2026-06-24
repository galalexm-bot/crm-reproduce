using System.ComponentModel.DataAnnotations;
using Orchard.Localization;

namespace Orchard.Mvc.DataAnnotations;

public class LocalizedStringLengthAttribute : StringLengthAttribute
{
	public Localizer T { get; set; }

	public LocalizedStringLengthAttribute(StringLengthAttribute attribute, Localizer t)
		: base(attribute.MaximumLength)
	{
		if (!string.IsNullOrEmpty(attribute.ErrorMessage))
		{
			base.ErrorMessage = attribute.ErrorMessage;
		}
		base.MinimumLength = attribute.MinimumLength;
		T = t;
	}

	public override string FormatErrorMessage(string name)
	{
		if (!string.IsNullOrEmpty(base.ErrorMessage))
		{
			return T(base.ErrorMessage, name, base.MaximumLength, base.MinimumLength).Text;
		}
		if (base.MinimumLength <= 0)
		{
			return T("The field {0} must be a string with a maximum length of {1}.", name, base.MaximumLength, base.MinimumLength).Text;
		}
		return T("The field {0} must be a string with a minimum length of {2} and a maximum length of {1}.", name, base.MaximumLength, base.MinimumLength).Text;
	}
}
