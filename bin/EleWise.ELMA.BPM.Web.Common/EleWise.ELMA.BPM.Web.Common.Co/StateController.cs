using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class StateController : BaseController
{
	public virtual ActionResult SaveMenuState(MenuState model)
	{
		if (model != null && !string.IsNullOrEmpty(model.Id))
		{
			StateExtensions.SaveState(model.Id, model);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}
}
