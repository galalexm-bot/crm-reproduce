using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public sealed class PortletViewModel
{
	private readonly string path;

	private readonly PersonalizationScope scope;

	private readonly string[] allowedProperties;

	private Calculated<MvcHtmlString> header = new Calculated<MvcHtmlString>();

	private Calculated<MvcHtmlString> settings = new Calculated<MvcHtmlString>();

	private Calculated<MvcHtmlString> content = new Calculated<MvcHtmlString>();

	public static readonly string[] SkipEditProperties = new string[8] { "Zone", "Order", "Closed", "Collapsed", "Minimized", "Shared", "Width", "Height" };

	public IPortlet Portlet { get; private set; }

	public string Path => path;

	public PersonalizationScope Scope => scope;

	public string[] AllowedProperties => allowedProperties;

	public bool AnyEditableProperties => AllowedProperties.Except(SkipEditProperties).Count() > 0;

	public PortletPersonalization Personalization { get; private set; }

	public bool CanClose { get; set; }

	public PortletViewModel(IPortlet portlet, PortletPersonalization personalization, string path, PersonalizationScope scope, string[] allowedProperties)
	{
		this.path = path;
		this.scope = scope;
		this.allowedProperties = allowedProperties;
		Portlet = portlet;
		Personalization = personalization;
		CanClose = allowedProperties.Contains("Closed");
	}

	public MvcHtmlString Name(HtmlHelper htmlHelper)
	{
		return MvcHtmlString.Create((!string.IsNullOrWhiteSpace(Personalization.Name)) ? SR.T(Personalization.Name) : SR.T(Portlet.Name));
	}

	public MvcHtmlString RenderHeader(HtmlHelper htmlHelper)
	{
		return header.Value(() => Portlet.RenderHeader(htmlHelper, Personalization));
	}

	public MvcHtmlString RenderContent(HtmlHelper htmlHelper)
	{
		return content.Value(() => Portlet.RenderContent(htmlHelper, Personalization));
	}

	public MvcHtmlString RenderSettings(HtmlHelper htmlHelper)
	{
		return settings.Value(() => Portlet.RenderSettings(htmlHelper, Personalization, path));
	}

	public string SettingsPrefix()
	{
		return SettingsPrefix(Personalization.InstanceId);
	}

	public static string SettingsPrefix(Guid instanceId)
	{
		return "Personalization" + UIExtensions.PrepareId(instanceId.ToString());
	}
}
