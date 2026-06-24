using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class PageProfileController : BPMController<IPageProfile, long>
{
	public ActionResult View(long id)
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Content.Controllers.PageController.Index");
		IPageProfile pageProfile = base.Manager.Load(id);
		return (ActionResult)(object)((Controller)this).View((object)new PageProfileModel(pageProfile));
	}
}
