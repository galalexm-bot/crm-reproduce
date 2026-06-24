using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Common")]
public class UnitMeasureController : EntityBaseController
{
	private const string CatalogsMenu = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root";

	private const string UnitMeasureGridId = "UnitMeasureGridId1";

	private new const string DataFilterPrefix = "DataFilter";

	public PermissionsModelService PermissionsModelService { get; set; }

	public ActionResult EditWpiSelectListItem(long? id, string JsonData)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		AddWpiSelectListItemViewModel addWpiSelectListItemViewModel = new AddWpiSelectListItemViewModel();
		if (id.HasValue)
		{
			List<IWpiSelectListItem> source = UnitMeasureModel.Deserialize(JsonData, loadEntityIfExists: false);
			addWpiSelectListItemViewModel.Entity = source.FirstOrDefault((IWpiSelectListItem s) => s.Id == id.Value);
		}
		if (addWpiSelectListItemViewModel.Entity == null)
		{
			addWpiSelectListItemViewModel.Entity = InterfaceActivator.Create<IWpiSelectListItem>();
		}
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix("WpiSelectListItem");
		viewData.set_TemplateInfo(val);
		return (ActionResult)(object)((Controller)this).PartialView("AddWpiSelectListItem", (object)addWpiSelectListItemViewModel);
	}

	public ActionResult SaveWpiSelectListItem([Bind(Prefix = "WpiSelectListItem")] AddWpiSelectListItemViewModel wpiSelectListItemModel, string wpiSelectListItemsJsonData)
	{
		List<IWpiSelectListItem> list = UnitMeasureModel.Deserialize(wpiSelectListItemsJsonData, loadEntityIfExists: false);
		int num = list.FindIndex((IWpiSelectListItem s) => s.Id == wpiSelectListItemModel.Entity.Id);
		if (num >= 0)
		{
			list[num] = wpiSelectListItemModel.Entity;
		}
		else
		{
			wpiSelectListItemModel.Entity.Id = 0L;
			list.Add(wpiSelectListItemModel.Entity);
			wpiSelectListItemModel.Entity.Id = list.Min((IWpiSelectListItem s) => s.Id) - 1;
		}
		if (wpiSelectListItemModel.Entity.IsDefault)
		{
			foreach (IWpiSelectListItem item in list.Where((IWpiSelectListItem m) => m.Id != wpiSelectListItemModel.Entity.Id))
			{
				item.IsDefault = false;
			}
		}
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)"WpiSelectListItemsGrid");
		return (ActionResult)(object)((Controller)this).PartialView("WpiSelectListItemsGrid", (object)list);
	}

	[EntityListLink(typeof(IUnitMeasure))]
	[FilterMenuItem(Id = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root", Type = typeof(IUnitMeasure), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		if (!FilterId.HasValue)
		{
			IFilter defaultFilter = FilterDefaultManager.Instance.LoadDefaultFilter(InterfaceActivator.UID<IUnitMeasure>()).CastAsRealType();
			if (defaultFilter == null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
				{
					FilterId = 0
				});
			}
			IFilterMenuProviderExtension filterMenuProviderExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault((IFilterMenuProviderExtension p) => p.SupportedFilter(defaultFilter));
			string href = null;
			filterMenuProviderExtension?.GetTreeNodeParameters(defaultFilter, new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext), isDefault: false, isSystemDefault: false, out var _, out var _, out href, out var _, new ActionRoute("Index", "UnitMeasure", new
			{
				area = "EleWise.ELMA.BPM.Web.Common"
			}), "FilterId");
			return (ActionResult)(object)((Controller)this).Redirect(href);
		}
		UnitMeasureViewModel unitMeasureViewModel = new UnitMeasureViewModel
		{
			Filter = CreateFilter(InterfaceActivator.UID<IUnitMeasure>(), FilterId),
			GridId = "UnitMeasureGridId1"
		};
		return (ActionResult)(object)((Controller)this).View((object)unitMeasureViewModel);
	}

	public virtual ActionResult EditFilters()
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		Type runtimeType = InterfaceActivator.TypeOf<IUnitMeasure>();
		Guid guid = InterfaceActivator.UID<IUnitMeasure>();
		IEntityMetadata entityMetadata = ((ClassMetadata)MetadataLoader.LoadMetadata(runtimeType)) as IEntityMetadata;
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTreeForType", guid);
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(entityMetadata.Uid, null));
	}

	[HttpGet]
	public virtual ActionResult EditFilter(long? FilterId = null)
	{
		if (!FilterId.HasValue)
		{
			return (ActionResult)(object)((Controller)this).View("Index");
		}
		IFilter filter = AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value);
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTreeForType", filter.ObjectsType.TypeUid);
		FilterModel filterModel = new FilterModel(filter, filter.ObjectsType.TypeUid)
		{
			ShowAllFields = true
		};
		return (ActionResult)(object)((Controller)this).View("Filter/Edit", (object)filterModel);
	}

	[HttpPost]
	public virtual ActionResult EditFilter(FilterModel model, EditableListModel access)
	{
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
		model.Entity.Save();
		if (!string.IsNullOrEmpty(((Controller)this).get_Request()["ReturnUrl"]))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("EditFilters");
	}

	protected virtual FilterModel CreateFilter(Guid typeUid, long? FilterId = null)
	{
		return new FilterModel((FilterId > 0) ? AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value) : InterfaceActivator.Create<IFilter>(), typeUid);
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, string searchQuery = null, [Bind(Prefix = "DataFilter")] FilterModel filter = null, long? FilterId = null)
	{
		Guid guid = InterfaceActivator.UID<IUnitMeasure>();
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(guid);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		IEntityMetadata entityMetadata = classMetadata as IEntityMetadata;
		filter = filter ?? CreateFilter(classMetadata.Uid, FilterId);
		GridResult gridResult = Grid(command, guid, typeByUid, classMetadata, entityMetadata, null, searchQuery, filter.Filter, null, showOnlyGroups: false, "", null, null, filter.Entity);
		if (gridResult == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		DynamicGrid grid = gridResult.GridData;
		grid.UniqueName = "UnitMeasureGridId1";
		grid.Customizable = true;
		((List<GridColumn>)grid.Columns).AddRange(GridBuilderExtensions.GetDefaultColumns(typeByUid, classMetadata, grid.State));
		PropertyMetadata titleProperty = classMetadata.GetTitleProperty();
		GridColumn gridColumn = ((titleProperty != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == titleProperty.Uid.ToString()) : null);
		if (gridColumn != null)
		{
			gridColumn.Template = (dynamic entity) => TitleCellTemplate(entity, titleProperty.Uid);
		}
		PropertyMetadata wpiListProperty = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == InterfaceActivator.PropertyUid((IUnitMeasure m) => m.WpiSelectList));
		GridColumn gridColumn2 = ((wpiListProperty != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == wpiListProperty.Uid.ToString()) : null);
		if (gridColumn2 != null)
		{
			gridColumn2.Template = (dynamic entity) => WPIListCellTemplate(entity);
		}
		GridColumn gridColumn3 = new GridColumn
		{
			ValueType = typeof(string),
			Name = null,
			Header = "",
			Sortable = false,
			Order = 2147483646,
			UniqueName = "actionColumn" + guid,
			Width = ((gridResult.GridTableView == null || gridResult.GridTableView.Resizeable) ? "96px" : "1%"),
			HtmlAttributes = new Dictionary<string, object> { { "style", "white-space:nowrap" } }
		};
		Guid uidCatalog;
		if (classMetadata is EntityMetadata)
		{
			uidCatalog = ((EntityMetadata)classMetadata).ImplementationUid;
		}
		else
		{
			uidCatalog = classMetadata.Uid;
		}
		Func<object, string> func2 = (Func<object, string>)(gridColumn3.Template = (Func<object, string>)((dynamic entity) => ActionsCellTemplate(entity, uidCatalog)));
		grid.Columns.Add(gridColumn3);
		return ExportExcel(grid.GridData, typeByUid, () => (ActionResult)(object)((Controller)this).PartialView("Templates/DynamicGrid", (object)grid));
	}

	private static string WPIListCellTemplate(IUnitMeasure entity)
	{
		return HttpUtility.HtmlEncode(string.Join(", ", from m in ((IEnumerable<IWpiSelectListItem>)entity.WpiSelectList).ToList()
			select m.Name));
	}

	private string TitleCellTemplate(IEntity entity, Guid titlePropertyUid)
	{
		object propertyValue = entity.GetPropertyValue(titlePropertyUid);
		propertyValue = HttpUtility.HtmlEncode(propertyValue ?? string.Empty);
		return string.Format("<a href=\"{0}\" onclick=\"{2}\">{1}</a>", "#", propertyValue, $"showUnitMeasureInfo({entity.GetId()})");
	}

	private string ActionsCellTemplate(IEntity entity, Guid ImplementationUid)
	{
		List<string> list = new List<string>();
		IEnumerable<ISystemCatalogChecker> extensionPoints = ComponentManager.Current.GetExtensionPoints<ISystemCatalogChecker>();
		if (entity == null || extensionPoints.Any((ISystemCatalogChecker point) => point.CantDelete(entity)))
		{
			return string.Empty;
		}
		object id = entity.GetId();
		string item = EleWise.ELMA.Web.Mvc.Html.HtmlExtensions.ImageLink(((Controller)this).get_Url(), "#edit.svg", "", ((Controller)this).get_Url().Action("Edit", "UnitMeasure", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			id = id
		}), new
		{
			title = SR.T("Редактировать запись"),
			@class = "svg-16-size"
		});
		string item2 = EleWise.ELMA.Web.Mvc.Html.HtmlExtensions.ImageLink(((Controller)this).get_Url(), "#delete.svg", "", string.Format("javascript:jConfirm('{1}', '{2}', function (r) {{if (r == true) {{deleteUnitMeasure('{0}')}}}});", id, SR.T("Удалить запись?"), SR.T("Удаление")), new
		{
			title = SR.T("Удалить запись"),
			@class = "svg-16-size"
		});
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(ImplementationUid);
		if (catalogProfile == null)
		{
			throw new ArgumentNullException("CatalogProfile is null");
		}
		if (base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogEditPermission, catalogProfile))
		{
			list.Add(item);
		}
		if (base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogDeletePermission, catalogProfile) && !ComponentManager.Current.GetExtensionPoints<ICatalogViewHandler>().Any((ICatalogViewHandler e) => !e.CanDelete(entity)))
		{
			list.Add(item2);
		}
		return string.Join("&nbsp;&nbsp;", list);
	}

	public JsonResult GetUnitMeasures(string text = "")
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		var data = (from u in EntityManager<IUnitMeasure>.Instance.Find(InterfaceActivator.Create<IUnitMeasureFilter>(), new FetchOptions(0, 100))
			select new
			{
				Value = u.Id.ToString(CultureInfo.InvariantCulture),
				Text = u.Name
			} into i
			where !string.IsNullOrEmpty(i.Text)
			orderby i.Text
			select i).ToArray();
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		return val;
	}

	public ActionResult Edit(long? id = null)
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		UnitMeasureModel unitMeasureModel = new UnitMeasureModel(id.HasValue ? UnitMeasureManager.Instance.Load(id.Value) : null);
		return (ActionResult)(object)((Controller)this).View((object)unitMeasureModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Save(UnitMeasureModel model)
	{
		if (HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogEditPermission))
		{
			try
			{
				if (model.Entity.IsSelectList)
				{
					List<IWpiSelectListItem> json = UnitMeasureModel.Deserialize(model.JsonData);
					((IEnumerable<IWpiSelectListItem>)model.Entity.WpiSelectList).Where((IWpiSelectListItem s) => !json.Contains(s)).ToList().ForEach(delegate(IWpiSelectListItem s)
					{
						s.UnitMeasure = null;
						((ICollection<IWpiSelectListItem>)model.Entity.WpiSelectList).Remove(s);
						s.Delete();
					});
					json.Where((IWpiSelectListItem s) => s.IsNew()).ToList().ForEach(delegate(IWpiSelectListItem s)
					{
						s.Id = 0L;
						s.UnitMeasure = model.Entity;
						model.Entity.WpiSelectList.Add(s);
					});
				}
				else
				{
					foreach (IWpiSelectListItem item in ((IEnumerable<IWpiSelectListItem>)model.Entity.WpiSelectList).ToList())
					{
						item.UnitMeasure = null;
						((ICollection<IWpiSelectListItem>)model.Entity.WpiSelectList).Remove(item);
						item.Delete();
					}
				}
				model.Entity.Save();
				base.Notifier.Information(SR.T("Единица измерения успешно сохранёна."));
			}
			catch (Exception exception)
			{
				base.Notifier.Error(SR.T("Ошибка сохранения единицы измерения"));
				base.Logger.Error(SR.T("Ошибка сохранения единицы измерения"), exception);
			}
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	private bool HasPermission(Permission permission)
	{
		Guid uid = InterfaceActivator.UID<IUnitMeasure>();
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(base.IMetadataRuntimeService.GetTypeByUid(uid));
		Guid uid2 = ((!(classMetadata is EntityMetadata)) ? classMetadata.Uid : ((EntityMetadata)classMetadata).ImplementationUid);
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(uid2);
		if (catalogProfile == null)
		{
			throw new ArgumentNullException("CatalogProfile is null");
		}
		return base.SecurityService.HasPermission(permission, catalogProfile);
	}

	[HttpGet]
	[EntityLink]
	public ActionResult Details(long id)
	{
		IUnitMeasure unitMeasure = UnitMeasureManager.Instance.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView((object)unitMeasure);
	}

	[HttpPost]
	public ActionResult Delete(long id)
	{
		try
		{
			if (HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogDeletePermission))
			{
				UnitMeasureManager.Instance.Load(id).Delete();
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = true,
					gridId = "UnitMeasureGridId1"
				});
			}
			throw new Exception(SR.T("Нет прав для удаления единицы измерения"));
		}
		catch (Exception ex)
		{
			base.Logger.Error(SR.T("Ошибка удаления единицы измерения (id={0})", id), ex);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			});
		}
	}

	[CreatorForm]
	public ActionResult CreatePopup()
	{
		IUnitMeasure unitMeasure = InterfaceActivator.Create<IUnitMeasure>();
		return (ActionResult)(object)((Controller)this).PartialView("EditorFields", (object)unitMeasure);
	}

	[HttpPost]
	public ActionResult Create(IUnitMeasure model)
	{
		try
		{
			if (((Controller)this).get_ModelState().get_IsValid())
			{
				model.Save();
				return CreatorJson(model);
			}
			return CreatorJson(null, SR.T("Модель не прошла проверку на сервере"));
		}
		catch (Exception ex)
		{
			return CreatorJson(null, ex.Message);
		}
	}
}
