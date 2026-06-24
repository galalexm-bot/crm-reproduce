using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Components;

internal class RelativeDateTimeBinder : ElmaModelBinder
{
	internal static void SetSettings(ModelBindingContext bindingContext)
	{
		IEnumerator<KeyValuePair<string, ModelMetadata>> enumerator = bindingContext.get_PropertyMetadata().GetEnumerator();
		for (int i = 0; i < bindingContext.get_PropertyMetadata().Count; i++)
		{
			KeyValuePair<string, ModelMetadata> current = enumerator.Current;
			if (!string.IsNullOrEmpty(current.Key) && current.Value != null && current.Value.get_ModelType() != null && current.Value.get_ModelType() == typeof(DateTimeRange))
			{
				DateTimeRangeBinder.SetSettings($"{bindingContext.get_ModelName()}.{current.Key}", bindingContext.get_ModelMetadata().GetPropertyMetadata());
			}
			enumerator.MoveNext();
		}
	}

	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		SetSettings(bindingContext);
		object obj = base.BindModel(controllerContext, bindingContext);
		if (obj is RelativeDateTime)
		{
			RelativeDateTime relativeDateTime = (RelativeDateTime)obj;
			if (bindingContext.get_ValueProvider().GetValue(ElmaModelBinder.GetPrefix(bindingContext) + "IsRelative") == null)
			{
				relativeDateTime.IsRelative = false;
			}
			obj = relativeDateTime;
		}
		return obj;
	}
}
