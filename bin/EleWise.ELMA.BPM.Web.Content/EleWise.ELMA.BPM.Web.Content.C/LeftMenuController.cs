using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class LeftMenuController : BaseMenuController<ILeftMenu>
{
	[ContentItem(Name = "SR.M('Левое меню')", Id = "EleWise.ELMA.BPM.Web.Content.Controllers.MenuController.Index", Image24 = "#menu.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View("Index");
	}

	protected override IWorkPlace[] GetWorkPlaces(ILeftMenu menu)
	{
		WorkPlaceManager instance = WorkPlaceManager.Instance;
		InstanceOf<IWorkPlaceFilter> instanceOf = new InstanceOf<IWorkPlaceFilter>();
		instanceOf.New.LeftMenu = menu;
		return instance.Find(instanceOf.New, null).ToArray();
	}

	[TransactionAction]
	public override ActionResult CreateNew(ILeftMenu menu, long workPlaceId)
	{
		IWorkPlace workPlace = WorkPlaceManager.Instance.LoadOrNull(workPlaceId);
		if (workPlace == null || workPlace.Uid == WorkPlaceManager.DefaultWorkPlaceUid)
		{
			if (menu != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Links", (object)new { menu.Id });
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		ILeftMenu leftMenu = ((menu != null) ? MenuManager.Instance.CloneMenu(menu) : InterfaceActivator.Create<ILeftMenu>());
		leftMenu.Name = SR.T("Левое меню ({0})", workPlace.Name);
		leftMenu.Description = null;
		leftMenu.Save();
		workPlace.LeftMenu = leftMenu;
		workPlace.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Links", (object)new { leftMenu.Id });
	}
}
