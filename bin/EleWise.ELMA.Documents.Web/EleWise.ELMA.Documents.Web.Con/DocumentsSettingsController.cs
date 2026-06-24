using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Documents.Web.Controllers;

[AnyPermission(new string[] { "7B1CC80C-1AD0-404A-8564-06DE4B269469", "2818B96D-D686-418C-8CCB-6D37815F1497" })]
public class DocumentsSettingsController : BPMController
{
	public DocumentsSettingsModule SettingsModule { get; set; }

	public DocumentsSettings Settings => SettingsModule.Settings;

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
