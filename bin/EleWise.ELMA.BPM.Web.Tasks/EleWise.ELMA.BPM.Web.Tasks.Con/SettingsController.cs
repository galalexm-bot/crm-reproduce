using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class SettingsController : BPMController<ISchedule, long>
{
	[ContentItem(Name = "SR.M('Задачи')", Image16 = "#task.svg")]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View("ModuleSettingsPage");
	}
}
