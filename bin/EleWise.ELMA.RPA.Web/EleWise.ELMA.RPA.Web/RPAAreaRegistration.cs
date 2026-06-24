using System.Web.Mvc;

namespace EleWise.ELMA.RPA.Web;

public class RPAAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.RPA.Web";

	public override string AreaName => "EleWise.ELMA.RPA.Web";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("RPA_default", "RPA/{controller}/{action}/{id}", (object)new
		{
			action = "Index",
			id = UrlParameter.Optional
		}, new string[1] { "EleWise.ELMA.RPA.Web.Controllers" });
	}
}
