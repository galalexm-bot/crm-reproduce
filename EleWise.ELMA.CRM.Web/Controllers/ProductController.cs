// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.ProductController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class ProductController : EntityBaseController
    {
        private const string CATALOGS_MENU = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root";
        private const string ProductGridId = "ProductGridId";

        public PermissionsModelService PermissionsModelService { get; set; }

        [FilterMenuItem(Id = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root", Type = typeof(IProduct), FilterEditAction = "EditFilters")]
        public ActionResult Index(string parentId = null, long? FilterId = null)
        {
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            string url1 = ProductController.ProductRedirect(((Controller)this).Url, nameof(Index), parentId: parentId);
            if (url1 != null)
                return Redirect(url1);
            if (!FilterId.HasValue)
            {
                IFilter defaultFilter = FilterDefaultManager.Instance.LoadDefaultFilter(InterfaceActivator.UID<IProduct>()).CastAsRealType<IFilter>();
                if (defaultFilter == null)
                    return RedirectToAction(nameof(Index), (object)new
                    {
                        parentId = parentId,
                        FilterId = 0
                    });
                IFilterMenuProviderExtension providerExtension = ComponentManager.Current.GetExtensionPoints<IFilterMenuProviderExtension>().FirstOrDefault<IFilterMenuProviderExtension>((Func<IFilterMenuProviderExtension, bool>)(p => p.SupportedFilter((IFilterFolder)defaultFilter)));
                string url2 = (string)null;
                string str1 = "";
                string str2 = "";
                bool flag;
                providerExtension?.GetTreeNodeParameters((IFilterFolder)defaultFilter, new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext), false, false, out str1, out str2, out url2, out flag, new ActionRoute(nameof(Index), "Product", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web",
                    parentId = parentId
                }), nameof(FilterId), (string)null);
                return Redirect(url2);
            }
            long? nullable = FilterId;
            long num = 0;
            if (!(nullable.GetValueOrDefault() == num & nullable.HasValue) && parentId != null)
                return RedirectToAction(nameof(Index), (object)new
                {
                    FilterId = FilterId
                });
            HttpContextAccessor.CurrentContext.Items.Add((object)"filterAdditionalRouteParameters", (object)new
            {
                parentId = parentId
            });
            return View((object)new ProductViewModel()
            {
                Filter = this.CreateFilter(InterfaceActivator.UID<IProduct>(), FilterId),
                CurrentFolderObject = (parentId != null ? AbstractNHEntityManager<IProduct, long>.Instance.Load(long.Parse(parentId)) : (IProduct)null),
                GridId = "ProductGridId"
            });
        }

        protected virtual FilterModel CreateFilter(Guid typeUid, long? FilterId = null)
        {
            long? nullable = FilterId;
            long num = 0;
            return new FilterModel(nullable.GetValueOrDefault() > num & nullable.HasValue ? (IFilterBase)AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value) : (IFilterBase)InterfaceActivator.Create<IFilter>(), typeUid, new Guid?(), new Guid?(), "Filter", (IEntityFilter)null, new Guid?(), false, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, (string)null, (string)null, (Type)null);
        }

        public virtual ActionResult EditFilters()
        {
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            Guid guid = InterfaceActivator.UID<IProduct>();
            HttpContextAccessor.CurrentContext.Items.Add((object)"showFiltersTreeForType", (object)guid);
            return View("Filter/FilterTree", (object)this.FilterMenuProvider.TreeMenuNodesForEdit(guid, new Guid?(), false, false, true));
        }

        [HttpGet]
        public virtual ActionResult EditFilter(long? FilterId = null)
        {
            ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
            if (!FilterId.HasValue)
                return View("Index");
            IFilter filter = AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value);
            HttpContextAccessor.CurrentContext.Items.Add((object)"showFiltersTreeForType", (object)filter.ObjectsType.TypeUid);
            return View("Filter/Edit", (object)new FilterModel((IFilterBase)filter, filter.ObjectsType.TypeUid, new Guid?(), new Guid?(), "Filter", (IEntityFilter)null, new Guid?(), false, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, (string)null, (string)null, (Type)null)
            {
                ShowAllFields = true
            });
        }

        [HttpPost]
        public virtual ActionResult EditFilter(FilterModel model, EditableListModel access)
        {
            if (model.GridState != null)
                model.GridState.DateState = DateTime.Now;
            ((EntityModel<IFilterBase>)model).Entity.GridState = model.GridState != null ? ClassSerializationHelper.SerializeObject((object)model.GridState) : (byte[])null;
            ((EntityModel<IFilterBase>)model).Entity.FilterFields = UniversalFilterSaver.Pack(model.Filter);
            ((EntityModel<IFilterBase>)model).Entity.SearchFields = (object)model.FilterColumnsSelected.Select<SelectListItem, SearchFieldsData>((Func<SelectListItem, SearchFieldsData>)(fc => new SearchFieldsData(fc.Value))).ToList<SearchFieldsData>();
            if (access != null && ((ListModelBase<EditableListItem>)(object)access).Items != null)
            {
                PermissionsModelService.BindPermissionsFromModel((object)((EntityModel<IFilterBase>)(object)model).Entity, access, (Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>>)delegate (ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
                {
                    new List<IInstanceSettingsPermissionHolder>();
                    CollectionExtensions.SyncFrom<IInstanceSettingsPermissionHolder>(holders, newHolders, (Func<IInstanceSettingsPermissionHolder, IInstanceSettingsPermissionHolder, bool>)((IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned)), (Func<IInstanceSettingsPermissionHolder, bool>)null, (Action<IInstanceSettingsPermissionHolder>)delegate (IInstanceSettingsPermissionHolder v)
                    {
                        if (v is IEntity)
                        {
                            ((IEntity)v).Delete();
                        }
                    });
                });
            }
            ((IEntity)((EntityModel<IFilterBase>)(object)model).Entity).Save();
            if (!string.IsNullOrEmpty(((Controller)this).Request["ReturnUrl"]))
            {
                return Redirect(Url.ReturnUrl());
            }
            return RedirectToAction("EditFilters");
        }

        [CustomGridAction]
        public ActionResult Grid(GridCommand command, string parentId, string searchQuery = null, [Bind(Prefix = "DataFilter")] FilterModel filter = null, long? FilterId = null)
        {
            Guid guid = InterfaceActivator.UID<IProduct>(true);
            Type typeByUid = ((EntityBaseController)this).IMetadataRuntimeService.GetTypeByUid(guid, true);
            ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid, true, true);
            ClassMetadata obj = metadata;
            IEntityMetadata val = (IEntityMetadata)(object)((obj is IEntityMetadata) ? obj : null);
            filter = filter ?? CreateFilter(((AbstractMetadata)metadata).Uid, FilterId);
            GridResult gridResult = this.Grid(command, guid, typeByUid, metadata, val, parentId, searchQuery, filter.Filter, (string)null, false, "", (string)null, (string)null, ((EntityModel<IFilterBase>)filter).Entity);
            if (gridResult == null)
            {
                return HttpNotFound();
            }
            DynamicGrid grid = gridResult.GridData;
            int filterId = 0;
            if (val != null && val.Hierarchical)
            {
                GridColumn val2 = new GridColumn();
                val2.ValueType = typeof(string);
                val2.Name = (string)null;
                val2.Header = (object)"";
                val2.Sortable = false;
                val2.UniqueName = "folderColumn" + guid;
                val2.Width = (gridResult.GridTableView == null || gridResult.GridTableView.Resizeable) ? "48px" : "1%";
                GridColumn val3 = val2;
                Func<object, string> template = (dynamic entity) => FolderCellTemplate(entity, gridResult.ParentId, filterId);
                val3.Template = (Func<object, object>)template;
                ((Grid)grid).Columns.Add(val3);
            }
            ((List<GridColumn>)((Grid)grid).Columns).AddRange(GridBuilderExtensions.GetDefaultColumns(typeByUid, metadata, grid.State, false, (IEnumerable<Guid>)null));
            PropertyMetadata titleProperty = ClassMetadataExtensions.GetTitleProperty(metadata);
            GridColumn val4 = ((titleProperty != null) ? ((Grid)grid).Columns.FirstOrDefault((GridColumn c) => c.UniqueName == ((AbstractMetadata)titleProperty).Uid.ToString()) : null);
            if (val4 != null)
            {
                val4.Template = (Func<object, object>)((dynamic entity) => TitleCellTemplate(entity, ((AbstractMetadata)titleProperty).Uid, gridResult.ParentId, metadata, filterId));
            }
            GridColumn val5 = new GridColumn();
            val5.ValueType = typeof(string);
            val5.Name = (string)null;
            val5.Header = (object)"";
            val5.Sortable = false;
            val5.Order = 2147483646;
            val5.UniqueName = "actionColumn" + guid;
            val5.Width = (gridResult.GridTableView == null || gridResult.GridTableView.Resizeable) ? "96px" : "1%";
            val5.HtmlAttributes = (IDictionary<string, object>)new Dictionary<string, object> { { "style", "white-space:nowrap" } };
            GridColumn val6 = val5;
            Guid uidCatalog = Guid.Empty;
            if (metadata is EntityMetadata)
            {
                uidCatalog = ((EntityMetadata)metadata).ImplementationUid;
            }
            else
            {
                uidCatalog = ((AbstractMetadata)metadata).Uid;
            }
            Func<object, string> template2 = (dynamic entity) => ActionsCellTemplate(entity, parentId, uidCatalog);
            val6.Template = (Func<object, object>)template2;
            ((Grid)grid).Columns.Add(val6);
            ICatalogProfile val7 = CatalogManager.Instance.LoadByCatalog(uidCatalog);
            ((Grid)grid).ExportExcel = ((BaseController)this).SecurityService.HasPermission(PermissionProvider.CatalogExportPermission, (object)val7, false);
            ((Grid)grid).UniqueName = "ProductGridId";
            return ExportExcel(((Grid)grid).GridData, typeByUid, (Func<ActionResult>)(() => PartialView("Templates/DynamicGrid", (object)grid)));
        }

        private string FolderCellTemplate(IEntity entity, object parentId, long? FilterId = null)
    {
        object parentId1;
        if (entity == null)
        {
            parentId1 = parentId;
        }
        else
        {
            if (!((IProduct)entity).IsGroup)
                return string.Empty;
            parentId1 = entity.GetId();
        }
        return GetHtmlHelper().ImageButton("#folder.svg").Url(this.GenerateViewUrl(parentId1, FilterId)).Attributes((object)new
        {
            tooltiptext = EleWise.ELMA.SR.T("Перейти в группу")
        }).ToHtmlString();
    }

    private string TitleCellTemplate(
      IEntity entity,
      Guid titlePropertyUid,
      object parentId,
      ClassMetadata metadata,
      long? FilterId = null)
    {
        if (entity == null)
            return string.Format("<a href=\"{0}\" onclick=\"{2}\">{1}</a>", (object)this.GenerateViewUrl(parentId, FilterId), (object)HttpUtility.HtmlEncode(EleWise.ELMA.SR.T("...\\(на уровень выше)")), (object)"");
        int num = !(metadata is IEntityMetadata entityMetadata) || !entityMetadata.Hierarchical || entityMetadata.HierarchyType != HierarchyType.GroupAndElements || !(entityMetadata.IsGroupPropertyUid != Guid.Empty) ? 0 : ((bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid) ? 1 : 0);
        object obj = (object)HttpUtility.HtmlEncode(entity.GetPropertyValue(titlePropertyUid) ?? (object)string.Empty);
        return num == 0 ? string.Format("<a href=\"javascript: {1}\">{0}</a>", obj, (object)string.Format("showProductInfo({0})", entity.GetId())) : string.Format("<a href=\"{0}\" onclick=\"{2}\">{1}</a>", (object)this.GenerateViewUrl(entity.GetId(), FilterId), obj, (object)"");
    }

    private string GenerateViewUrl(object parentId, long? FilterId = null) => ((Controller)this).Url.Action("Index", "Product", (object)new
    {
        area = "EleWise.ELMA.CRM.Web",
        parentId = parentId,
        FilterId = FilterId
    });

    private string ActionsCellTemplate(IEntity entity, string parentId, Guid ImplementationUid)
    {
        List<string> values = new List<string>();
        IEnumerable<ISystemCatalogChecker> extensionPoints = ComponentManager.Current.GetExtensionPoints<ISystemCatalogChecker>();
        if (entity == null || extensionPoints.Any<ISystemCatalogChecker>((Func<ISystemCatalogChecker, bool>)(point => point.CantDelete((object)entity))))
            return string.Empty;
        object id = entity.GetId();
        HtmlHelper htmlHelper = GetHtmlHelper();
        string htmlString1 = htmlHelper.ImageButton("#edit.svg").Attributes((object)new
        {
            tooltiptext = EleWise.ELMA.SR.T("Редактировать запись")
        }).Click(string.Format("editProduct({0}, {1})", id, !string.IsNullOrEmpty(parentId) ? (object)parentId : (object)"null")).ToHtmlString();
        string htmlString2 = htmlHelper.ImageButton("#remove.svg").Attributes((object)new
        {
            tooltiptext = EleWise.ELMA.SR.T("Удалить запись")
        }).Click(string.Format("jConfirm('{1}', '{2}', function (r) {{if (r == true) {{deleteProduct('{0}')}}}});", id, (object)EleWise.ELMA.SR.T("Удалить запись?"), (object)EleWise.ELMA.SR.T("Удаление"))).ToHtmlString();
        ICatalogProfile target = CatalogManager.Instance.LoadByCatalog(ImplementationUid);
        if (target == null)
            throw new ArgumentNullException("CatalogProfile is null");
        // ISSUE: explicit non-virtual call
        if (((BaseController)this).SecurityService.HasPermission(PermissionProvider.CatalogEditPermission, (object)target))
            values.Add(htmlString1);
        // ISSUE: explicit non-virtual call
        if (((BaseController)this).SecurityService.HasPermission(PermissionProvider.CatalogDeletePermission, (object)target) && !ComponentManager.Current.GetExtensionPoints<ICatalogViewHandler>().Any<ICatalogViewHandler>((Func<ICatalogViewHandler, bool>)(e => !e.CanDelete(entity))))
            values.Add(htmlString2);
        return string.Join("&nbsp;&nbsp;", (IEnumerable<string>)values);
    }

    public JsonResult GetProducts(string text = "")
    {
        IEntityManager<IProduct> instance = EntityManager<IProduct>.Instance;
        InstanceOf<IProductFilter> obj = new InstanceOf<IProductFilter>();
        obj.New.IsGroup = (bool?)false;
        var data = (from u in instance.Find((IEntityFilter)(object)obj.New, new FetchOptions(0, 100))
                    select new
                    {
                        Value = ((IEntity<long>)(object)u).Id.ToString(),
                        Text = u.Name
                    } into i
                    where !string.IsNullOrEmpty(i.Text)
                    orderby i.Text
                    select i).ToArray();
        JsonResult val = new JsonResult();
        val.Data = (object)data;
        return val;
    }

    [Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
    public ActionResult Edit(long? id = null, string parentId = null)
    {
        ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
        string url = ProductController.ProductRedirect(((Controller)this).Url, id.HasValue ? "Create" : nameof(Edit), id.ToString(), parentId);
        if (url != null)
            return Redirect(url);
        ProductViewModel model = id.HasValue ? new ProductViewModel(AbstractNHEntityManager<IProduct, long>.Instance.Load(id.Value)) : InterfaceActivator.Create<ProductViewModel>();
        if (model.Entity.IsNew() && !string.IsNullOrEmpty(parentId))
            model.Entity.Parent = AbstractNHEntityManager<IProduct, long>.Instance.Load(Convert.ToInt64(parentId));
        return View(nameof(Edit), (object)model);
    }

    [HttpPost]
    [Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
    public ActionResult Edit(ProductViewModel model)
    {
        if (model.Entity.Parent == model)
        {
            (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Нельзя указывать в качестве родительского продукта самого себя"));
            return RedirectToAction("Index", (object)new
            {
                parentId = (model.Entity.Parent != null ? new long?(model.Entity.Parent.Id) : new long?())
            });
        }
        try
        {
            if (model.Entity.IsGroup)
                model.Entity.Price = new double?();
            model.Entity.Save();
        }
        catch (Exception ex)
        {
            (((BaseController)this).Notifier).Error(EleWise.ELMA.SR.T("Ошибка сохранения записи"));
            ((BaseController)this).Logger.Error((object)EleWise.ELMA.SR.T("Ошибка сохранения продукта"), ex);
        }
        return RedirectToAction("Index", (object)new
        {
            parentId = (model.Entity.Parent != null ? new long?(model.Entity.Parent.Id) : new long?())
        });
    }

    [HttpGet]
    public ActionResult Details(long id)
    {
        ((Controller)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
        ProductViewModel productViewModel = new ProductViewModel(AbstractNHEntityManager<IProduct, long>.Instance.Load(id));
        string url = ProductController.ProductRedirect(((Controller)this).Url, nameof(Details), id.ToString(), product: productViewModel);
        if (url != null)
        {
            return Redirect(url);
        }
        return View("Details", (object)productViewModel);
    }

    [HttpPost]
    [Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
    public ActionResult Delete(long id)
    {
        try
        {
            AbstractNHEntityManager<IProduct, long>.Instance.Load(id).Delete();
            return Json((object)new
            {
                success = true,
                gridId = "ProductGridId"
            });
        }
        catch (Exception ex)
        {
            ((BaseController)this).Logger.Error((object)EleWise.ELMA.SR.T("Ошибка удаления продукта (id={0})", (object)id), ex);
            return Json((object)new
            {
                success = false,
                error = ex.Message
            });
        }
    }

    [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
    [Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
    public ActionResult CreatePopup(
      [ParameterContainer] IProduct product,
      Guid? formUid = null,
      EleWise.ELMA.Model.Views.ViewType? viewType = null,
      bool formReadOnly = false,
      string parentFormId = null)
    {
        return PartialView("EditorFields", (object)new ProductViewModel(product, viewType.HasValue ? viewType.Value : EleWise.ELMA.Model.Views.ViewType.Create)
        {
            FormUid = formUid
        });
    }

    [HttpPost]
    [Permission("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}")]
    public ActionResult Create(ProductViewModel model)
    {
        try
        {
            if (model.Entity.IsGroup)
                model.Entity.Price = new double?();
            model.Entity.Save();
            return IsCustomViewRequest() ? HandleCustomViewJsonCallback((IEntity)model.Entity) : ((BaseController)this).CreatorJson((IEntity)model.Entity);
        }
        catch (Exception ex)
        {
            return ((BaseController)this).CreatorJson((IEntity)null, ex.Message);
        }
    }

    [AsyncViewItemAction]
    public ActionResult AsyncViewItem(Guid viewItemUid, long id, EleWise.ELMA.Model.Views.ViewType viewType, Guid? formUid)
    {
        ProductViewModel originalModel = new ProductViewModel(AbstractNHEntityManager<IProduct, long>.Instance.LoadOrCreate(id), viewType);
        originalModel.FormUid = formUid;
        return AsyncViewItemView<ProductViewModel>(originalModel.View, viewType, viewItemUid, originalModel, (Expression<Func<ProductViewModel, object>>)(m => m.Entity));
    }

    public static string ProductRedirect(
      UrlHelper urlHelper,
      string action,
      string id = null,
      string parentId = null,
      ProductViewModel product = null)
    {
        Guid guid = new Guid("845380fd-8f1f-4619-b8eb-b25357966f59");
        if (!DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Details.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/DetailsForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Edit.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/EditForm.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Product/Index.cshtml"))
        {
            switch (action)
            {
                case "Index":
                    return urlHelper.Action("View", "Catalogs", (object)new
                    {
                        area = "EleWise.ELMA.BPM.Web.Common",
                        uid = guid,
                        parentId = parentId
                    });
                case "Create":
                    return urlHelper.Action("Add", "Catalogs", (object)new
                    {
                        area = "EleWise.ELMA.BPM.Web.Common",
                        uid = guid,
                        id = product.Entity.Id.ToString(),
                        parentId = parentId
                    });
                case "Edit":
                    return urlHelper.Action("Edit", "Catalogs", (object)new
                    {
                        area = "EleWise.ELMA.BPM.Web.Common",
                        uid = guid,
                        id = product.Entity.Id.ToString(),
                        parentId = parentId
                    });
                case "Details":
                    return urlHelper.Action("ViewItem", "Catalogs", (object)new
                    {
                        area = "EleWise.ELMA.BPM.Web.Common",
                        uid = guid,
                        id = product.Entity.Id.ToString()
                    });
            }
        }
        return (string)null;
    }
}
}
