// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.SaleController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.CRM.Web.Portlets;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [AllPermissions(new string[] { "{46401803-1B46-4E60-8DA0-227FF8CF60F3}", "{96144EE1-1A52-45C4-9AE7-4FF1AD6A03E8}" })]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class SaleController : FilterTreeBaseController<ISale, long>
    {
        public IUnionComplexCacheService ComplexCacheService { get; set; }

        [ContentItem(Name = "SR.M('Сделки')", Image24 = "#sale.svg")]
        [FilterMenuItem(Id = "crm-salies", Type = typeof(ISale), FilterEditAction = "EditFilters")]
        public ActionResult Index(long? FilterId = null) => this.BaseIndex(FilterId, nameof(FilterId), nameof(Index), new Guid?()) ?? View((object)this.CreateGridData((GridCommand)null, this.CreateFilter(FilterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter")));

        public ActionResult Search(long? FilterId = null)
        {
            if (base.Request.QueryString.Count == 0)
            {
                return RedirectToAction("Index");
            }
            FilterModel filter = CreateFilter(FilterId);
            GridDataFilter<ISale> model = CreateGridData(null, filter);
            return View("Index", model);
        }

        [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
        [Permission("{F7D14102-3444-458C-A0B7-7C067D07BDF8}")]
        public ActionResult CreatePopup(
          [ParameterContainer] ISale sale,
          Guid? formUid = null,
          EleWise.ELMA.Model.Views.ViewType? viewType = null,
          bool formReadOnly = false,
          string parentFormId = "",
          string formId = "")
        {
            SaleModel saleModel = new SaleModel(sale, viewType.HasValue ? viewType.Value : EleWise.ELMA.Model.Views.ViewType.Create);
            saleModel.FormUid = formUid;
            saleModel.FormReadOnly = formReadOnly;
            saleModel.FormId = formId;
            SaleModel model = saleModel;
            model.DynamicFormSettings.ParentFormId = parentFormId;
            DynamicFormSettings dynamicFormSettings = model.DynamicFormSettings;
            dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + (object)model.View.Uid;
            return PartialView("Sale/SaleEditForm", (object)model);
        }

        [SaleCreate]
        [Permission("{F7D14102-3444-458C-A0B7-7C067D07BDF8}")]
        [ContentItem(Name = "SR.M('Создать сделку')", Image24 = "#sale.svg")]
        public ActionResult Create(long? contractorId)
        {
            SaleModel model = new SaleModel();
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            if (model.LockEditPermission)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Sale");
            }
            if (contractorId.HasValue)
            {
                long? nullable = contractorId;
                long num = 0;
                if (nullable.GetValueOrDefault() > num & nullable.HasValue)
                {
                    IContractor contractor = ContractorManager.Instance.LoadOrNull(contractorId.Value);
                    model.Entity.Contractor = contractor;
                    model.ContractorReadOnly = true;
                }
            }
            return View((object)model);
        }

        [HttpPost]
        [Permission("{F7D14102-3444-458C-A0B7-7C067D07BDF8}")]
        public ActionResult Create(SaleModel model)
        {
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            if (model.LockEditPermission)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Sale");
            }
            model.Entity.Save();
            string str = ((Controller)this).Url.Entity((IEntity)model.Entity);
            // ISSUE: explicit non-virtual call
            Notifier.Information(MvcHtmlString.Create(EleWise.ELMA.SR.T("Сделка <a href='{1}'>\"{0}\"</a> сохранена успешно", (object)model.Entity.Name.HtmlEncode(), (object)str)));
            if (IsCustomViewRequest())
                return HandleCustomViewJsonCallback((IEntity)model.Entity);
            return ((BaseController)this).IsCreatorRequest() ? ((BaseController)this).CreatorJson((IEntity)model.Entity) : RedirectToAction("Details", "Sale", (object)new
            {
                id = model.Entity.Id
            });
        }

        [DetailsAction]
        [EntityLink]
        public ActionResult Details(long id, int? tabIndex = null)
        {
            try
            {
                if (tabIndex.HasValue)
                {
                    if (DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/Sale/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Sale/TasksTab.cshtml"))
                        ((ControllerBase)this).ViewData["SelectedTab"] = (object)tabIndex.Value;
                }

                ISale sale = base.Manager.Load(id);
                ThrowExceptionIfDeleted((ISoftDeletable)sale);
                SaleModel model = new SaleModel(sale, EleWise.ELMA.Model.Views.ViewType.Display);
                if (sale.IsDeleted)
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Error(EleWise.ELMA.SR.T("Сделка с идентификатором {0} была удалена", (object)id));
                    return RedirectToAction("Index", "Sale");
                }
                model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
                ((BaseController)this).SetAsReadForFeed((IEntity)sale);
                return View((object)model);
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "Sale");
            }
        }

        [AsyncViewItemAction]
        public ActionResult AsyncViewItem(Guid viewItemUid, long id, EleWise.ELMA.Model.Views.ViewType viewType, Guid? formUid)
        {
            // ISSUE: explicit non-virtual call
            SaleModel originalModel = new SaleModel(base.Manager.LoadOrCreate(id), viewType);
            originalModel.FormUid = formUid;
            return AsyncViewItemView<SaleModel>(originalModel.View, viewType, viewItemUid, originalModel, (Expression<Func<SaleModel, object>>)(m => m.Entity));
        }

        [Permission]
        public ActionResult Edit([InstancePermission(typeof(ISale), "{AF2CEF4B-F639-49B4-BD88-363F20BD5A74}")] long id)
        {
            try
            {
                ISale sale = base.Manager.Load(id);
                SaleModel model = new SaleModel(sale, EleWise.ELMA.Model.Views.ViewType.Edit);
                ThrowExceptionIfDeleted((ISoftDeletable)sale);
                model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
                if (model.LockEditPermission)
                {
                    return RedirectToAction("Details", new { id });
                }
                return View(model);
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "Sale");
            }
        }

        [HttpPost]
        [Permission]
        public ActionResult Edit([InstancePermission("{AF2CEF4B-F639-49B4-BD88-363F20BD5A74}")] SaleModel model)
        {
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            if (model.LockEditPermission)
                return RedirectToAction("Details", (object)new
                {
                    Id = model.Entity.Id
                });
            model.Entity.Save();
            string str = ((Controller)this).Url.Entity((IEntity)model.Entity);
            // ISSUE: explicit non-virtual call
            Notifier.Information(MvcHtmlString.Create(EleWise.ELMA.SR.T("Сделка <a href='{1}'>\"{0}\"</a> сохранена успешно", (object)model.Entity.Name.HtmlEncode(), (object)str)));
            return RedirectToAction("Details", "Sale", (object)new
            {
                id = model.Entity.Id
            });
        }

        [HttpGet]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult Delete(long id)
        {
            try
            {
                ISale sale = base.Manager.Load(id);
                base.Manager.Delete(sale);
                Notifier.Information(EleWise.ELMA.SR.T("Сделка \"{0}\" удалена", (object)sale.Name));
                return RedirectToAction("Index", "Sale", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "Sale", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
        }

        [HttpPost]
        [TransactionAction]
        public ActionResult ChangeStatus(SaleChangeStatusModel model)
        {
            ISale sale = SaleManager.Instance.Load(model.EntityId);
            if (model.Status == sale.SaleStatus && model.ShortStatus == sale.ShortStatus)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Сделка уже имеет данный статус"));
                return Redirect(model.RedirectUrl);
            }
            ComponentManager.Current.GetExtensionPoints<IActionWebHandler>().ToList<IActionWebHandler>().ForEach((Action<IActionWebHandler>)(p => p.Process((IBaseController)this, nameof(ChangeStatus), ((ControllerBase)this).ValueProvider, (object)model)));
            if (!model.Break)
            {
                sale.ShortStatus = model.ShortStatus;
                SaleManager.Instance.ChangeStatus(sale, model.Status, model.Comment);
            }
            return Redirect(model.RedirectUrl);
        }

        [HttpPost]
        public ActionResult ChangeStage(SaleChangeStageModel model)
        {
            ISale sale = SaleManager.Instance.Load(model.EntityId);
            if (model.Stage == sale.SaleStage)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Information("Сделка уже находится на данной стадии");
                return Redirect(model.RedirectUrl);
            }
            ComponentManager.Current.GetExtensionPoints<IActionWebHandler>().ToList<IActionWebHandler>().ForEach((Action<IActionWebHandler>)(p => p.Process((IBaseController)this, nameof(ChangeStage), ((ControllerBase)this).ValueProvider, (object)model)));
            if (!model.Break)
            {
                sale.ShortStatus = model.ShortStatus;
                SaleManager.Instance.ChangeStage(sale, model.Stage, model.Comment);
            }
            return Redirect(model.RedirectUrl);
        }

        [CustomGridAction]
        [Permission("{96144EE1-1A52-45C4-9AE7-4FF1AD6A03E8}")]
        public ActionResult SalesOfContractor(GridCommand command, long contractorId)
        {
            IContractor contractor = ContractorManager.Instance.Load(contractorId);
            ISaleFilter filter = InterfaceActivator.Create<ISaleFilter>();
            filter.Contractors.Add(contractor);
            return PartialView("SalesOfContractorGrid", base.Manager.CreateGridData<ISale, ISaleFilter>(command, filter));
        }

        public ActionResult Products(long saleId)
        {
            ISale sale = SaleManager.Instance.Load(saleId);
            ISaleProductFilter filter = InterfaceActivator.Create<ISaleProductFilter>();
            filter.Sale = sale;
            SaleProductsModel model = new SaleProductsModel(EleWise.ELMA.Model.Views.ViewType.Display)
            {
                GridData = EntityManager<ISaleProduct>.Instance.CreateGridData<ISaleProduct, ISaleProductFilter>((GridCommand)null, filter),
                Sale = sale,
                ReadOnly = sale.SaleClosed()
            };
            if (!model.ReadOnly)
            {
                ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
                model.ReadOnly = !serviceNotNull.HasPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, (object)model.Sale) && !serviceNotNull.HasPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, (object)model.Sale);
            }
            return PartialView("SaleProducts/Products", (object)model);
        }

        [CustomGridAction]
        public ActionResult ProductsGrid(GridCommand command, long saleId)
        {
            ISale sale = SaleManager.Instance.Load(saleId);
            ISaleProductFilter filter = InterfaceActivator.Create<ISaleProductFilter>();
            filter.Sale = sale;
            GridData<ISaleProduct, ISaleProductFilter> gridData = EntityManager<ISaleProduct>.Instance.CreateGridData<ISaleProduct, ISaleProductFilter>(command, filter);
            ((ControllerBase)this).ViewData["ReadOnly"] = (object)sale.SaleClosed();
            return PartialView("SaleProducts/Grid", (object)gridData);
        }

        public ActionResult DeleteProduct(long productLinkId)
        {
            ISaleProduct saleProduct = EntityManager<ISaleProduct>.Instance.Load((object)productLinkId);
            long id = saleProduct.Sale.Id;
            saleProduct.Delete();
            return this.ProductsGrid((GridCommand)null, id);
        }

        public ActionResult CreateProduct(long saleId)
        {
            ISale sale = SaleManager.Instance.Load(saleId);
            SaleProductsModel model = new SaleProductsModel(EleWise.ELMA.Model.Views.ViewType.Create);
            model.Entity.Sale = sale;
            return PartialView("SaleProducts/EditProduct", (object)model);
        }

        [HttpPost]
        public ActionResult AddProduct(SaleProductsModel model)
        {
            model.Entity.Save();
            return ((BaseController)this).SuccessJson();
        }

        public ActionResult EditProduct(ISaleProduct productLink)
        {
            SaleProductsModel model = new SaleProductsModel(EleWise.ELMA.Model.Views.ViewType.Edit);
            model.Entity = productLink;
            return PartialView("SaleProducts/EditProduct", (object)model);
        }

        [HttpPost]
        public ActionResult SaveEditedProduct(SaleProductsModel productLink)
        {
            productLink.Entity.Save();
            return ((BaseController)this).SuccessJson();
        }

        protected virtual string GridIdPrefix => "Sales";

        protected virtual bool EnableEqlQuery => true;

        [HttpPost]
        public ActionResult SummaryTable([Bind(Prefix = "DataFilter")] FilterModel filter = null) => PartialView((object)SaleManager.Instance.SalesVolumeByCurrency(filter?.Filter).Select<KeyValuePair<string, double>, SalesVolumesInfo>((Func<KeyValuePair<string, double>, SalesVolumesInfo>)(x => new SalesVolumesInfo()
        {
            Currency = x.Key,
            Volume = x.Value
        })));

        [HttpGet]
        public ActionResult SalePortlet(SalePortletPersonalization settings) => PartialView((object)new SalePortletModel()
        {
            FilterId = (settings.Filter != null ? new long?(settings.Filter.Id) : new long?()),
            ShowOnlyMy = settings.ShowOnlyMy
        });

        [CustomGridAction]
        public ActionResult PortletGrid(GridCommand command, long? filterId, bool showOnlyMy)
        {
            FilterModel filter = this.CreateFilter(filterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter");
            ((ISaleFilter)filter.Filter).ShowOnlyMy = showOnlyMy;
            return PartialView((object)this.CreateGridData(command, filter));
        }

        private ActionResult SelectPermission(ISale instance)
        {
            ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
            bool flag = serviceNotNull.HasPermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, (object)instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, (object)instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
            Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
            Dictionary<Guid, Guid> informsOne = new Dictionary<Guid, Guid>();
            CRMPermissionModel model = new CRMPermissionModel();
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            model.Id = instance.Id;
            model.AdditionalPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)instance, InterfaceActivator.TypeOf<ISale>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h =>
         {
             if ((!(h is ISalePersonPermission) || ((ISalePersonPermission)h).Sale != instance ? 0 : (!((ISalePersonPermission)h).InheritedFromNumber.HasValue ? 1 : 0)) == 0)
                 return false;
             if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
             {
                 if (participantWorkOne.ContainsKey(h.PermissionId))
                     return false;
                 participantWorkOne.Add(h.PermissionId, h.PermissionId);
                 return true;
             }
             if (!(h.TypeRoleId == CommonRoleTypes.Informs.Id))
                 return true;
             if (informsOne.ContainsKey(h.PermissionId))
                 return false;
             informsOne.Add(h.PermissionId, h.PermissionId);
             return true;
         }), true, (string)null);
            if (model.LockEditPermission)
                model.AdditionalPermissionsModel.Edit = false;
            model.AdditionalPermissionsModel.Instance = (object)instance;
            ((Action<EntityPermissionRoleTypeSelectorModel>)(m => m.Routes = new RouteValueDictionary((object)new
            {
                action = "PermissionSettings",
                controller = "Sale",
                area = "EleWise.ELMA.CRM.Web"
            })))(model.AdditionalPermissionsModel);
            model.InheritAvailable = true;
            participantWorkOne = new Dictionary<Guid, Guid>();
            informsOne = new Dictionary<Guid, Guid>();
            model.InheritPermissions = instance.InheritPermissions;
            model.InheritPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)instance, InterfaceActivator.TypeOf<ISale>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h =>
         {
             if ((!(h is ISalePersonPermission) || ((ISalePersonPermission)h).Sale != instance ? 0 : (((ISalePersonPermission)h).InheritedFromNumber.HasValue ? 1 : 0)) == 0)
                 return false;
             if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
             {
                 if (participantWorkOne.ContainsKey(h.PermissionId))
                     return false;
                 participantWorkOne.Add(h.PermissionId, h.PermissionId);
                 return true;
             }
             if (!(h.TypeRoleId == CommonRoleTypes.Informs.Id))
                 return true;
             if (informsOne.ContainsKey(h.PermissionId))
                 return false;
             informsOne.Add(h.PermissionId, h.PermissionId);
             return true;
         }), true, (string)null);
            model.InheritPermissionsModel.BindModelName = "InheritPermissions";
            model.InheritPermissionsModel.Instance = (object)instance;
            model.InheritPermissionsModel.Edit = false;
            model.InheritAvailable = flag;
            return PartialView("Sale/SalePermissionSetting", (object)model);
        }

        [HttpPost]
        public ActionResult EnableInheritPermission(ISale instance, bool enable)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    Id = instance.Id
                });
            SaleManager.Instance.EnableInheritPermissions(instance, enable);
            return this.SelectPermission(instance);
        }

        public ActionResult GetPermissionSettings(ISale instance) => this.PermissionSettings(instance);

        [HttpPost]
        [TransactionAction]
        public ActionResult PermissionSettings(long id, EditableListModel access)
        {
            ISale instance = SaleManager.Instance.Load(id);
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    Id = instance.Id
                });
            if (access != null)
                this.PermissionsModelService.BindPermissionsFromModel((object)instance, access, (Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>>)((holders, newHolders) =>
              {
                  List<IInstanceSettingsPermissionHolder> permissionHolderList = new List<IInstanceSettingsPermissionHolder>();
                  if (instance.InheritPermissions)
                  {
                      permissionHolderList.AddRange(holders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(h => ((ISalePersonPermission)h).InheritedFromNumber.HasValue)));
                      foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                          holders.Remove(permissionHolder);
                  }
                  holders.SyncFrom<IInstanceSettingsPermissionHolder>(newHolders, (Func<IInstanceSettingsPermissionHolder, IInstanceSettingsPermissionHolder, bool>)((v1, v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned)), onRemove: ((Action<IInstanceSettingsPermissionHolder>)(v =>
        {
                    if (!(v is IEntity))
                        return;
                    ((IEntity)v).Delete();
                })));
                  if (!instance.InheritPermissions)
                      return;
                  foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                      holders.Add(permissionHolder);
              }));
            return Redirect(((Controller)this).Url.ReturnUrl());
        }

        public ActionResult PermissionSettings(ISale instance) => this.SelectPermission(instance);
    }
}
