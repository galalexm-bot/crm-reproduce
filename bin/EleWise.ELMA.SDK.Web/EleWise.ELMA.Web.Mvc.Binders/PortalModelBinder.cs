using System.Web.Mvc;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Models.Portal;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class PortalModelBinder : IModelBinder
{
	public const string PortalModelName = "portalPositionsData";

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		return GetPortalModel(bindingContext.GetValue<string>("portalPositionsData"));
	}

	public static PortalModel GetPortalModel(string model)
	{
		if (!string.IsNullOrEmpty(model))
		{
			return (PortalModel)new JsonSerializer().Deserialize(model, typeof(PortalModel));
		}
		return null;
	}
}
