using System;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Binders;

internal class PasswordBinder : ElmaModelBinder
{
	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		string[] array = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName()).get_RawValue() as string[];
		PasswordSettings passwordSettings = bindingContext.get_ModelMetadata().GetPropertyMetadata().Settings as PasswordSettings;
		if (array != null && array.Length != 0 && !string.IsNullOrEmpty(array[0]))
		{
			return new PasswordInfo(array[0], passwordSettings?.PasswordType ?? Guid.Empty);
		}
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(ElmaModelBinder.GetPrefix(bindingContext) + "Hash");
		ValueProviderResult value2 = bindingContext.get_ValueProvider().GetValue(ElmaModelBinder.GetPrefix(bindingContext) + "Salt");
		return new PasswordInfo((value != null) ? value.get_AttemptedValue() : "", (value2 != null) ? value2.get_AttemptedValue() : "", passwordSettings.PasswordType);
	}
}
