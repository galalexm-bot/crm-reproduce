using System.Web.Mvc;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class DropDownItemModelBinder : IModelBinder
{
	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		string value = bindingContext.GetValue<string>(bindingContext.get_ModelName());
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		return new DropDownItem(value);
	}
}
