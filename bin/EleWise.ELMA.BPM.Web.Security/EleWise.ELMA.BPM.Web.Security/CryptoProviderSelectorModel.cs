using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class CryptoProviderSelectorModel
{
	private class ProviderDigitalSignatureTypesModel
	{
		public Guid ProviderUid { get; set; }

		public Guid OriginalProviderUid { get; set; }

		public bool Default { get; set; }

		public IEnumerable<DigitalSignatureTypeModel> DigitalSignatureTypes { get; set; }

		public ProviderDigitalSignatureTypesModel()
		{
			DigitalSignatureTypes = new List<DigitalSignatureTypeModel>();
		}
	}

	public long UserId { get; set; }

	public IEnumerable<ICryptoProviderBase> Providers { get; set; }

	public Guid SelectedProviderUid { get; set; }

	public Guid DefaultProviderUid { get; set; }

	public IEnumerable<IDigitalSignatureType> DigitalSignatureTypes { get; set; }

	public Guid SelectedDigitalSignatureTypeUid { get; set; }

	public Guid DefaultDigitalSignatureTypeUid { get; set; }

	public string Action { get; set; }

	public string Controller { get; set; }

	public string Area { get; set; }

	public string PopupId { get; set; }

	public List<SelectListItem> SelectListProviders => GetAllowProviders().Select((Func<CryptoProviderBaseModel, SelectListItem>)delegate(CryptoProviderBaseModel i)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		SelectListItem val = new SelectListItem();
		val.set_Text(i.DisplayName);
		val.set_Value(i.Uid.ToString());
		return val;
	}).ToList();

	public List<SelectListItem> SelectListDigitalSignatureTypes
	{
		get
		{
			ProviderDigitalSignatureTypesModel providerDigitalSignatureTypesModel = GetAllowDigitalSignatureTypes().FirstOrDefault((ProviderDigitalSignatureTypesModel dst) => dst.ProviderUid == SelectedProviderUid);
			if (providerDigitalSignatureTypesModel != null)
			{
				return providerDigitalSignatureTypesModel.DigitalSignatureTypes.Select((Func<DigitalSignatureTypeModel, SelectListItem>)delegate(DigitalSignatureTypeModel dst)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0011: Unknown result type (might be due to invalid IL or missing references)
					//IL_002c: Expected O, but got Unknown
					SelectListItem val = new SelectListItem();
					val.set_Text(dst.DisplayName);
					val.set_Value(dst.Uid.ToString());
					return val;
				}).ToList();
			}
			return new List<SelectListItem>();
		}
	}

	public string DigitalSignatureTypesJson
	{
		get
		{
			IEnumerable<ProviderDigitalSignatureTypesModel> allowDigitalSignatureTypes = GetAllowDigitalSignatureTypes();
			return new JsonSerializer().Serialize(allowDigitalSignatureTypes);
		}
	}

	public CryptoProviderSelectorModel()
	{
		Providers = new List<ICryptoProviderBase>();
		DigitalSignatureTypes = new List<IDigitalSignatureType>();
	}

	private IEnumerable<ProviderDigitalSignatureTypesModel> GetAllowDigitalSignatureTypes()
	{
		IEnumerable<CryptoProviderBaseModel> allowProviders = GetAllowProviders();
		List<ProviderDigitalSignatureTypesModel> list = new List<ProviderDigitalSignatureTypesModel>();
		foreach (CryptoProviderBaseModel allowProvider in allowProviders)
		{
			List<IDigitalSignatureType> source = DigitalSignatureTypes.Where((IDigitalSignatureType udst) => udst.Providers.Contains(allowProvider.OriginalUid)).Distinct((IDigitalSignatureType l, IDigitalSignatureType r) => l.Uid == r.Uid, (IDigitalSignatureType i) => i.Uid.GetHashCode()).ToList();
			List<DigitalSignatureTypeModel> list2 = source.Select((IDigitalSignatureType udst) => new DigitalSignatureTypeModel
			{
				DisplayName = udst.DisplayName,
				Uid = udst.Uid,
				OriginalUid = udst.Uid,
				Default = false
			}).ToList();
			if (allowProvider.Default)
			{
				IDigitalSignatureType digitalSignatureType = source.FirstOrDefault((IDigitalSignatureType u) => u.Uid == DefaultDigitalSignatureTypeUid && u.Providers.Contains(allowProvider.OriginalUid));
				list2.Insert(0, new DigitalSignatureTypeModel
				{
					DisplayName = SR.T("По умолчанию ({0})", (digitalSignatureType != null) ? digitalSignatureType.DisplayName : SR.T("Не выбран")),
					Uid = Guid.Empty,
					OriginalUid = (digitalSignatureType?.Uid ?? Guid.Empty),
					Default = true
				});
			}
			list.Add(new ProviderDigitalSignatureTypesModel
			{
				ProviderUid = allowProvider.Uid,
				DigitalSignatureTypes = list2,
				Default = allowProvider.Default,
				OriginalProviderUid = allowProvider.OriginalUid
			});
		}
		return list;
	}

	private IEnumerable<CryptoProviderBaseModel> GetAllowProviders()
	{
		List<ICryptoProviderBase> source = Providers.Distinct((ICryptoProviderBase l, ICryptoProviderBase r) => l.ProviderUid == r.ProviderUid).ToList();
		ICryptoProviderBase cryptoProviderBase = source.FirstOrDefault((ICryptoProviderBase p) => p.ProviderUid == DefaultProviderUid);
		List<CryptoProviderBaseModel> list = source.Select((ICryptoProviderBase p) => new CryptoProviderBaseModel
		{
			DisplayName = p.DisplayName,
			Uid = p.ProviderUid,
			OriginalUid = p.ProviderUid,
			Default = false
		}).ToList();
		list.Insert(0, new CryptoProviderBaseModel
		{
			DisplayName = SR.T("По умолчанию ({0})", (cryptoProviderBase != null) ? cryptoProviderBase.DisplayName : SR.T("Не выбран")),
			Uid = Guid.Empty,
			OriginalUid = (cryptoProviderBase?.ProviderUid ?? Guid.Empty),
			Default = true
		});
		return list;
	}
}
