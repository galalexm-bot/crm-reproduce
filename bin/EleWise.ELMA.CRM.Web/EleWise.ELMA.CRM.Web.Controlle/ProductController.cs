using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
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
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[RouteArea("EleWise.ELMA.CRM.Web")]
public class ProductController : EntityBaseController
{
	private const string CATALOGS_MENU = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root";

	private const string ProductGridId = "ProductGridId";

	public PermissionsModelService PermissionsModelService { get; set; }

	[FilterMenuItem(Id = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root", Type = typeof(IProduct), FilterEditAction = "EditFilters")]
	public ActionResult Index(string parentId = null, long? FilterId = null)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		string action = "Index";
		string text = ProductRedirect(((Controller)this).get_Url(), action, null, parentId);
		if (text != null)
		{
			return (ActionResult)(object)((Controller)this).Redirect(text);
		}
		if (!FilterId.HasValue)
		{
			IFilter defaultFilter = FilterDefaultManager.Instance.LoadDefaultFilter(InterfaceActivator.UID<IProduct>()).CastAsRealType();
			if (defaultFilter == null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
				{
					parentId = parentId,
					FilterId = 0
				});
			}
			IFilterMenuProviderExtension filterMenuProviderExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault((IFilterMenuProviderExtension p) => p.SupportedFilter(defaultFilter));
			string href = null;
			filterMenuProviderExtension?.GetTreeNodeParameters(defaultFilter, new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext), isDefault: false, isSystemDefault: false, out var _, out var _, out href, out var _, new ActionRoute("Index", "Product", new
			{
				area = "EleWise.ELMA.CRM.Web",
				parentId = parentId
			}), "FilterId");
			return (ActionResult)(object)((Controller)this).Redirect(href);
		}
		if (FilterId != 0 && parentId != null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new { FilterId });
		}
		HttpContextAccessor.CurrentContext.Items.Add("filterAdditionalRouteParameters", new { parentId });
		ProductViewModel productViewModel = new ProductViewModel
		{
			Filter = CreateFilter(InterfaceActivator.UID<IProduct>(), FilterId),
			CurrentFolderObject = ((parentId != null) ? AbstractNHEntityManager<IProduct, long>.Instance.Load(long.Parse(parentId)) : null),
			GridId = "ProductGridId"
		};
		return (ActionResult)(object)((Controller)this).View((object)productViewModel);
	}

	protected virtual FilterModel CreateFilter(Guid typeUid, long? FilterId = null)
	{
		return new FilterModel((FilterId > 0) ? AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value) : InterfaceActivator.Create<IFilter>(), typeUid);
	}

	public virtual ActionResult EditFilters()
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		Guid guid = InterfaceActivator.UID<IProduct>();
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTreeForType", guid);
		return (ActionResult)(object)((Controller)this).View("Filter/FilterTree", (object)base.FilterMenuProvider.TreeMenuNodesForEdit(guid, null));
	}

	[HttpGet]
	public virtual ActionResult EditFilter(long? FilterId = null)
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
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

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, string parentId, string searchQuery = null, [Bind(Prefix = "DataFilter")] FilterModel filter = null, long? FilterId = null)
	{
		Guid guid = InterfaceActivator.UID<IProduct>();
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(guid);
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		IEntityMetadata entityMetadata = metadata as IEntityMetadata;
		filter = filter ?? CreateFilter(metadata.Uid, FilterId);
		GridResult gridResult = Grid(command, guid, typeByUid, metadata, entityMetadata, parentId, searchQuery, filter.Filter, null, showOnlyGroups: false, "", null, null, filter.Entity);
		if (gridResult == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		DynamicGrid grid = gridResult.GridData;
		int filterId = 0;
		if (entityMetadata != null && entityMetadata.Hierarchical)
		{
			GridColumn gridColumn = new GridColumn
			{
				ValueType = typeof(string),
				Name = null,
				Header = "",
				Sortable = false,
				UniqueName = "folderColumn" + guid,
				Width = ((gridResult.GridTableView == null || gridResult.GridTableView.Resizeable) ? "48px" : "1%")
			};
			Func<object, string> func2 = (Func<object, string>)(gridColumn.Template = (Func<object, string>)((dynamic entity) => FolderCellTemplate(entity, gridResult.ParentId, filterId)));
			grid.Columns.Add(gridColumn);
		}
		((List<GridColumn>)grid.Columns).AddRange(GridBuilderExtensions.GetDefaultColumns(typeByUid, metadata, grid.State));
		PropertyMetadata titleProperty = metadata.GetTitleProperty();
		GridColumn gridColumn2 = ((titleProperty != null) ? grid.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == titleProperty.Uid.ToString()) : null);
		if (gridColumn2 != null)
		{
			gridColumn2.Template = (dynamic entity) => TitleCellTemplate(entity, titleProperty.Uid, gridResult.ParentId, metadata, filterId);
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
		Guid uidCatalog = Guid.Empty;
		if (metadata is EntityMetadata)
		{
			uidCatalog = ((EntityMetadata)metadata).ImplementationUid;
		}
		else
		{
			uidCatalog = metadata.Uid;
		}
		Func<object, string> func4 = (Func<object, string>)(gridColumn3.Template = (Func<object, string>)((dynamic entity) => ActionsCellTemplate(entity, parentId, uidCatalog)));
		grid.Columns.Add(gridColumn3);
		ICatalogProfile target = CatalogManager.Instance.LoadByCatalog(uidCatalog);
		grid.ExportExcel = base.SecurityService.HasPermission(PermissionProvider.CatalogExportPermission, target);
		grid.UniqueName = "ProductGridId";
		return ExportExcel(grid.GridData, typeByUid, () => (ActionResult)(object)((Controller)this).PartialView("Templates/DynamicGrid", (object)grid));
	}

	private string FolderCellTemplate(IEntity entity, object parentId, long? FilterId = null)
	{
		object parentId2;
		if (entity == null)
		{
			parentId2 = parentId;
		}
		else
		{
			if (!((IProduct)entity).IsGroup)
			{
				return string.Empty;
			}
			parentId2 = entity.GetId();
		}
		return GetHtmlHelper().ImageButton("#folder.svg").Url(GenerateViewUrl(parentId2, FilterId)).Attributes(new
		{
			tooltiptext = SR.T("Перейти в группу")
		})
			.ToHtmlString();
	}

	private string TitleCellTemplate(IEntity entity, Guid titlePropertyUid, object parentId, ClassMetadata metadata, long? FilterId = null)
	{
		if (entity == null)
		{
			return string.Format("<a href=\"{0}\" onclick=\"{2}\">{1}</a>", GenerateViewUrl(parentId, FilterId), HttpUtility.HtmlEncode(SR.T("...\\(на уровень выше)")), "");
		}
		bool num = metadata is IEntityMetadata entityMetadata && entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && (bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
		object propertyValue = entity.GetPropertyValue(titlePropertyUid);
		propertyValue = HttpUtility.HtmlEncode(propertyValue ?? string.Empty);
		if (!num)
		{
			return string.Format("<a href=\"javascript: {1}\">{0}</a>", propertyValue, $"showProductInfo({entity.GetId()})");
		}
		return string.Format("<a href=\"{0}\" onclick=\"{2}\">{1}</a>", GenerateViewUrl(entity.GetId(), FilterId), propertyValue, "");
	}

	private string GenerateViewUrl(object parentId, long? FilterId = null)
	{
		return ((Controller)this).get_Url().Action("Index", "Product", (object)new
		{
			area = "EleWise.ELMA.CRM.Web",
			parentId = parentId,
			FilterId = FilterId
		});
	}

	private string ActionsCellTemplate(IEntity entity, string parentId, Guid ImplementationUid)
	{
		List<string> list = new List<string>();
		IEnumerable<ISystemCatalogChecker> extensionPoints = ComponentManager.Current.GetExtensionPoints<ISystemCatalogChecker>();
		if (entity == null || extensionPoints.Any((ISystemCatalogChecker point) => point.CantDelete(entity)))
		{
			return string.Empty;
		}
		object id = entity.GetId();
		HtmlHelper htmlHelper = GetHtmlHelper();
		string item = htmlHelper.ImageButton("#edit.svg").Attributes(new
		{
			tooltiptext = SR.T("Редактировать запись")
		}).Click(string.Format("editProduct({0}, {1})", id, (!string.IsNullOrEmpty(parentId)) ? parentId : "null"))
			.ToHtmlString();
		string item2 = htmlHelper.ImageButton("#remove.svg").Attributes(new
		{
			tooltiptext = SR.T("Удалить запись")
		}).Click(string.Format("jConfirm('{1}', '{2}', function (r) {{if (r == true) {{deleteProduct('{0}')}}}});", id, SR.T("Удалить запись?"), SR.T("Удаление")))
			.ToHtmlString();
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(ImplementationUid);
		if (catalogProfile == null)
		{
			throw new ArgumentNullException("CatalogProfile is null");
		}
		if (base.SecurityService.HasPermission(PermissionProvider.CatalogEditPermission, catalogProfile))
		{
			list.Add(item);
		}
		if (base.SecurityService.HasPermission(PermissionProvider.CatalogDeletePermission, catalogProfile) && !ComponentManager.Current.GetExtensionPoints<ICatalogViewHandler>().Any((ICatalogViewHandler e) => !e.CanDelete(entity)))
		{
			list.Add(item2);
		}
		return string.Join("&nbsp;&nbsp;", list);
	}

	public JsonResult GetProducts(string text = "")
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		IEntityManager<IProduct> instance = EntityManager<IProduct>.Instance;
		InstanceOf<IProductFilter> instanceOf = new InstanceOf<IProductFilter>();
		instanceOf.New.IsGroup = false;
		var data = (from u in instance.Find(instanceOf.New, new FetchOptions(0, 100))
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

	[Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
	public ActionResult Edit(long? id = null, string parentId = null)
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		string text = ProductRedirect(((Controller)this).get_Url(), id.HasValue ? "Create" : "Edit", id.ToString(), parentId);
		if (text != null)
		{
			return (ActionResult)(object)((Controller)this).Redirect(text);
		}
		ProductViewModel productViewModel = (id.HasValue ? new ProductViewModel(AbstractNHEntityManager<IProduct, long>.Instance.Load(id.Value)) : InterfaceActivator.Create<ProductViewModel>());
		if (productViewModel.Entity.IsNew() && !string.IsNullOrEmpty(parentId))
		{
			productViewModel.Entity.Parent = AbstractNHEntityManager<IProduct, long>.Instance.Load(Convert.ToInt64(parentId));
		}
		return (ActionResult)(object)((Controller)this).View("Edit", (object)productViewModel);
	}

	[HttpPost]
	[Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
	public ActionResult Edit(ProductViewModel model)
	{
		if (model.Entity.Parent == model)
		{
			base.Notifier.Error(SR.T("Нельзя указывать в качестве родительского продукта самого себя"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
			{
				parentId = ((model.Entity.Parent != null) ? new long?(model.Entity.Parent.Id) : null)
			});
		}
		try
		{
			if (model.Entity.IsGroup)
			{
				model.Entity.Price = null;
			}
			model.Entity.Save();
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Ошибка сохранения записи"));
			base.Logger.Error(SR.T("Ошибка сохранения продукта"), exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
		{
			parentId = ((model.Entity.Parent != null) ? new long?(model.Entity.Parent.Id) : null)
		});
	}

	[HttpGet]
	public ActionResult Details(long id)
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		ProductViewModel productViewModel = new ProductViewModel(AbstractNHEntityManager<IProduct, long>.Instance.Load(id));
		string text = ProductRedirect(((Controller)this).get_Url(), "Details", id.ToString(), null, productViewModel);
		if (text != null)
		{
			return (ActionResult)(object)((Controller)this).Redirect(text);
		}
		return (ActionResult)(object)((Controller)this).View("Details", (object)productViewModel);
	}

	[HttpPost]
	[Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
	public ActionResult Delete(long id)
	{
		try
		{
			AbstractNHEntityManager<IProduct, long>.Instance.Load(id).Delete();
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				gridId = "ProductGridId"
			});
		}
		catch (Exception ex)
		{
			base.Logger.Error(SR.T("Ошибка удаления продукта (id={0})", id), ex);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			});
		}
	}

	[EntityForm("Create", "EleWise.ELMA.CRM.Web")]
	[Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
	public ActionResult CreatePopup([ParameterContainer] IProduct product, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = null)
	{
		ProductViewModel productViewModel = new ProductViewModel(product, (!viewType.HasValue) ? ViewType.Create : viewType.Value)
		{
			FormUid = formUid
		};
		return (ActionResult)(object)((Controller)this).PartialView("EditorFields", (object)productViewModel);
	}

	[HttpPost]
	[Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
	public ActionResult Create(ProductViewModel model)
	{
		try
		{
			if (model.Entity.IsGroup)
			{
				model.Entity.Price = null;
			}
			model.Entity.Save();
			if (IsCustomViewRequest())
			{
				return HandleCustomViewJsonCallback(model.Entity);
			}
			return CreatorJson(model.Entity);
		}
		catch (Exception ex)
		{
			return CreatorJson(null, ex.Message);
		}
	}

	[AsyncViewItemAction]
	public ActionResult AsyncViewItem(Guid viewItemUid, long id, ViewType viewType, Guid? formUid)
	{
		ProductViewModel productViewModel = new ProductViewModel(AbstractNHEntityManager<IProduct, long>.Instance.LoadOrCreate(id), viewType);
		productViewModel.FormUid = formUid;
		return AsyncViewItemView(productViewModel.View, viewType, viewItemUid, productViewModel, (ProductViewModel m) => m.Entity);
	}

	public static string ProductRedirect(UrlHelper urlHelper, string action, string id = null, string parentId = null, ProductViewModel product = null)
	{
		Guid uid = new Guid("845380fd-8f1f-4619-b8eb-b25357966f59");
		if (!DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Details.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/DetailsForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Edit.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/EditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Index.cshtml"))
		{
			switch (action)
			{
			case "Index":
				return urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = uid,
					parentId = parentId
				});
			case "Create":
				return urlHelper.Action("Add", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = uid,
					id = product.Entity.Id.ToString(),
					parentId = parentId
				});
			case "Edit":
				return urlHelper.Action("Edit", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = uid,
					id = product.Entity.Id.ToString(),
					parentId = parentId
				});
			case "Details":
				return urlHelper.Action("ViewItem", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = uid,
					id = product.Entity.Id.ToString()
				});
			}
		}
		return null;
	}
}
