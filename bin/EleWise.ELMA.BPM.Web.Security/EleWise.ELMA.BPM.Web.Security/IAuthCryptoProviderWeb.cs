using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IAuthCryptoProviderWeb : ICryptoProviderWebBase
{
	IAuthCryptoProvider Provider { get; }

	bool CanRender(HtmlHelper htmlHelper);

	MvcHtmlString PrepareCertificateLogOn(HtmlHelper htmlHelper, PrepareLogOnCertificateModel model);
}
