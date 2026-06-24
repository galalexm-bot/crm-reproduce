using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Messages.Web.Controllers;

[AnyPermission(new string[] { "7B1CC80C-1AD0-404A-8564-06DE4B269469", "39F0AC82-A80F-4403-A041-CFFD8E183FD3" })]
public class MessagesSettingsController : BPMController
{
	public MessagesSettingsModule SettingsModule { get; set; }

	public MessagesSettings Settings => SettingsModule.Settings;

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
