// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.AttachmentFilterController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using System;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    public class AttachmentFilterController : BPMController<ICRMAttachment, long>
    {
        public ContractorManager ContractorManager { get; set; }

        public ContactManager ContactManager { get; set; }

        public LeadManager LeadManager { get; set; }

        public SaleManager SaleManager { get; set; }

        [CustomGridAction]
        public ActionResult AttachmentsOfContractor(GridCommand command, long contractorId)
        {
            IContractor contractor = this.ContractorManager.Load(contractorId);
            ICRMAttachmentFilter filter = InterfaceActivator.Create<ICRMAttachmentFilter>();
            filter.Contractor = contractor;
            // ISSUE: explicit non-virtual call
            GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = ((BaseController<ICRMAttachment, long>)this).Manager.CreateGridData<ICRMAttachment, ICRMAttachmentFilter>(command, filter);
            // ISSUE: explicit non-virtual call
            ((ControllerBase)this).ViewData["CanEdit"] = (object)base.SecurityService.HasPermission(CRMPermissionProvider.EditContractorPermission, (object)contractor);
            return PartialView("AttachmentGrid", (object)gridData);
        }

        [CustomGridAction]
        public ActionResult AttachmentsOfContact(GridCommand command, long contactId)
        {
            IContact target = this.ContactManager.Load(contactId);
            ICRMAttachmentFilter filter = InterfaceActivator.Create<ICRMAttachmentFilter>();
            filter.Contact = target;
            GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = base.Manager.CreateGridData<ICRMAttachment, ICRMAttachmentFilter>(command, filter);
            ((ControllerBase)this).ViewData["CanEdit"] = (object)base.SecurityService.HasPermission(CRMPermissionProvider.EditContactPermission, (object)target);
            return PartialView("AttachmentGrid", (object)gridData);
        }

        [CustomGridAction]
        public ActionResult AttachmentsOfLead(GridCommand command, long leadId)
        {
            ILead lead = LeadManager.Load(leadId);
            ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
            iCRMAttachmentFilter.Lead = lead;
            GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = base.Manager.CreateGridData(command, iCRMAttachmentFilter);
            bool flag = lead.Status != LeadStatus.Qualified && lead.Status != LeadStatus.Unqualified && base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead);
            base.ViewData["CanEdit"] = flag;
            return PartialView("AttachmentGrid", gridData);
        }

        [CustomGridAction]
        public ActionResult AttachmentsOfSale(GridCommand command, long saleId)
        {
            ISale target = this.SaleManager.Load(saleId);
            ICRMAttachmentFilter filter = InterfaceActivator.Create<ICRMAttachmentFilter>();
            filter.Sale = target;
            // ISSUE: explicit non-virtual call
            GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = base.Manager.CreateGridData<ICRMAttachment, ICRMAttachmentFilter>(command, filter);
            // ISSUE: explicit non-virtual call
            ((ControllerBase)this).ViewData["CanEdit"] = (object)base.SecurityService.HasPermission(CRMPermissionProvider.EditSalePermission, (object)target);
            return PartialView("AttachmentGrid", (object)gridData);
        }

        [CustomGridAction]
        public ActionResult Attachments(GridCommand command, long? contractorId = null, long? contactId = null, long? leadId = null, long? saleId = null, CRMObjectIdOnly? type = null)
        {
            ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
            if (contractorId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Contractor))
            {
                IContractor target = (iCRMAttachmentFilter.Contractor = ContractorManager.Load(contractorId.Value));
                bool flag = base.SecurityService.HasPermission(CRMPermissionProvider.EditContractorPermission, target);
                base.ViewData["CanEdit"] = flag;
            }
            else if (contactId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Contact))
            {
                IContact target2 = (iCRMAttachmentFilter.Contact = ContactManager.Load(contactId.Value));
                bool flag2 = base.SecurityService.HasPermission(CRMPermissionProvider.EditContactPermission, target2);
                base.ViewData["CanEdit"] = flag2;
            }
            else if (leadId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Lead))
            {
                ILead lead2 = (iCRMAttachmentFilter.Lead = LeadManager.Load(leadId.Value));
                bool flag3 = lead2.Status != LeadStatus.Qualified && lead2.Status != LeadStatus.Unqualified && base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead2);
                base.ViewData["CanEdit"] = flag3;
            }
            else
            {
                if (!saleId.HasValue || (type.HasValue && type != CRMObjectIdOnly.Sale))
                {
                    throw new ArgumentNullException("contractorId");
                }
                ISale target3 = (iCRMAttachmentFilter.Sale = SaleManager.Load(saleId.Value));
                bool flag4 = base.SecurityService.HasPermission(CRMPermissionProvider.EditSalePermission, target3);
                base.ViewData["CanEdit"] = flag4;
            }
            GridData<ICRMAttachment, ICRMAttachmentFilter> model = base.Manager.CreateGridData(command, iCRMAttachmentFilter);
            return PartialView("AttachmentGrid", model);
        }
    }
}
