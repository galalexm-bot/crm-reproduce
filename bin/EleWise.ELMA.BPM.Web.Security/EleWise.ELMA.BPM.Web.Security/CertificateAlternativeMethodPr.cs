using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component(EnableInterceptiors = false, InjectProerties = true, Order = 20)]
public class CertificateAlternativeMethodProvider : IAlternativeMethodProvider
{
	public const string UID_S = "{6E328F91-1B04-4AFD-B594-0CAE3DC492F3}";

	public AuthCryptoProviderService AuthCryptoProviderService { get; set; }

	public string DisplayName => SR.T("Войти по сертификату");

	public SelectListItem NewListItem => (SelectListItem)(object)AlternativeMethodListItem.Item(DisplayName, ProviderUid.ToString("N"), "/Content/IconPack/regicon.svg");

	public Guid ProviderUid => new Guid("{6E328F91-1B04-4AFD-B594-0CAE3DC492F3}");

	public bool CanRender(HtmlHelper html)
	{
		if (Locator.GetServiceNotNull<SecuritySettingsModule>().Settings.AllowLoginByCertificate)
		{
			return AuthCryptoProviderService.Providers.Any();
		}
		return false;
	}

	public MvcHtmlString RenderContent(HtmlHelper html)
	{
		SecuritySettings settings = Locator.GetServiceNotNull<SecuritySettingsModule>().Settings;
		if (settings.AllowLoginByCertificate)
		{
			if (!settings.AllowLoginOnlyByDefaultCertificate)
			{
				return PartialExtensions.Partial(html, "LogOn/CertificateAlternativeMethodByCrypto");
			}
			return PartialExtensions.Partial(html, "LogOn/CertificateAlternativeMethodByLogin");
		}
		return MvcHtmlString.Empty;
	}
}
