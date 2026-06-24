using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component]
public class CapiComAuthContentProvider : CapiComContentProviderBase, IAuthCryptoProviderWeb, ICryptoProviderWebBase
{
	public CapiComAuthCryptoProvider CapiComProvider { get; set; }

	public IAuthCryptoProvider Provider => CapiComProvider;

	public override Guid ProviderUid => CapiComProvider.ProviderUid;

	public bool CanRender(HtmlHelper htmlHelper)
	{
		return true;
	}

	public MvcHtmlString PrepareCertificateLogOn(HtmlHelper htmlHelper, PrepareLogOnCertificateModel model)
	{
		return PartialExtensions.Partial(htmlHelper, "Certificate/CapiComLogOn", (object)model);
	}
}
