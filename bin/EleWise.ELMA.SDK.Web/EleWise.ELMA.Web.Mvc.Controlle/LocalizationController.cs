using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Util;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class LocalizationController : BaseController
{
	[HttpGet]
	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "id", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult Load(string id)
	{
		string msg;
		Dictionary<string, string> jSPoStrings = LocalizationUtility.GetJSPoStrings(id, out msg);
		if (jSPoStrings == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				message = msg
			}, (JsonRequestBehavior)0);
		}
		return (ActionResult)(object)((Controller)this).Json((object)jSPoStrings, (JsonRequestBehavior)0);
	}
}
