// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.LeadContactController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    public class LeadContactController : BPMController<ILeadContact, long>
    {
        [CustomGridAction]
        public ActionResult GridTable(
          GridCommand command,
          CustomGridCommand customCommand,
          LeadContactGrid grid)
        {
            ILeadContactFilter filter = InterfaceActivator.Create<ILeadContactFilter>();
            if (grid.LeadId > 0L)
            {
                ILead lead = EntityManager<ILead>.Instance.Load((object)grid.LeadId);
                filter.Lead = lead;
            }
            grid.Data = base.Manager.CreateGridData<ILeadContact, ILeadContactFilter>(command, filter);
            return PartialView((object)grid);
        }

        public ActionResult Create(long leadId)
        {
            ILead target = EntityManager<ILead>.Instance.Load((object)leadId);
            // ISSUE: explicit non-virtual call
            // ISSUE: explicit non-virtual call
            // ISSUE: explicit non-virtual call
            if (!base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, (object)target) && !base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, (object)target) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, (object)target))
                throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для создания контакта возможности \"{0}\" с идентификатором {1}", (object)target.Name.HtmlEncode(), (object)target.Id));
            ((Controller)this).SetCurrentMenuItem("crm-leads");
            LeadContactModel model = new LeadContactModel();
            model.Entity.Email.Add(InterfaceActivator.Create<IEmail>());
            model.Entity.Phone.Add(InterfaceActivator.Create<IPhone>());
            model.Entity.Lead = EntityManager<ILead>.Instance.Load((object)leadId);
            return View((object)model);
        }

        [HttpPost]
        public ActionResult Create(LeadContactModel model)
        {
            // ISSUE: explicit non-virtual call
            // ISSUE: explicit non-virtual call
            // ISSUE: explicit non-virtual call
            if (!base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, (object)model.Entity.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, (object)model.Entity.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, (object)model.Entity.Lead))
                throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для создания контакта возможности \"{0}\" с идентификатором {1}", (object)model.Entity.Lead.Name.HtmlEncode(), (object)model.Entity.Lead.Id));
            try
            {
                model.Save();
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Контакт \"{0}\" сохранен успешно", (object)model.Entity.Name));
                return RedirectToAction("Details", "Lead", (object)new
                {
                    id = model.Entity.Lead.Id,
                    tabIndex = 1
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return View((object)model);
            }
        }

        public ActionResult Edit(long id)
        {
            ((Controller)this).SetCurrentMenuItem("crm-leads");
            ILeadContact leadContact = base.Manager.Load(id);
            ThrowExceptionIfDeleted((ISoftDeletable)leadContact);

            if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, (object)leadContact.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, (object)leadContact.Lead))
                throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для редактирования контакта возможности \"{0}\" с идентификатором {1}", (object)leadContact.Lead.Name.HtmlEncode(), (object)leadContact.Lead.Id));
            if (!leadContact.Email.Any<IEmail>())
                leadContact.Email.Add(InterfaceActivator.Create<IEmail>());
            if (!leadContact.Phone.Any<IPhone>())
                leadContact.Phone.Add(InterfaceActivator.Create<IPhone>());
            return View((object)new LeadContactModel(leadContact));
        }

        [HttpPost]
        public ActionResult Edit(LeadContactModel model)
        {
            // ISSUE: explicit non-virtual call
            // ISSUE: explicit non-virtual call
            if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, (object)model.Entity.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, (object)model.Entity.Lead))
                throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для редактирования контакта возможности \"{0}\" с идентификатором {1}", (object)model.Entity.Lead.Name.HtmlEncode(), (object)model.Entity.Lead.Id));
            model.Save();
            // ISSUE: explicit non-virtual call
            Notifier.Information(EleWise.ELMA.SR.T("Контакт \"{0} {1} {2}\" сохранен успешно", (object)model.Entity.Firstname, (object)model.Entity.Surname, (object)model.Entity.Middlename));
            return RedirectToAction("Details", "Lead", (object)new
            {
                id = model.Entity.Lead.Id,
                tabIndex = 1
            });
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            ILeadContact leadContact = base.Manager.Load(id);
            if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, (object)leadContact.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, (object)leadContact.Lead))
                throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для удаления контакта возможности \"{0}\" с идентификатором {1}", (object)leadContact.Lead.Name.HtmlEncode(), (object)leadContact.Lead.Id));
            return PartialView("DeleteLeadContact", (object)new LeadContactInfoModel()
            {
                Id = id
            });
        }

        [HttpPost]
        public ActionResult Delete(LeadContactInfoModel model)
        {
            ILeadContact leadContact = base.Manager.Load(model.Id);
            if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, (object)leadContact.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, (object)leadContact.Lead))
                throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для удаления контакта возможности \"{0}\" с идентификатором {1}", (object)leadContact.Lead.Name.HtmlEncode(), (object)leadContact.Lead.Id));
            long id = leadContact.Lead.Id;
            base.Manager.Delete(leadContact);
            return RedirectToAction("Details", "Lead", (object)new
            {
                id = id,
                tabIndex = 1
            });
        }
    }
}
