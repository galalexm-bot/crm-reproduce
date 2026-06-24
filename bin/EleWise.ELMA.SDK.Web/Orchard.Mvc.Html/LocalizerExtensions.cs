using System.Linq;
using Orchard.Localization;

namespace Orchard.Mvc.Html;

public static class LocalizerExtensions
{
	public static LocalizedString Plural(this Localizer T, string textSingular, string textPlural, int count, params object[] args)
	{
		return T((count == 1) ? textSingular : textPlural, new object[1] { count }.Concat(args).ToArray());
	}

	public static LocalizedString Plural(this Localizer T, string textNone, string textSingular, string textPlural, int count, params object[] args)
	{
		return count switch
		{
			0 => T(textNone, new object[1] { count }.Concat(args).ToArray()), 
			1 => T(textSingular, new object[1] { count }.Concat(args).ToArray()), 
			_ => T(textPlural, new object[1] { count }.Concat(args).ToArray()), 
		};
	}
}
