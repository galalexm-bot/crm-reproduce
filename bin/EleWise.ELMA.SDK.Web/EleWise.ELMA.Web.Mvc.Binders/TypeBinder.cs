using System;
using System.Web.Mvc;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class TypeBinder : IModelBinder
{
	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
		if (value == null)
		{
			return null;
		}
		string attemptedValue = value.get_AttemptedValue();
		if (string.IsNullOrEmpty(attemptedValue))
		{
			return null;
		}
		if (Guid.TryParse(attemptedValue, out var result))
		{
			return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(result);
		}
		return Type.GetType(attemptedValue, throwOnError: true);
	}
}
