// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.ContractorIndividualController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.ExtensionPoints;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class ContractorIndividualController : BPMController<IContractorIndividual, long>
    {
        private ICountry defaultCountry = Locator.GetService<CrmSettingsModule>().Settings.DefaultCountry;

        public IUnionComplexCacheService ComplexCacheService { get; set; }

        [NotNull]
        public IEntityActionHandler EntityActionHandler { get; set; }

        [ContractorCreate]
        [Permission("FED901DB-3E4A-4BF0-B3DD-5BD1CC0D7255", typeof(IContractorIndividual))]
        [ContentItem(Name = "SR.M('Создание физического лица')", Image24 = "#add.svg")]
        public ActionResult Create()
        {
            ContractorIndividualModel model = new ContractorIndividualModel();
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            if (model.LockEditPermission)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Contractor", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
            this.InitNewModel(model);
            return View((object)model);
        }

        [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
        [Permission("FED901DB-3E4A-4BF0-B3DD-5BD1CC0D7255", typeof(IContractorIndividual))]
        public ActionResult CreatePopup(
          [ParameterContainer] IContractorIndividual contractor,
          Guid? formUid = null,
          EleWise.ELMA.Model.Views.ViewType? viewType = null,
          bool formReadOnly = false,
          string parentFormId = "",
          string formId = "")
        {
            ContractorIndividualModel contractorIndividualModel = new ContractorIndividualModel(contractor, viewType.HasValue ? viewType.Value : EleWise.ELMA.Model.Views.ViewType.Create);
            contractorIndividualModel.FormUid = formUid;
            contractorIndividualModel.FormReadOnly = formReadOnly;
            contractorIndividualModel.FormId = formId;
            ContractorIndividualModel model = contractorIndividualModel;
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            this.InitNewModel(model, contractor == null);
            model.DynamicFormSettings.ParentFormId = parentFormId;
            DynamicFormSettings dynamicFormSettings = model.DynamicFormSettings;
            dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + (object)model.View.Uid;
            return PartialView("ContractorIndividual/ContractorIndividualEditForm", (object)model);
        }

        [HttpPost]
        [Permission("FED901DB-3E4A-4BF0-B3DD-5BD1CC0D7255", typeof(IContractorIndividual))]
        [TransactionAction]
        public ActionResult Create(ContractorIndividualModel model)
        {
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            if (model.LockEditPermission)
                return RedirectToAction("Details", (object)new
                {
                    Id = model.Entity.Id
                });
            if (!model.Entity.IsNew())
                this.EntityActionHandler.ActionExecuted(new EntityActionEventArgs((IEntity)null, (IEntity)model.Entity, "c7b89bfd-dc8f-440d-82a9-da1ee469afd9"));
            SaveWithCategoryRulesResult categoryRulesResult = model.SaveWithCategoryRules();
            string information = (string)null;
            if (categoryRulesResult.AddedCategories.Count > 0)
            {
                string str;
                if (!((BaseController)this).IsCreatorRequest())
                    str = EleWise.ELMA.SR.T("Физическое лицо <a href=\"{1}\">{0}</a> сохранено успешно", (object)model.Entity.Name.HtmlEncode(), (object)((Controller)this).Url.Entity((IEntity)model.Entity));
                else
                    str = "";
                information = str;
                if (categoryRulesResult.AddedCategories.Count > 0)
                {
                    if (!((BaseController)this).IsCreatorRequest())
                        information = information + "<br/>" + EleWise.ELMA.SR.T("Автоматически добавлены категории: {0}", (object)categoryRulesResult.AddedCategories.Select<ICategory, string>((Func<ICategory, string>)(c => c.Name)).ToSeparatedString<string>(", ")).HtmlEncode();
                    else
                        information = EleWise.ELMA.SR.T("Физическому лицу {0} автоматически добавлены категории: {1}", (object)model.Entity.Name.HtmlEncode(), (object)categoryRulesResult.AddedCategories.Select<ICategory, string>((Func<ICategory, string>)(c => c.Name)).ToSeparatedString<string>(", ").HtmlEncode());
                }
                Notifier.Information(MvcHtmlString.Create(information));
            }
            if (IsCustomViewRequest())
                return (HandleCustomViewJsonCallback((IEntity)model.Entity));

            return ((BaseController)this).IsCreatorRequest() ? ((BaseController)this).CreatorJsonWithInformation((IEntity)model.Entity, information) : RedirectToAction("Details", (object)new
            {
                Id = model.Entity.Id
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
                    if (DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/ContractorIndividual/TabView.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Shared/Contractor/TasksTab.cshtml"))
                        ((ControllerBase)this).ViewData["SelectedTab"] = (object)tabIndex.Value;
                }
                IContractorIndividual contractor = base.Manager.Load(id);
                ThrowExceptionIfDeleted((ISoftDeletable)contractor);
                return View((object)new ContractorIndividualModel(contractor, EleWise.ELMA.Model.Views.ViewType.Display)
                {
                    LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "Contractor");
            }
        }

        [AsyncViewItemAction]
        public ActionResult AsyncViewItem(Guid viewItemUid, long id, EleWise.ELMA.Model.Views.ViewType viewType, Guid? formUid)
        {
            // ISSUE: explicit non-virtual call
            ContractorIndividualModel originalModel = new ContractorIndividualModel(base.Manager.LoadOrCreate(id), viewType);
            originalModel.FormUid = formUid;
            originalModel.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            return AsyncViewItemView<ContractorIndividualModel>(originalModel.View, viewType, viewItemUid, originalModel, (Expression<Func<ContractorIndividualModel, object>>)(m => m.Entity));
        }
        public ActionResult Edit(long id)
        {
            try
            {
                IContractorIndividual contractorIndividual = base.Manager.Load(id);
                ThrowExceptionIfDeleted((ISoftDeletable)contractorIndividual);

                if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditContractorPermission, (object)contractorIndividual))
                    throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для редактирования контрагента \"{0}\" с идентификатором {1}", (object)contractorIndividual.Name, (object)contractorIndividual.Id));
                ContractorIndividualModel model = new ContractorIndividualModel(contractorIndividual, EleWise.ELMA.Model.Views.ViewType.Edit);
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
                return RedirectToAction("Index", "Contractor");
            }
        }

        [HttpPost]
        [TransactionAction]
        public ActionResult Edit(ContractorIndividualModel model)
        {
            try
            {
                model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
                if (model.LockEditPermission)
                    return RedirectToAction("Details", (object)new
                    {
                        Id = model.Entity.Id
                    });
                ContractorIndividualModel contractorIndividualModel = model;
                bool? unassignOldCategories1 = model.UnassignOldCategories;
                bool flag1 = true;
                bool? unassignOldCategories2;
                int num;
                if (!(unassignOldCategories1.GetValueOrDefault() == flag1 & unassignOldCategories1.HasValue))
                {
                    unassignOldCategories2 = model.UnassignOldCategories;
                    bool flag2 = false;
                    num = unassignOldCategories2.GetValueOrDefault() == flag2 & unassignOldCategories2.HasValue ? 2 : 0;
                }
                else
                    num = 1;
                SaveWithCategoryRulesResult categoryRulesResult = contractorIndividualModel.SaveWithCategoryRules((RuleDeletedCategoryAction)num);
                unassignOldCategories2 = model.UnassignOldCategories;
                if (!unassignOldCategories2.HasValue && categoryRulesResult.DeletedCategories.Count > 0)
                {
                    ((BaseController)this).UnitOfWorkManager.RollbackCurrent("");
                    model.CategoriesToDelete = (IEnumerable<ICategory>)categoryRulesResult.DeletedCategories;
                    return View((object)model);
                }
                this.EntityActionHandler.ActionExecuted(new EntityActionEventArgs((IEntity)null, (IEntity)model.Entity, "c7b89bfd-dc8f-440d-82a9-da1ee469afd9"));
                if (categoryRulesResult.AddedCategories.Count > 0 || categoryRulesResult.DeletedCategories.Count > 0)
                {
                    string str = EleWise.ELMA.SR.T("Физическое лицо <a href=\"{1}\">{0}</a> сохранено успешно", (object)model.Entity.Name.HtmlEncode(), (object)((Controller)this).Url.Entity((IEntity)model.Entity));
                    if (categoryRulesResult.AddedCategories.Count > 0)
                        str = str + "<br/> " + EleWise.ELMA.SR.T("Автоматически добавлены категории: {0}", (object)categoryRulesResult.AddedCategories.Select<ICategory, string>((Func<ICategory, string>)(c => c.Name)).ToSeparatedString<string>(", ")).HtmlEncode();
                    if (categoryRulesResult.DeletedCategories.Count > 0)
                        str = str + "<br/> " + EleWise.ELMA.SR.T("Удалены категории: {0}", (object)categoryRulesResult.DeletedCategories.Select<ICategory, string>((Func<ICategory, string>)(c => c.Name)).ToSeparatedString<string>(", ")).HtmlEncode();
                    // ISSUE: explicit non-virtual call
                    Notifier.Information(MvcHtmlString.Create(str));
                }
                return RedirectToAction("Details", (object)new
                {
                    Id = model.Entity.Id
                });
            }
            catch (Exception ex)
            {
                ((BaseController)this).Logger.Error((object)ex.Message, ex);
                ((BaseController)this).UnitOfWorkManager.RollbackCurrent("");
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return View((object)model);
            }
        }

        [HttpGet]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult Delete(long id)
        {
            try
            {
                if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                    return RedirectToAction("Details", (object) new { id = id });

                IContractorIndividual contractorIndividual = base.Manager.Load(id);
                base.Manager.Delete(contractorIndividual);
                Notifier.Information(EleWise.ELMA.SR.T("Физическое лицо \"{0}\" успешно удалено", (object)contractorIndividual.Name));
                return RedirectToAction("Index", "Contractor", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "Contractor", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
        }

        [HttpGet]
        [Permission("{9219C9AB-7E68-47B1-8939-FF6FC4439DA0}")]
        public ActionResult AddWatch(Guid typeUid, string entityId)
        {
            object entityId1 = ModelHelper.TryConvertEntityId(typeUid, (object)entityId);
            IUser currentUser = this.GetCurrentUser();
            if (!WatchManager.Instance.IsWatchExsist(typeUid, entityId1, currentUser))
                WatchManager.Instance.CreateWatchByUser(typeUid, entityId1, currentUser);
            return RedirectToAction("Details", (object)new
            {
                Id = entityId
            });
        }

        [HttpGet]
        [Permission("{9219C9AB-7E68-47B1-8939-FF6FC4439DA0}")]
        public ActionResult RemoveWatch(Guid typeUid, string entityId)
        {
            object entityId1 = ModelHelper.TryConvertEntityId(typeUid, (object)entityId);
            IUser currentUser = this.GetCurrentUser();
            WatchManager.Instance.GetWatchByUser(typeUid, new long?(currentUser.Id), entityId1).ForEach((Action<IWatch>)(w => w.Delete()));
            return RedirectToAction("Details", (object)new
            {
                Id = entityId
            });
        }

        protected void InitNewModel(ContractorIndividualModel model) => this.InitNewModel(model, true);

        private void InitNewModel(ContractorIndividualModel model, bool contractorWasNull)
        {
            if (this.defaultCountry != null && model.Contractor != null)
            {
                IAddressProvider addressProvider = ComponentManager.Current.GetExtensionPoints<IAddressProvider>().FirstOrDefault<IAddressProvider>((Func<IAddressProvider, bool>)(p => p.CountryCode == this.defaultCountry.CountryCode));
                IAddress address1 = addressProvider != null ? addressProvider.CreateAddress() : EntityManager<IAddress>.Instance.Create();
                address1.Country = this.defaultCountry;
                model.Contractor.LegalAddress = address1;
                IAddress address2 = addressProvider != null ? addressProvider.CreateAddress() : EntityManager<IAddress>.Instance.Create();
                address2.Country = this.defaultCountry;
                model.Contractor.PostalAddress = address2;
            }
            if (!contractorWasNull)
                return;
            model.Entity.Email.Add(InterfaceActivator.Create<IEmail>());
            model.Entity.Phone.Add(InterfaceActivator.Create<IPhone>());
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
        }
    }
}
