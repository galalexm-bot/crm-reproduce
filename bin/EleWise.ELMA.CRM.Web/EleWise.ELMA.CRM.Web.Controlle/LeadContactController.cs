using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
public class LeadContactController : BPMController<ILeadContact, long>
{
	[CustomGridAction]
	public ActionResult GridTable(GridCommand command, CustomGridCommand customCommand, LeadContactGrid grid)
	{
		ILeadContactFilter leadContactFilter = InterfaceActivator.Create<ILeadContactFilter>();
		if (grid.LeadId > 0)
		{
			ILead lead2 = (leadContactFilter.Lead = EntityManager<ILead>.Instance.Load(grid.LeadId));
		}
		grid.Data = base.Manager.CreateGridData(command, leadContactFilter);
		return (ActionResult)(object)((Controller)this).PartialView((object)grid);
	}

	public ActionResult Create(long leadId)
	{
		ILead lead = EntityManager<ILead>.Instance.Load(leadId);
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead))
		{
			throw new SecurityException(SR.T("Недостаточно прав для создания контакта возможности \"{0}\" с идентификатором {1}", lead.Name.HtmlEncode(), lead.Id));
		}
		((Controller)(object)this).SetCurrentMenuItem("crm-leads");
		LeadContactModel leadContactModel = new LeadContactModel();
		leadContactModel.Entity.Email.Add(InterfaceActivator.Create<IEmail>());
		leadContactModel.Entity.Phone.Add(InterfaceActivator.Create<IPhone>());
		leadContactModel.Entity.Lead = EntityManager<ILead>.Instance.Load(leadId);
		return (ActionResult)(object)((Controller)this).View((object)leadContactModel);
	}

	[HttpPost]
	public ActionResult Create(LeadContactModel model)
	{
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, model.Entity.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, model.Entity.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, model.Entity.Lead))
		{
			throw new SecurityException(SR.T("Недостаточно прав для создания контакта возможности \"{0}\" с идентификатором {1}", model.Entity.Lead.Name.HtmlEncode(), model.Entity.Lead.Id));
		}
		try
		{
			model.Save();
			base.Notifier.Information(SR.T("Контакт \"{0}\" сохранен успешно", model.Entity.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "Lead", (object)new
			{
				id = model.Entity.Lead.Id,
				tabIndex = 1
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).View((object)model);
		}
	}

	public ActionResult Edit(long id)
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-leads");
		ILeadContact leadContact = base.Manager.Load(id);
		ThrowExceptionIfDeleted(leadContact);
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, leadContact.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, leadContact.Lead))
		{
			throw new SecurityException(SR.T("Недостаточно прав для редактирования контакта возможности \"{0}\" с идентификатором {1}", leadContact.Lead.Name.HtmlEncode(), leadContact.Lead.Id));
		}
		if (!((IEnumerable<IEmail>)leadContact.Email).Any())
		{
			leadContact.Email.Add(InterfaceActivator.Create<IEmail>());
		}
		if (!((IEnumerable<IPhone>)leadContact.Phone).Any())
		{
			leadContact.Phone.Add(InterfaceActivator.Create<IPhone>());
		}
		return (ActionResult)(object)((Controller)this).View((object)new LeadContactModel(leadContact));
	}

	[HttpPost]
	public ActionResult Edit(LeadContactModel model)
	{
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, model.Entity.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, model.Entity.Lead))
		{
			throw new SecurityException(SR.T("Недостаточно прав для редактирования контакта возможности \"{0}\" с идентификатором {1}", model.Entity.Lead.Name.HtmlEncode(), model.Entity.Lead.Id));
		}
		model.Save();
		base.Notifier.Information(SR.T("Контакт \"{0} {1} {2}\" сохранен успешно", model.Entity.Firstname, model.Entity.Surname, model.Entity.Middlename));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "Lead", (object)new
		{
			id = model.Entity.Lead.Id,
			tabIndex = 1
		});
	}

	[HttpGet]
	public ActionResult Delete(long id)
	{
		ILeadContact leadContact = base.Manager.Load(id);
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, leadContact.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, leadContact.Lead))
		{
			throw new SecurityException(SR.T("Недостаточно прав для удаления контакта возможности \"{0}\" с идентификатором {1}", leadContact.Lead.Name.HtmlEncode(), leadContact.Lead.Id));
		}
		return (ActionResult)(object)((Controller)this).PartialView("DeleteLeadContact", (object)new LeadContactInfoModel
		{
			Id = id
		});
	}

	[HttpPost]
	public ActionResult Delete(LeadContactInfoModel model)
	{
		ILeadContact leadContact = base.Manager.Load(model.Id);
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, leadContact.Lead) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, leadContact.Lead))
		{
			throw new SecurityException(SR.T("Недостаточно прав для удаления контакта возможности \"{0}\" с идентификатором {1}", leadContact.Lead.Name.HtmlEncode(), leadContact.Lead.Id));
		}
		long id = leadContact.Lead.Id;
		base.Manager.Delete(leadContact);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Details", "Lead", (object)new
		{
			id = id,
			tabIndex = 1
		});
	}
}
