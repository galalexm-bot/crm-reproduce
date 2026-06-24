using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class ReferenceOnEntityTypeBinder : IModelBinder
{
	private static readonly TypeConverter converter = TypeDescriptor.GetConverter(typeof(ReferenceOnEntityType));

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName() + ".TypeUid");
		if (value != null && value.get_RawValue() is string[] array && array.Length != 0 && !string.IsNullOrEmpty(array[0]))
		{
			return converter.ConvertFromString(array[0]);
		}
		return null;
	}
}
