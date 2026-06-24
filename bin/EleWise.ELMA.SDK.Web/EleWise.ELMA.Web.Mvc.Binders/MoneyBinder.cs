using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class MoneyBinder : IModelBinder
{
	private static readonly TypeConverter converter = TypeDescriptor.GetConverter(typeof(double));

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		if (bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName()).get_RawValue() is string[] array && array.Length != 0 && !string.IsNullOrEmpty(array[0]))
		{
			Money money = default(Money);
			money.Value = (double)converter.ConvertFromString(array[0]);
			return money;
		}
		return default(Money);
	}
}
