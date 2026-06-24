// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.CategoryController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Cache;
using EleWise.ELMA.CRM.Exceptions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
    public class CategoryController : BPMController<ICategory, long>
    {
        public ICacheService CacheService { get; set; }

        public IUnionComplexCacheService ComplexCacheService { get; set; }

        public PermissionsModelService PermissionsModelService { get; set; }

        public ActionResult Index()
        {
            this.SetCurrentMenuItem("crm-admin-menu");
            ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
            categoryFilter.ShowNoCategory = true;
            GridData<ICategory, ICategoryFilter> gridData = CreateGridData(null, categoryFilter);
            EleWise.ELMA.Security.Models.IUser currentUser = GetCurrentUser();
            bool showAccess = base.SecurityService.HasPermission(currentUser, PermissionProvider.AccessManagmentPermission);
            return View(new CategoryIndexModel
            {
                CurrentUser = currentUser,
                GridData = gridData,
                ShowAccess = showAccess,
                CheckUpdatePermission = CategoryManager.Instance.CheckUpdateCategoryPermission(),
                LockEditPermission = CategoryManager.Instance.CheckLockEditPermission(),
                LastRecalculatePermissionsError = CacheService.Get<string>("34839AAF-916F-4FEF-917D-21EA38656268")
            });
        }

        [HttpPost]
        public ActionResult GetRecalculateCategoryPermissionStatus()
        {
            string str = this.CacheService.Get<string>("34839AAF-916F-4FEF-917D-21EA38656268");
            return Json((object)new
            {
                blocking = CategoryManager.Instance.CheckLockEditPermission(),
                lastErr = str
            }, "text/html");
        }

        public ActionResult Create()
        {
            ((Controller)this).SetCurrentMenuItem("crm-admin-menu");
            ICategory category = InterfaceActivator.Create<ICategory>();
            CategoryEditModel model = new CategoryEditModel()
            {
                Category = category
            };
            bool blocking = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            model.LockEditPermission = blocking;
            if (!blocking)
                CategoryManager.Instance.CreateContainerPermission(category, false);
            model.CheckUpdatePermission = CategoryManager.Instance.CheckUpdateCategoryPermission(category);
            model.ContractorPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)category.ContainerContractorPermission, InterfaceActivator.TypeOf<IContContractorPermission>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h => h is ITemplateContractorPermission && ((ITemplateContractorPermission)h).ContainerContractor == category.ContainerContractorPermission && !((ITemplateContractorPermission)h).DelPermission), true, (string)null);
            model.ContractorPermissionsModel.ShowSaveButton = false;
            model.ContractorPermissionsModel.NoForm = true;
            model.ContractorPermissionsModel.BindModelName = "contractor";
            model.ContractorPermissionsModel.Edit = !model.LockEditPermission;
            model.LeadPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)category.ContainerLeadPermission, InterfaceActivator.TypeOf<IContLeadPermission>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h => h is ITemplateLeadPermission && ((ITemplateLeadPermission)h).ContainerLead == category.ContainerLeadPermission && !((ITemplateLeadPermission)h).DelPermission), true, (string)null);
            model.LeadPermissionsModel.NoForm = true;
            model.LeadPermissionsModel.ShowSaveButton = false;
            model.LeadPermissionsModel.BindModelName = "lead";
            model.LeadPermissionsModel.Edit = !model.LockEditPermission;
            model.Category = category;
            return View("EditForm", (object)model);
        }

        [HttpPost]
        public ActionResult SaveCategory(
          ICategory category,
          EditableListModel lead,
          EditableListModel contractor)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return this.EditCategory(category);
            if (CategoryManager.Instance.GetAllCategories().Any<ICategory>((Func<ICategory, bool>)(c => c.Name == category.Name && c.Uid != category.Uid)))
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Категория с именем \"{0}\" уже существует", (object)category.Name));
                return this.EditCategory(category);
            }
            this.updateTemplatePermission(category, lead, contractor);
            try
            {
                category.Save();
            }
            catch (BlockedPermissionException ex)
            {
                return this.EditCategory(category);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RecalculateCategoryPermission()
        {
            if (CategoryManager.Instance.RecalculateCategoryPermissionInThread())
                return (ActionResult)new JsonResult()
                {
                    Data = (object)new { Ok = true }
                };
            return (ActionResult)new JsonResult()
            {
                Data = (object)new
                {
                    Error = EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже.")
                }
            };
        }

        [TransactionAction]
        private void updateTemplatePermission(
          ICategory category,
          EditableListModel lead,
          EditableListModel contractorTemplateModel)
        {
            CategoryManager.Instance.CreateContainerPermission(category, true);
            if (contractorTemplateModel != null && contractorTemplateModel.Items != null)
                this.PermissionsModelService.BindPermissionsFromModel((object)category.ContainerContractorPermission, contractorTemplateModel, new Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>>(CategoryController.SyncFromContractor));
            if (lead == null || lead.Items == null)
                return;
            this.PermissionsModelService.BindPermissionsFromModel((object)category.ContainerLeadPermission, lead, new Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>>(CategoryController.SyncFromLead));
        }

        public static void SyncFromContractor(
          ICollection<IInstanceSettingsPermissionHolder> target,
          IEnumerable<IInstanceSettingsPermissionHolder> source)
        {
            List<IInstanceSettingsPermissionHolder> list1 = target.ToList<IInstanceSettingsPermissionHolder>();
            List<IInstanceSettingsPermissionHolder> list2 = source.ToList<IInstanceSettingsPermissionHolder>();
            foreach (IInstanceSettingsPermissionHolder permissionHolder1 in list2)
            {
                IInstanceSettingsPermissionHolder v2 = permissionHolder1;
                if (!target.Any<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(v1 => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned))))
                    target.Add(v2);
                foreach (IInstanceSettingsPermissionHolder permissionHolder2 in target.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(v1 => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned) && (!(v1 is ITemplateContractorPermission) || ((ITemplateContractorPermission)v1).DelPermission))))
                {
                    if (permissionHolder2 is ITemplateContractorPermission contractorPermission)
                    {
                        contractorPermission.DelPermission = false;
                        contractorPermission.AddPermission = true;
                    }
                }
            }
            foreach (IInstanceSettingsPermissionHolder permissionHolder in list1)
            {
                IInstanceSettingsPermissionHolder v2 = permissionHolder;
                if (!list2.Any<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(v1 => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned))) && v2 is ITemplateContractorPermission)
                {
                    ITemplateContractorPermission contractorPermission = v2 as ITemplateContractorPermission;
                    contractorPermission.DelPermission = true;
                    contractorPermission.AddPermission = false;
                }
            }
        }

        public static void SyncFromLead(
          ICollection<IInstanceSettingsPermissionHolder> target,
          IEnumerable<IInstanceSettingsPermissionHolder> source)
        {
            List<IInstanceSettingsPermissionHolder> list1 = target.ToList<IInstanceSettingsPermissionHolder>();
            List<IInstanceSettingsPermissionHolder> list2 = source.ToList<IInstanceSettingsPermissionHolder>();
            foreach (IInstanceSettingsPermissionHolder permissionHolder1 in list2)
            {
                IInstanceSettingsPermissionHolder v2 = permissionHolder1;
                if (!target.Any<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(v1 => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned))))
                    target.Add(v2);
                foreach (IInstanceSettingsPermissionHolder permissionHolder2 in target.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(v1 => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned) && (!(v1 is ITemplateLeadPermission) || ((ITemplateLeadPermission)v1).DelPermission))))
                {
                    if (permissionHolder2 is ITemplateLeadPermission templateLeadPermission)
                    {
                        templateLeadPermission.DelPermission = false;
                        templateLeadPermission.AddPermission = true;
                    }
                }
            }
            foreach (IInstanceSettingsPermissionHolder permissionHolder in list1)
            {
                IInstanceSettingsPermissionHolder v2 = permissionHolder;
                if (!list2.Any<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(v1 => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned))) && v2 is ITemplateLeadPermission)
                {
                    ITemplateLeadPermission templateLeadPermission = v2 as ITemplateLeadPermission;
                    templateLeadPermission.DelPermission = true;
                    templateLeadPermission.AddPermission = false;
                }
            }
        }

        private ActionResult EditCategory(ICategory category)
        {
            ((Controller)this).SetCurrentMenuItem("crm-admin-menu");
            CategoryEditModel model = new CategoryEditModel()
            {
                Category = category
            };
            bool blocking = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            model.LockEditPermission = blocking;
            if (!blocking)
                CategoryManager.Instance.CreateContainerPermission(category, true);
            model.CheckUpdatePermission = CategoryManager.Instance.CheckUpdateCategoryPermission(category);
            model.ContractorPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)category.ContainerContractorPermission, InterfaceActivator.TypeOf<IContContractorPermission>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h => (!(h is ITemplateContractorPermission contractorPermission) || contractorPermission.User != null || contractorPermission.Group != null || contractorPermission.OrganizationItemPosition != null || contractorPermission.OrganizationItemEmployee != null) && h is ITemplateContractorPermission && ((ITemplateContractorPermission)h).ContainerContractor == category.ContainerContractorPermission && !((ITemplateContractorPermission)h).DelPermission), true, (string)null);
            model.ContractorPermissionsModel.ShowSaveButton = false;
            model.ContractorPermissionsModel.NoForm = true;
            model.ContractorPermissionsModel.BindModelName = "contractor";
            model.ContractorPermissionsModel.Edit = !model.LockEditPermission;
            model.LeadPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)category.ContainerLeadPermission, InterfaceActivator.TypeOf<IContLeadPermission>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h => (!(h is ITemplateLeadPermission templateLeadPermission) || templateLeadPermission.User != null || templateLeadPermission.Group != null || templateLeadPermission.OrganizationItemPosition != null || templateLeadPermission.OrganizationItemEmployee != null) && h is ITemplateLeadPermission && ((ITemplateLeadPermission)h).ContainerLead == category.ContainerLeadPermission && !((ITemplateLeadPermission)h).DelPermission), true, (string)null);
            model.LeadPermissionsModel.NoForm = true;
            model.LeadPermissionsModel.ShowSaveButton = false;
            model.LeadPermissionsModel.BindModelName = "lead";
            model.LeadPermissionsModel.Edit = !model.LockEditPermission;
            model.Category = category;
            return View("EditForm", (object)model);
        }

        public ActionResult Edit(ICategory category) => this.EditCategory(category);

        public ActionResult Delete(ICategory category)
        {
            if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
            {
                return EditCategory(category);
            }
            category.Delete();
            ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
            categoryFilter.ShowNoCategory = true;
            GridData<ICategory, ICategoryFilter> model = CreateGridData(null, categoryFilter);
            return PartialView("Grid", model);
        }

        [CustomGridAction]
        public virtual ActionResult Grid(GridCommand command)
        {
            ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
            categoryFilter.ShowNoCategory = true;
            GridData<ICategory, ICategoryFilter> gridData = CreateGridData(command, categoryFilter);
            return GridView(gridData);
        }
    }
}
