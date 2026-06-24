using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[AnyPermission(new string[] { "7B1CC80C-1AD0-404A-8564-06DE4B269469", "7e213bd2-19d2-4d4d-9964-6c14901a5917" })]
public class TasksSettingsController : BPMController
{
	public TasksSettingsModule SettingsModule { get; set; }

	public TasksSettings Settings => SettingsModule.Settings;

	[HttpGet]
	public ActionResult View()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	[HttpGet]
	public ActionResult Edit()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}
}
