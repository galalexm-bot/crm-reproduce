using System;
using System.Globalization;

namespace EleWise.ELMA.Core.Helpers;

public static class CultureString
{
	public static string ToInvariantCultureString(this double val)
	{
		return val.ToString((IFormatProvider)(object)CultureInfo.get_InvariantCulture());
	}
}
