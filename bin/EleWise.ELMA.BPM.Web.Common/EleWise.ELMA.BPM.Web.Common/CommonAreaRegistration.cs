using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common;

public class CommonAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.BPM.Web.Common";

	public override string AreaName => "EleWise.ELMA.BPM.Web.Common";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("Common_default", "Common/{controller}/{action}/{id}", (object)new
		{
			action = "Index",
			id = UrlParameter.Optional
		}, new string[1] { "EleWise.ELMA.BPM.Web.Common.Controllers" });
	}
}
