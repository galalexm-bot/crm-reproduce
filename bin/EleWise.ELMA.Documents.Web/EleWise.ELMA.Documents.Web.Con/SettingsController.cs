using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Portlets;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Documents.Web.Controllers;

[RouteArea("EleWise.ELMA.Documents.Web")]
[Permission("2818B96D-D686-418C-8CCB-6D37815F1497")]
public class SettingsController : DmsObjectController
{
	[Permission("2818B96D-D686-418C-8CCB-6D37815F1497")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View("Settings/DmsModuleSettingsPage", (object)ComponentManager.Current.GetExtensionPoints<IModuleSettingsDmsPageProvider>().ToList());
	}

	public PartialViewResult HomePortlet(DocumentsHomePortletPersonalization settings)
	{
		return ((Controller)this).PartialView("HomePortlet", (object)ComponentManager.Current.GetExtensionPoints<IModuleSettingsDmsPageProvider>().ToList());
	}
}
