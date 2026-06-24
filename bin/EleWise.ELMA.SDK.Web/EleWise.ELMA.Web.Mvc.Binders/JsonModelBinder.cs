using System.Web.Mvc;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class JsonModelBinder : IModelBinder
{
	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		try
		{
			string attemptedValue = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName()).get_AttemptedValue();
			return string.IsNullOrEmpty(attemptedValue) ? null : JsonConvert.DeserializeObject(attemptedValue, bindingContext.get_ModelType());
		}
		catch
		{
			return null;
		}
	}
}
