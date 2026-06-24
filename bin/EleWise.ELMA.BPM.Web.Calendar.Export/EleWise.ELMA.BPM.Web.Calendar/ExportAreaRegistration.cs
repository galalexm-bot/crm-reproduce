using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Calendar.Export;

public class ExportAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.BPM.Web.Calendar.Export";

	public override string AreaName => "EleWise.ELMA.BPM.Web.Calendar.Export";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("Export_default", "Export/{controller}/{action}/{id}", (object)new
		{
			controller = "Scheduler",
			action = "Index",
			id = UrlParameter.Optional
		}, new string[1] { "EleWise.ELMA.BPM.Web.Calendar.Export.Controllers" });
	}
}
