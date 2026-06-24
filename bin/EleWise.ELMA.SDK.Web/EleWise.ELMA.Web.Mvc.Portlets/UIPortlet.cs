using System;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public class UIPortlet : Portlet<UIPortletPersonalization>
{
	private PortletDescriptor _descriptor;

	public override Guid Uid => _descriptor.HeaderUid;

	public override string Name => _descriptor.Metadata.DisplayName;

	public override string Category => SR.T("Портлеты конфигурации");

	public override string Description => _descriptor.Metadata.Description;

	public override Type SettingsType => _descriptor.PersonalizationType;

	public UIPortlet(PortletDescriptor descriptor)
		: base(initFromSelfType: false)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		Contract.ArgumentNotNull(descriptor, "descriptor");
		_descriptor = descriptor;
		PortletProfile @default = PortletProfile.Default;
		PortletMetadata portletMetadata = (PortletMetadata)descriptor.Metadata;
		MetadataImage icon = portletMetadata.Icon;
		portletMetadata.GetNamedImage("CD097E40E88B466B833FC69F312600AF");
		if (!string.IsNullOrWhiteSpace(portletMetadata.IconUrl) && (icon == null || HostingEnvironment.VirtualPathProvider.FileExists(portletMetadata.IconUrl)))
		{
			@default.ImageUrl = portletMetadata.IconUrl;
		}
		else if (icon != null && HttpContextAccessor.CurrentContext != null && HttpContextAccessor.CurrentContext.Request != null && HttpContextAccessor.CurrentContext.Request.RequestContext != null)
		{
			UrlHelper url = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
			@default.ImageUrl = url.FormImage(ObjectIconFormat.x24, descriptor, "CD097E40E88B466B833FC69F312600AF");
		}
		Profile = @default;
	}

	public override MvcHtmlString Content(HtmlHelper html, UIPortletPersonalization data)
	{
		return ChildActionExtensions.Action(html, "PortletContent", "UI", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			headerUid = Uid,
			settings = data,
			loadMode = (data.Collapsed ? DynamicLoadMode.Custom : DynamicLoadMode.Server)
		});
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		return (PortletPersonalization)Activator.CreateInstance(_descriptor.PersonalizationType);
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
