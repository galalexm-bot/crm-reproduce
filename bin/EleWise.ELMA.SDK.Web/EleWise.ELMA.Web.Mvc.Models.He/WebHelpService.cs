using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Models.Help;

[Service(Scope = ServiceScope.Shell, Type = (ComponentType.Web | ComponentType.Test))]
public class WebHelpService
{
	public IEnumerable<IHelpPageUrlProvider> HelpPageUrlProviders { get; set; }

	public string GetPageUrl(ControllerContext controllerContext)
	{
		if (controllerContext == null)
		{
			throw new ArgumentNullException("controllerContext");
		}
		string text = HelpPageUrlProviders.Select((IHelpPageUrlProvider p) => p.FindUrl(controllerContext)).FirstOrDefault((string s) => !string.IsNullOrWhiteSpace(s));
		if (text != null)
		{
			return HttpUtility.HtmlEncode(text).ToString();
		}
		throw new InvalidOperationException(SR.T("Невозможно определить адрес справки для текущего запроса"));
	}

	public string GetPageUrl(HttpContextBase httpContext, string pagePath)
	{
		if (httpContext == null)
		{
			throw new ArgumentNullException("httpContext");
		}
		return (from p in HelpPageUrlProviders.OfType<IHelpPageUrlProviderEx>()
			select p.FindUrl(httpContext, pagePath)).FirstOrDefault((string s) => !string.IsNullOrWhiteSpace(s)) ?? "";
	}
}
