using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class EntityModelBinder : IModelBinder
{
	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		return Activator.CreateInstance(bindingContext.get_ModelMetadata().get_ModelType());
	}
}
