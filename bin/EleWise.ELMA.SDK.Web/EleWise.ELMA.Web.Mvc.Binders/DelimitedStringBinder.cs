using System.Web.Mvc;
using EleWise.ELMA.Helpers;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class DelimitedStringBinder : IModelBinder
{
	private readonly char[] separator;

	public DelimitedStringBinder(params char[] separator)
	{
		this.separator = separator;
	}

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
		if (value != null && value.get_RawValue() is string[] array && array.Length != 0 && !string.IsNullOrEmpty(array[0]))
		{
			return StringParseHelper.GetIdsFromString(array[0], separator);
		}
		return null;
	}
}
