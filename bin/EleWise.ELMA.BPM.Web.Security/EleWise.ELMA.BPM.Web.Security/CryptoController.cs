using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class CryptoController : BPMController
{
	public IEnumerable<IAuthCryptoProvider> CryptoProviders { get; set; }

	public IEnumerable<IGlobalSettingsModule> Modules { get; set; }

	public AuthCryptoProviderService AuthCryptoProviderService { get; set; }

	public JsonResult GetDigitalSignatureTypes(Guid? providerUid)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		var list = (providerUid.HasValue ? AuthCryptoProviderService.GetDigitalSignatureTypesByProviderUid(providerUid.Value).Distinct((IDigitalSignatureType l, IDigitalSignatureType r) => l.Uid.Equals(r.Uid), (IDigitalSignatureType i) => i.Uid.GetHashCode()).ToList() : new List<IDigitalSignatureType>()).Select((IDigitalSignatureType i) => new
		{
			Value = i.Uid,
			Text = i.DisplayName
		}).ToList();
		if (list.Count == 0)
		{
			list.Add(new
			{
				Value = Guid.Empty,
				Text = SR.T("Не выбран")
			});
		}
		JsonResult val = new JsonResult();
		val.set_Data((object)list);
		return val;
	}

	[HttpGet]
	public ActionResult ViewPopup(Guid? provider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (!provider.HasValue)
		{
			return (ActionResult)new EmptyResult();
		}
		((ControllerBase)this).get_ViewData().set_Item("providerUid", (object)provider);
		return (ActionResult)(object)((Controller)this).PartialView((object)GetSettingsModule(provider));
	}

	[HttpGet]
	public ActionResult EditPopup(Guid? provider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (!provider.HasValue)
		{
			return (ActionResult)new EmptyResult();
		}
		((ControllerBase)this).get_ViewData().set_Item("providerUid", (object)provider);
		return (ActionResult)(object)((Controller)this).PartialView((object)GetSettingsModule(provider));
	}

	[CustomGridAction]
	public ActionResult ProvidersList(GridCommand command)
	{
		GridData<ICryptoProviderBase> gridData = CryptoProviders.Cast<ICryptoProviderBase>().CreateGridData();
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpPost]
	public JsonResult SaveProviderSettings(Guid? provider)
	{
		try
		{
			IGlobalSettingsModule settingsModule = GetSettingsModule(provider);
			if (settingsModule != null && settingsModule.Settings is CryptoProviderSettingsBase)
			{
				((Controller)this).TryUpdateModel<object>(settingsModule.Settings);
				settingsModule.SaveSettings();
			}
		}
		catch (Exception ex)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				reason = ex.Message
			});
		}
		return ((Controller)this).Json((object)new
		{
			success = true,
			reason = SR.T("Настройки криптопровайдера успешно сохранены")
		});
	}

	public ActionResult CertificationAuthorityEditor(string infoJson, int? index, string callback)
	{
		CertificationAuthorityEditorModel certificationAuthorityEditorModel = new CertificationAuthorityEditorModel
		{
			Index = index,
			CallbackFunctionName = callback
		};
		try
		{
			certificationAuthorityEditorModel.Info = infoJson.FromJson<CertificationAuthorityInfo>();
		}
		catch (Exception message)
		{
			certificationAuthorityEditorModel.Info = new CertificationAuthorityInfo();
			base.Logger.Error(message);
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)certificationAuthorityEditorModel);
	}

	private IGlobalSettingsModule GetSettingsModule(Guid? provider)
	{
		return Modules.FirstOrDefault((IGlobalSettingsModule m) => m.ModuleGuid.Equals(provider));
	}
}
