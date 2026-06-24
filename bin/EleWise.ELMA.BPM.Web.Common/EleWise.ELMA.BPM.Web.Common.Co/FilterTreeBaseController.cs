using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using NHibernate;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class FilterTreeBaseController<TModel, TId> : BPMController<TModel, TId>, IFilterController where TModel : IEntity<TId>
{
	public const string DataFilterPrefix = "DataFilter";

	public FilterMenuProvider FilterMenuProvider { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	public IEnumerable<IUniqueFilterExtension> UniqueFilterExtensions { get; set; }

	protected virtual Guid? UniqueFilterUid => null;

	protected virtual string GridIdPrefix => null;

	protected virtual Guid? Code => null;

	protected virtual string TypesRootName => null;

	protected virtual bool EnableFavoriteFilters => false;

	protected virtual bool DisableColumnSettings => false;

	protected virtual bool EnableEqlQuery => false;

	public virtual ActionResult FilterSave(string FilterName, [Bind(Prefix = "DataFilter")] FilterModel filter)
	{
		filter.Save(FilterName);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			filterId = filter.Entity.Id,
			filterName = filter.Entity.Name
		}, (JsonRequestBehavior)0);
	}

	public virtual ActionResult FastFilterSave(string prefix, [Bind(Prefix = "DataFilter")] FilterModel model)
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
		if (zoneId.HasValue)
		{
			((ControllerBase)this).get_ViewData().set_Item("ZoneUid", (object)zoneId.Value);
			return (ActionResult)(object)((Controller)this).PartialView("Filter/RenderFilterPropertiesZone", (object)model);
		}
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
		model.Entity.Save();
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
		FilterFolderModel filterFolderModel = new FilterFolderModel
		{
			Entity = FilterFolderManager.Instance.Load(FilterId.Value)
		};
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

	protected virtual FilterModel CreateFilter(long? FilterId = null, Guid? FilterCode = null, IEntityFilter filterToMerge = null, GridState getSourceForRefresh = null, string updatePrefix = "Filter")
	{
		Guid.TryParse(((Controller)this).get_Request()["FilterTypeSelector"], out var result);
		IFilter filter = ((FilterId > 0) ? AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value) : InterfaceActivator.Create<IFilter>());
		Guid filterObjectTypeUid = FilterObjectTypeUid(filter, FilterCode);
		Guid? typeUid = ((result != Guid.Empty) ? new Guid?(result) : null);
		Guid? filterCode = FilterCode ?? Code;
		FilterModel filterModel = new FilterModel(filter, filterObjectTypeUid, typeUid, null, "Filter", filterToMerge, filterCode, EnableEqlQuery, getSourceForRefresh, null, TypesRootName)
		{
			DisableColumnSettings = DisableColumnSettings
		};
		if (filter.FilterFields == null && result != Guid.Empty)
		{
			filter.FilterFields = UniversalFilterSaver.Pack(filterModel.Filter);
		}
		bool disableSecurity = filterModel.Filter.DisableSecurity;
		((Controller)this).TryUpdateModel<IEntityFilter>(filterModel.Filter, updatePrefix);
		filterModel.Filter.DisableSecurity = disableSecurity;
		if (!string.IsNullOrEmpty(GridIdPrefix))
		{
			filterModel.GridIdPrefix = GridIdPrefix;
		}
		return filterModel;
	}

	protected virtual Guid FilterObjectTypeUid(IFilterBase filter, Guid? filterCode)
	{
		return UniqueFilterUid ?? InterfaceActivator.UID<TModel>();
	}

	protected ActionResult BaseIndex(long? FilterId, string filterIdParameter = "FilterId", string clickAction = "Index", Guid? code = null)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		if (!FilterId.HasValue)
		{
			IFilter defaultFilter = FilterDefaultManager.Instance.LoadDefaultFilter(UniqueFilterUid ?? InterfaceActivator.UID<TModel>(), code ?? Code).CastAsRealType();
			if (defaultFilter == null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction(clickAction, (object)new
				{
					FilterId = 0
				});
			}
			IFilterMenuProviderExtension filterMenuProviderExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault((IFilterMenuProviderExtension p) => p.SupportedFilter(defaultFilter));
			string href = null;
			if (filterMenuProviderExtension != null)
			{
				string text = (string)HttpContextAccessor.CurrentContext.Request.RequestContext.RouteData.Values["area"];
				filterMenuProviderExtension.GetTreeNodeParameters(defaultFilter, new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext), isDefault: false, isSystemDefault: false, out var _, out var _, out href, out var _, new ActionRoute((string)HttpContextAccessor.CurrentContext.Request.RequestContext.RouteData.Values["action"], (string)HttpContextAccessor.CurrentContext.Request.RequestContext.RouteData.Values["controller"], string.IsNullOrEmpty(text) ? null : new
				{
					area = text
				}), filterIdParameter);
			}
			return (ActionResult)(object)((Controller)this).Redirect(href);
		}
		return null;
	}

	public virtual ActionResult EditFilters()
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)FilterMenuProvider.TreeMenuNodesForEdit(UniqueFilterUid ?? InterfaceActivator.UID<TModel>(), Code));
	}

	protected virtual GridDataFilter<TModel> CreateGridData(GridCommand command, FilterModel filter)
	{
		Type filterType = ((filter != null && filter.Filter != null) ? filter.Filter.GetType() : null);
		IUniqueFilterExtension uniqueFilterExtension = ((filterType != null) ? UniqueFilterExtensions.FirstOrDefault((IUniqueFilterExtension e) => e.FilterType == filterType) : null);
		IEntityManager entityManager = ModelHelper.GetEntityManager((uniqueFilterExtension != null) ? uniqueFilterExtension.EntityType : ((filterType != null) ? Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(filterType).Uid) : InterfaceActivator.TypeOf<TModel>()));
		if (EnableEqlQuery)
		{
			IEntityFilter filter2 = filter.Filter;
			try
			{
				entityManager.CheckFilter(filter2);
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
		return entityManager.CreateGridData<TModel>(command, filter);
	}

	protected virtual void InitEqlQuery(FilterModel model)
	{
		//IL_0061: Expected O, but got Unknown
		if (EnableEqlQuery)
		{
			IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(model.Filter.GetType()).Uid));
			try
			{
				entityManager.CheckFilter(model.Filter);
			}
			catch (NullReferenceException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (QueryException val)
			{
				string text = ((Exception)val).Message.Split(':')[1];
				string text2 = text.Substring(0, text.IndexOf(" of", StringComparison.InvariantCulture)).Trim();
				base.Notifier.Error(SR.T("Свойство \"{0}\" не найдено", text2));
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
	}

	protected virtual void CheckFilterEditPermission(IFilterBase filter)
	{
		if (filter != null && !base.SecurityService.HasPermission(PermissionProvider.FilterEditPermission, filter))
		{
			throw new SecurityException(SR.T("Текущий пользователь не имеет прав на редактирование фильтра \"{0}\" с идентификатором {1}", filter.Name, filter.Id));
		}
	}

	[HttpGet]
	public virtual ActionResult EditFilter(long? FilterId = null)
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		if (!FilterId.HasValue)
		{
			return (ActionResult)(object)((Controller)this).View("Index");
		}
		IFilter filter = AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value);
		CheckFilterEditPermission(filter);
		FilterModel filterModel = new FilterModel(filter, filter.ObjectsType.TypeUid, null, null, "Filter", null, Code, EnableEqlQuery)
		{
			DisableColumnSettings = DisableColumnSettings
		};
		InitEqlQuery(filterModel);
		filterModel.ShowAllFields = true;
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("DataFilter");
		return (ActionResult)(object)((Controller)this).View("Filter/Edit", (object)filterModel);
	}

	[HttpPost]
	public virtual ActionResult EditFilter([Bind(Prefix = "DataFilter")] FilterModel model, EditableListModel access)
	{
		CheckFilterEditPermission(model.Entity);
		if (model.GridState != null)
		{
			model.GridState.DateState = DateTime.Now;
		}
		model.Entity.GridState = ((model.GridState != null) ? ClassSerializationHelper.SerializeObject(model.GridState) : null);
		model.Entity.FilterFields = UniversalFilterSaver.Pack(model.Filter);
		model.Entity.SearchFields = model.FilterColumnsSelected.Select((SelectListItem fc) => new SearchFieldsData(fc.get_Value())).ToList();
		if (access != null && access.Items != null)
		{
			PermissionsModelService.BindPermissionsFromModel(model.Entity, access, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
			{
				new List<IInstanceSettingsPermissionHolder>();
				holders.SyncFrom(newHolders, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
				{
					if (v is IEntity)
					{
						((IEntity)v).Delete();
					}
				});
			});
		}
		CheckModel(model);
		model.Entity.Save();
		if (!string.IsNullOrEmpty(((Controller)this).get_Request()["ReturnUrl"]))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		return RedirectAfterSave(model);
	}

	protected virtual void CheckModel(FilterModel model)
	{
	}

	protected virtual ActionResult RedirectAfterSave(FilterModel model)
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("EditFilters", (object)new
		{
			code = model.Entity.Code
		});
	}

	[CustomGridAction]
	public virtual ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filter, long? FilterId = null, string SearchTasksType = null)
	{
		if (filter == null)
		{
			filter = CreateFilter(FilterId);
		}
		GridDataFilter<TModel> gridData = CreateGridData(command, filter);
		return GridView(gridData);
	}
}
