using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class TaskController : BPMController<ICRMTaskBase, long>
{
	public static ICRMTaskBaseFilter CreateFilter()
	{
		ICRMTaskBaseFilter iCRMTaskBaseFilter = InterfaceActivator.Create<ICRMTaskBaseFilter>();
		iCRMTaskBaseFilter.DisableSecurity = true;
		iCRMTaskBaseFilter.FilterByEntity = true;
		if (!Locator.GetServiceNotNull<CrmSettingsModule>().Settings.TasksGrid_ShowCompleted)
		{
			iCRMTaskBaseFilter.CompleteStatus = TaskCompleteStatus.Active;
		}
		return iCRMTaskBaseFilter;
	}

	[CustomGridAction]
	public ActionResult TasksOfContractor(GridCommand command, long contractorId)
	{
		IContractor contractor = ContractorManager.Instance.Load(contractorId);
		ICRMTaskBaseFilter iCRMTaskBaseFilter = CreateFilter();
		iCRMTaskBaseFilter.Contractor = contractor;
		GridData<ITaskBase, ICRMTaskBaseFilter> gridData = TaskBaseManager.Instance.CreateGridData(command, iCRMTaskBaseFilter);
		return (ActionResult)(object)((Controller)this).PartialView("TaskGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult TasksOfContact(GridCommand command, long contactId)
	{
		IContact contact = ContactManager.Instance.Load(contactId);
		ICRMTaskBaseFilter iCRMTaskBaseFilter = CreateFilter();
		iCRMTaskBaseFilter.Contact = contact;
		GridData<ITaskBase, ICRMTaskBaseFilter> gridData = TaskBaseManager.Instance.CreateGridData(command, iCRMTaskBaseFilter);
		return (ActionResult)(object)((Controller)this).PartialView("TaskGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult TasksOfLead(GridCommand command, long leadId)
	{
		ILead lead = LeadManager.Instance.Load(leadId);
		ICRMTaskBaseFilter iCRMTaskBaseFilter = CreateFilter();
		iCRMTaskBaseFilter.Lead = lead;
		GridData<ITaskBase, ICRMTaskBaseFilter> gridData = TaskBaseManager.Instance.CreateGridData(command, iCRMTaskBaseFilter);
		return (ActionResult)(object)((Controller)this).PartialView("TaskGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult TasksOfSale(GridCommand command, long saleId)
	{
		ISale sale = SaleManager.Instance.Load(saleId);
		ICRMTaskBaseFilter iCRMTaskBaseFilter = CreateFilter();
		iCRMTaskBaseFilter.Sale = sale;
		GridData<ITaskBase, ICRMTaskBaseFilter> gridData = TaskBaseManager.Instance.CreateGridData(command, iCRMTaskBaseFilter);
		return (ActionResult)(object)((Controller)this).PartialView("TaskGrid", (object)gridData);
	}

	[CustomGridAction]
	public ActionResult Tasks(GridCommand command, long? contractorId = null, long? contactId = null, long? leadId = null, long? saleId = null, CRMObjectIdOnly? type = null)
	{
		ICRMTaskBaseFilter iCRMTaskBaseFilter = CreateFilter();
		if (contractorId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Contractor))
		{
			iCRMTaskBaseFilter.Contractor = ContractorManager.Instance.Load(contractorId.Value);
		}
		else if (contactId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Contact))
		{
			iCRMTaskBaseFilter.Contact = ContactManager.Instance.Load(contactId.Value);
		}
		else if (leadId.HasValue && (!type.HasValue || type == CRMObjectIdOnly.Lead))
		{
			iCRMTaskBaseFilter.Lead = LeadManager.Instance.Load(leadId.Value);
		}
		else
		{
			if (!saleId.HasValue || (type.HasValue && type != CRMObjectIdOnly.Sale))
			{
				throw new ArgumentNullException("contractorId");
			}
			iCRMTaskBaseFilter.Sale = SaleManager.Instance.Load(saleId.Value);
		}
		GridData<ITaskBase, ICRMTaskBaseFilter> gridData = TaskBaseManager.Instance.CreateGridData(command, iCRMTaskBaseFilter);
		return (ActionResult)(object)((Controller)this).PartialView("TaskGrid", (object)gridData);
	}

	public ActionResult Create(long id, Guid typeUid)
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("Create", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			crmEntityId = id,
			crmEntityTypeUid = typeUid
		});
	}
}
