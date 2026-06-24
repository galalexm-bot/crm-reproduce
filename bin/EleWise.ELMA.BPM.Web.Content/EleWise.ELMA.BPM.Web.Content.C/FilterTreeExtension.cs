using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class FilterTreeExtension : IFilterTreeButtonsExtension
{
	public string ItemTextExtraButtons(UrlHelper url, FilterTreeItem item)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		if (item.FolderType.Contains("folder") && FilterFolderManager.Instance.HasEditPermission(item.FolderId) && serviceNotNull.HasPermission(EleWise.ELMA.Content.PermissionProvider.UseContentRegistry) && item.FilterType != FilterType.FavoriteFilter)
		{
			return HtmlExtensions.ImageButton(url, "~/Content/IconPack/add.svg", "", $"filterAddActionLink(\"{item.FolderId}\")", null, new
			{
				@class = "tree-item-button",
				tooltipheader = SR.T("Создать ссылку на действие"),
				tooltiptext = SR.T("Ссылка на действие позволяет перейти на любое действие в системе")
			});
		}
		if (item.FolderType.Contains("action") && FilterFolderManager.Instance.HasEditPermission(item.FolderId) && serviceNotNull.HasPermission(EleWise.ELMA.Content.PermissionProvider.UseContentRegistry))
		{
			return ((item.FilterType != FilterType.FavoriteFilter) ? HtmlExtensions.ImageButton(url, "~/Content/IconPack/edit.svg", "", $"editFilterActionLink(\"{item.FolderId}\")", null, new
			{
				@class = "tree-item-button",
				tooltipheader = SR.T("Изменить ссылку"),
				tooltiptext = SR.T("Можно изменить: действие, права доступа")
			}) : "") + HtmlExtensions.ImageButton(url, "~/Content/IconPack/basket.svg", "", $"deleteFilterActionLink(\"{item.FolderId}\")", null, new
			{
				@class = "tree-item-button",
				tooltipheader = SR.T("Удалить ссылку"),
				tooltiptext = SR.T("Удалить ссылку на действие")
			});
		}
		return string.Empty;
	}
}
