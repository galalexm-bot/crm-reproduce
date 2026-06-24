using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public sealed class DefaultController : Controller
{
	public ActionResult StatusCode(string id)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		((Controller)this).get_Response().Status = id;
		return (ActionResult)new EmptyResult();
	}
}
