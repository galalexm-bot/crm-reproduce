using System.Web.Mvc;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;
using Orchard.Themes;

namespace EleWise.ELMA.Documents.Web.Controllers;

[RouteArea("EleWise.ELMA.Documents.Web")]
[Themed]
[Permission("410ABDDC-FC2D-46E6-BB5E-ADF1B41E49A1")]
public class HomeController : BaseController
{
	[ContentItem(Name = "SR.M('Документооборот')", Id = "EleWise.ELMA.Documents.Web-Module-HomePage", Image24 = "#folders.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}
}
