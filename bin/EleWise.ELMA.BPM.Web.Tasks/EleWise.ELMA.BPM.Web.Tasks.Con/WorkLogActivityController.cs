using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.BPM.Web.Tasks.Models;
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
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Buttons;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Tasks")]
public class WorkLogActivityController : EntityBaseController
{
	private const string CatalogsMenu = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root";

	private const string WorkLogActivityGridId = "WorkLogActivityGridId";

	public PermissionsModelService PermissionsModelService { get; set; }

	public IEnumerable<ISystemCatalogChecker> SystemCatalogCheckers { get; set; }

	[EntityListLink(typeof(IWorkLogActivity))]
	[FilterMenuItem(Id = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root", Type = typeof(IWorkLogActivity), FilterEditAction = "EditFilters")]
	public ActionResult Index(long? FilterId = null)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		if (!FilterId.HasValue)
		{
			IFilter defaultFilter = FilterDefaultManager.Instance.LoadDefaultFilter(InterfaceActivator.UID<IWorkLogActivity>()).CastAsRealType();
			if (defaultFilter == null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
				{
					FilterId = 0
				});
			}
			IFilterMenuProviderExtension filterMenuProviderExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault((IFilterMenuProviderExtension p) => p.SupportedFilter(defaultFilter));
			string href = null;
			filterMenuProviderExtension?.GetTreeNodeParameters(defaultFilter, new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext), isDefault: false, isSystemDefault: false, out var _, out var _, out href, out var _, new ActionRoute("Index", "WorkLogActivity", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			}), "FilterId");
			return (ActionResult)(object)((Controller)this).Redirect(href);
		}
		WorkLogActivityViewModel workLogActivityViewModel = new WorkLogActivityViewModel
		{
			Filter = CreateFilter(InterfaceActivator.UID<IWorkLogActivity>(), FilterId),
			GridId = "WorkLogActivityGridId"
		};
		return (ActionResult)(object)((Controller)this).View((object)workLogActivityViewModel);
	}

	public virtual ActionResult EditFilters()
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		Type runtimeType = InterfaceActivator.TypeOf<IWorkLogActivity>();
		Guid guid = InterfaceActivator.UID<IWorkLogActivity>();
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
		FilterModel filterModel = new FilterModel(filter, filter.ObjectsType.TypeUid);
		filterModel.ShowAllFields = true;
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

	public ActionResult AccessSettingsItemPopup(long id, string popupId)
	{
		Type type = InterfaceActivator.TypeOf<IWorkLogActivity>();
		object target = ModelHelper.GetEntityManager(type).LoadOrNull(id);
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityDependedPermissionSettings", "PermissionManagment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = id,
			type = InterfaceActivator.TypeOf(type).AssemblyQualifiedName,
			disabledNotUserGroup = true,
			ajax = true,
			showSaveButton = false,
			popupId = popupId,
			readOnly = !base.SecurityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogInstanceGrantAccessPermission, target)
		});
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, string searchQuery = null, [Bind(Prefix = "DataFilter")] FilterModel filter = null, long? FilterId = null)
	{
		Guid guid = InterfaceActivator.UID<IWorkLogActivity>();
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(guid);
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		IEntityMetadata entityMetadata = metadata as IEntityMetadata;
		filter = filter ?? CreateFilter(metadata.Uid, FilterId);
		GridResult gridResult = Grid(command, guid, typeByUid, metadata, entityMetadata, null, searchQuery, filter.Filter, null, showOnlyGroups: false, "", null, null, filter.Entity);
		if (gridResult == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		DynamicGrid grid = gridResult.GridData;
		((List<GridColumn>)grid.Columns).AddRange(GridBuilderExtensions.GetDefaultColumns(typeByUid, metadata, grid.State));
		PropertyMetadata titleProperty = metadata.GetTitleProperty();
		GridColumn gridColumn = ((titleProperty != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == titleProperty.Uid.ToString()) : null);
		if (gridColumn != null)
		{
			gridColumn.Template = (dynamic entity) => TitleCellTemplate(entity, titleProperty.Uid, metadata, 0);
		}
		GridColumn gridColumn2 = new GridColumn
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
		if (metadata is EntityMetadata)
		{
			uidCatalog = ((EntityMetadata)metadata).ImplementationUid;
		}
		else
		{
			uidCatalog = metadata.Uid;
		}
		Func<object, string> func2 = (Func<object, string>)(gridColumn2.Template = (Func<object, string>)((dynamic entity) => ActionsCellTemplate(entity, uidCatalog)));
		grid.Columns.Add(gridColumn2);
		grid.UniqueName = "WorkLogActivityGridId";
		grid.Customizable = false;
		return ExportExcel(grid.GridData, typeByUid, () => (ActionResult)(object)((Controller)this).PartialView("Templates/DynamicGrid", (object)grid));
	}

	private string TitleCellTemplate(IEntity entity, Guid titlePropertyUid, ClassMetadata metadata, long? FilterId = null)
	{
		bool num = metadata is IEntityMetadata entityMetadata && entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && (bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
		object propertyValue = entity.GetPropertyValue(titlePropertyUid);
		propertyValue = HttpUtility.HtmlEncode(propertyValue ?? string.Empty);
		if (!num)
		{
			return string.Format("<a href=\"{0}\" onclick=\"{2}\">{1}</a>", "#", propertyValue, $"showWorkLogActivityInfo({entity.GetId()})");
		}
		return string.Format("<a href=\"{0}\" onclick=\"{2}\">{1}</a>", GenerateViewUrl(FilterId), propertyValue, "");
	}

	private string GenerateViewUrl(long? FilterId = null)
	{
		return ((Controller)this).get_Url().Action("Index", "WorkLogActivity", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			FilterId = FilterId
		});
	}

	private string ActionsCellTemplate(IEntity entity, Guid implementationUid)
	{
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(implementationUid);
		if (catalogProfile == null)
		{
			throw new ArgumentNullException("CatalogProfile is null");
		}
		List<string> list = new List<string>();
		IWorkLogActivity workLogActivity = entity as IWorkLogActivity;
		IEnumerable<ISystemCatalogChecker> extensionPoints = ComponentManager.Current.GetExtensionPoints<ISystemCatalogChecker>();
		if (workLogActivity == null || extensionPoints.Any((ISystemCatalogChecker point) => point.CantDelete(entity)))
		{
			return string.Empty;
		}
		bool flag = CanAccessEditEntity(workLogActivity);
		bool flag2 = CanEditEntity(workLogActivity, catalogProfile);
		bool flag3 = CanDeleteEntity(workLogActivity, catalogProfile);
		if (!flag2 && !flag3 && !flag)
		{
			return string.Empty;
		}
		object id = entity.GetId();
		HtmlHelper htmlHelper = GetHtmlHelper();
		if (flag)
		{
			ActionButtonBuilder actionButtonBuilder = htmlHelper.Button().IconUrl("#access.svg").NoBorder()
				.Circle()
				.Click($"accessSettingsWorkLogActivity('{id}')")
				.Attributes(new
				{
					title = SR.T("Права доступа")
				});
			list.Add(actionButtonBuilder.ToHtmlString());
		}
		if (flag2)
		{
			ActionButtonBuilder actionButtonBuilder2 = htmlHelper.Button().IconUrl("#edit.svg").NoBorder()
				.Circle()
				.Url(((Controller)this).get_Url().Action("Edit", "WorkLogActivity", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks",
					id = id
				}))
				.Attributes(new
				{
					title = SR.T("Редактировать запись")
				});
			list.Add(actionButtonBuilder2.ToHtmlString());
		}
		if (flag3)
		{
			ActionButtonBuilder actionButtonBuilder3 = htmlHelper.Button().IconUrl("#remove.svg").NoBorder()
				.Circle()
				.Click(string.Format("jConfirm('{0}', '{1}', function (r) {{if (r == true) {{deleteWorkLogActivity('{2}')}}}});", SR.T("Вид деятельности может быть использован в ранее созданных трудозатратах. Вы действительно хотите удалить запись?"), SR.T("Удаление"), id))
				.Attributes(new
				{
					title = SR.T("Удалить запись")
				});
			list.Add(actionButtonBuilder3.ToHtmlString());
		}
		return string.Join("&nbsp;&nbsp;", list);
	}

	private bool CanAccessEditEntity(object entity)
	{
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

	private bool CanEditEntity(IWorkLogActivity workLogActivity, ICatalogProfile profile)
	{
		if (workLogActivity != null)
		{
			return HasEditPermission(workLogActivity, profile);
		}
		return true;
	}

	private bool CanDeleteEntity(IWorkLogActivity workLogActivity, ICatalogProfile profile)
	{
		if (workLogActivity == null || (SystemCatalogCheckers != null && SystemCatalogCheckers.Any((ISystemCatalogChecker point) => point.CantDelete(workLogActivity))))
		{
			return false;
		}
		if (workLogActivity != null)
		{
			return HasDeletePermission(workLogActivity, profile);
		}
		return true;
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

	public JsonResult GetWorkLogActivityes(string text = "")
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		var data = (from u in EntityManager<IWorkLogActivity>.Instance.Find(InterfaceActivator.Create<IWorkLogActivityFilter>(), new FetchOptions(0, 100))
			select new
			{
				Value = u.Id.ToString(),
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
		WorkLogActivityModel workLogActivityModel = new WorkLogActivityModel(id.HasValue ? WorkLogActivityManager.Instance.Load(id.Value) : InterfaceActivator.Create<IWorkLogActivity>());
		return (ActionResult)(object)((Controller)this).View((object)workLogActivityModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Save(WorkLogActivityModel model)
	{
		try
		{
			if (!model.Entity.AllObjectTypes)
			{
				object obj;
				if (model.ObjectTypeUids == null)
				{
					IEnumerable<Guid> enumerable = new Guid[0];
					obj = enumerable;
				}
				else
				{
					obj = from u in model.ObjectTypeUids.Split(",".ToCharArray())
						select new Guid(u);
				}
				if (obj == null)
				{
					obj = new Guid[0];
				}
				Guid[] uids = ((IEnumerable<Guid>)obj).ToArray();
				((IEnumerable<IWorkLogActivityObjectType>)model.Entity.ObjectsUIDs).Where((IWorkLogActivityObjectType s) => !uids.Contains(s.ObjectUID.TypeUid)).ToList().ForEach(delegate(IWorkLogActivityObjectType s)
				{
					s.WorkLogActivity = null;
					((ICollection<IWorkLogActivityObjectType>)model.Entity.ObjectsUIDs).Remove(s);
					s.Delete();
				});
				uids.Where((Guid uid) => ((IEnumerable<IWorkLogActivityObjectType>)model.Entity.ObjectsUIDs).All((IWorkLogActivityObjectType e) => e.ObjectUID.TypeUid != uid)).ToList().ForEach(delegate(Guid uid)
				{
					IWorkLogActivityObjectType workLogActivityObjectType = InterfaceActivator.Create<IWorkLogActivityObjectType>();
					workLogActivityObjectType.WorkLogActivity = model.Entity;
					workLogActivityObjectType.ObjectUID = new ReferenceOnEntityType
					{
						TypeUid = uid
					};
					model.Entity.ObjectsUIDs.Add(workLogActivityObjectType);
				});
			}
			model.Entity.Save();
			base.Notifier.Information(SR.T("Вид деятельности успешно сохранён."));
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Ошибка сохранения вида деятельности"));
			base.Logger.Error(SR.T("Ошибка сохранения вида деятельности"), exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[HttpGet]
	[EntityLink]
	public ActionResult Details(long id)
	{
		IWorkLogActivity workLogActivity = WorkLogActivityManager.Instance.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView((object)workLogActivity);
	}

	[HttpPost]
	public ActionResult Delete(long id)
	{
		try
		{
			WorkLogActivityManager.Instance.Load(id).Delete();
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				gridId = "WorkLogActivityGridId"
			});
		}
		catch (Exception ex)
		{
			base.Logger.Error(SR.T("Ошибка удаления вида деятельности (id={0})", id), ex);
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
		IWorkLogActivity workLogActivity = InterfaceActivator.Create<IWorkLogActivity>();
		return (ActionResult)(object)((Controller)this).PartialView("EditorFields", (object)workLogActivity);
	}

	[HttpPost]
	public ActionResult Create(IWorkLogActivity model)
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

	public ActionResult EntityTree(List<Guid> uids, string functionCallBack)
	{
		TreeState treeState = TreePersonalizationAdministration.LoadState("WorkLogActivityObjectTypeTree");
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = "WorkLogActivityObjectTypeTree"
			};
			TreePersonalizationAdministration.SaveState("WorkLogActivityObjectTypeTree", treeState);
		}
		if (uids == null)
		{
			uids = new List<Guid>();
		}
		uids = uids.Distinct().ToList();
		TreeModel tree = new TreeModel
		{
			Id = "WorkLogActivityObjectTypeTree",
			Children = BuildTree(uids, treeState, enabled: true),
			HtmlAttributes = new
			{
				style = "width:100%;"
			},
			ShowExpandCollapseButtons = true,
			SaveState = true
		};
		return (ActionResult)(object)((Controller)this).PartialView("EntityTree", (object)new WorkLogTypeSettingsModel
		{
			Tree = tree,
			Uids = uids
		});
	}

	public ActionResult EntityTreeView(long workLogActivityId)
	{
		IEnumerable<Guid> uids = ((IEnumerable<IWorkLogActivityObjectType>)WorkLogActivityManager.Instance.LoadOrNull(workLogActivityId).ObjectsUIDs).Select((IWorkLogActivityObjectType o) => o.ObjectUID.TypeUid);
		TreeModel tree = new TreeModel
		{
			Id = "WorkLogActivityObjectTypeTreeView",
			Children = BuildTree(uids, null, enabled: true),
			HtmlAttributes = new
			{
				style = "width:100%;"
			},
			ShowExpandCollapseButtons = false,
			SaveState = false,
			HighlightPath = false
		};
		return (ActionResult)(object)((Controller)this).PartialView("EntityTree", (object)new WorkLogTypeSettingsModel
		{
			Tree = tree,
			ReadOnly = true
		});
	}

	public ActionResult EntityTreeAddPopup(string popupId, string functionCallBack, List<Guid> uids)
	{
		TreeState treeState = TreePersonalizationAdministration.LoadState("WorkLogActivityObjectTypeTreeAdd");
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = "WorkLogActivityObjectTypeTreeAdd"
			};
			TreePersonalizationAdministration.SaveState("WorkLogActivityObjectTypeTreeAdd", treeState);
		}
		if (uids == null)
		{
			uids = new List<Guid>();
		}
		uids = uids.Distinct().ToList();
		List<Guid> uids2 = (from u in WorkLogExtensionHelper.ObjectsUidEnabledList()
			where uids.All((Guid uid) => uid != u)
			select u).ToList();
		TreeModel tree = new TreeModel
		{
			Id = "WorkLogActivityObjectTypeTreeAdd",
			Children = BuildTree(uids2, treeState, enabled: true),
			HtmlAttributes = new
			{
				style = "width:100%; border: 0px solid #FFF;"
			},
			ShowExpandCollapseButtons = true,
			ShowCheckBox = true,
			HighlightPath = false
		};
		((ControllerBase)this).get_ViewData().set_Item("functionCallBack", (object)functionCallBack);
		return (ActionResult)(object)((Controller)this).PartialView("EntityTreeAddPopup", (object)new WorkLogTypeSettingsModel
		{
			Tree = tree,
			PopupId = popupId
		});
	}

	private static List<TreeMenuNode> BuildTree(IEnumerable<Guid> uids, TreeState treeState, bool enabled, Func<ClassMetadata, string> nameFormatter = null, Func<ClassMetadata, string> onClick = null)
	{
		return EntityTreeHelper.BuildTree(uids, treeState, enabled, nameFormatter, onClick);
	}
}
