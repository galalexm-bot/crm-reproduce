using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Components;

public class BooleanBinder : ElmaModelBinder
{
	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
		if (value == null || value.get_RawValue() == null)
		{
			return null;
		}
		if (value.get_RawValue() is bool)
		{
			return value.get_RawValue();
		}
		string text = ((value.get_RawValue() is string[]) ? ((string[])value.get_RawValue())[0] : (value.get_RawValue() as string));
		if (string.IsNullOrWhiteSpace(text))
		{
			return null;
		}
		int startIndex;
		if ((startIndex = text.IndexOf(',')) >= 0)
		{
			text = text.Remove(startIndex);
		}
		try
		{
			return Convert.ToBoolean(text);
		}
		catch
		{
			return null;
		}
	}
}
