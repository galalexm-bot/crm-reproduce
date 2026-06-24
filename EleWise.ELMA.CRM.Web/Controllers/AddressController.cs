// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.AddressController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  public class AddressController : BPMController
  {
    private ActionResult AddressProviderWeb(long? countryCode, IAddress model)
    {
      IAddressProviderWeb addressProviderWeb = ComponentManager.Current.GetExtensionPoints<IAddressProviderWeb>().FirstOrDefault<IAddressProviderWeb>((Func<IAddressProviderWeb, bool>) (p =>
      {
        long countryCode1 = p.CountryCode;
        long? nullable = countryCode;
        long valueOrDefault = nullable.GetValueOrDefault();
        return countryCode1 == valueOrDefault & nullable.HasValue;
      }));
      if (addressProviderWeb == null)
        return (ActionResult) null;
      return string.IsNullOrWhiteSpace(addressProviderWeb.EditorPartialViewName) ? (ActionResult) new EmptyResult() : PartialView(addressProviderWeb.EditorPartialViewName, (object) model.ConvertTo(addressProviderWeb.AddressType));
    }

    public ActionResult ProviderRegion(
      string htmlFieldPrefix,
      IAddress address,
      string addressJsonState)
    {
      IAddress model = address ?? InterfaceActivator.Create<IAddress>();
      if (!string.IsNullOrWhiteSpace(addressJsonState))
        new EntityJsonSerializer().Deserialize(addressJsonState, (object) model, false);
      ((ControllerBase) this).ViewData.TemplateInfo = new TemplateInfo()
      {
        HtmlFieldPrefix = htmlFieldPrefix
      };
      return this.AddressProviderWeb(model.Country != null ? new long?(model.Country.CountryCode) : new long?(), model) ?? PartialView("DefaultProviderRegion", (object) model);
    }

    public JsonResult GetAddressItems(int type, long? countryCode = null, Guid? parent = null, string text = null)
    {
      IEnumerable<IAddrBase> addrs = type == 1 ? AddrManager.Instance.GetRegions((long) type, countryCode, text) : (parent.HasValue ? AddrManager.Instance.GetChildren(parent, (long) type, text) : Enumerable.Empty<IAddrBase>());
      return new JsonResult()
      {
        Data = (object) AddressItem.GetItems(addrs),
        JsonRequestBehavior = JsonRequestBehavior.AllowGet
      };
    }

    public static AddressItem GetAddressItem(string name, int type, long? countryCode = null) => AddressItem.GetItem(AddrManager.Instance.FindItem((long) type, name, countryCode));

    [HttpPost]
    public string GenerateAddress(IAddress model)
    {
      ICountry country = model.Country;
      return AddrManager.Instance.GenerateName((country != null ? ComponentManager.Current.GetExtensionPoints<IAddressProvider>().FirstOrDefault<IAddressProvider>((Func<IAddressProvider, bool>) (p => p.CountryCode == country.CountryCode)) : (IAddressProvider) null)?.AddressFormatTemplate ?? AddressHelper.FormatTemplate, model);
    }
  }
}
