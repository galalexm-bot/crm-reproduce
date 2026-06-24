using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Web.Controllers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.Messages.Web.Menu;

[Component]
public class MessagesMenuItems : IMenuItemsProvider
{
	public const string messages = "messages";

	public const string messagesTree = "messages-tree";

	public const string MessagesSettings = "messages-admin-settings";

	public ISecurityService SecurityService { get; set; }

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action("EleWise.ELMA.Messagess.Web-Module-CreateMessages").Order(10).Container("create");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Action("EleWise.ELMA.Messagess.Web-Module-CreateMessages").Parent("create").Order(40)
			.Name(SR.M("Послать сообщение"))
			.Container("top");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("left");
		});
		factory.Action("MessagesPage").Name(SR.M("Сообщения")).Image24("#messages.svg")
			.Order(10)
			.Code("messages")
			.Container("left");
		factory.Action((BaseMessageController c) => c.MessagesSettingsPage()).Code("messages-admin-settings").Order(30)
			.Parent("commonhome")
			.Container("left");
	}
}
