using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class ViewDataExtensions
{
	private const string VIEW_ATTRIBUTES = "ViewAttributes";

	private const string VIEW_TITLE = "ViewTitle";

	public static HtmlAttributes HtmlAttributes<TModel>(this ViewDataDictionary<TModel> viewData)
	{
		if (!(((ViewDataDictionary)viewData).get_Item("ViewAttributes") is WebViewAttributes webViewAttributes))
		{
			return null;
		}
		return webViewAttributes.Html;
	}

	public static ViewAttributes ViewAttributes<TModel>(this ViewDataDictionary<TModel> viewData)
	{
		return ((ViewDataDictionary)viewData).get_Item("ViewAttributes") as ViewAttributes;
	}

	public static WebViewAttributes WebViewAttributes<TModel>(this ViewDataDictionary<TModel> viewData)
	{
		return ((ViewDataDictionary)viewData).get_Item("ViewAttributes") as WebViewAttributes;
	}

	public static TypeSettings TypeSettings<TModel>(this ViewDataDictionary<TModel> viewData)
	{
		return viewData.ViewAttributes<TModel>()?.TypeSettings;
	}

	public static bool TypeSettingsHasDefaultValue<TModel>(this ViewDataDictionary<TModel> viewData)
	{
		if (viewData.TypeSettings<TModel>() != null)
		{
			return viewData.TypeSettings<TModel>().GetType().GetInterfaces()
				.FirstOrDefault((Type i) => i.Name.Contains("IHasDefaultValue")) != null;
		}
		return false;
	}

	public static string GetViewTitle(this ViewDataDictionary viewData)
	{
		return (string)viewData.get_Item("ViewTitle");
	}

	public static void SetViewTitle(this ViewDataDictionary viewData, string value)
	{
		viewData.set_Item("ViewTitle", (object)value);
	}

	public static bool TryGetValue(this ViewDataDictionary viewData, string key, out string value, string defaultValue = null)
	{
		object obj = default(object);
		bool flag = viewData.TryGetValue(key, ref obj);
		value = (flag ? obj.ToString() : defaultValue);
		return flag;
	}

	public static bool TryGetValue<T>(this ViewDataDictionary viewData, string key, out T value)
	{
		return viewData.TryGetValue(key, out value, default(T));
	}

	public static bool TryGetValue<T>(this ViewDataDictionary viewData, string key, out T value, T defaultValue)
	{
		object obj = default(object);
		bool flag = viewData.TryGetValue(key, ref obj);
		value = (flag ? ((T)obj) : defaultValue);
		return flag;
	}
}
