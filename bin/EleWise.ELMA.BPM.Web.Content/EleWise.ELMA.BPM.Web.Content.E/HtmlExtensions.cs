using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Menu;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Buttons;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.BPM.Web.Content.Extensions;

public static class HtmlExtensions
{
	private const string PageSettingsUrlContextKey = "WorkPlaceCustomizer.PageSettingsUrl";

	public static MvcHtmlString FilterTreeToolbar(this HtmlHelper html)
	{
		FilterTreeEditModel filterTreeEditModel = new FilterTreeEditModel();
		return PartialExtensions.Partial(html, "FilterTreeContent/FilterTreeToolbar", (object)filterTreeEditModel);
	}

	public static bool FilterTreeEnabledFavorites(this HtmlHelper html, string activeMenuItemCode)
	{
		return ComponentManager.Current.GetExtensionPoints<IFilterFavoriteMenuExtension>().Any((IFilterFavoriteMenuExtension p) => p.HasMenuItemCode(activeMenuItemCode));
	}

	public static bool PortletPageInFavorites(this HtmlHelper html, long id, string activeMenuItemCode)
	{
		Guid guid = Guid.Empty;
		Guid? code = null;
		IFilterFavoriteMenuExtension filterFavoriteMenuExtension = ComponentManager.Current.GetExtensionPoints<IFilterFavoriteMenuExtension>().FirstOrDefault((IFilterFavoriteMenuExtension p) => p.HasMenuItemCode(activeMenuItemCode));
		if (filterFavoriteMenuExtension != null)
		{
			guid = filterFavoriteMenuExtension.GetFilterTreeTypeUid();
			code = filterFavoriteMenuExtension.GetFilterTreeCode();
		}
		if (guid == Guid.Empty)
		{
			return false;
		}
		if (EntityManager<IPageBase>.Instance.LoadOrNull(id) != null)
		{
			ReferenceOnEntityType type = new ReferenceOnEntityType
			{
				TypeUid = guid
			};
			return (from f in FilterFolderManager.Instance.LoadFavoriteFilters(type, code)
				where f.ParentFolder != null
				select f).Cast<IFilterActionLink>().Any((IFilterActionLink f) => f.ActionId == id.ToString());
		}
		return false;
	}

	public static MvcHtmlString RegisterActionWizard(this HtmlHelper html, ActionWizardSettings settings)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_014d: Expected O, but got Unknown
		List<ActionWizardItemModel> list = new List<ActionWizardItemModel>();
		foreach (ILinkTypeProvider extensionPoint in ComponentManager.Current.GetExtensionPoints<ILinkTypeProvider>())
		{
			object[] customAttributes = extensionPoint.GetType().GetCustomAttributes(typeof(ActionWizardItemAttribute), inherit: false);
			if (customAttributes.Length != 0)
			{
				list.Add(new ActionWizardItemModel
				{
					Provider = extensionPoint,
					Attribute = (ActionWizardItemAttribute)customAttributes[0]
				});
			}
		}
		AddElmaElementModel addElmaElementModel = new AddElmaElementModel
		{
			Settings = settings,
			Actions = (from a in list
				where a.Attribute.Category == ActionWizardItemCategory.Action
				orderby a.Attribute.Order
				select a).ToList(),
			Links = (from a in list
				where a.Attribute.Category == ActionWizardItemCategory.Link
				orderby a.Attribute.Order
				select a).ToList()
		};
		ViewDataDictionary val = new ViewDataDictionary();
		TemplateInfo val2 = new TemplateInfo();
		val2.set_HtmlFieldPrefix("HtmlEditorElement");
		val.set_TemplateInfo(val2);
		return PartialExtensions.Partial(html, "ContentAction/ContentActionWizard", (object)addElmaElementModel, val);
	}

	public static MvcHtmlString OpenActionWizard(this HtmlHelper html, ActionWizardSettings model)
	{
		return html.OpenPopup(model.PopupId, $"{model.PopupId}_resetContentActionWizard()");
	}

	public static MvcHtmlString GetFolderCrumbs([NotNull] this HtmlHelper html, IPageFolder currentFolder)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		IPageFolder pageFolder = currentFolder;
		StringBuilder stringBuilder = new StringBuilder();
		while (pageFolder != null)
		{
			string text = ((HtmlString)(object)LinkExtensions.ActionLink(html, pageFolder.Name, "Index", "Page", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content",
				id = pageFolder.Id
			}, (object)new { })).ToHtmlString();
			stringBuilder.Insert(0, (pageFolder.Id == currentFolder.Id) ? $"<span>{pageFolder.Name.HtmlEncode()}</span>" : text);
			stringBuilder.Insert(0, " \\ ");
			pageFolder = pageFolder.Folder;
		}
		stringBuilder.Insert(0, ((HtmlString)(object)LinkExtensions.ActionLink(html, SR.T("Страницы"), "Index", "Page", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content",
			id = (long?)null
		}, (object)new { })).ToHtmlString());
		return MvcHtmlString.Create(stringBuilder.ToString());
	}

	public static string GetFolderCrumbsText(this HtmlHelper html, IPageFolder currentFolder)
	{
		if (currentFolder == null)
		{
			return "\\";
		}
		IPageFolder pageFolder = currentFolder;
		StringBuilder stringBuilder = new StringBuilder();
		while (pageFolder != null)
		{
			stringBuilder.Insert(0, pageFolder.Name.HtmlEncode());
			stringBuilder.Insert(0, "\\");
			pageFolder = pageFolder.Folder;
		}
		return stringBuilder.ToString();
	}

	public static MvcHtmlString GetTinyExplorerCrumbs([NotNull] this HtmlHelper html, IPageFolder currentFolder, bool personal)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		IPageFolder pageFolder = currentFolder;
		StringBuilder stringBuilder = new StringBuilder();
		string text = html.Url().Action("Content", "PagesExplorer", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content",
			id = (long?)null
		});
		while (pageFolder != null)
		{
			stringBuilder.Insert(0, (pageFolder.Id == currentFolder.Id) ? $"<span>{pageFolder.Name.HtmlEncode()}</span>" : string.Format("<a href=\"javascript:void(0)\" objectId=\"{0}\" data-url=\"{2}\" data-personal=\"{3}\">{1}</a>", pageFolder.Id, pageFolder.Name.HtmlEncode(), text, personal));
			stringBuilder.Insert(0, " \\ ");
			pageFolder = pageFolder.Folder;
		}
		stringBuilder.Insert(0, (currentFolder == null) ? string.Format("<span>{0}</span>", SR.T("Корневая папка")) : string.Format("<a href=\"javascript:void(0)\" objectId=\"0\" data-url=\"{1}\" data-personal=\"{2}\">{0}</a>", SR.T("Корневая папка"), text, personal));
		return MvcHtmlString.Create(stringBuilder.ToString());
	}

	public static MvcHtmlString SortablePagesList([NotNull] this HtmlHelper html, string explorerId, int height)
	{
		html.get_ViewData().set_Item("Height", (object)height);
		html.get_ViewData().set_Item("ExplorerId", (object)explorerId);
		return PartialExtensions.Partial(html, "WorkplacePages/SortablePagesList");
	}

	public static void SetWorkPlaceCustomizerPageSettingsUrl([NotNull] this HtmlHelper html, string url)
	{
		ContextVars.Set("WorkPlaceCustomizer.PageSettingsUrl", url);
	}

	public static string GetWorkPlaceCustomizerPageSettingsUrl([NotNull] this HtmlHelper html)
	{
		return ContextVars.GetOrDefault<string>("WorkPlaceCustomizer.PageSettingsUrl");
	}

	public static void HeaderBreadcrumbsInZone(this HtmlHelper htmlHelper, string title = null, bool setTitle = true)
	{
		MvcHtmlString breadcrumbs = htmlHelper.HeaderBreadcrumbs(title, setTitle);
		if (!MvcHtmlString.IsNullOrEmpty(breadcrumbs))
		{
			htmlHelper.RenderInZone("Header", (dynamic d) => breadcrumbs);
		}
	}

	public static MvcHtmlString HeaderBreadcrumbs(this HtmlHelper htmlHelper, string title = null, bool setTitle = true)
	{
		bool flag = string.IsNullOrWhiteSpace(title);
		if (setTitle && !flag)
		{
			htmlHelper.Title(title);
		}
		MenuModel menuModel = htmlHelper.GetMenuModel(MenuManager.LeftMenuUid, throwIfNotFound: true, skipChildNonActiveItems: true);
		if (menuModel != null && menuModel.ActiveItems != null && menuModel.ActiveItems.Count > 0)
		{
			int num = menuModel.ActiveItems.Count - 1;
			ButtonGroupBuilder buttonGroupBuilder = htmlHelper.Breadcrumbs("header-breadcrumbs-view");
			for (int num2 = num; num2 >= 0; num2--)
			{
				MenuItemNode menuItemNode = menuModel.ActiveItems[num2];
				if (!menuItemNode.Disabled && !menuItemNode.IsHome)
				{
					ActionButtonBuilder actionButtonBuilder = htmlHelper.Button().Text(menuItemNode.Name);
					if (flag && num2 == 0)
					{
						if (setTitle)
						{
							htmlHelper.Title(menuItemNode.Name);
						}
					}
					else
					{
						actionButtonBuilder.Url(menuItemNode.Url);
					}
					buttonGroupBuilder.Item(actionButtonBuilder);
				}
			}
			if (!flag)
			{
				buttonGroupBuilder.Item(delegate(ActionButtonBuilder btn)
				{
					btn.Text(title);
				});
			}
			return MvcHtmlString.Create(buttonGroupBuilder.ToHtmlString());
		}
		return MvcHtmlString.Empty;
	}
}
