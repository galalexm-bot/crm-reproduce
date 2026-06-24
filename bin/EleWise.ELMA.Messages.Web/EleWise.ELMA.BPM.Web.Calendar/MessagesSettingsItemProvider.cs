using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Models.Buttons;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component]
internal sealed class MessagesSettingsItemProvider : IModuleSettingsItemProvider
{
	private SecurityService securityService;

	public MessagesSettingsItemProvider(SecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool Check(string id)
	{
		return id == "messages-admin-settings";
	}

	public IEnumerable<LinkButton> GetItems(UrlHelper urlHelper)
	{
		List<LinkButton> list = new List<LinkButton>();
		list.Add(new LinkButton
		{
			Href = urlHelper.Action("Index", "Settings", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				module = "EleWise.ELMA.Messages",
				title = SR.T("Настройки модуля «Сообщения»")
			}),
			Image = "#setting_outline.svg",
			Text = SR.T("Настройки модуля «Сообщения»")
		});
		if (securityService.HasPermission(EleWise.ELMA.Security.PermissionProvider.AccessManagmentPermission))
		{
			list.Add(new LinkButton
			{
				Href = urlHelper.Action("GlobalPermissions", "PermissionManagment", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Security",
					module = "EleWise.ELMA.BPM.Web.Messages",
					currentMenu = "messages-admin-settings",
					title = SR.T("Права доступа к модулю «Сообщения»")
				}),
				Image = "#access.svg",
				Text = SR.T("Права доступа к модулю «Сообщения»")
			});
		}
		if (securityService.HasPermission(EleWise.ELMA.Messages.PermissionProvider.ChannelManagmentPermission))
		{
			list.Add(new LinkButton
			{
				Href = urlHelper.Action("Groups", "InformationChannel", (object)new
				{
					area = "EleWise.ELMA.Messages.Web"
				}),
				Text = SR.T("Информационные каналы"),
				Image = "#channel.svg"
			});
		}
		return list;
	}
}
