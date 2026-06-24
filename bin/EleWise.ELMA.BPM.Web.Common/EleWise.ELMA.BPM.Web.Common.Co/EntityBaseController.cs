using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.FilterSearchForm;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using NHibernate;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class EntityBaseController : BPMController, IFilterController
{
	protected class GridResult
	{
		public DynamicGrid GridData;

		public object ParentId;

		public TableView GridTableView;
	}

	public const string DataFilterPrefix = "DataFilter";

	protected const string FolderGridColumnWidth = "48px";

	protected const string ActionsGridColumnWidth = "96px";

	public IMetadataRuntimeService IMetadataRuntimeService { get; set; }

	public FilterMenuProvider FilterMenuProvider { get; set; }

	protected virtual bool EnableEqlQuery => false;

	public ActionResult FilterSave(string FilterName, [Bind(Prefix = "DataFilter")] FilterModel filter)
	{
		FilterControllerHelper.Save(FilterName, filter);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			filterId = filter.Entity.Id,
			filterName = filter.Entity.Name
		}, (JsonRequestBehavior)0);
	}

	public ActionResult FastFilterSave(string prefix, [Bind(Prefix = "DataFilter")] FilterModel model)
	{
		FilterControllerHelper.FastFilterSave(model, EnableEqlQuery);
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		return (ActionResult)(object)((Controller)this).PartialView("Filter/FastFilterSavePopup", (object)model);
	}

	public ActionResult FilterFields(string HtmlFieldPrefix, [Bind(Prefix = "DataFilter")] FilterModel model = null, Guid? zoneId = null, string filterGridId = "")
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		FilterControllerHelper.FilterFields(model);
		model.EnableEqlQuery = EnableEqlQuery;
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix(HtmlFieldPrefix);
		viewData.set_TemplateInfo(val);
		((ControllerBase)this).get_ViewData().set_Item("filterGridId", (object)filterGridId);
		return (ActionResult)(object)((Controller)this).PartialView("Filter/FilterModelFields", (object)model);
	}

	[HttpPost]
	public ActionResult FilterColumnSettings([Bind(Prefix = "DataFilter")] FilterModel model)
	{
		model.EnableEqlQuery = EnableEqlQuery;
		FilterControllerHelper.FilterColumnSettings(model);
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("DataFilter");
		return (ActionResult)(object)((Controller)this).PartialView("Filter/FilterColumnSettings", (object)model);
	}

	[HttpGet]
	public ActionResult FilterTreeAddFilterFolder(Guid TypeUid, long ParentFilterFolderId, Guid? code)
	{
		FilterFolderModel filterFolderModel = FilterControllerHelper.AddFilterFolderModel(TypeUid, ParentFilterFolderId, code);
		return (ActionResult)(object)((Controller)this).PartialView("Filter/FilterFolderAddForm", (object)filterFolderModel);
	}

	[HttpPost]
	public ActionResult FilterTreeAddFilterFolder(FilterFolderModel model)
	{
		FilterControllerHelper.AddFilterFolder(model);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Новая папка сохранена"),
			tree = FilterMenuProvider.BuildJson(model.Entity.ObjectsType.TypeUid, model.Entity.Code)
		}, (JsonRequestBehavior)0);
	}

	[HttpGet]
	public ActionResult FilterTreeEditFilterFolder(long? FilterId = null, string q = null)
	{
		if (!FilterId.HasValue)
		{
			return (ActionResult)(object)((Controller)this).View("Index");
		}
		FilterFolderModel filterFolderModel = FilterControllerHelper.CreateFilterFolderModel(FilterId);
		return (ActionResult)(object)((Controller)this).PartialView("Filter/FilterFolderEditForm", (object)filterFolderModel);
	}

	[HttpPost]
	public ActionResult FilterTreeEditFilterFolder(FilterFolderModel model)
	{
		FilterControllerHelper.EditFilterFolder(model);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Изменения сохранены"),
			tree = FilterMenuProvider.BuildJson(model.Entity.ObjectsType.TypeUid, model.Entity.Code)
		}, (JsonRequestBehavior)0);
	}

	public ActionResult FilterTreeNodeDroped(Guid TypeUid, string target, string destination, string position, Guid? code)
	{
		Pair<string, object> pair = FilterControllerHelper.NodeDroped(TypeUid, target, destination, position, code);
		if (pair.Second == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = pair.First
			}, (JsonRequestBehavior)0);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = pair.First,
			tree = pair.Second
		}, (JsonRequestBehavior)0);
	}

	public ActionResult FilterTreeDelete(Guid TypeUid, long Id, Guid? code)
	{
		Tuple<string, string, object> tuple = FilterControllerHelper.Delete(TypeUid, Id, code);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = tuple.Item1,
			error = tuple.Item2,
			tree = tuple.Item3
		}, (JsonRequestBehavior)0);
	}

	public ActionResult FilterTreeOpenFolder(string url)
	{
		return (ActionResult)(object)((Controller)this).Redirect(HttpUtility.UrlDecode(url));
	}

	public ActionResult FilterTreeSetFilterDefault(Guid TypeUid, long Id, Guid? code)
	{
		Tuple<string, string, object> tuple = FilterControllerHelper.SetFilterDefault(TypeUid, Id, code);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = tuple.Item1,
			error = tuple.Item2,
			tree = tuple.Item3
		}, (JsonRequestBehavior)0);
	}

	public ActionResult FilterTreeSetFilterSystemDefault(Guid TypeUid, long Id, Guid? code)
	{
		Tuple<string, string, object> tuple = FilterControllerHelper.SetFilterSystemDefault(TypeUid, Id, code);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = tuple.Item1,
			error = tuple.Item2,
			tree = tuple.Item3
		}, (JsonRequestBehavior)0);
	}

	[CustomGridAction]
	protected GridResult Grid(GridCommand command, Guid uid, Type type, ClassMetadata metadata, IEntityMetadata entityMetadata, string parentId = null, string searchQuery = null, IEntityFilter filter = null, string dynamicGridCallback = null, bool showOnlyGroups = false, string inputId = "", string filterProviderUid = null, string filterProviderData = null, IFilterBase entity = null)
	{
		filter = filter ?? ((IEntityFilter)Activator.CreateInstance(ModelHelper.GetEntityFilterType(type)));
		if (entityMetadata != null && entityMetadata.Hierarchical && string.IsNullOrEmpty(searchQuery) && string.IsNullOrEmpty(filterProviderData))
		{
			if (!string.IsNullOrEmpty(filterProviderUid))
			{
				Guid empty = Guid.Empty;
				if (!string.Equals(filterProviderUid, empty.ToString()))
				{
					goto IL_00a9;
				}
			}
			if (filter.IsEmpty())
			{
				filter.FilterByHierarchyParent = true;
				object obj = ModelHelper.TryConvertEntityId(type, parentId);
				filter.HierarchyParent = ((obj != null) ? ModelHelper.GetEntityManager(type).Load(obj) : null);
			}
		}
		goto IL_00a9;
		IL_00a9:
		if (!string.IsNullOrEmpty(searchQuery))
		{
			filter.SearchString = searchQuery;
		}
		filter.ShowOnlyGroups = showOnlyGroups;
		if (!string.IsNullOrEmpty(filterProviderUid))
		{
			if (Guid.TryParse(filterProviderUid, out var uidFP) && uidFP != Guid.Empty)
			{
				IEntityFilterProvider entityFilterProvider = ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().First((IEntityFilterProvider p) => p.ProviderUid == uidFP);
				IEntityFilter filter2 = entityFilterProvider.GetFilter(uid, filter);
				if (filter2 != null)
				{
					filter = filter2;
				}
				entityFilterProvider.ApplyFilter(filter, filterProviderData);
			}
		}
		IGridData gridData = GetGridData(command, metadata?.Uid ?? uid, filter);
		if (gridData == null)
		{
			return null;
		}
		object parentId2 = ((entityMetadata != null && filter.HierarchyParent != null && metadata.Properties.Any((PropertyMetadata p) => p.Uid == entityMetadata.ParentPropertyUid)) ? ((IEntity)((IEntity)filter.HierarchyParent).GetPropertyValue(entityMetadata.ParentPropertyUid)) : null)?.GetId();
		TableView tableView = ((metadata != null && metadata.TableViews != null) ? metadata.TableViews.FirstOrDefault((TableView v) => v.ViewType == ViewType.List) : null);
		string text = GenerateGridId(uid, inputId, entity);
		DynamicGrid dynamicGrid = new DynamicGrid(text, text, gridData, type, dynamicGridCallback);
		dynamicGrid.Columns = new List<GridColumn>();
		dynamicGrid.StateProviderUid = ((entity == null || entity.Id == 0L) ? Guid.Empty : FilterGridStateProvider.UID);
		dynamicGrid.Customizable = tableView?.Customizable ?? true;
		dynamicGrid.EnableCustomize = entity == null || entity.Id == 0;
		dynamicGrid.HeaderVisible = tableView?.ShowHeader ?? true;
		dynamicGrid.Resizeable = tableView?.Resizeable ?? true;
		dynamicGrid.Sortable = tableView?.Sortable ?? true;
		dynamicGrid.Reorderable = tableView?.Reorderable ?? false;
		return new GridResult
		{
			GridData = dynamicGrid,
			ParentId = parentId2,
			GridTableView = tableView
		};
	}

	public static string GenerateGridId(Guid uid, string inputId, IFilterBase entity = null)
	{
		if (entity == null || entity.Id <= 0)
		{
			return UIExtensions.PrepareId("CatalogsGrid" + uid.ToString() + inputId);
		}
		return string.Format("{0}_{1}", "CatalogsGrid", entity.Uid);
	}

	public ActionResult RegisterPopoverFilterTree(string code)
	{
		if (!string.IsNullOrWhiteSpace(code))
		{
			string filterTreeId = FastSearchFilterTreeButton.GetFilterTreeId(code);
			TreeState treeState = TreePersonalizationAdministration.LoadState(filterTreeId);
			if (treeState == null)
			{
				treeState = new TreeState
				{
					Id = filterTreeId
				};
				TreePersonalizationAdministration.SaveState(filterTreeId, treeState);
			}
			Pair<ActionRoute, TreeModel> filterTreeByMenuItemCode = FilterMenuProvider.GetFilterTreeByMenuItemCode(code, ((Controller)this).get_HttpContext(), treeState);
			if (filterTreeByMenuItemCode != null)
			{
				filterTreeByMenuItemCode.Second.Id = FastSearchFilterTreeButton.GetFilterTreeId(code);
				if (!HttpContextAccessor.CurrentContext.Items.Contains("hideFiltersTree"))
				{
					HttpContextAccessor.CurrentContext.Items.Add("hideFiltersTree", true);
				}
				return (ActionResult)(object)((Controller)this).PartialView("Filter/PopoverFilterTree", (object)filterTreeByMenuItemCode);
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("Filter/PopoverFilterTree");
	}

	private IGridData GetGridData(GridCommand command, Guid uid, IEntityFilter filter)
	{
		Type typeByUid = IMetadataRuntimeService.GetTypeByUid(uid);
		if (typeByUid == null)
		{
			return null;
		}
		return (IGridData)typeof(EntityBaseController).GetMethod("GetGridDataGeneric", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy).MakeGenericMethod(typeByUid).Invoke(this, new object[2] { command, filter });
	}

	[UsedImplicitly]
	private IGridData GetGridDataGeneric<T>(GridCommand command, IEntityFilter filter) where T : class, IEntity
	{
		GridData<T> gridData = ((filter == null) ? ((GridData<T>)GridBuilderExtensions.GetGridData<T>(command)) : ((GridData<T>)GridBuilderExtensions.GetFilteredGridData<T, IEntityFilter>(command, filter)));
		if (EnableEqlQuery && filter != null)
		{
			try
			{
				GridBuilderExtensions.GetEntityManagerByFilter<T>(filter).CheckFilter(filter);
			}
			catch (NullReferenceException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (ADOException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (Exception exception)
			{
				FormNotifierExtensions.Error(base.Notifier, exception);
			}
		}
		if (gridData != null && filter != null && filter.HierarchyParent != null)
		{
			gridData.AddDataSourceExecuted(delegate(GridData<T> data)
			{
				List<T> list = new List<T>();
				IEnumerable<T> enumerable = (IEnumerable<T>)data.DataSource;
				if (!enumerable.Any() || enumerable.First() != null)
				{
					list.Add(null);
				}
				list.AddRange(enumerable);
				data.DataSource = list;
				data.HasExitFromGroup = true;
			});
		}
		return gridData;
	}
}
