using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IPortlet
{
	Guid Uid { get; }

	string Id { get; }

	string Name { get; }

	string Category { get; }

	string Description { get; }

	string Author { get; }

	string WebSite { get; }

	string Module { get; }

	IPortletProfile Profile { get; }

	bool AllowMultipleInstance { get; }

	bool AllowGadget { get; }

	bool GoodExternalSupported { get; }

	Type SettingsType { get; }

	PortletPersonalization CreateDefaultSettings(string path);

	string GetNameUrl(UrlHelper urlHelper, PortletPersonalization data);

	[Obsolete("Use GetNameUrl(UrlHelper, PortletPersonalization)", false)]
	string GetNameUrl(UrlHelper urlHelper);

	void BeforeRender(HtmlHelper html, PortletPersonalization data);

	void BeforeEditRender(HtmlHelper html, PortletPersonalization data);

	MvcHtmlString RenderHeader(HtmlHelper html, PortletPersonalization data);

	MvcHtmlString RenderContent(HtmlHelper html, PortletPersonalization data);

	MvcHtmlString RenderSettings(HtmlHelper html, PortletPersonalization data, string path);

	bool HasPermission();

	bool HasViewPermission(PortletPersonalization data);

	bool CanChangeProperty(PortletPersonalization portletPersonalization, string name, string path);
}
