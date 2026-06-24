using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security;

public class SecurityAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.BPM.Web.Security";

	public override string AreaName => "EleWise.ELMA.BPM.Web.Security";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("Security_default", "Security/{controller}/{action}/{id}", (object)new
		{
			action = "Index",
			id = UrlParameter.Optional
		}, new string[1] { "EleWise.ELMA.BPM.Web.Security.Controllers" });
	}
}
