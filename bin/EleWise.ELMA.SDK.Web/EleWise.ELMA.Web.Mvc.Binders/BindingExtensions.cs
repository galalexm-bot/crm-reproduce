using System.Globalization;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Binders;

public static class BindingExtensions
{
	public static T ConvertTo<T>(this ValueProviderResult valueProviderResult)
	{
		return (T)valueProviderResult.ConvertTo(typeof(T));
	}

	public static T GetValue<T>(this ModelBindingContext bindingContext, string key)
	{
		return bindingContext.GetValue<T>(key, null);
	}

	public static T GetValue<T>(this ModelBindingContext bindingContext, string key, CultureInfo culture)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(key);
		if (value == null)
		{
			return default(T);
		}
		if (culture == null)
		{
			return (T)value.ConvertTo(typeof(T));
		}
		return (T)value.ConvertTo(typeof(T), culture);
	}
}
