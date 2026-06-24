using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class PingController : Controller
{
	public ActionResult Ping()
	{
		if (Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser() == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new[]
			{
				new
				{
					f = "elma.logout"
				}
			}, (JsonRequestBehavior)0);
		}
		var array = (from p in ComponentManager.Current.GetExtensionPoints<IPingDataExtension>().Select(delegate(IPingDataExtension p)
			{
				try
				{
					return new
					{
						f = p.ClientFunction,
						d = p.GetData()
					};
				}
				catch
				{
					return null;
				}
			})
			where p != null
			select p).ToArray();
		return (ActionResult)(object)((Controller)this).Json((object)array, (JsonRequestBehavior)0);
	}
}
