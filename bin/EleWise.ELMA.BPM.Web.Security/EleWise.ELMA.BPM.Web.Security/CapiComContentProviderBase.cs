using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Security.Components;

public abstract class CapiComContentProviderBase : ICryptoProviderWebBase
{
	public abstract Guid ProviderUid { get; }

	public virtual MvcHtmlString RenderCertificateSelector(HtmlHelper htmlHelper, CertificateSelectorModel model)
	{
		return PartialExtensions.Partial(htmlHelper, "Certificate/CapiComCertificateSelector", (object)model);
	}

	public virtual MvcHtmlString PrepareAttachCertificate(HtmlHelper htmlHelper, PrepareAttachCertificateModel model)
	{
		return PartialExtensions.Partial(htmlHelper, "Certificate/CapiComAttachCertificateContent", (object)model);
	}

	public virtual void RegisterScripts(HtmlHelper htmlHelper)
	{
		htmlHelper.RegisterScriptSrc("~/Modules/EleWise.ELMA.BPM.Web.Security/Scripts/certificate.js");
	}
}
