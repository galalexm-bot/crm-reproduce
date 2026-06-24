using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Code;

public class CertificateAlternativeMethodLogOnHelper
{
	private class ProviderDigitalSignatureTypes
	{
		public Guid ProviderUid { get; set; }

		public IEnumerable<DigitalSignatureType> DigitalSignatureTypes { get; set; }
	}

	private class DigitalSignatureType
	{
		public Guid Uid { get; set; }

		public string DisplayName { get; set; }
	}

	public static CertificateAlternativeMethodLogOnHelper Instance
	{
		get
		{
			IEnumerable<IAuthCryptoProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IAuthCryptoProvider>();
			AuthCryptoProviderService serviceNotNull = Locator.GetServiceNotNull<AuthCryptoProviderService>();
			SecuritySettingsModule serviceNotNull2 = Locator.GetServiceNotNull<SecuritySettingsModule>();
			return new CertificateAlternativeMethodLogOnHelper(extensionPoints, serviceNotNull, serviceNotNull2);
		}
	}

	private IEnumerable<IAuthCryptoProvider> AuthCryptoProviders { get; set; }

	private AuthCryptoProviderService AuthCryptoProviderService { get; set; }

	private SecuritySettingsModule SecuritySettingsModule { get; set; }

	public Guid DefaultAuthCryptoProviderUid => SecuritySettingsModule.Settings.DefaultAuthCryptoProviderSettings.CryptoProviderUid;

	public Guid DefaultAuthDigitalSignatureTypeUid => SecuritySettingsModule.Settings.DefaultAuthCryptoProviderSettings.DigitalSignatureTypeUid;

	private CertificateAlternativeMethodLogOnHelper(IEnumerable<IAuthCryptoProvider> authCryptoProviders, AuthCryptoProviderService authCryptoProviderService, SecuritySettingsModule securitySettingsModule)
	{
		AuthCryptoProviders = authCryptoProviders;
		AuthCryptoProviderService = authCryptoProviderService;
		SecuritySettingsModule = securitySettingsModule;
	}

	public IEnumerable<SelectListItem> GetCryptoProviderSelectList()
	{
		return AuthCryptoProviders.Select((Func<IAuthCryptoProvider, SelectListItem>)delegate(IAuthCryptoProvider p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			SelectListItem val = new SelectListItem();
			val.set_Value(p.ProviderUid.ToString());
			val.set_Text(p.DisplayName);
			return val;
		});
	}

	public IEnumerable<SelectListItem> GetCurrentDigitalSignatureTypeSelectList()
	{
		ProviderDigitalSignatureTypes providerDigitalSignatureTypes = GetListProviderDigitalSignatureTypes().FirstOrDefault((ProviderDigitalSignatureTypes i) => i.ProviderUid == DefaultAuthCryptoProviderUid);
		if (providerDigitalSignatureTypes == null)
		{
			return new List<SelectListItem>();
		}
		return providerDigitalSignatureTypes.DigitalSignatureTypes.Select((Func<DigitalSignatureType, SelectListItem>)delegate(DigitalSignatureType i)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			SelectListItem val = new SelectListItem();
			val.set_Value(i.Uid.ToString());
			val.set_Text(i.DisplayName);
			return val;
		});
	}

	public string GetSerializedProviderDigitalSignatureTypes()
	{
		IEnumerable<ProviderDigitalSignatureTypes> listProviderDigitalSignatureTypes = GetListProviderDigitalSignatureTypes();
		return new JsonSerializer().Serialize(listProviderDigitalSignatureTypes);
	}

	private IEnumerable<ProviderDigitalSignatureTypes> GetListProviderDigitalSignatureTypes()
	{
		List<ProviderDigitalSignatureTypes> list = new List<ProviderDigitalSignatureTypes>();
		foreach (IAuthCryptoProvider authCryptoProvider in AuthCryptoProviders)
		{
			IEnumerable<DigitalSignatureType> digitalSignatureTypes = from t in AuthCryptoProviderService.GetDigitalSignatureTypesByProviderUid(authCryptoProvider.ProviderUid).Distinct((IDigitalSignatureType l, IDigitalSignatureType r) => l.Uid.Equals(r.Uid), (IDigitalSignatureType i) => i.Uid.GetHashCode())
				select new DigitalSignatureType
				{
					Uid = t.Uid,
					DisplayName = t.DisplayName
				};
			list.Add(new ProviderDigitalSignatureTypes
			{
				ProviderUid = authCryptoProvider.ProviderUid,
				DigitalSignatureTypes = digitalSignatureTypes
			});
		}
		return list;
	}
}
