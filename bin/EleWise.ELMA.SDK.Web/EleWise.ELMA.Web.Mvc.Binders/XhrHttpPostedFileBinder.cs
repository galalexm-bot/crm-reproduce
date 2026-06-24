using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Binders;

internal class XhrHttpPostedFileBinder : IModelBinder
{
	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return XhrPostedFile.Create(controllerContext.get_RequestContext().HttpContext.Request, bindingContext.get_ModelName()) ?? new HttpPostedFileBaseModelBinder().BindModel(controllerContext, bindingContext);
	}
}
