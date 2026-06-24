using System;
using System.Web.Mvc;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.References;

namespace EleWise.ELMA.Web.Mvc.Binders;

internal class ReferenceOnTypeBinder : DefaultModelBinder
{
	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
		if (value != null)
		{
			string attemptedValue = value.get_AttemptedValue();
			if (string.IsNullOrWhiteSpace(attemptedValue))
			{
				return null;
			}
			(Guid, Guid) typeAndSubTypeFromStringWithDelimeter = ModelHelper.GetTypeAndSubTypeFromStringWithDelimeter(attemptedValue);
			return new ReferenceOnType(typeAndSubTypeFromStringWithDelimeter.Item1, typeAndSubTypeFromStringWithDelimeter.Item2);
		}
		return ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
	}
}
