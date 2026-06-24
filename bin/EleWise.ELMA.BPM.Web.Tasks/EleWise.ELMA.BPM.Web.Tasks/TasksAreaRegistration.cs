using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks;

public class TasksAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.BPM.Web.Tasks";

	public override string AreaName => "EleWise.ELMA.BPM.Web.Tasks";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("Tasks_default", "Tasks/{controller}/{action}/{id}", (object)new
		{
			controller = "AllTasks",
			action = "Index",
			id = UrlParameter.Optional
		}, new string[1] { "EleWise.ELMA.BPM.Web.Tasks.Controllers" });
	}
}
