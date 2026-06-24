using System.Web.Mvc;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.DTO.Managers;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Models.Help;

namespace EleWise.ELMA.Web.DTO.Managers;

public class WebHelpDTOManager : DTOManager, IWebHelpDTOManager, IConfigurationService
{
	private class FakeController : Controller
	{
		[HttpGet]
		public ActionResult Action()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			return (ActionResult)new EmptyResult();
		}
	}

	public virtual string GetHelpUrl(string pagePath)
	{
		ControllerContext val = ControllerContextCreator.Create((Controller)(object)new FakeController());
		return Locator.GetServiceNotNull<WebHelpService>().GetPageUrl(val.get_HttpContext(), pagePath).Trim();
	}
}
