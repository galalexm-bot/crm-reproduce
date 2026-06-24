using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Calendar;

public class CalendarAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.BPM.Web.Calendar";

	public override string AreaName => "EleWise.ELMA.BPM.Web.Calendar";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("Calendar_default", "Calendar/{controller}/{action}/{id}", (object)new
		{
			controller = "Scheduler",
			action = "Index",
			id = UrlParameter.Optional
		}, new string[1] { "EleWise.ELMA.BPM.Web.Calendar.Controllers" });
	}
}
