using System;
using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class ReferenceOnEntityBinder : DefaultModelBinder
{
	private static readonly TypeConverter converter = TypeDescriptor.GetConverter(typeof(ReferenceOnEntity));

	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName() + ".ObjectTypeUId");
		if (value != null && Guid.TryParse(value.get_AttemptedValue(), out var result))
		{
			ValueProviderResult value2 = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName() + ".ObjectId");
			if (value2 != null && long.TryParse(value2.get_AttemptedValue(), out var result2))
			{
				return new ReferenceOnEntity(result2, result);
			}
		}
		return ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
	}
}
