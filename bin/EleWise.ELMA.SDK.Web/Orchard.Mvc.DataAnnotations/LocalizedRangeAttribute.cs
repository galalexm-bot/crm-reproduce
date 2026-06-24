using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Orchard.Localization;

namespace Orchard.Mvc.DataAnnotations;

public class LocalizedRangeAttribute : RangeAttribute
{
	public Localizer T { get; set; }

	public LocalizedRangeAttribute(RangeAttribute attribute, Localizer t)
		: base(attribute.OperandType, Convert.ToString(attribute.Minimum, CultureInfo.CurrentCulture), Convert.ToString(attribute.Maximum, CultureInfo.CurrentCulture))
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
			return T(base.ErrorMessage, name, base.Minimum, base.Maximum).Text;
		}
		return T("The field {0} must be between {1} and {2}.", name, base.Minimum, base.Maximum).Text;
	}
}
