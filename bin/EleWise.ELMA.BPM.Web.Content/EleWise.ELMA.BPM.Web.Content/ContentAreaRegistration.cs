using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Content;

public class ContentAreaRegistration : AreaRegistration
{
	public override string AreaName => "Content";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("Content_default", "Content/{controller}/{action}/{id}", (object)new
		{
			action = "Index",
			id = UrlParameter.Optional
		}, new string[1] { "EleWise.ELMA.BPM.Web.Content.Controllers" });
	}
}
