using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class ContractorBaseAddressController : BPMController
{
	public CrmSettingsModule SettingsModule { get; set; }

	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult Settings()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		return (ActionResult)(object)((Controller)this).View((object)(from i in ComponentManager.Current.GetExtensionPoints<IAddressBaseSettings>().SelectMany((IAddressBaseSettings p) => p.Settings(((Controller)this).get_Url()))
			where !string.IsNullOrWhiteSpace(i.Name) && !string.IsNullOrWhiteSpace(i.Value)
			select i));
	}

	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult DefaultCountry()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		return (ActionResult)(object)((Controller)this).View((object)SettingsModule.Settings);
	}

	[HttpPost]
	public ActionResult DefaultCountrySave(CrmSettings model)
	{
		SettingsModule.Settings.DefaultCountry = model.DefaultCountry;
		SettingsModule.SaveSettings();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Admin");
	}
}
