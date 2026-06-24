using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Documents.Web.Integration.Buttons;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 11)]
public class HomeIndexCreateDocumentToolbarButton : IActionItemProvider
{
	public const string CREAEDOCUMENTBUTTON_GUID = "Documents_CreateDocumentToolbarButton";

	public const string CREATE_GUID = "Tasks_CreateTaskToobarButton";

	private readonly ISecurityService securityService;

	private readonly IEnumerable<IControllerActionProvider> contentActionProviders;

	public HomeIndexCreateDocumentToolbarButton(ISecurityService securityService, IEnumerable<IControllerActionProvider> contentActionProviders)
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
		ActionToolbarGroup actionToolbarGroup = rootItem.Items.FirstOrDefault((IActionItem item) => item != null && (item.Uid == "HomePageToolbarGroup" || item.Uid == "DocumentHomePageGroup")) as ActionToolbarGroup;
		if (!securityService.HasPermission(PermissionProvider.DocumentsAccessPermission) || actionToolbarGroup == null)
		{
			return;
		}
		IActionItem actionItem = actionToolbarGroup.Items.FirstOrDefault((IActionItem m) => m.Uid == "Tasks_CreateTaskToobarButton");
		if (actionItem != null)
		{
			actionItem.Items.AddSequense(GetItems(rootItem, htmlHelper));
			return;
		}
		ActionToolbarItem actionToolbarItem = GetItems(rootItem, htmlHelper).FirstOrDefault((IActionItem i) => i.Uid == "Documents_CreateDocumentToolbarButton") as ActionToolbarItem;
		if (actionToolbarItem != null)
		{
			actionToolbarItem.Text = SR.T("Создать документ");
			actionToolbarItem.IsMainAction = true;
		}
		actionToolbarGroup.Items.Add(actionToolbarItem);
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && rootItem.Items.Any((IActionItem item) => item is ActionToolbarGroup && (item.Uid == "HomePageToolbarGroup" || item.Uid == "DocumentHomePageGroup")))
		{
			IContentAction contentAction = All().FirstOrDefault((IContentAction ci) => ci.Id == "EleWise.ELMA.Documents.Web-Module-CreateDocument");
			if (contentAction != null)
			{
				ActionMenuItem actionMenuItem = (ActionMenuItem)contentAction.CreateButton(htmlHelper);
				actionMenuItem.Uid = "Documents_CreateDocumentToolbarButton";
				actionMenuItem.Text = SR.T("Документ");
				actionMenuItem.IconUrl = "#add_doc.svg";
				yield return actionMenuItem;
			}
		}
	}
}
