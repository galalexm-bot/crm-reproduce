using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public abstract class Portlet<TSettings> : IPortlet where TSettings : PortletPersonalization, new()
{
	private readonly Lazy<string> author;

	private readonly Lazy<string> module;

	private readonly Lazy<string> category;

	private readonly Lazy<string> webSite;

	private IPortletProfile _profile;

	public ISecurityService SecurityService { get; set; }

	public IModuleService ModuleService => Locator.GetServiceNotNull<IModuleService>();

	public abstract Guid Uid { get; }

	public string Id => Uid.ToString();

	public abstract string Name { get; }

	public virtual string Category => category.Value;

	public abstract string Description { get; }

	public virtual string Author
	{
		get
		{
			if (author == null)
			{
				return null;
			}
			return SR.M(author.Value);
		}
	}

	public virtual string WebSite
	{
		get
		{
			if (webSite == null)
			{
				return null;
			}
			return SR.T(webSite.Value);
		}
	}

	public virtual string Module
	{
		get
		{
			if (module == null)
			{
				return null;
			}
			return SR.M(module.Value);
		}
	}

	public virtual IPortletProfile Profile
	{
		get
		{
			return _profile ?? (_profile = PortletProfile.Default);
		}
		set
		{
			_profile = value;
		}
	}

	public virtual bool AllowMultipleInstance => false;

	public virtual bool AllowGadget => true;

	public virtual bool GoodExternalSupported => false;

	public virtual Type SettingsType => typeof(TSettings);

	protected Portlet()
		: this(initFromSelfType: true)
	{
	}

	protected Portlet(bool initFromSelfType)
	{
		author = new Lazy<string>(() => ModuleService.GetModuleByType(GetType())?.Author);
		module = new Lazy<string>(() => (from AssemblyProductAttribute a in GetType().Assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: true)
			select a.Product).FirstOrDefault());
		category = new Lazy<string>(() => ModuleService.GetModuleByType(GetType())?.DisplayName);
		webSite = new Lazy<string>(() => ModuleService.GetModuleByType(GetType())?.WebSite);
	}

	string IPortlet.GetNameUrl(UrlHelper urlHelper, PortletPersonalization data)
	{
		return GetNameUrl(urlHelper, CastSettings(data));
	}

	public virtual string GetNameUrl(UrlHelper urlHelper, TSettings data)
	{
		return GetNameUrl(urlHelper);
	}

	[Obsolete("Use GetNameUrl(UrlHelper, PortletPersonalization)", false)]
	public virtual string GetNameUrl(UrlHelper urlHelper)
	{
		return null;
	}

	public TSettings CastSettings(PortletPersonalization data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		TSettings val = data as TSettings;
		if (val == null)
		{
			if (data.GetType() != typeof(TSettings))
			{
				IPortletPersonalizationOldConverterExtensions portletPersonalizationOldConverterExtensions = ComponentManager.Current.GetExtensionPoints<IPortletPersonalizationOldConverterExtensions>().FirstOrDefault((IPortletPersonalizationOldConverterExtensions e) => e.OldSettingsType == data.GetType() && e.NewSettingsType == typeof(TSettings));
				if (portletPersonalizationOldConverterExtensions != null)
				{
					val = portletPersonalizationOldConverterExtensions.Convert(data) as TSettings;
				}
			}
			if (val == null)
			{
				val = (TSettings)CreateDefaultSettings(null);
			}
		}
		else
		{
			ComponentManager.Current.GetExtensionPoints<IPortletPersonalizationOldConverterExtensions>().FirstOrDefault((IPortletPersonalizationOldConverterExtensions e) => e.OldSettingsType == data.GetType() && e.NewSettingsType == typeof(TSettings))?.Update(data);
		}
		return val;
	}

	void IPortlet.BeforeRender(HtmlHelper html, PortletPersonalization data)
	{
		try
		{
			BeforeRender(html, CastSettings(data));
		}
		catch (Exception ex)
		{
			NullLogger.Instance.Warn(SR.T(ex.Message), ex);
			PartialExtensions.Partial(html, "Templates/Error", (object)ex);
		}
	}

	void IPortlet.BeforeEditRender(HtmlHelper html, PortletPersonalization data)
	{
		try
		{
			BeforeEditRender(html, CastSettings(data));
		}
		catch (Exception ex)
		{
			NullLogger.Instance.Warn(SR.T(ex.Message), ex);
			PartialExtensions.Partial(html, "Templates/Error", (object)ex);
		}
	}

	public MvcHtmlString RenderHeader(HtmlHelper html, PortletPersonalization data)
	{
		return Header(html, CastSettings(data));
	}

	public virtual void BeforeEditRender(HtmlHelper html, TSettings data)
	{
	}

	public MvcHtmlString RenderContent(HtmlHelper html, PortletPersonalization data)
	{
		try
		{
			return Content(html, CastSettings(data));
		}
		catch (Exception ex)
		{
			NullLogger.Instance.Warn(SR.T(ex.Message), ex);
			return PartialExtensions.Partial(html, "Templates/Error", (object)ex);
		}
	}

	public MvcHtmlString RenderSettings(HtmlHelper html, PortletPersonalization data, string path)
	{
		return Settings(html, CastSettings(data), path);
	}

	public virtual void BeforeRender(HtmlHelper html, TSettings data)
	{
	}

	public virtual MvcHtmlString Header(HtmlHelper html, TSettings data)
	{
		return MvcHtmlString.Empty;
	}

	public abstract MvcHtmlString Content(HtmlHelper html, TSettings data);

	public virtual MvcHtmlString Settings(HtmlHelper html, TSettings data, string path)
	{
		return null;
	}

	protected MvcHtmlString RenderContentAction(HtmlHelper html, string action, string controller, string area, TSettings data)
	{
		return ChildActionExtensions.Action(html, action, controller, (object)new
		{
			LoadMode = (data.Collapsed ? DynamicLoadMode.Custom : DynamicLoadMode.Server),
			area = area,
			viewId = Uid.ToString(),
			PortletData = data,
			settings = data
		});
	}

	protected MvcHtmlString RenderSettingsPartialView(HtmlHelper html, string partialViewName, TSettings data)
	{
		string htmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(PortletViewModel.SettingsPrefix(data.InstanceId));
		MvcHtmlString result = PartialExtensions.Partial(html, partialViewName, (object)data);
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
		return result;
	}

	public virtual PortletPersonalization CreateDefaultSettings(string path)
	{
		return new TSettings();
	}

	bool IPortlet.HasViewPermission(PortletPersonalization data)
	{
		return HasViewPermission(CastSettings(data));
	}

	protected virtual bool HasViewPermission(TSettings data)
	{
		return HasPermission();
	}

	public virtual bool HasPermission()
	{
		Permission permission = PortletPermission();
		if (permission == null)
		{
			return true;
		}
		return SecurityService.HasPermission(permission);
	}

	protected abstract Permission PortletPermission();

	public virtual bool CanChangeProperty(PortletPersonalization portletPersonalization, string name, string path)
	{
		return true;
	}

	public static bool IsUrlsEquas(string url1, string url2)
	{
		if (string.IsNullOrEmpty(url1) || string.IsNullOrEmpty(url2))
		{
			return false;
		}
		return Regex.Replace(url1, "((?<=\\=)|(?<=/))\\d+", "") == Regex.Replace(url2, "((?<=\\=)|(?<=/))\\d+", "");
	}
}
