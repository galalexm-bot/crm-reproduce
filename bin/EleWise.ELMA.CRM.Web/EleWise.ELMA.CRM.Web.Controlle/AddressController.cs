using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.ExtensionPoints;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class AddressController : BPMController
{
	private ActionResult AddressProviderWeb(long? countryCode, IAddress model)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		IAddressProviderWeb addressProviderWeb = ComponentManager.Current.GetExtensionPoints<IAddressProviderWeb>().FirstOrDefault((IAddressProviderWeb p) => p.CountryCode == countryCode);
		if (addressProviderWeb == null)
		{
			return null;
		}
		if (string.IsNullOrWhiteSpace(addressProviderWeb.EditorPartialViewName))
		{
			return (ActionResult)new EmptyResult();
		}
		return (ActionResult)(object)((Controller)this).PartialView(addressProviderWeb.EditorPartialViewName, (object)model.ConvertTo(addressProviderWeb.AddressType));
	}

	public ActionResult ProviderRegion(string htmlFieldPrefix, IAddress address, string addressJsonState)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		IAddress address2 = address ?? InterfaceActivator.Create<IAddress>();
		if (!string.IsNullOrWhiteSpace(addressJsonState))
		{
			new EntityJsonSerializer().Deserialize(addressJsonState, address2, loadEntityIfExists: false);
		}
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix(htmlFieldPrefix);
		viewData.set_TemplateInfo(val);
		long? countryCode = ((address2.Country != null) ? new long?(address2.Country.CountryCode) : null);
		return (ActionResult)(((object)AddressProviderWeb(countryCode, address2)) ?? ((object)((Controller)this).PartialView("DefaultProviderRegion", (object)address2)));
	}

	public JsonResult GetAddressItems(int type, long? countryCode = null, Guid? parent = null, string text = null)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		IEnumerable<IAddrBase> addrs = ((type == 1) ? AddrManager.Instance.GetRegions(type, countryCode, text) : (parent.HasValue ? AddrManager.Instance.GetChildren(parent, type, text) : Enumerable.Empty<IAddrBase>()));
		JsonResult val = new JsonResult();
		val.set_Data((object)AddressItem.GetItems(addrs));
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val;
	}

	public static AddressItem GetAddressItem(string name, int type, long? countryCode = null)
	{
		return AddressItem.GetItem(AddrManager.Instance.FindItem(type, name, countryCode));
	}

	[HttpPost]
	public string GenerateAddress(IAddress model)
	{
		ICountry country = model.Country;
		IAddressProvider obj = ((country != null) ? ComponentManager.Current.GetExtensionPoints<IAddressProvider>().FirstOrDefault((IAddressProvider p) => p.CountryCode == country.CountryCode) : null);
		return AddrManager.Instance.GenerateName(obj?.AddressFormatTemplate ?? AddressHelper.FormatTemplate, model);
	}
}
