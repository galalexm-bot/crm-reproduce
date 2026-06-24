using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Portlets.Binders;

public class PortletPersonalizationBinder : DefaultModelBinder
{
	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		if (controllerContext.get_IsChildAction() && controllerContext.get_RouteData().Values.ContainsKey("PortletData"))
		{
			return controllerContext.get_RouteData().Values["PortletData"];
		}
		return ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
	}
}
