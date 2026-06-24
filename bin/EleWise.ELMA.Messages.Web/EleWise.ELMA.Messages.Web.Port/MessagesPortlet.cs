using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Messages.Web.Portlets;

[Component]
public class MessagesPortlet : Portlet<MessagesPortletPersonalization>
{
	public static string UID_S = "{84FF0FCF-59A3-4992-BD74-CAE2B545D935}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	private const bool autoName = true;

	private const bool autoUrl = true;

	public override Guid Uid => UID;

	public override string Name => SR.T("Лента сообщений");

	public override string Description => SR.T("Портлет отображения моих сообщений");

	public virtual bool AutoName => true;

	public virtual bool AutoUrl => true;

	public override IPortletProfile Profile => _profile;

	public override bool AllowMultipleInstance => true;

	public MessagesPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#messages.svg";
	}

	public override void BeforeRender(HtmlHelper html, MessagesPortletPersonalization data)
	{
		UpdateNameAndUrl(html, data);
		base.BeforeRender(html, data);
	}

	public override void BeforeEditRender(HtmlHelper html, MessagesPortletPersonalization data)
	{
		UpdateNameAndUrl(html, data);
		base.BeforeEditRender(html, data);
	}

	protected virtual void UpdateNameAndUrl(HtmlHelper html, MessagesPortletPersonalization data)
	{
		if (data.ChannelId > -1)
		{
			string text = ((html != null) ? html.Url().InformationChannel(data.ChannelId) : "");
			if ((string.IsNullOrEmpty(data.NameUrl) || Portlet<MessagesPortletPersonalization>.IsUrlsEquas(data.NameUrl, text)) && AutoUrl)
			{
				data.NameUrl = text;
			}
			if (AutoName && string.IsNullOrWhiteSpace(data.Name))
			{
				IInformationChannel informationChannel = InformationChannelManager.Instance.LoadOrNull(data.ChannelId);
				if (informationChannel != null)
				{
					data.Name = "#" + informationChannel.Name;
				}
			}
		}
		if (AutoUrl)
		{
			if (html != null && string.IsNullOrEmpty(data.NameUrl))
			{
				data.NameUrl = html.Url().Action("List", "BaseMessage", (object)new
				{
					area = "EleWise.ELMA.Messages.Web"
				});
			}
			data.NameUrl = data.NameUrl;
		}
		if (html != null)
		{
			base.BeforeEditRender(html, data);
		}
	}

	public override MvcHtmlString Content(HtmlHelper html, MessagesPortletPersonalization data)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		if (data.ChannelId == -2)
		{
			return new MvcHtmlString("");
		}
		if (data.ChannelId == -1)
		{
			return RenderContentAction(html, "FeedPortlet", "Feed", "EleWise.ELMA.Messages.Web", data);
		}
		return RenderContentAction(html, "MessagePortlet", "BaseMessage", "EleWise.ELMA.Messages.Web", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, MessagesPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "BaseMessage/MessagePortletSettings", data);
	}

	protected override Permission PortletPermission()
	{
		return null;
	}

	public override bool CanChangeProperty(PortletPersonalization portletPersonalization, string name, string path)
	{
		if (portletPersonalization is MessagesPortletPersonalization messagesPortletPersonalization && name == "ShowOnlyNew")
		{
			return messagesPortletPersonalization.CanChangePropertyShowOnlyNew();
		}
		return base.CanChangeProperty(portletPersonalization, name, path);
	}

	protected override bool HasViewPermission(MessagesPortletPersonalization data)
	{
		if (data.ChannelId == -1)
		{
			return base.HasViewPermission(data);
		}
		IInformationChannel channel = null;
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			channel = InformationChannelManager.Instance.LoadOrNull(data.ChannelId);
		});
		if (channel != null)
		{
			if (base.SecurityService.HasPermission(PermissionProvider.ChannelViewPermission, channel))
			{
				return base.HasViewPermission(data);
			}
			return false;
		}
		return base.HasViewPermission(data);
	}
}
