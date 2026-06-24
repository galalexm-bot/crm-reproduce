using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Messages.Web.Components;

[Component(EnableInterceptors = false, InjectProerties = false, Order = 3)]
internal sealed class SendMessageUserProfileToolbarButton : IActionItemProvider
{
	private readonly ISecurityService securityService;

	public const string SENDMESSAGE_GUID = "Messages_SendMessageUserProfileToolbarButton";

	private const string CREATE_GUID = "Tasks_CreateTaskUserProfileToobarButton";

	public SendMessageUserProfileToolbarButton(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar")
		{
			return;
		}
		EleWise.ELMA.Security.Models.IUser userFromModel = htmlHelper.GetUserFromModel();
		if (userFromModel != null && userFromModel.Status != UserStatus.Blocked && securityService.HasPermission(PermissionProvider.MessagesAccessPermission) && rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "UserProfileButtonActionsGroup") is ActionToolbarGroup actionToolbarGroup)
		{
			actionToolbarGroup.Items.FirstOrDefault((IActionItem m) => m.Uid == "Tasks_CreateTaskUserProfileToobarButton")?.Items.AddSequense(GetItems(rootItem, htmlHelper));
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		EleWise.ELMA.Security.Models.IUser userFromModel = htmlHelper.GetUserFromModel();
		if (userFromModel != null)
		{
			htmlHelper.RegisterContent("AddChannelMessageSelectorWindow", (dynamic d) => ChildActionExtensions.Action(htmlHelper, "AddMessageSelectorWindow", "ChannelMessage", (object)new
			{
				area = "EleWise.ELMA.Messages.Web"
			}));
			yield return new ActionToolbarItem("Messages_SendMessageUserProfileToolbarButton")
			{
				Text = SR.T("Сообщение"),
				IconUrl = "#add_event.svg",
				ToolTip = SR.T("Создать сообщение"),
				Click = $"javascript:AddChannelMessageWindowContent(null, {userFromModel.Id})"
			};
		}
	}
}
