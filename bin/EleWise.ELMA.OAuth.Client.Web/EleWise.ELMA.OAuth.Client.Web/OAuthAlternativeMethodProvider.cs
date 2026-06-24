using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.OAuth.Client.Services;

namespace EleWise.ELMA.OAuth.Client.Web.Components;

[Component]
public class OAuthAlternativeMethodProvider : IAlternativeMethodProvider
{
	private readonly IEnumerable<IOAuthProvider> oAuthProvider;

	public const string Uid = "199F0025-9B9B-498C-B441-C3C6D55DE6B9";

	public Guid ProviderUid => new Guid("199F0025-9B9B-498C-B441-C3C6D55DE6B9");

	public string DisplayName => "Внешний провайдер";

	public SelectListItem NewListItem => (SelectListItem)(object)AlternativeMethodListItem.Item(DisplayName, ProviderUid.ToString("N"), "#web.svg");

	public OAuthAlternativeMethodProvider(IEnumerable<IOAuthProvider> oAuthProvider)
	{
		this.oAuthProvider = oAuthProvider;
	}

	public bool CanRender(HtmlHelper html)
	{
		return oAuthProvider.Any();
	}

	public MvcHtmlString RenderContent(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "LogOn/OAuthAlternativeMethodProvider", (object)oAuthProvider);
	}
}
