using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Service(Scope = ServiceScope.Shell)]
public class FilterMenuProvider
{
	private readonly IComponentManager componentManager;

	private readonly FilterFolderManager filterFolderManager;

	private LazyWithReset<IEnumerable<KeyValuePair<Guid, Guid?>>> withoutAllItems;

	public FilterMenuProvider(IComponentManager componentManager, FilterFolderManager filterFolderManager)
	{
		this.componentManager = componentManager;
		this.filterFolderManager = filterFolderManager;
		withoutAllItems = new LazyWithReset<IEnumerable<KeyValuePair<Guid, Guid?>>>(EvaluteWithoutAllItems);
	}

	public bool ContainsCode(string Code)
	{
		return EvaluteActions().Any((FilterMenuItem v) => v.Code == Code);
	}

	public FilterMenuItem FilterMenuItemByTypeUidandCode(Guid TypeUid, Guid? Code)
	{
		EntityMetadata testMetadata = MetadataLoader.LoadMetadata(TypeUid) as EntityMetadata;
		if (testMetadata == null)
		{
			return null;
		}
		return EvaluteActions().FirstOrDefault(delegate(FilterMenuItem v)
		{
			if (v.TypeCode != Code)
			{
				return false;
			}
			if (v.TypeUid == TypeUid)
			{
				return true;
			}
			try
			{
				if (!(MetadataLoader.LoadMetadata(v.TypeUid) is EntityMetadata entityMetadata))
				{
					return false;
				}
				List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(entityMetadata);
				childClasses.Add(entityMetadata);
				return childClasses.Any((ClassMetadata classMetadata) => testMetadata.Uid == classMetadata.Uid);
			}
			catch (Exception)
			{
				return false;
			}
		});
	}

	public IEnumerable<FilterMenuItem> FilterMenuItemByCode(string Code)
	{
		return from v in EvaluteActions()
			where v.Code == Code
			select v;
	}

	[ContextCache]
	protected virtual IEnumerable<FilterMenuItem> EvaluteActions()
	{
		return componentManager.GetExtensionPoints<IFilterMenuItemExtension>().SelectMany((IFilterMenuItemExtension p) => p.FilterMenuItems()).ToList();
	}

	private IEnumerable<KeyValuePair<Guid, Guid?>> EvaluteWithoutAllItems()
	{
		return componentManager.GetExtensionPointTypes(typeof(IBaseController)).SelectMany((Type ct) => (from m in ct.GetMethods(BindingFlags.Instance | BindingFlags.Public)
			where m.ReturnType == typeof(ActionResult)
			select m).SelectMany((MethodInfo m) => from FilterMenuItemAttribute a in m.GetCustomAttributes(typeof(FilterMenuItemAttribute), inherit: true)
			where a.HideFilterAll
			select new KeyValuePair<Guid, Guid?>(a.TypeUid, a.Code))).ToArray();
	}

	public List<TreeMenuNode> TreeMenuNodes(Guid typeUid, TreeState treeState, ActionRoute routes, string FilterIdParameter = "FilterId", string ClickAction = null, Guid? code = null, bool includeFavorites = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		UrlHelper urlHelper = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
		return GetTree(Folders(typeUid, code, includeFavorites), treeState, urlHelper, routes, FilterIdParameter, ClickAction).ToList();
	}

	public List<TreeMenuNode> TreeMenuNodesWithoutAll(Guid typeUid, TreeState treeState, ActionRoute routes, string FilterIdParameter = "FilterId", string ClickAction = null, Guid? code = null, bool includeFavorites = false, bool excludeRootFolder = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		UrlHelper urlHelper = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
		IEnumerable<IFilterFolder> enumerable = FoldersWithoutAll(typeUid, code, includeFavorites);
		IFilterFolder parentFolder = (excludeRootFolder ? enumerable.FirstOrDefault((IFilterFolder f) => f.ParentFolder == null) : null);
		return GetTree(enumerable, treeState, urlHelper, routes, FilterIdParameter, ClickAction, parentFolder).ToList();
	}

	public FilterTreeEditModel TreeMenuNodesForEdit(Guid typeUid, Guid? code, bool includeFavorites = false, bool withoutAll = false, bool showBackButton = true)
	{
		string text = "FilterTree_" + ((typeUid != Guid.Empty || !code.HasValue) ? typeUid : code.Value);
		TreeState treeState = TreePersonalizationAdministration.LoadState(text);
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = text
			};
			TreePersonalizationAdministration.SaveState(text, treeState);
		}
		IEnumerable<IFilterFolder> enumerable = FoldersForEdit(typeUid, code, includeFavorites);
		bool accessSharedFilter = FilterFolderManager.Instance.HasSharedFilterPermission(enumerable.FirstOrDefault((IFilterFolder f) => f.FilterType == FilterType.SharedFilter));
		RouteValueDictionary values = HttpContextAccessor.CurrentContext.Request.RequestContext.RouteData.Values;
		ActionRoute routes = new ActionRoute((string)values["action"], (string)values["controller"], new
		{
			area = values["area"]
		});
		return new FilterTreeEditModel
		{
			TypeUid = typeUid,
			FilterTreeModel = new TreeModel
			{
				Id = text,
				Children = GetTreeForEdit(enumerable, routes, treeState, accessSharedFilter).ToList(),
				OnNodeDragStartFunction = "filterItemDragStart",
				OnNodeDraggingFunction = "filterItemDragging",
				OnNodeDroppedFunction = "filterItemDropped"
			},
			AccessSharedFilter = accessSharedFilter,
			Code = code,
			ShowBackButton = showBackButton
		};
	}

	private IEnumerable<IFilterFolder> GetFilterAll(ReferenceOnEntityType refType, Guid? code)
	{
		if (withoutAllItems.Value.All((KeyValuePair<Guid, Guid?> i) => i.Key != refType.TypeUid))
		{
			IFilter[] array = new IFilter[1];
			InstanceOf<IFilter> instanceOf = new InstanceOf<IFilter>();
			instanceOf.New.Name = SR.T("Все");
			instanceOf.New.Id = 0L;
			instanceOf.New.Weight = long.MinValue;
			instanceOf.New.FilterType = FilterType.SystemFilter;
			instanceOf.New.ObjectsType = refType;
			instanceOf.New.Code = code;
			array[0] = instanceOf.New;
			return array;
		}
		return new IFilterFolder[0];
	}

	public IEnumerable<IFilterFolder> Folders(Guid typeUid, Guid? code, bool includeFavorites = false)
	{
		ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType
		{
			TypeUid = typeUid
		};
		return from filter in GetFilterAll(referenceOnEntityType, code).Union(filterFolderManager.LoadFilterFolders(referenceOnEntityType, code, includeFavorites))
			orderby filter.Weight ?? filter.Id
			select filter;
	}

	public IEnumerable<IFilterFolder> FoldersWithoutAll(Guid typeUid, Guid? code, bool includeFavorites = false)
	{
		ReferenceOnEntityType type = new ReferenceOnEntityType
		{
			TypeUid = typeUid
		};
		return from filter in filterFolderManager.LoadFilterFolders(type, code, includeFavorites)
			orderby filter.Weight ?? filter.Id
			select filter;
	}

	public IEnumerable<IFilterFolder> FoldersForEdit(Guid typeUid, Guid? code, bool includeFavorites = false)
	{
		ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType
		{
			TypeUid = typeUid
		};
		return from filter in GetFilterAll(referenceOnEntityType, code).Union(filterFolderManager.LoadOrCreateFilterFolders(referenceOnEntityType, code, includeFavorites))
			orderby filter.Weight ?? filter.Id
			select filter;
	}

	private IEnumerable<TreeMenuNode> GetTree(IEnumerable<IFilterFolder> folders, TreeState treeState, UrlHelper urlHelper, ActionRoute routes, string FilterIdParameter, string ClickAction, IFilterFolder parentFolder = null)
	{
		List<TreeMenuNode> nodes = new List<TreeMenuNode>();
		folders.Where((IFilterFolder folder) => folder.ParentFolder == parentFolder).ForEach(delegate(IFilterFolder folder)
		{
			IFilterMenuProviderExtension filterMenuProviderExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault((IFilterMenuProviderExtension p) => p.SupportedFilter(folder));
			string icon = null;
			string href = null;
			filterMenuProviderExtension?.GetTreeNodeParameters(folder, urlHelper, isDefault: false, isSystemDefault: false, out var _, out icon, out href, out var _, routes, FilterIdParameter, ClickAction);
			TreeMenuNode treeMenuNode = new TreeMenuNode
			{
				text = (string.IsNullOrWhiteSpace(folder.Name) ? SR.T("Без названия") : folder.Name),
				id = folder.Id.ToString(),
				tag = folder,
				icon = ((folder is IFilterBase && !string.IsNullOrEmpty(((IFilterBase)folder).ImageUrl)) ? ((IFilterBase)folder).ImageUrl : icon),
				typeuid = folder.TypeUid,
				children = GetTree(folders, treeState, urlHelper, routes, FilterIdParameter, ClickAction, folder).ToList(),
				href = href
			};
			if (folder != null && treeMenuNode.children.Count > 0)
			{
				if (treeMenuNode.children[0].children.Count > 0)
				{
					treeMenuNode.onclick = treeMenuNode.children[0].onclick;
					treeMenuNode.href = treeMenuNode.children[0].href;
				}
				else if (string.IsNullOrEmpty(treeMenuNode.children[0].onclick) && !string.IsNullOrEmpty(treeMenuNode.children[0].href) && treeMenuNode.children[0].href.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase))
				{
					treeMenuNode.onclick = treeMenuNode.children[0].href.Substring(11);
					treeMenuNode.href = "#";
				}
				else
				{
					treeMenuNode.onclick = treeMenuNode.children[0].onclick;
					if (routes != null)
					{
						treeMenuNode.href = urlHelper.Action("FilterTreeOpenFolder", routes.Controller, (object)new
						{
							area = routes.Area,
							url = HttpUtility.UrlEncode(treeMenuNode.children[0].href)
						});
					}
				}
			}
			if (treeState != null)
			{
				treeMenuNode.expanded = treeState[treeMenuNode.id];
			}
			if (!string.IsNullOrEmpty(treeMenuNode.href) && treeMenuNode.href.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase))
			{
				treeMenuNode.onclick = treeMenuNode.href.Substring(11);
				treeMenuNode.href = "#";
			}
			if (treeMenuNode.tag is IFilter || treeMenuNode.children.Count > 0)
			{
				nodes.Add(treeMenuNode);
			}
		});
		return nodes;
	}

	private IEnumerable<TreeMenuNode> GetTreeForEdit(IEnumerable<IFilterFolder> folders, ActionRoute routes, TreeState treeState, bool accessSharedFilter, IFilterFolder parentFolder = null)
	{
		IFilter defaultFilter = (folders.Any() ? FilterDefaultManager.Instance.LoadDefaultFilter(folders.FirstOrDefault().ObjectsType, folders.FirstOrDefault().Code) : null);
		IFilter systemDefaultFilter = FilterDefaultManager.Instance.LoadSystemDefaultFilter(folders.FirstOrDefault().ObjectsType, folders.FirstOrDefault().Code);
		List<TreeMenuNode> nodes = new List<TreeMenuNode>();
		IEnumerable<IFilterFolder> enumerable = null;
		enumerable = ((parentFolder != null) ? folders.Where((IFilterFolder folder) => folder.ParentFolder != null && folder.ParentFolder.Uid == parentFolder.Uid) : folders.Where((IFilterFolder folder) => folder.ParentFolder == null));
		enumerable.ForEach(delegate(IFilterFolder folder)
		{
			bool flag = folder.Id == ((defaultFilter == null) ? 0 : defaultFilter.Id);
			bool flag2 = folder.Id == ((systemDefaultFilter == null) ? 0 : systemDefaultFilter.Id);
			IFilterMenuProviderExtension filterMenuProviderExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault((IFilterMenuProviderExtension p) => p.SupportedFilter(folder));
			string type = null;
			string icon = null;
			bool canMakeDefault = false;
			filterMenuProviderExtension?.GetTreeNodeParameters(folder, null, flag, flag2, out type, out icon, out var _, out canMakeDefault, routes);
			string id = folder.Id.ToString();
			FilterTreeItem filterTreeItem = new FilterTreeItem
			{
				Controller = routes.Controller,
				Area = routes.Area,
				IsDefault = flag,
				IsSystemDefault = flag2,
				AccessSharedFilter = accessSharedFilter,
				CanMakeDefault = canMakeDefault,
				FolderId = folder.Id,
				FolderType = type,
				FilterType = folder.FilterType,
				text = (string.IsNullOrWhiteSpace(folder.Name) ? SR.T("Без названия") : folder.Name.HtmlEncode()),
				icon = icon,
				icon2 = ((folder is IFilterBase && !string.IsNullOrEmpty(((IFilterBase)folder).ImageUrl)) ? ((IFilterBase)folder).ImageUrl : null),
				id = id,
				typeuid = folder.TypeUid,
				ObjectsType = folder.ObjectsType.TypeUid,
				Code = folder.Code,
				expanded = (treeState != null && treeState[id]),
				children = GetTreeForEdit(folders, routes, treeState, accessSharedFilter, folder).ToList(),
				isHtml = true,
				HtmlClass = new List<string>(),
				HtmlAttributes = new Dictionary<string, object>
				{
					{ "folderType", type },
					{
						"filterType",
						folder.FilterType.ToString()
					}
				},
				ImageHtmlAttributes = new Dictionary<string, object>()
			};
			if (flag || flag2)
			{
				if (flag)
				{
					filterTreeItem.HtmlClass.Add("default_filter");
				}
				if (flag2)
				{
					filterTreeItem.HtmlClass.Add("systemDefault_filter");
				}
				if (flag2)
				{
					filterTreeItem.ImageHtmlAttributes["tooltipheader"] = SR.T("Фильтр по умолчанию для всех");
					filterTreeItem.ImageHtmlAttributes["tooltiptext"] = SR.T("Этот фильтр будет автоматически открываться при переходе в раздел, если не установлен собственный фильтр по умолчанию");
				}
				else if (flag)
				{
					filterTreeItem.ImageHtmlAttributes["tooltipheader"] = SR.T("Фильтр по умолчанию");
					filterTreeItem.ImageHtmlAttributes["tooltiptext"] = SR.T("Этот фильтр будет автоматически открываться при переходе в раздел");
				}
			}
			nodes.Add(filterTreeItem);
		});
		return nodes;
	}

	public IList<TreeViewItem> BuildJson(Guid typeUid, Guid? code = null)
	{
		string text = "FilterTree_" + typeUid;
		TreeState treeState = TreePersonalizationAdministration.LoadState(text);
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = text
			};
			TreePersonalizationAdministration.SaveState(text, treeState);
		}
		RouteValueDictionary values = HttpContextAccessor.CurrentContext.Request.RequestContext.RouteData.Values;
		ActionRoute routes = new ActionRoute((string)values["action"], (string)values["controller"], new
		{
			area = values["area"]
		});
		IFilterFolder[] array = FoldersForEdit(typeUid, code).ToArray();
		bool accessSharedFilter = FilterFolderManager.Instance.HasSharedFilterPermission(array.FirstOrDefault((IFilterFolder f) => f.FilterType == FilterType.SharedFilter));
		return new TreeModel
		{
			Children = GetTreeForEdit(array, routes, treeState, accessSharedFilter).ToList()
		}.ToTreeViewItemList();
	}

	public Pair<ActionRoute, TreeModel> GetFilterTreeByMenuItemCode(string code, HttpContextBase httpContext, TreeState treeState)
	{
		if (!string.IsNullOrWhiteSpace(code))
		{
			FilterMenuItem filterMenuItem = GetFilterMenuItem(code, httpContext);
			if (filterMenuItem != null)
			{
				Pair<ActionRoute, TreeModel> pair = new Pair<ActionRoute, TreeModel>();
				if (!string.IsNullOrWhiteSpace(filterMenuItem.FilterEditAction))
				{
					pair.First = new ActionRoute(filterMenuItem.FilterEditAction, filterMenuItem.Routes.Controller, filterMenuItem.Routes.Routes);
				}
				List<TreeMenuNode> children = TreeMenuNodes(filterMenuItem.TypeUid, treeState, filterMenuItem.Routes, filterMenuItem.FilterIdParameter, filterMenuItem.ClickAction, filterMenuItem.TypeCode, filterMenuItem.IncludeFavorites);
				pair.Second = new TreeModel
				{
					Children = children,
					Id = "FilterTree",
					HtmlAttributes = new { }
				};
				return pair;
			}
		}
		return null;
	}

	private FilterMenuItem GetFilterMenuItem(string code, HttpContextBase httpContext)
	{
		IEnumerable<FilterMenuItem> source = FilterMenuItemByCode(code);
		if (!bool.TryParse(HttpContextAccessor.CurrentContext.Request["showFiltersTree"], out var result))
		{
			result = false;
		}
		Guid showFiltersTreeForType;
		if (HttpContextAccessor.CurrentContext.Items["showFiltersTreeForType"] != null)
		{
			showFiltersTreeForType = (Guid)HttpContextAccessor.CurrentContext.Items["showFiltersTreeForType"];
		}
		else if (!Guid.TryParse(HttpContextAccessor.CurrentContext.Request["showFiltersTreeForType"], out showFiltersTreeForType))
		{
			showFiltersTreeForType = Guid.Empty;
		}
		if (((bool?)HttpContextAccessor.CurrentContext.Items["showFiltersTree"]) ?? result)
		{
			return source.FirstOrDefault();
		}
		if (showFiltersTreeForType != Guid.Empty)
		{
			return source.FirstOrDefault((FilterMenuItem fmi) => fmi.TypeUid == showFiltersTreeForType);
		}
		return source.FirstOrDefault((FilterMenuItem fmi) => fmi.Routes.CreateRoutes().All((KeyValuePair<string, object> route) => (httpContext.Request.RequestContext.RouteData.Values[route.Key] ?? httpContext.Request.RequestContext.HttpContext.Request.QueryString[route.Key]).SafeToString() == route.Value.SafeToString()));
	}
}
