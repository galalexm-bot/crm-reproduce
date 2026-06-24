using System;
using System.Linq;
using System.Text;
using System.Web;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterTreeItem : TreeMenuNode
{
	public string Controller { get; set; }

	public string Area { get; set; }

	public bool IsDefault { get; set; }

	public bool IsSystemDefault { get; set; }

	public bool AccessSharedFilter { get; set; }

	public bool CanMakeDefault { get; set; }

	public long FolderId { get; set; }

	public string FolderType { get; set; }

	public FilterType FilterType { get; set; }

	public Guid ObjectsType { get; set; }

	public Guid? Code { get; set; }

	public string icon2 { get; set; }

	public override string GetEncodedText()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (!string.IsNullOrEmpty(icon2))
		{
			stringBuilder.AppendLine(base.Url.Image(icon2));
		}
		stringBuilder.AppendLine($"<span>{((base.isHtml || string.IsNullOrEmpty(base.text)) ? (base.text + base.textAdditional) : (HttpUtility.HtmlEncode(base.text) + base.textAdditional))}</span>");
		if ((FolderType.Contains("filter") || FolderType.Contains("action")) && !IsDefault && CanMakeDefault && FilterType != FilterType.FavoriteFilter)
		{
			stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#filter.svg", "", $"defaultFilter(\"{FolderId}\")", null, new
			{
				@class = "tree-item-button",
				tooltipheader = SR.T("Сделать собственным фильтром по умолчанию"),
				tooltiptext = SR.T("Установить этот фильтр как фильтр по умолчанию - он будет автоматически открываться при переходе в раздел")
			}));
		}
		if ((FolderType.Contains("filter") || FolderType.Contains("action")) && !IsSystemDefault && CanMakeDefault && FilterType != FilterType.MyFilter && AccessSharedFilter && FilterType != FilterType.FavoriteFilter)
		{
			stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#filter.svg", "", $"systemDefaultFilter(\"{FolderId}\")", null, new
			{
				@class = "tree-item-button",
				tooltipheader = SR.T("Сделать фильтром по умолчанию для всех"),
				tooltiptext = SR.T("Установить этот фильтр как фильтр по умолчанию для всех - он будет автоматически открываться при переходе в раздел, если не установлен собственный фильтр по умолчанию")
			}));
		}
		if (FilterType != FilterType.SystemFilter && (FilterType != 0 || AccessSharedFilter))
		{
			if (FolderType.Contains("folder") && FilterFolderManager.Instance.HasEditPermission(FolderId) && FilterType != FilterType.FavoriteFilter)
			{
				stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#folder_add.svg", "", $"filterAddFolder(\"{FolderId}\")", null, new
				{
					@class = "tree-item-button",
					tooltipheader = SR.T("Создать папку для фильтров"),
					tooltiptext = SR.T("Папки позволяют иерархически сгруппировать фильтры")
				}));
			}
			foreach (IFilterTreeButtonsExtension extensionPoint in ComponentManager.Current.GetExtensionPoints<IFilterTreeButtonsExtension>())
			{
				stringBuilder.AppendLine(extensionPoint.ItemTextExtraButtons(base.Url, this));
			}
			if ((FolderType.Contains("filter") || FolderType.Contains("folder")) && FilterFolderManager.Instance.HasEditPermission(FolderId))
			{
				if (FolderType.Contains("filter"))
				{
					IFilterTreeEditLink filterTreeEditLink = ComponentManager.Current.GetExtensionPoints<IFilterTreeEditLink>().FirstOrDefault((IFilterTreeEditLink p) => p.AvailableFilterType(ObjectsType));
					if (filterTreeEditLink != null)
					{
						stringBuilder.AppendLine(filterTreeEditLink.GenerateLink(base.Url, this));
					}
					else
					{
						stringBuilder.AppendLine(HtmlExtensions.ImageLink(base.Url, "#edit.svg", "", base.Url.Action("EditFilter", Controller, (object)new
						{
							area = Area,
							FilterId = FolderId,
							ReturnUrl = ((Controller == "Catalogs") ? base.Url.Action("EditFilters", Controller, (object)new
							{
								area = Area,
								uid = ObjectsType
							}) : base.Url.Action("EditFilters", Controller, (object)new
							{
								area = Area
							}))
						}), null, new
						{
							@class = "tree-item-button",
							tooltipheader = SR.T("Изменить фильтр"),
							tooltiptext = SR.T("Можно изменить: значения полей фильтрации, набор колонок в таблице, состав полей на форме поиска, права доступа")
						}));
					}
				}
				if (FolderType.Equals("folder"))
				{
					stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#edit.svg", "", $"filterEditFolder(\"{FolderId}\")", null, new
					{
						@class = "tree-item-button",
						tooltipheader = SR.T("Изменить папку"),
						tooltiptext = SR.T("Изменить название папки")
					}));
				}
				if (!FolderType.Equals("top_filter") && !FolderType.Equals("top_folder"))
				{
					stringBuilder.AppendLine(HtmlExtensions.ImageButton(base.Url, "#basket.svg", "", string.Format("deleteFilter(\"{0}\", {1})", FolderId, (FolderType == "folder").ToString().ToLower()), null, new
					{
						@class = "tree-item-button",
						tooltipheader = (FolderType.Contains("filter") ? SR.T("Удалить фильтр") : SR.T("Удалить папку с фильтрами")),
						tooltiptext = (FolderType.Contains("filter") ? SR.T("Удалить фильтр из дерева фильтров") : SR.T("Все подпапки и их содержимое будут удалены"))
					}));
				}
			}
		}
		return stringBuilder.ToString();
	}
}
