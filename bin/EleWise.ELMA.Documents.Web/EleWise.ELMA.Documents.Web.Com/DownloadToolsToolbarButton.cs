using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 60)]
internal sealed class DownloadToolsToolbarButton : IActionItemProvider
{
	private readonly ISecurityService securityService;

	private readonly PackageService packageService;

	public DownloadToolsToolbarButton(ISecurityService securityService, PackageService packageService)
	{
		this.securityService = securityService;
		this.packageService = packageService;
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		IActionItem actionItem = rootItem.Items.FirstOrDefault((IActionItem m) => m != null && m.Uid == "DownloadToolbarButton") ?? new ActionToolbarItem("DownloadToolbarButton")
		{
			Text = SR.T("Загрузки"),
			IconUrl = "#download.svg"
		};
		if ((securityService.HasPermission(CommonPermissions.AdminPermission) || securityService.HasPermission(CommonPermissions.DesignerAccessPermission)) && packageService != null && packageService.Initialized && packageService.IsDesignerInstallerAvailable())
		{
			actionItem.Items.Add(new ActionToolbarItem
			{
				Text = SR.T("Дизайнер ELMA"),
				Url = htmlHelper.Url().Action("DesignerInstaller", "Packages", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common"
				}),
				IconUrl = "#process.svg"
			});
		}
		yield return actionItem;
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar" || !(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "UserProfileButtonActionsGroup") is ActionToolbarGroup) || !(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "MoreButtonToolbarGroup") is ActionToolbarGroup actionToolbarGroup))
		{
			return;
		}
		IActionItem additionalButton = actionToolbarGroup.Items.FirstOrDefault((IActionItem m) => m.Uid == "more_btn");
		if (additionalButton != null)
		{
			GetItems(additionalButton, htmlHelper).ForEach(delegate(IActionItem item)
			{
				additionalButton.Items.Add(item);
			});
		}
	}
}
