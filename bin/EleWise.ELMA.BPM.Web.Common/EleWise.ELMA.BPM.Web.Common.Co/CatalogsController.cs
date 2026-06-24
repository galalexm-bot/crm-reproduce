using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
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
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;
using NHibernate;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[Permission("051DAC95-8C8C-48D1-9CAD-1150F6C8EEAE")]
public class CatalogsController : EntityBaseController
{
	private static IEnumerable<IFilterModelExtension> filterModelExtensions;

	public new const string DataFilterPrefix = "DataFilter";

	public PermissionsModelService PermissionsModelService { get; set; }

	public IEnumerable<ISystemCatalogChecker> SystemCatalogCheckers { get; set; }

	public IEnumerable<IGridObjectSelectorExtension> selectObjectColumnPointService { get; set; }

	private static IEnumerable<IFilterModelExtension> FilterModelExtensions => filterModelExtensions ?? (filterModelExtensions = ComponentManager.Current.GetExtensionPoints<IFilterModelExtension>());

	protected override bool EnableEqlQuery => true;

	internal static IEnumerable<ClassMetadata> EntityList => from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<ClassMetadata>()
			.Where(delegate(ClassMetadata e)
			{
				EntityMetadata entityMetadata = e as EntityMetadata;
				if (e is IEntityMetadata && entityMetadata == null)
				{
					return ComponentManager.Current.GetExtensionPoints<ICatalogViewHandler>().Any((ICatalogViewHandler vh) => vh.ShowInCatalogTree((IEntityMetadata)e));
				}
				return entityMetadata != null && (entityMetadata.Type == EntityMetadataType.Entity || entityMetadata.Type == EntityMetadataType.Interface) && entityMetadata.ShowInCatalogList;
			})
		select (m is EntityMetadata) ? ((ClassMetadata)MetadataLoader.LoadMetadata(m.Uid, inherit: false, loadImplementation: false)) : m;

	public CatalogsController(ILogger logger)
	{
		base.Logger = logger;
	}

	[HttpPost]
	public ActionResult Delete(Guid uid, string id)
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid);
		if (typeByUid == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid, inherit: false);
		if (classMetadata == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		ICatalogProfile catalogProfile = GetCatalogProfile(classMetadata);
		if (catalogProfile == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (!string.IsNullOrEmpty(id))
		{
			try
			{
				object id2 = TypeDescriptor.GetConverter(ModelHelper.GetEntityIdType(typeByUid)).ConvertFromInvariantString(id);
				IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
				object obj = entityManager.Load(id2);
				if (classMetadata.AllowCreateHeirs && obj is IInheritable)
				{
					IEntity entity = ModelHelper.GetEntity(((IInheritable)obj).TypeUid, id2);
					if (entity != null)
					{
						obj = entity;
						entityManager = ModelHelper.GetEntityManager(entity.GetType());
					}
				}
				if (!CanDeleteEntity(obj, catalogProfile))
				{
					throw new SecurityException(SR.T("Недостаточно прав для удаления элементов справочника \"{0}\"", classMetadata.DisplayName));
				}
				entityManager.Delete(obj);
			}
			catch (InvalidOperationException ex)
			{
				base.Logger.Error(SR.T("Ошибка при удалении записи справочника"), ex);
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					error = ex.Message
				});
			}
			catch (Exception ex2)
			{
				base.Logger.Error(SR.T("Ошибка при удалении записи справочника"), ex2.InnerException ?? ex2);
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					error = (ex2.InnerException ?? ex2).Message
				});
			}
			return (ActionResult)new EmptyResult();
		}
		return (ActionResult)(object)((Controller)this).HttpNotFound();
	}

	public ActionResult Edit(Guid uid, string id, bool inPopUp = false, string parentId = null, string backUrl = null)
	{
		if (!string.IsNullOrEmpty(id))
		{
			return Add(uid, id, isGroup: false, inPopUp, parentId, backUrl);
		}
		return (ActionResult)(object)((Controller)this).HttpNotFound();
	}

	[EntityForm("Save", "EleWise.ELMA.BPM.Web.Common")]
	public ActionResult CreateForm([ParameterContainer] IEntity catalogEntity, Guid uid, string prefix, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string id = null, string parentFormId = "", string formId = "")
	{
		CatalogItemModel catalogItemModel = InitNewModel(uid, id, isGroup: false, inPopUp: false, null, ((!formReadOnly && string.IsNullOrEmpty(id)) || formReadOnly) ? $"Form{prefix}" : null, viewType, null, formReadOnly);
		catalogItemModel.FormUid = formUid;
		catalogItemModel.FormReadOnly = formReadOnly;
		catalogItemModel.FormId = formId;
		if (formReadOnly)
		{
			catalogItemModel.FormReadOnly = true;
			catalogItemModel.ViewType = ViewType.Display;
		}
		if (catalogEntity != null)
		{
			catalogItemModel.Entity = catalogEntity;
		}
		catalogItemModel.DynamicFormSettings.ParentFormId = parentFormId;
		string viewItemId = catalogItemModel.DynamicFormSettings.ViewItemId + ";" + catalogItemModel.View.Uid;
		catalogItemModel.DynamicFormSettings.ViewItemId = viewItemId;
		catalogItemModel.ViewItemId = viewItemId;
		return (ActionResult)(object)((Controller)this).PartialView("EditFormFields", (object)catalogItemModel);
	}

	private CatalogItemModel InitNewModel(Guid uid, string id, bool isGroup = false, bool inPopUp = false, string parentId = null, string formId = null, ViewType? viewType = null, string backUrl = null, bool formReadOnly = false)
	{
		CatalogItemModel catalogItemModel = new CatalogItemModel();
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid, inherit: false);
		ICatalogProfile catalogProfile = GetCatalogProfile(classMetadata);
		IEntityMetadata entityMetadata = classMetadata as IEntityMetadata;
		IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
		TypeConverter converter = TypeDescriptor.GetConverter(ModelHelper.GetEntityIdType(typeByUid));
		PropertyMetadata propertyMetadata = ((entityMetadata != null && entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty) ? classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == entityMetadata.IsGroupPropertyUid) : null);
		catalogItemModel.CatalogName = classMetadata.DisplayName;
		catalogItemModel.FormReadOnly = formReadOnly;
		if (!string.IsNullOrEmpty(id))
		{
			catalogItemModel.Id = converter.ConvertFromInvariantString(id);
			catalogItemModel.ViewType = viewType ?? ViewType.Edit;
			catalogItemModel.Entity = (IEntity)entityManager.Load(catalogItemModel.Id).CastAsRealType();
		}
		else
		{
			if (formReadOnly)
			{
				throw new ArgumentException(SR.T("Не задан идентификатор объекта"));
			}
			catalogItemModel.Entity = (IEntity)Activator.CreateInstance(typeByUid);
			catalogItemModel.ViewType = viewType ?? ViewType.Create;
			if (propertyMetadata != null)
			{
				catalogItemModel.Entity.SetPropertyValue(propertyMetadata.Uid, isGroup);
			}
		}
		if (formReadOnly)
		{
			if ((!(entityMetadata is EntityMetadata metadata) || !metadata.CanUsePermissions()) && !base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogViewPermission, catalogProfile))
			{
				throw new SecurityException(SR.T("Недостаточно прав для просмотра справочника \"{0}\"", classMetadata.DisplayName));
			}
		}
		else
		{
			if (catalogItemModel.Entity.IsNew() && (!viewType.HasValue || viewType == ViewType.Create) && !base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogAddPermission, catalogProfile))
			{
				throw new SecurityException(SR.T("Недостаточно прав для добавления элементов справочника \"{0}\"", classMetadata.DisplayName));
			}
			if (!catalogItemModel.Entity.IsNew() && (!viewType.HasValue || viewType == ViewType.Edit) && !HasEditPermission(catalogItemModel.Entity, catalogProfile))
			{
				throw new SecurityException(SR.T("Недостаточно прав для редактирования элементов справочника \"{0}\"", classMetadata.DisplayName));
			}
		}
		if (propertyMetadata != null)
		{
			catalogItemModel.IsGroup = (bool)catalogItemModel.Entity.GetPropertyValue(propertyMetadata.Uid);
		}
		if (!string.IsNullOrEmpty(parentId) && entityMetadata != null)
		{
			catalogItemModel.Entity.SetPropertyValue(entityMetadata.ParentPropertyUid, entityManager.Load(converter.ConvertFromInvariantString(parentId)));
		}
		catalogItemModel.FormId = ((!string.IsNullOrEmpty(formId)) ? formId : "GlobalForm");
		catalogItemModel.TypeUid = uid;
		catalogItemModel.InPopUp = inPopUp;
		catalogItemModel.BackUrl = backUrl;
		return catalogItemModel;
	}

	public ActionResult Add(Guid uid, string id, bool isGroup = false, bool inPopUp = false, string parentId = null, string backUrl = null)
	{
		if (backUrl == null)
		{
			backUrl = ((Controller)this).get_Url().Action("View", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				uid = uid,
				parentId = parentId
			});
		}
		CatalogItemModel catalogItemModel = InitNewModel(uid, id, isGroup, inPopUp, parentId, null, null, backUrl);
		if (!inPopUp)
		{
			return (ActionResult)(object)((Controller)this).View("Add", (object)catalogItemModel);
		}
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)catalogItemModel);
	}

	public ActionResult ViewItem(Guid uid, string id, bool inPopUp = false, string backUrl = null)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		CatalogItemModel catalogItemModel = new CatalogItemModel();
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid);
		if (typeByUid == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid, inherit: false);
		ICatalogProfile catalogProfile = GetCatalogProfile(classMetadata);
		if (catalogProfile == null)
		{
			string text = EleWise.ELMA.Web.Mvc.Extensions.UrlExtensions.Entity(new UrlHelper(new RequestContext(HttpContextAccessor.CurrentContext, RouteTable.Routes.GetRouteData(HttpContextAccessor.CurrentContext))), uid, id);
			if (!string.IsNullOrWhiteSpace(text))
			{
				return (ActionResult)(object)((Controller)this).Redirect(text);
			}
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (!base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogViewPermission, catalogProfile) && !base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogEditPermission, catalogProfile) && !base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogDeletePermission, catalogProfile) && !base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogAddPermission, catalogProfile))
		{
			throw new SecurityException(SR.T("Недостаточно прав для просмотра справочника \"{0}\"", classMetadata.DisplayName));
		}
		if (!string.IsNullOrEmpty(id))
		{
			Type entityIdType = ModelHelper.GetEntityIdType(typeByUid);
			catalogItemModel.CatalogName = classMetadata.DisplayName;
			TypeConverter converter = TypeDescriptor.GetConverter(entityIdType);
			catalogItemModel.Id = converter.ConvertFromInvariantString(id);
			catalogItemModel.ViewType = ViewType.Display;
			IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
			catalogItemModel.Entity = (IEntity)entityManager.Load(catalogItemModel.Id);
			IEntityMetadata entityMetadata = classMetadata as IEntityMetadata;
			PropertyMetadata propertyMetadata = ((entityMetadata != null && entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty) ? classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == entityMetadata.IsGroupPropertyUid) : null);
			if (propertyMetadata != null)
			{
				catalogItemModel.IsGroup = (bool)catalogItemModel.Entity.GetPropertyValue(propertyMetadata.Uid);
			}
			catalogItemModel.TypeUid = uid;
			catalogItemModel.InPopUp = inPopUp;
			catalogItemModel.BackUrl = backUrl;
			catalogItemModel.CanEdit = CanEditEntity(catalogItemModel.Entity, catalogProfile);
			catalogItemModel.CanDelete = CanDeleteEntity(catalogItemModel.Entity, catalogProfile);
			catalogItemModel.CanFullAccess = CanAccessEditEntity(catalogItemModel.Entity);
			if (!inPopUp)
			{
				return (ActionResult)(object)((Controller)this).View("ViewItem", (object)catalogItemModel);
			}
			return (ActionResult)(object)((Controller)this).PartialView("ViewForm", (object)catalogItemModel);
		}
		throw new ArgumentException(SR.T("Не задан идентификатор объекта"));
	}

	[AsyncViewItemAction]
	public ActionResult AsyncViewItem(Guid viewItemUid, Guid uid, string id, ViewType viewType, string formId = null, bool isGroup = false, Guid? formUid = null)
	{
		ViewType? viewType2 = viewType;
		CatalogItemModel catalogItemModel = InitNewModel(uid, id, isGroup, inPopUp: false, null, formId, viewType2);
		catalogItemModel.FormUid = formUid;
		return AsyncViewItemView(catalogItemModel.View, viewType, viewItemUid, catalogItemModel, (CatalogItemModel m) => m.Entity, catalogItemModel.ItemType, CatalogObjectViewItemProvider.UID, catalogItemModel.ViewItemId, (catalogItemModel.DynamicFormSettings != null) ? catalogItemModel.DynamicFormSettings.DynamicFormsProviderUid : Guid.Empty, (catalogItemModel.DynamicFormSettings != null) ? catalogItemModel.DynamicFormSettings.DynamicFormsProviderData : null, catalogItemModel.FormId);
	}

	public ActionResult Save(CatalogItemModel model)
	{
		IEntityManager entityManager = ModelHelper.GetEntityManager(base.IMetadataRuntimeService.GetTypeByUid(model.TypeUid));
		try
		{
			entityManager.Save(model.Entity);
		}
		catch (Exception ex)
		{
			Locator.GetServiceNotNull<IUnitOfWorkManager>().RollbackCurrent("");
			base.Logger.Error(ex, SR.T("Ошибка при сохранении объекта"));
			if (IsCustomViewRequest())
			{
				return (ActionResult)((!IsCreatorRequest()) ? ((object)((Controller)this).View("Add", (object)model)) : ((object)CreatorJson(model.Entity, SR.T("Не удалось сохранить объект: {0} {1}", ex.Message, (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message)) ? ex.InnerException.Message : ""))));
			}
			base.Notifier.Error((ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message)) ? ex.InnerException.Message : ex.Message);
			return (ActionResult)((!IsCreatorRequest()) ? ((object)((Controller)this).View("Add", (object)model)) : ((object)CreatorJson(model.Entity, ex.Message)));
		}
		if (IsCustomViewRequest())
		{
			return HandleCustomViewJsonCallback(model.Entity);
		}
		if (IsCreatorRequest())
		{
			return CreatorJson(model.Entity);
		}
		if (model.InPopUp)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new { model.Continue }, (JsonRequestBehavior)0);
		}
		if (!string.IsNullOrEmpty(model.BackUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.BackUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = model.TypeUid
		});
	}

	[HttpPost]
	public ActionResult FilteringAjax(string text, int? filterMode)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a5: Expected O, but got Unknown
		text = text.ToLower();
		var list = (from e in EntityList
			where e.DisplayName.ToLower().IndexOf(text) != -1 || e.Description.ToLower().IndexOf(text) != -1
			orderby e.DisplayName
			select new
			{
				id = e.Uid,
				name = e.DisplayName.HtmlEncode()
			}).ToList();
		JsonResult val = new JsonResult();
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		val.set_Data((object)new SelectList((IEnumerable)list, "id", "name"));
		return (ActionResult)val;
	}

	public ActionResult View(Guid uid, string parentId = null, long? FilterId = null)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		string text = ((Controller)this).get_Url().EntityList(base.IMetadataRuntimeService.GetTypeByUid(uid));
		if (text != null)
		{
			return (ActionResult)(object)((Controller)this).Redirect(text);
		}
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid);
		if (typeByUid == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid, inherit: false);
		if (classMetadata == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (classMetadata.Uid != uid)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
			{
				uid = classMetadata.Uid,
				parentId = parentId,
				FilterId = FilterId
			});
		}
		if (!FilterId.HasValue)
		{
			IFilter defaultFilter = FilterDefaultManager.Instance.LoadDefaultFilter(classMetadata.Uid).CastAsRealType();
			if (defaultFilter == null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
				{
					uid = uid,
					parentId = parentId,
					FilterId = 0
				});
			}
			IFilterMenuProviderExtension filterMenuProviderExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault((IFilterMenuProviderExtension p) => p.SupportedFilter(defaultFilter));
			string href = null;
			filterMenuProviderExtension?.GetTreeNodeParameters(defaultFilter, new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext), isDefault: false, isSystemDefault: false, out var _, out var _, out href, out var _, new ActionRoute("View", "Catalogs", new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				uid = uid,
				parentId = parentId
			}), "FilterId");
			return (ActionResult)(object)((Controller)this).Redirect(href);
		}
		if (FilterId != 0 && parentId != null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new { uid, FilterId });
		}
		HttpContextAccessor.CurrentContext.Items.Add("filterAdditionalRouteParameters", new { parentId });
		if (GetCatalogProfile(classMetadata) == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		CatalogViewModel catalogViewModel = FillViewModel(typeByUid, classMetadata, parentId, FilterId);
		return (ActionResult)(object)((Controller)this).View((object)catalogViewModel);
	}

	public ActionResult Search(Guid uid, string parentId = null, long? FilterId = null)
	{
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid, inherit: false);
		if (((Controller)this).get_Request().QueryString.Count <= 1 || uid != classMetadata.Uid)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
			{
				uid = classMetadata.Uid,
				parentId = parentId,
				FilterId = FilterId
			});
		}
		GetCatalogProfile(classMetadata);
		CatalogViewModel catalogViewModel = FillViewModel(typeByUid, classMetadata, parentId, FilterId);
		return (ActionResult)(object)((Controller)this).View("View", (object)catalogViewModel);
	}

	private CatalogViewModel FillViewModel(Type type, ClassMetadata metadata, string parentId, long? filterId)
	{
		if (!base.SecurityService.HasPermission(CommonPermissions.View, type))
		{
			throw new SecurityException(SR.T("Недостаточно прав для просмотра справочника \"{0}\"", metadata.DisplayName));
		}
		IEntityMetadata entityMetadata = MetadataLoader.LoadMetadata(type) as IEntityMetadata;
		bool existPropertiesForFastSearch = entityMetadata != null && EntityHelper.GetEntityManager(type).ExistPropertiesForFastSearch(entityMetadata);
		FilterModel filter = CreateFilter(metadata.Uid, filterId, existPropertiesForFastSearch, "Filter");
		CatalogViewModel catalogViewModel = new CatalogViewModel
		{
			Metadata = metadata,
			Filter = filter
		};
		PropertyMetadata propertyMetadata = ((entityMetadata != null && entityMetadata.Hierarchical && entityMetadata.ParentPropertyUid != Guid.Empty) ? metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == entityMetadata.ParentPropertyUid) : null);
		if (entityMetadata != null && entityMetadata.Hierarchical && propertyMetadata != null)
		{
			object obj = ModelHelper.TryConvertEntityId(type, parentId);
			catalogViewModel.CurrentFolderObject = ((obj != null) ? ((IEntity)ModelHelper.GetEntityManager(type).Load(obj)) : null);
			catalogViewModel.ParentPropertyUid = propertyMetadata.Uid;
		}
		catalogViewModel.HasAddPermission = base.SecurityService.HasPermission(CommonPermissions.Create, type);
		return catalogViewModel;
	}

	protected virtual ICatalogProfile GetCatalogProfile(ClassMetadata metadata)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		if (!(metadata is EntityMetadata entityMetadata))
		{
			return CatalogManager.Instance.LoadByCatalog(metadata.Uid);
		}
		return CatalogManager.Instance.LoadByCatalog(entityMetadata.ImplementationUid);
	}

	protected virtual FilterModel CreateFilter(Guid typeUid, long? FilterId, bool existPropertiesForFastSearch)
	{
		return CreateFilter(typeUid, FilterId, existPropertiesForFastSearch, null);
	}

	protected virtual FilterModel CreateFilter(Guid typeUid, long? FilterId = null, bool existPropertiesForFastSearch = true, string updatePrefix = "Filter")
	{
		FilterModel filterModel = new FilterModel((FilterId > 0) ? AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value) : InterfaceActivator.Create<IFilter>(), typeUid, null, null, "Filter", null, null, CanUseEqlQuery(typeUid));
		((Controller)this).TryUpdateModel<IEntityFilter>(filterModel.Filter, updatePrefix);
		filterModel.ExistPropertiesForFastSearch = existPropertiesForFastSearch;
		if (FilterId == 0)
		{
			foreach (IDefaultFilterCatalogExtension item in from a in ComponentManager.Current.GetExtensionPoints<IDefaultFilterCatalogExtension>()
				where a.EntityTypeUid == typeUid
				select a)
			{
				filterModel.Filter = item.ModifyFilter(filterModel.Filter);
			}
		}
		if (FilterModelExtensions != null)
		{
			foreach (IFilterModelExtension filterModelExtension in FilterModelExtensions)
			{
				filterModelExtension.Update(filterModel);
			}
			return filterModel;
		}
		return filterModel;
	}

	protected bool CanUseEqlQuery(Guid typeUid)
	{
		if (EnableEqlQuery)
		{
			return MetadataLoader.LoadMetadata(typeUid) is EntityMetadata;
		}
		return false;
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, Guid uid, string parentId = null, string searchQuery = null, [Bind(Prefix = "DataFilter")] FilterModel filter = null, long? filterId = null)
	{
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid((filter != null && filter.FilterTypeUid != Guid.Empty) ? filter.FilterTypeUid : uid);
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		IEntityMetadata entityMetadata = metadata as IEntityMetadata;
		filter = filter ?? CreateFilter(metadata.Uid, filterId);
		string gridUniqueName = EntityBaseController.GenerateGridId(uid, "", filter.Entity);
		if (command == null)
		{
			command = GridBuilderExtensions.GetCommandFromRequest(((ControllerBase)this).get_ControllerContext().get_HttpContext().Request.Params, gridUniqueName);
		}
		GridResult gridResult = Grid(command, uid, typeByUid, metadata, entityMetadata, parentId, searchQuery, filter.Filter, null, showOnlyGroups: false, "", null, null, filter.Entity);
		if (gridResult == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		DynamicGrid grid = gridResult.GridData;
		long? realFilterId = ((filter.Entity != null && filter.Entity.Id > 0) ? new long?(filter.Entity.Id) : null);
		if (entityMetadata != null && entityMetadata.Hierarchical)
		{
			GridColumn gridColumn = new GridColumn
			{
				ValueType = typeof(string),
				Name = null,
				Header = "",
				Sortable = false,
				UniqueName = "folderColumn" + uid,
				Width = ((gridResult.GridTableView == null || gridResult.GridTableView.Resizeable) ? "48px" : "1%")
			};
			Func<object, string> func2 = (Func<object, string>)(gridColumn.Template = (Func<object, string>)((dynamic entity) => FolderCellTemplate(entity, uid, gridResult.ParentId)));
			grid.Columns.Add(gridColumn);
		}
		((List<GridColumn>)grid.Columns).AddRange(GridBuilderExtensions.GetDefaultColumns(typeByUid, metadata, grid.State));
		PropertyMetadata titleProperty = metadata.GetTitleProperty();
		GridColumn gridColumn2 = ((titleProperty != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == titleProperty.Uid.ToString()) : null);
		if (gridColumn2 != null)
		{
			gridColumn2.Template = (dynamic entity) => TitleCellTemplate(entity, uid, titleProperty.Uid, gridResult.ParentId, metadata, filterId);
		}
		GridColumn gridColumn3 = new GridColumn
		{
			ValueType = typeof(string),
			Name = null,
			Header = "",
			Sortable = false,
			Order = 2147483646,
			UniqueName = "actionColumn" + uid,
			Width = ((gridResult.GridTableView == null || gridResult.GridTableView.Resizeable) ? "96px" : "1%"),
			HtmlAttributes = new Dictionary<string, object> { { "style", "white-space:nowrap" } }
		};
		Guid uidCatalog = Guid.Empty;
		if (metadata is EntityMetadata)
		{
			uidCatalog = ((EntityMetadata)metadata).ImplementationUid;
		}
		else
		{
			uidCatalog = metadata.Uid;
		}
		Func<object, string> func4 = (Func<object, string>)(gridColumn3.Template = (Func<object, string>)((dynamic entity) => ActionsCellTemplate(entity, parentId, uid, uidCatalog, realFilterId)));
		grid.Columns.Add(gridColumn3);
		ICatalogProfile target = CatalogManager.Instance.LoadByCatalog(uidCatalog);
		grid.ExportExcel = base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogExportPermission, target);
		foreach (IGridObjectSelectorExtension item in selectObjectColumnPointService)
		{
			if (item is IGridObjectSelectorExtensionExtended gridObjectSelectorExtensionExtended)
			{
				gridObjectSelectorExtensionExtended.EditGrid(grid, uid, GetHtmlHelper());
			}
			else
			{
				item.EditGrid(grid, uid);
			}
		}
		return ExportExcel(grid.GridData, typeByUid, () => (ActionResult)(object)((Controller)this).PartialView("Templates/DynamicGrid", (object)grid));
	}

	[ContentItem(Name = "SR.M('Справочники')", Root = true, Id = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root", Image24 = "#catalogs.svg")]
	public ActionResult Index()
	{
		AutocompleteComboBox autocompleteComboBox = new AutocompleteComboBox
		{
			Name = "CatalogsComboBox",
			MultiSelect = false,
			ActionName = "FilteringAjax",
			ControllerName = "Catalogs",
			AutocompleteActionUrl = ((Controller)this).get_Url().Action("FilteringAjax", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common"
			}),
			HtmlAttributes = new HtmlAttributes(),
			OnChange = "onChangeCatalogsComboBox"
		};
		autocompleteComboBox.HtmlAttributes.style.width = "100%";
		autocompleteComboBox.RouteValueDictionary.Add("area", "EleWise.ELMA.BPM.Web.Common");
		string text = "CatalogsTree";
		TreeState treeState = TreePersonalizationAdministration.LoadState(text);
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = text
			};
			TreePersonalizationAdministration.SaveState(text, treeState);
		}
		TreeModel tree = new TreeModel
		{
			Id = text,
			Children = BuildTree(EntityList, treeState, (Guid guid) => ((Controller)this).get_Url().EntityList(base.IMetadataRuntimeService.GetTypeByUid(guid)) ?? ((Controller)this).get_Url().Action("View", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				uid = guid
			}), ((Controller)this).get_Url(), null, checkPermissions: true),
			HtmlAttributes = new
			{
				style = "width:100%; border: 0px solid #FFF;"
			},
			ShowExpandCollapseButtons = true
		};
		return (ActionResult)(object)((Controller)this).View((object)new CatalogListModel
		{
			Tree = tree,
			ComboBox = autocompleteComboBox
		});
	}

	public virtual ActionResult EditFilters(Guid uid)
	{
		IEntityMetadata entityMetadata = ((ClassMetadata)MetadataLoader.LoadMetadata(base.IMetadataRuntimeService.GetTypeByUid(uid))) as IEntityMetadata;
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTreeForType", uid);
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(entityMetadata.Uid, null));
	}

	private void CheckFilterEditPermission(IFilterBase filter)
	{
		if (filter != null && !base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.FilterEditPermission, filter))
		{
			throw new SecurityException(SR.T("Текущий пользователь не имеет прав на редактирование фильтра \"{0}\" с идентификатором {1}", filter.Name, filter.Id));
		}
	}

	[HttpGet]
	public virtual ActionResult EditFilter(long? FilterId = null)
	{
		//IL_00f0: Expected O, but got Unknown
		if (!FilterId.HasValue)
		{
			return (ActionResult)(object)((Controller)this).View("Index");
		}
		IFilter filter = AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value);
		CheckFilterEditPermission(filter);
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTreeForType", filter.ObjectsType.TypeUid);
		FilterModel filterModel = new FilterModel(filter, filter.ObjectsType.TypeUid, null, null, "Filter", null, null, CanUseEqlQuery(filter.ObjectsType.TypeUid));
		if (EnableEqlQuery)
		{
			IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(filterModel.FilterTypeUid));
			try
			{
				entityManagerOrNull?.CheckFilter(filterModel.Filter);
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
		model.Entity.Save();
		if (!string.IsNullOrEmpty(((Controller)this).get_Request()["ReturnUrl"]))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("EditFilters", (object)new
		{
			uid = model.Entity.ObjectsType.TypeUid
		});
	}

	public ActionResult AccessSettingsCatalogItemPopup(Guid typeUid, long id, string popupId, string onClosePopupFunction)
	{
		Type entityType = ModelHelper.GetEntityType(typeUid);
		object target = ModelHelper.GetEntityManager(entityType).LoadOrNull(id);
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityDependedPermissionSettings", "PermissionManagment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = id,
			type = InterfaceActivator.TypeOf(entityType).AssemblyQualifiedName,
			disabledNotUserGroup = true,
			ajax = true,
			showSaveButton = false,
			popupId = popupId,
			readOnly = !base.SecurityService.HasPermission(CommonPermissions.GrantAccess, target),
			onClosePopupFunction = onClosePopupFunction
		});
	}

	[HttpGet]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Permissions()
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Security.Controllers.PermissionManagmentController.Index");
		IOrderedEnumerable<ClassMetadata> orderedEnumerable = from c in EntityList.ToList()
			orderby c.DisplayName
			select c;
		CatalogsPermissionsGrid catalogsPermissionsGrid = new CatalogsPermissionsGrid();
		foreach (ClassMetadata item in orderedEnumerable)
		{
			CatalogPermissionItem catalogPermissionItem = new CatalogPermissionItem();
			catalogPermissionItem.CatalogName = item.DisplayName;
			catalogPermissionItem.Uid = item.Uid;
			catalogsPermissionsGrid.Data.Add(catalogPermissionItem);
		}
		return (ActionResult)(object)((Controller)this).View((object)catalogsPermissionsGrid);
	}

	[HttpGet]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult PermissionSettings(Guid uid)
	{
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(uid);
		if (catalogProfile == null)
		{
			catalogProfile = InterfaceActivator.Create<ICatalogProfile>();
			catalogProfile.CatalogType = new ReferenceOnEntityType
			{
				TypeUid = uid
			};
			catalogProfile.Save();
		}
		((ControllerBase)this).get_TempData().set_Item("ReturnUrl", (object)((Controller)this).get_Request().UrlReferrer.ToString());
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityPermissionSettings", "PermissionManagment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = catalogProfile.Id,
			type = catalogProfile.GetType().AssemblyQualifiedName
		});
	}

	internal static List<TreeMenuNode> BuildTree(IEnumerable<ClassMetadata> list, TreeState treeState, Func<Guid, string> href, UrlHelper url, Func<Guid, string> onclick, bool checkPermissions)
	{
		List<TreeMenuNode> list2 = new List<TreeMenuNode>();
		BuildTree(MetadataTreeHelper.BuildTree(list.Cast<ICodeItemMetadata>()), list2, treeState, href, url, onclick, checkPermissions);
		return list2;
	}

	internal static void BuildTree(MetadataTreeHelper.GroupNode parent, List<TreeMenuNode> nodes, TreeState treeState, Func<Guid, string> href, UrlHelper url, Func<Guid, string> onclick, bool checkPermissions)
	{
		foreach (MetadataTreeHelper.GroupNode groupNode in parent.GroupNodes)
		{
			string text = ((groupNode.Group != null) ? ("group_" + groupNode.Group.Id) : groupNode.Namespace);
			TreeMenuNode treeMenuNode = new TreeMenuNode
			{
				text = SR.T(groupNode.Name),
				expanded = (text != null && treeState[text]),
				id = text,
				icon = "#folder.svg"
			};
			nodes.Add(treeMenuNode);
			BuildTree(groupNode, treeMenuNode.children, treeState, href, url, onclick, checkPermissions);
		}
		foreach (ClassMetadata item2 in from c in parent.MetadataNodes.Select((MetadataTreeHelper.MetadataNode n) => n.Metadata).OfType<ClassMetadata>()
			where c is IEntityMetadata
			select c)
		{
			ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(item2.Uid);
			if (catalogProfile == null)
			{
				continue;
			}
			if (checkPermissions)
			{
				EntityMetadata entityMetadata = ((catalogProfile.CatalogType != null) ? (MetadataLoader.LoadMetadata(catalogProfile.CatalogType.EntityType) as EntityMetadata) : null);
				if (entityMetadata == null || !entityMetadata.CanUsePermissions())
				{
					ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
					if (!serviceNotNull.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogViewPermission, catalogProfile) && !serviceNotNull.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogAddPermission, catalogProfile) && !serviceNotNull.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogEditPermission, catalogProfile) && !serviceNotNull.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogDeletePermission, catalogProfile))
					{
						continue;
					}
				}
			}
			TreeMenuNode item = new TreeMenuNode
			{
				text = item2.DisplayName,
				expanded = treeState[item2.Uid.ToString()],
				id = item2.Uid.ToString(),
				icon = GetIconString(url, item2),
				href = href?.Invoke(item2.Uid),
				onclick = onclick?.Invoke(item2.Uid)
			};
			nodes.Add(item);
		}
	}

	private static string GetIconString(UrlHelper urlHelper, ClassMetadata metadata)
	{
		if (urlHelper != null && metadata.Images != null && metadata.Images.Any())
		{
			return urlHelper.Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = metadata.Uid,
				size = 16,
				useParent = false
			});
		}
		return "#dictionary.svg";
	}

	private string ActionsCellTemplate(IEntity entity, string parentId, Guid uid, Guid ImplementationUid, long? filterId)
	{
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(ImplementationUid);
		if (catalogProfile == null)
		{
			throw new ArgumentNullException("CatalogProfile is null");
		}
		bool flag = CanAccessEditEntity(entity);
		bool flag2 = CanEditEntity(entity, catalogProfile);
		bool flag3 = CanDeleteEntity(entity, catalogProfile);
		if (!flag2 && !flag3 && !flag)
		{
			return string.Empty;
		}
		List<string> list = new List<string>();
		object id = entity.GetId();
		HtmlHelper htmlHelper = GetHtmlHelper();
		if (flag)
		{
			string item = htmlHelper.ImageButton("#access.svg").Attributes(new
			{
				tooltiptext = SR.T("Права доступа")
			}).Click($"accessSettingsCatalogItem('{uid}', '{id}');")
				.ToHtmlString();
			list.Add(item);
		}
		if (flag2)
		{
			string item2 = htmlHelper.ImageButton("#edit.svg").Attributes(new
			{
				tooltiptext = SR.T("Редактировать запись")
			}).Url(((Controller)this).get_Url().Action("Edit", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				uid = uid,
				id = id,
				parentId = parentId,
				backUrl = ((Controller)this).get_Url().Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = uid,
					parentId = parentId,
					filterId = filterId
				})
			}))
				.ToHtmlString();
			list.Add(item2);
		}
		if (flag3)
		{
			string item3 = htmlHelper.ImageButton("#remove.svg").Attributes(new
			{
				tooltiptext = SR.T("Удалить запись")
			}).Click(string.Format("jConfirm('{2}', '{3}', function (r) {{if (r == true) {{deleteCatalogItem('{0}', '{1}')}}}});", uid, id, SR.T("Удалить запись?"), SR.T("Удаление")))
				.ToHtmlString();
			list.Add(item3);
		}
		return "<div style='text-align: right'>" + string.Join("&nbsp;&nbsp;", list) + "</div>";
	}

	private bool CanAccessEditEntity(object entity)
	{
		if (entity == null)
		{
			return false;
		}
		Type typeWithoutProxy = entity.GetType().GetTypeWithoutProxy();
		if (typeWithoutProxy == null)
		{
			return false;
		}
		if (!(MetadataLoader.LoadMetadata(typeWithoutProxy, inherit: false) is EntityMetadata metadata))
		{
			return false;
		}
		if (metadata.CanUsePermissions())
		{
			return base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogInstanceGrantAccessPermission, entity);
		}
		return false;
	}

	private bool CanEditEntity(object entity, ICatalogProfile profile)
	{
		if (entity == null || (SystemCatalogCheckers != null && SystemCatalogCheckers.Any((ISystemCatalogChecker point) => point.CantDelete(entity))))
		{
			return false;
		}
		if (profile != null)
		{
			return HasEditPermission(entity, profile);
		}
		return true;
	}

	private bool CanDeleteEntity(object entity, ICatalogProfile profile)
	{
		if (entity == null || (SystemCatalogCheckers != null && SystemCatalogCheckers.Any((ISystemCatalogChecker point) => point.CantDelete(entity))))
		{
			return false;
		}
		IEntity iEntity = entity as IEntity;
		if (profile == null || HasDeletePermission(entity, profile))
		{
			if (iEntity != null)
			{
				return !ComponentManager.Current.GetExtensionPoints<ICatalogViewHandler>().Any((ICatalogViewHandler e) => !e.CanDelete(iEntity));
			}
			return true;
		}
		return false;
	}

	private string FolderCellTemplate(IEntity entity, Guid uid, object parentId)
	{
		object parentId2;
		if (entity == null)
		{
			parentId2 = parentId;
		}
		else
		{
			IEntityMetadata entityMetadata = ((ClassMetadata)base.IMetadataRuntimeService.GetMetadata(uid)) as IEntityMetadata;
			if (entity == null || entityMetadata == null || !entityMetadata.Hierarchical)
			{
				return string.Empty;
			}
			bool flag = entityMetadata != null && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && (bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
			if ((entityMetadata == null || entityMetadata.HierarchyType != HierarchyType.Elements) && !flag)
			{
				return string.Empty;
			}
			parentId2 = entity.GetId();
		}
		return GetHtmlHelper().ImageButton("#folder.svg").Url(GenerateViewUrl(uid, parentId2)).Attributes(new
		{
			tooltiptext = SR.T("Перейти в группу")
		})
			.ToHtmlString();
	}

	private string TitleCellTemplate(IEntity entity, Guid uid, Guid titlePropertyUid, object parentId, ClassMetadata metadata, long? filterId)
	{
		if (entity == null)
		{
			return string.Format("<a href=\"{0}\">{1}</a>", GenerateViewUrl(uid, parentId), HttpUtility.HtmlEncode(SR.T("...\\(на уровень выше)")));
		}
		bool num = metadata is IEntityMetadata entityMetadata && entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && (bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
		object propertyValue = entity.GetPropertyValue(titlePropertyUid);
		propertyValue = HttpUtility.HtmlEncode(propertyValue ?? string.Empty);
		if (!num)
		{
			return $"<a href=\"{GenerateViewItemUrl(uid, entity.GetId(), parentId, filterId)}\">{propertyValue}</a>";
		}
		return $"<a href=\"{GenerateViewUrl(uid, entity.GetId())}\">{propertyValue}</a>";
	}

	private string GenerateViewItemUrl(Guid uid, object objectId, object parentId, long? filterId)
	{
		return ((Controller)this).get_Url().Action("ViewItem", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = uid,
			id = objectId?.ToString().Trim(),
			backUrl = ((Controller)this).get_Url().Action("View", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				uid = uid,
				parentId = parentId?.ToString().Trim(),
				filterId = filterId
			})
		});
	}

	private string GenerateViewUrl(Guid uid, object parentId, long? filterId = null)
	{
		return ((Controller)this).get_Url().Action("View", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = uid,
			parentId = parentId,
			filterId = filterId
		});
	}

	private bool HasEditPermission(object target, ICatalogProfile profile = null)
	{
		return HasPermission(target, profile, (IEntity entity) => EleWise.ELMA.Common.PermissionProvider.CatalogInstancePowerPermission, EleWise.ELMA.Common.PermissionProvider.CatalogEditPermission);
	}

	private bool HasDeletePermission(object target, ICatalogProfile profile = null)
	{
		return HasPermission(target, profile, (IEntity entity) => EleWise.ELMA.Common.PermissionProvider.CatalogInstancePowerPermission, EleWise.ELMA.Common.PermissionProvider.CatalogDeletePermission);
	}

	private bool HasPermission(object target, ICatalogProfile profile, Func<IEntity, Permission> instancePermission, Permission profilePermission)
	{
		if (target is IEntity entity)
		{
			IMetadata metadata = MetadataLoader.LoadMetadata(entity.GetType());
			EntityMetadata entityMetadata = metadata as EntityMetadata;
			if (entityMetadata != null && entityMetadata.CanUsePermissions())
			{
				return base.SecurityService.HasPermission(instancePermission(entity), entity);
			}
			if (profile == null)
			{
				profile = ((entityMetadata != null) ? CatalogManager.Instance.LoadByCatalog(entityMetadata.ImplementationUid) : CatalogManager.Instance.LoadByCatalog(metadata.Uid));
				if (profile != null)
				{
					return HasPermission(null, profile, instancePermission, profilePermission);
				}
			}
		}
		else if (profile != null && profile.CatalogType != null && MetadataLoader.LoadMetadata(profile.CatalogType.EntityType) is EntityMetadata metadata2 && metadata2.CanUsePermissions())
		{
			throw new ArgumentNullException("target", SR.T("Не задан объект проверки прав. Для типа {0} права определяются на экземпляр объекта", profile.CatalogType.EntityType));
		}
		return base.SecurityService.HasPermission(profilePermission, profile);
	}
}
