using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class AttachmentFilterController : BPMController<ICRMAttachment, long>
{
	public ContractorManager ContractorManager { get; set; }

	public ContactManager ContactManager { get; set; }

	public LeadManager LeadManager { get; set; }

	public SaleManager SaleManager { get; set; }

	[CustomGridAction]
	public ActionResult AttachmentsOfContractor(GridCommand command, long contractorId)
	{
		IContractor contractor = ContractorManager.Load(contractorId);
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		iCRMAttachmentFilter.Contractor = contractor;
		GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = base.Manager.CreateGridData(command, iCRMAttachmentFilter);
		bool flag = base.SecurityService.HasPermission(CRMPermissionProvider.EditContractorPermission, contractor);
		((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)flag);
		return (ActionResult)(object)((Controller)this).PartialView("AttachmentGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult AttachmentsOfContact(GridCommand command, long contactId)
	{
		IContact contact = ContactManager.Load(contactId);
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		iCRMAttachmentFilter.Contact = contact;
		GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = base.Manager.CreateGridData(command, iCRMAttachmentFilter);
		bool flag = base.SecurityService.HasPermission(CRMPermissionProvider.EditContactPermission, contact);
		((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)flag);
		return (ActionResult)(object)((Controller)this).PartialView("AttachmentGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult AttachmentsOfLead(GridCommand command, long leadId)
	{
		ILead lead = LeadManager.Load(leadId);
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		iCRMAttachmentFilter.Lead = lead;
		GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = base.Manager.CreateGridData(command, iCRMAttachmentFilter);
		bool flag = lead.Status != LeadStatus.Qualified && lead.Status != LeadStatus.Unqualified && base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead);
		((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)flag);
		return (ActionResult)(object)((Controller)this).PartialView("AttachmentGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult AttachmentsOfSale(GridCommand command, long saleId)
	{
		ISale sale = SaleManager.Load(saleId);
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		iCRMAttachmentFilter.Sale = sale;
		GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = base.Manager.CreateGridData(command, iCRMAttachmentFilter);
		bool flag = base.SecurityService.HasPermission(CRMPermissionProvider.EditSalePermission, sale);
		((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)flag);
		return (ActionResult)(object)((Controller)this).PartialView("AttachmentGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult Attachments(GridCommand command, long? contractorId = null, long? contactId = null, long? leadId = null, long? saleId = null, CRMObjectIdOnly? type = null)
	{
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		if (contractorId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Contractor))
		{
			IContractor target = (iCRMAttachmentFilter.Contractor = ContractorManager.Load(contractorId.Value));
			bool flag = base.SecurityService.HasPermission(CRMPermissionProvider.EditContractorPermission, target);
			((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)flag);
		}
		else if (contactId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Contact))
		{
			IContact target2 = (iCRMAttachmentFilter.Contact = ContactManager.Load(contactId.Value));
			bool flag2 = base.SecurityService.HasPermission(CRMPermissionProvider.EditContactPermission, target2);
			((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)flag2);
		}
		else if (leadId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Lead))
		{
			ILead lead2 = (iCRMAttachmentFilter.Lead = LeadManager.Load(leadId.Value));
			bool flag3 = lead2.Status != LeadStatus.Qualified && lead2.Status != LeadStatus.Unqualified && base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead2);
			((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)flag3);
		}
		else
		{
			if (!saleId.HasValue || (type.HasValue && type != CRMObjectIdOnly.Sale))
			{
				throw new ArgumentNullException("contractorId");
			}
			ISale target3 = (iCRMAttachmentFilter.Sale = SaleManager.Load(saleId.Value));
			bool flag4 = base.SecurityService.HasPermission(CRMPermissionProvider.EditSalePermission, target3);
			((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)flag4);
		}
		GridData<ICRMAttachment, ICRMAttachmentFilter> gridData = base.Manager.CreateGridData(command, iCRMAttachmentFilter);
		return (ActionResult)(object)((Controller)this).PartialView("AttachmentGrid", (object)gridData);
	}
}
