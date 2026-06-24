using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Messages.Web.Extensions;

[Component]
public class MessageProfileActions : IProfileActionProviderPoint
{
	public IEnumerable<IProfileAction> GetProfileActions(HtmlHelper html, EleWise.ELMA.Security.Models.IUser user)
	{
		List<IProfileAction> list = new List<IProfileAction>();
		if (user.Status != UserStatus.Blocked && Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.MessagesAccessPermission))
		{
			list.Add(new SimpleProfileAction
			{
				ImageUrl = "#add_message.svg",
				ActionUrl = $"javascript:AddChannelMessageWindowContent(null, {user.Id})",
				Caption = SR.T("Сообщение"),
				Tooltip = SR.T("Послать сообщение данному пользователю"),
				Order = 30
			});
			html.RegisterContent("AddChannelMessageSelectorWindow", (dynamic d) => ChildActionExtensions.Action(html, "AddMessageSelectorWindow", "ChannelMessage", (object)new
			{
				area = "EleWise.ELMA.Messages.Web"
			}));
		}
		return list;
	}
}
