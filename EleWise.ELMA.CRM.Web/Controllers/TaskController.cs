// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.TaskController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using System;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  public class TaskController : BPMController<ICRMTaskBase, long>
  {
    public static ICRMTaskBaseFilter CreateFilter()
    {
      ICRMTaskBaseFilter filter = InterfaceActivator.Create<ICRMTaskBaseFilter>();
      filter.DisableSecurity = true;
      filter.FilterByEntity = true;
      if (!Locator.GetServiceNotNull<CrmSettingsModule>().Settings.TasksGrid_ShowCompleted)
        filter.CompleteStatus = TaskCompleteStatus.Active;
      return filter;
    }

    [CustomGridAction]
    public ActionResult TasksOfContractor(GridCommand command, long contractorId)
    {
      IContractor contractor = ContractorManager.Instance.Load(contractorId);
      ICRMTaskBaseFilter filter = TaskController.CreateFilter();
      filter.Contractor = contractor;
      return PartialView("TaskGrid", (object) TaskBaseManager.Instance.CreateGridData<ITaskBase, ICRMTaskBaseFilter>(command, filter));
    }

    [CustomGridAction]
    public ActionResult TasksOfContact(GridCommand command, long contactId)
    {
      IContact contact = ContactManager.Instance.Load(contactId);
      ICRMTaskBaseFilter filter = TaskController.CreateFilter();
      filter.Contact = contact;
      return PartialView("TaskGrid", (object) TaskBaseManager.Instance.CreateGridData<ITaskBase, ICRMTaskBaseFilter>(command, filter));
    }

    [CustomGridAction]
    public ActionResult TasksOfLead(GridCommand command, long leadId)
    {
      ILead lead = LeadManager.Instance.Load(leadId);
      ICRMTaskBaseFilter filter = TaskController.CreateFilter();
      filter.Lead = lead;
      return PartialView("TaskGrid", (object) TaskBaseManager.Instance.CreateGridData<ITaskBase, ICRMTaskBaseFilter>(command, filter));
    }

    [CustomGridAction]
    public ActionResult TasksOfSale(GridCommand command, long saleId)
    {
      ISale sale = SaleManager.Instance.Load(saleId);
      ICRMTaskBaseFilter filter = TaskController.CreateFilter();
      filter.Sale = sale;
      return PartialView("TaskGrid", (object) TaskBaseManager.Instance.CreateGridData<ITaskBase, ICRMTaskBaseFilter>(command, filter));
    }

    [CustomGridAction]
    public ActionResult Tasks(
      GridCommand command,
      long? contractorId = null,
      long? contactId = null,
      long? leadId = null,
      long? saleId = null,
      CRMObjectIdOnly? type = null)
    {
      ICRMTaskBaseFilter filter = TaskController.CreateFilter();
      CRMObjectIdOnly? nullable;
      if (contractorId.HasValue)
      {
        if (type.HasValue)
        {
          nullable = type;
          CRMObjectIdOnly crmObjectIdOnly = CRMObjectIdOnly.Contractor;
          if (!(nullable.GetValueOrDefault() == crmObjectIdOnly & nullable.HasValue))
            goto label_4;
        }
        filter.Contractor = ContractorManager.Instance.Load(contractorId.Value);
        goto label_17;
      }
label_4:
      if (contactId.HasValue)
      {
        if (type.HasValue)
        {
          nullable = type;
          CRMObjectIdOnly crmObjectIdOnly = CRMObjectIdOnly.Contact;
          if (!(nullable.GetValueOrDefault() == crmObjectIdOnly & nullable.HasValue))
            goto label_8;
        }
        filter.Contact = ContactManager.Instance.Load(contactId.Value);
        goto label_17;
      }
label_8:
      if (leadId.HasValue)
      {
        if (type.HasValue)
        {
          nullable = type;
          CRMObjectIdOnly crmObjectIdOnly = CRMObjectIdOnly.Lead;
          if (!(nullable.GetValueOrDefault() == crmObjectIdOnly & nullable.HasValue))
            goto label_12;
        }
        filter.Lead = LeadManager.Instance.Load(leadId.Value);
        goto label_17;
      }
label_12:
      if (saleId.HasValue)
      {
        if (type.HasValue)
        {
          nullable = type;
          CRMObjectIdOnly crmObjectIdOnly = CRMObjectIdOnly.Sale;
          if (!(nullable.GetValueOrDefault() == crmObjectIdOnly & nullable.HasValue))
            goto label_16;
        }
        filter.Sale = SaleManager.Instance.Load(saleId.Value);
        goto label_17;
      }
label_16:
      throw new ArgumentNullException(nameof (contractorId));
label_17:
      return PartialView("TaskGrid", (object) TaskBaseManager.Instance.CreateGridData<ITaskBase, ICRMTaskBaseFilter>(command, filter));
    }

    public ActionResult Create(long id, Guid typeUid) => RedirectToAction(nameof (Create), "Task", (object) new
    {
      area = "EleWise.ELMA.BPM.Web.Tasks",
      crmEntityId = id,
      crmEntityTypeUid = typeUid
    });
  }
}
