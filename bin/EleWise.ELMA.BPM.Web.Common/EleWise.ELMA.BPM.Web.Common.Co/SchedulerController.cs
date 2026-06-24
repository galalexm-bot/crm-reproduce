using System.Web.Mvc;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class SchedulerController : SchedulerControllerBase
{
	[HttpGet]
	[ContentItem(Name = "SR.M('Планировщик')", Image24 = "#clock.svg")]
	public override ActionResult Index()
	{
		return base.Index();
	}
}
