using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Components;

internal class DateTimeRangeBinder : ElmaModelBinder
{
	internal static void SetSettings(string modelName, IPropertyMetadata property)
	{
		if (!string.IsNullOrEmpty(modelName) && property != null && !ContextVars.Contains(modelName))
		{
			ContextVars.Set(modelName, property);
		}
	}

	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		SetSettings(bindingContext.get_ModelName(), bindingContext.get_ModelMetadata().GetPropertyMetadata());
		object obj = base.BindModel(controllerContext, bindingContext);
		if (obj is DateTimeRange dateTimeRange)
		{
			ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName() + ".From");
			ValueProviderResult value2 = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName() + ".To");
			if (dateTimeRange.From.HasValue && value != null && !string.IsNullOrEmpty(value.get_AttemptedValue()))
			{
				string[] array = value.get_AttemptedValue().Split(' ');
				if (array.Length < 2 || string.IsNullOrWhiteSpace(array[1]))
				{
					dateTimeRange.From = dateTimeRange.From.Value.AddSeconds(10.0);
				}
			}
			if (dateTimeRange.To.HasValue && value2 != null && !string.IsNullOrEmpty(value2.get_AttemptedValue()))
			{
				string[] array2 = value2.get_AttemptedValue().Split(' ');
				if (array2.Length < 2 || string.IsNullOrWhiteSpace(array2[1]))
				{
					dateTimeRange.To = dateTimeRange.To.Value.AddDays(1.0).AddSeconds(-10.0);
				}
			}
			obj = dateTimeRange;
		}
		return obj;
	}
}
