using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Views.Page;

public class HomePageManagmentController : BPMController
{
	public IEntityManager<IHomePageSetting> HomePageManager { get; set; }

	[ContentItem(Name = "SR.M('Главные страницы')", Image24 = "#access.svg")]
	public ActionResult Index()
	{
		IWorkplacePages workplacePages = WorkplacePagesManager.Instance.Load(WorkPlaceManager.DefaultWorkplacePagesUid);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Edit", "WorkplacePages", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content",
			id = workplacePages.Id
		});
	}
}
