using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class HtmlStringModelBinder : IModelBinder
{
	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
		return new HtmlString(((value != null) ? value.get_AttemptedValue() : null) ?? "");
	}
}
