using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class TrustedDeviceModel
{
	internal class TrustedDeviceModel_SR
	{
		public static string Name => SR.T("Наименование");

		public static string CreationDate => SR.T("Дата регистрации");

		public static string TrustedDeviceType => SR.T("Тип");

		public static string LastTouchDate => SR.T("Дата последнего использования");
	}

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(TrustedDeviceModel_SR), "Name")]
	public string Name { get; set; }

	public string Id { get; set; }

	[DisplayName(typeof(TrustedDeviceModel_SR), "CreationDate")]
	public DateTime CreationDate { get; set; }

	[DisplayName(typeof(TrustedDeviceModel_SR), "TrustedDeviceType")]
	public TrustedDeviceType TrustedDeviceType { get; set; }

	public string TrustedDeviceValue { get; set; }

	public string TrustedDeviceImageUrl { get; set; }

	[DisplayName(typeof(TrustedDeviceModel_SR), "LastTouchDate")]
	public DateTime? LastTouchDate { get; set; }

	public string AdditionalInfo { get; set; }

	public bool? IsDefault { get; set; }

	public TrustedDeviceModel()
	{
	}

	public TrustedDeviceModel(DeviceToken deviceToken)
	{
		TrustedDeviceType = TrustedDeviceType.TrustedDevice;
		TrustedDeviceImageUrl = "#computer.svg";
		Id = deviceToken.Token.ToString("N");
		Name = deviceToken.Name;
		TrustedDeviceValue = deviceToken.Token.ToString("N");
		CreationDate = deviceToken.CreationDate;
		LastTouchDate = deviceToken.LastLogonDate;
	}

	public TrustedDeviceModel(IUserCertificate certificate)
	{
		ICryptoProviderBase cryptoProviderBase = ComponentManager.Current.GetExtensionPoints<ICryptoProviderBase>().FirstOrDefault(delegate(ICryptoProviderBase p)
		{
			Guid providerUid = p.ProviderUid;
			Guid? cryptoProviderGuid = certificate.CryptoProviderGuid;
			return providerUid == cryptoProviderGuid;
		});
		ICertificateCryptoAction certificateCryptoAction = ComponentManager.Current.GetExtensionPoints<ICertificateCryptoAction>().FirstOrDefault(delegate(ICertificateCryptoAction p)
		{
			Guid actionUid = p.ActionUid;
			Guid? cryptoActionGuid = certificate.CryptoActionGuid;
			return actionUid == cryptoActionGuid;
		});
		TrustedDeviceType = TrustedDeviceType.Certificate;
		TrustedDeviceImageUrl = "#document_agreement.svg";
		Id = certificate.Id.ToString();
		Name = certificate.Name;
		TrustedDeviceValue = certificate.Thumbprint;
		AdditionalInfo = $"<span style=\"display:block\">{certificate.Thumbprint}</span><span style=\"display:block\">{((cryptoProviderBase != null) ? cryptoProviderBase.DisplayName : string.Empty)}</span>";
		CreationDate = certificate.CreationDate;
		LastTouchDate = certificate.LastTouchDate;
		IsDefault = ((certificateCryptoAction == null) ? null : ((!certificateCryptoAction.SupportOnlyDefaultCertificate) ? null : (certificate.IsDefault.HasValue ? new bool?(certificate.IsDefault.Value) : new bool?(false))));
	}

	public TrustedDeviceModel(IUserPublicKeyToken token)
	{
		TrustedDeviceType = TrustedDeviceType.Token;
		TrustedDeviceImageUrl = "#token.svg";
		Id = token.Id.ToString();
		Name = token.Name;
		TrustedDeviceValue = token.PublicKey;
		AdditionalInfo = token.DeviceId;
		CreationDate = token.CreationDate;
		LastTouchDate = token.LastLogonDate;
	}
}
