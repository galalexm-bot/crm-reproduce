using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

public interface ICryptoProviderWebBase
{
	Guid ProviderUid { get; }

	void RegisterScripts(HtmlHelper htmlHelper);

	MvcHtmlString RenderCertificateSelector(HtmlHelper htmlHelper, CertificateSelectorModel model);

	MvcHtmlString PrepareAttachCertificate(HtmlHelper htmlHelper, PrepareAttachCertificateModel model);
}
