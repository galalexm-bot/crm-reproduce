using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Messages.Web.Integration.Buttons;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 3)]
public class HomeIndexCreateMessagesToolbarButton : IActionItemProvider
{
	public const string SENDMESSAGEBUTTON_GUID = "Messages_SendMessageToolbarButton";

	private const string CreateButtonUid = "Tasks_CreateTaskToobarButton";

	private readonly ISecurityService securityService;

	private readonly IEnumerable<IControllerActionProvider> contentActionProviders;

	public HomeIndexCreateMessagesToolbarButton(ISecurityService securityService, IEnumerable<IControllerActionProvider> contentActionProviders)
	{
		this.securityService = securityService;
		this.contentActionProviders = contentActionProviders;
	}

	private IEnumerable<IContentAction> All()
	{
		return contentActionProviders.SelectMany((IControllerActionProvider p) => p.Actions());
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar")
		{
			return;
		}
		IActionItem createButton = (rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "HomePageToolbarGroup") as ActionToolbarGroup)?.Items?.FirstOrDefault((IActionItem i) => i.Uid == "Tasks_CreateTaskToobarButton");
		if (createButton != null)
		{
			GetItems(rootItem, htmlHelper).ForEach(delegate(IActionItem item)
			{
				createButton.Items.Add(item);
			});
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && rootItem.Items.Any((IActionItem item) => item is ActionToolbarGroup && item.Uid == "HomePageToolbarGroup"))
		{
			IContentAction contentAction = All().FirstOrDefault((IContentAction ci) => ci.Id == "EleWise.ELMA.Messagess.Web-Module-CreateMessages");
			if (contentAction != null)
			{
				ActionToolbarItem actionToolbarItem = (ActionToolbarItem)contentAction.CreateButton(htmlHelper);
				actionToolbarItem.IconUrl = "#add_message.svg";
				actionToolbarItem.Uid = "Messages_SendMessageToolbarButton";
				actionToolbarItem.Text = SR.T("Сообщение");
				yield return actionToolbarItem;
			}
		}
	}
}
