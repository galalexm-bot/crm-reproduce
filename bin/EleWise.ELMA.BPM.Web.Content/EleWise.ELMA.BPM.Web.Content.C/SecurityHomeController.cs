using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.Services;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;
using Orchard.Themes;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Content")]
[Themed]
public class SecurityHomeController : BaseController
{
	public IEntityManager<IPortletPage> PortletPageManager { get; set; }

	[ContentItem(Name = "SR.M('Администрирование - Домашняя страница')", Image24 = "~/Content/IconPack/home.svg")]
	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult Index()
	{
		IPortletPage portletPage = AbstractNHEntityManager<IPortletPage, long>.Instance.LoadOrNull(SecurityDefaultHomePageCreator.DefaultPageGuid);
		return (ActionResult)(object)((Controller)this).View((object)portletPage);
	}
}
