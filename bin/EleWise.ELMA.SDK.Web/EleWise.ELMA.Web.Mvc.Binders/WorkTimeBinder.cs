using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class WorkTimeBinder : IModelBinder
{
	private static readonly TypeConverter converter = TypeDescriptor.GetConverter(typeof(long));

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		if (bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName()).get_RawValue() is string[] array && array.Length != 0 && !string.IsNullOrEmpty(array[0]))
		{
			WorkTime workTime = default(WorkTime);
			workTime.Value = (long)converter.ConvertFromString(array[0]);
			return workTime;
		}
		return default(WorkTime);
	}
}
