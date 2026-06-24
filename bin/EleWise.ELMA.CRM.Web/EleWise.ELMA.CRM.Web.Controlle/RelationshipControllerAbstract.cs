using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.CRM.Web.Controllers;

public abstract class RelationshipControllerAbstract<TRelationshipEntity, TRelationshipEntityModel> : BPMController<TRelationshipEntity, long> where TRelationshipEntity : class, IRelationship where TRelationshipEntityModel : RelationshipModel<TRelationshipEntity>, new()
{
	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	[NotNull]
	public new IUnitOfWorkManager UnitOfWorkManager { get; set; }

	[NotNull]
	public RelationshipManager RelationshipManager { get; set; }

	protected virtual void InitNewModel(TRelationshipEntityModel model)
	{
	}

	protected abstract TRelationshipEntityModel InitNewModel(TRelationshipEntity entity, ViewType viewType);

	protected ActionResult Create(long ContractorId = 0L, long ContactId = 0L, long LeadId = 0L, long SaleId = 0L, long RelationId = 0L, string start = "", string end = "", Action<TRelationshipEntityModel> createAction = null)
	{
		return Create(ContractorId, ContactId, LeadId, SaleId, RelationId, start, end, 0L, createAction);
	}

	protected ActionResult Create(long ContractorId, long ContactId, long LeadId, long SaleId, long RelationId, string start, string end, long scheduleId, Action<TRelationshipEntityModel> createAction = null)
	{
		if (!CreateElement(ContractorId, ContactId, LeadId, SaleId))
		{
			throw new SecurityException(SR.T("Недостаточно прав для создания взаимоотношения"));
		}
		if (SaleId == 0L && LeadId == 0L && ContactId == 0L && ContractorId == 0L)
		{
			base.ActiveMenuItem = "SchedulerController.CalendarItems";
		}
		TRelationshipEntityModel val = InitNewModel(null, ViewType.Create);
		DateTime result = DateTime.Now;
		if (DateTime.TryParse(start, out result))
		{
			val.Entity.StartDate = result;
		}
		if (DateTime.TryParse(end, out result))
		{
			val.Entity.EndDate = result;
		}
		if (scheduleId > 0)
		{
			ISchedule schedule = null;
			try
			{
				schedule = ScheduleManager.Instance.LoadOrNull(scheduleId);
			}
			catch (Exception)
			{
			}
			if (schedule != null && schedule.Owner == null)
			{
				val.Entity.Schedules.Add(schedule);
			}
		}
		if (RelationId > 0)
		{
			IRelationship relationship = EntityManager<IRelationship>.Instance.Load(RelationId);
			if (relationship.Contact != null)
			{
				ContactId = relationship.Contact.Id;
				val.Link = RelationshipLink.Contact;
			}
			if (relationship.Contractor != null)
			{
				ContractorId = relationship.Contractor.Id;
				val.Link = RelationshipLink.Contractor;
			}
			if (relationship.Lead != null)
			{
				LeadId = relationship.Lead.Id;
				val.Link = RelationshipLink.Lead;
			}
			val.PrevRelationshipId = RelationId;
		}
		else
		{
			val.LinkReadOnly = ContractorId > 0 || ContactId > 0 || LeadId > 0 || SaleId > 0;
		}
		if (ContractorId > 0)
		{
			val.Entity.Contractor = ContractorManager.Instance.Load(ContractorId);
			val.Link = RelationshipLink.Contractor;
			((Controller)(object)this).SetCurrentMenuItem("crm-contractors");
		}
		if (ContactId > 0)
		{
			val.Entity.Contact = ContactManager.Instance.Load(ContactId);
			val.Link = RelationshipLink.Contact;
			((Controller)(object)this).SetCurrentMenuItem("crm-contacts");
		}
		if (LeadId > 0)
		{
			val.Entity.Lead = LeadManager.Instance.Load(LeadId);
			val.Link = RelationshipLink.Lead;
			((Controller)(object)this).SetCurrentMenuItem("crm-leads");
		}
		if (SaleId > 0)
		{
			val.Entity.Sale = SaleManager.Instance.Load(SaleId);
			val.Entity.Contractor = val.Entity.Sale.Contractor;
			val.Link = RelationshipLink.Contractor;
			((Controller)(object)this).SetCurrentMenuItem("crm-salies");
		}
		createAction?.Invoke(val);
		return (ActionResult)(object)((Controller)this).View((object)val);
	}

	protected ActionResult CreateMany(long[] contactsId, long[] contractorsId, long[] leadsId, long[] salesId)
	{
		TRelationshipEntityModel val = InitNewModel(null, ViewType.Create);
		val.IsMultiCreation = true;
		val.LinkReadOnly = true;
		if (contactsId != null)
		{
			if (contactsId.Length == 1)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Create", (object)new
				{
					ContactId = contactsId[0]
				});
			}
			val.Contacts = new List<IContact>();
			long[] array = contactsId;
			foreach (long id in array)
			{
				val.Contacts.Add(ContactManager.Instance.Load(id));
			}
			((Controller)(object)this).SetCurrentMenuItem("crm-contacts");
		}
		if (contractorsId != null)
		{
			if (contractorsId.Length == 1)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Create", (object)new
				{
					ContractorId = contractorsId[0]
				});
			}
			val.Contractors = new List<IContractor>();
			long[] array = contractorsId;
			foreach (long id2 in array)
			{
				val.Contractors.Add(ContractorManager.Instance.Load(id2));
			}
			((Controller)(object)this).SetCurrentMenuItem("crm-contractors");
		}
		if (leadsId != null)
		{
			if (leadsId.Length == 1)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Create", (object)new
				{
					LeadId = leadsId[0]
				});
			}
			val.Leads = new List<ILead>();
			long[] array = leadsId;
			foreach (long id3 in array)
			{
				val.Leads.Add(LeadManager.Instance.Load(id3));
			}
			((Controller)(object)this).SetCurrentMenuItem("crm-leads");
		}
		if (salesId != null)
		{
			if (salesId.Length == 1)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Create", (object)new
				{
					SalesId = salesId[0]
				});
			}
			val.Sales = new List<ISale>();
			long[] array = salesId;
			foreach (long id4 in array)
			{
				val.Sales.Add(SaleManager.Instance.Load(id4));
			}
			((Controller)(object)this).SetCurrentMenuItem("crm-salies");
		}
		return (ActionResult)(object)((Controller)this).View("Create", (object)val);
	}

	[HttpPost]
	public virtual ActionResult CreateMany(TRelationshipEntityModel model)
	{
		CheckCreateElement(model);
		try
		{
			using (IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true))
			{
				model.Save();
				EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, model.Entity, "70c5300a-fafb-495c-bda9-4c5dc12cc8bd"));
				unitOfWork.Commit();
			}
			base.Notifier.Information(GetSuccessfulSaveMvcNotification(model.Entities));
			if (model.Contacts != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contact");
			}
			if (model.Contractors != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
			}
			if (model.Leads != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Lead");
			}
			if (model.Sales != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Sale");
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
		}
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult Create(TRelationshipEntityModel model)
	{
		CheckCreateElement(model);
		try
		{
			FillContractorClients(model);
			FillLeadContacts(model);
			model.Save();
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, model.Entity, "70c5300a-fafb-495c-bda9-4c5dc12cc8bd"));
			base.Notifier.Information(GetSuccessfulSaveMvcNotification(model.Entity));
			if (IsCustomViewRequest())
			{
				return HandleCustomViewJsonCallback(model.Entity);
			}
			if (model.Entity.Contractor == null && model.Entity.Contact == null && model.Entity.Lead == null && model.Entity.Sale == null)
			{
				return (ActionResult)((!IsCreatorRequest()) ? ((object)RedirectToAction("Index", "Scheduler", "EleWise.ELMA.BPM.Web.Calendar")) : ((object)CreatorJson(model.Entity)));
			}
			return (ActionResult)((!IsCreatorRequest()) ? ((object)((Controller)this).RedirectToAction("Details", (object)new
			{
				id = model.Entity.Id
			})) : ((object)CreatorJson(model.Entity)));
		}
		catch (Exception ex)
		{
			FormNotifierExtensions.Error(base.Notifier, ex);
			return (ActionResult)((!IsCreatorRequest()) ? ((object)((Controller)this).View((object)model)) : ((object)CreatorJson(null, ex.Message)));
		}
	}

	private void FillContractorClients(TRelationshipEntityModel model)
	{
		((ICollection<IContact>)model.Entity.ContractorsContacts).Clear();
		if (model.ContractorContacts != null)
		{
			model.Entity.ContractorsContacts.AddAll((ICollection<IContact>)model.ContractorContacts);
		}
	}

	private void FillLeadContacts(TRelationshipEntityModel model)
	{
		((ICollection<ILeadContact>)model.Entity.LeadContacts).Clear();
		if (model.LeadContacts != null)
		{
			model.Entity.LeadContacts.AddAll((ICollection<ILeadContact>)model.LeadContacts);
		}
	}

	[DetailsAction]
	[EntityLink]
	public virtual ActionResult Details(long id)
	{
		try
		{
			TRelationshipEntity entity = base.Manager.Load(id);
			TRelationshipEntityModel val = InitNewModel(entity, ViewType.Display);
			ThrowExceptionIfDeleted(val.Entity);
			if (val.Entity.Contractor != null)
			{
				((Controller)(object)this).SetCurrentMenuItem("crm-contractors");
			}
			else if (val.Entity.Contact != null)
			{
				((Controller)(object)this).SetCurrentMenuItem("crm-contacts");
			}
			else if (val.Entity.Lead != null)
			{
				((Controller)(object)this).SetCurrentMenuItem("crm-leads");
			}
			else if (val.Entity.Sale != null)
			{
				((Controller)(object)this).SetCurrentMenuItem("crm-salies");
			}
			else
			{
				base.ActiveMenuItem = "SchedulerController.CalendarItems";
			}
			SetAsReadForFeed(val.Entity);
			if (val.PrivateAccess)
			{
				return (ActionResult)(object)((Controller)this).View("RelationshipIsPrivate", (object)val);
			}
			return (ActionResult)(object)((Controller)this).View((object)val);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
		}
	}

	public virtual ActionResult Edit(long id)
	{
		try
		{
			TRelationshipEntity val = AbstractNHEntityManager<TRelationshipEntity, long>.Instance.Load(id);
			ThrowExceptionIfDeleted(val);
			if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, val))
			{
				base.Notifier.Error(SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
			}
			TRelationshipEntityModel val2 = InitNewModel(val, ViewType.Edit);
			RelationshipLink link = RelationshipLink.Contractor;
			if (val.Contractor != null)
			{
				val2.PrevContractorId = val.Contractor.Id;
				foreach (IContact item in (IEnumerable<IContact>)val.ContractorsContacts)
				{
					val2.PrevContractorContactsIds.Add(item.Id);
				}
				link = RelationshipLink.Contractor;
			}
			else if (val.Contact != null)
			{
				val2.PrevContactId = val.Contact.Id;
				link = RelationshipLink.Contact;
			}
			else if (val.Lead != null)
			{
				val2.PrevLeadId = val.Lead.Id;
				link = RelationshipLink.Lead;
			}
			else
			{
				base.ActiveMenuItem = "SchedulerController.CalendarItems";
			}
			val2.Link = link;
			if (val2.PrivateAccess)
			{
				return (ActionResult)(object)((Controller)this).View("RelationshipIsPrivate", (object)val2);
			}
			return (ActionResult)(object)((Controller)this).View((object)val2);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
		}
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult Edit(TRelationshipEntityModel model)
	{
		CheckCreateElement(model);
		try
		{
			FillContractorClients(model);
			FillLeadContacts(model);
			model.Save();
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, model.Entity, "687e895b-0cae-42e1-b882-e431b66535ae"));
			base.Notifier.Information(GetSuccessfulSaveMvcNotification(model.Entity));
			if (model.Entity.Contractor == null && model.Entity.Contact == null && model.Entity.Lead == null && model.Entity.Sale == null)
			{
				return (ActionResult)(object)RedirectToAction("Index", "Scheduler", "EleWise.ELMA.BPM.Web.Calendar");
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new
			{
				id = model.Entity.Id
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).View((object)model);
		}
	}

	public ActionResult AddComment(long id)
	{
		return null;
	}

	[HttpGet]
	[TransactionAction]
	public virtual ActionResult Delete(long id)
	{
		try
		{
			TRelationshipEntity val = base.Manager.Load(id);
			if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, val) || !base.SecurityService.HasPermission(CRMPermissionProvider.CRMDeletePermission))
			{
				base.Notifier.Error(SR.T("Текущий пользователь не имеет прав на удаление взаимоотношения"));
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
			}
			RelationshipManager.Instance.DeleteRelationship(val, out var currentParentEntity);
			base.Notifier.Information(GetSuccessfulDeleteMvcNotification(val));
			return (ActionResult)((currentParentEntity != null) ? ((object)((Controller)this).Redirect(((Controller)this).get_Url().Entity(currentParentEntity))) : ((object)RedirectToAction("Index", "Scheduler", "EleWise.ELMA.BPM.Web.Calendar")));
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
		}
	}

	[HttpPost]
	public ActionResult Complete(RelationshipCompleteModel relationshipCompleteModel)
	{
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.ExecuteRelationshipPermission, base.Manager.Load(relationshipCompleteModel.EntityId)))
		{
			base.Notifier.Error(SR.T("Текущий пользователь не имеет прав на выполнение взаимоотношения"));
			return (ActionResult)(object)((Controller)this).Redirect(relationshipCompleteModel.RedirectUrl);
		}
		RelationshipManager.Instance.Complete(relationshipCompleteModel.EntityId, relationshipCompleteModel.Comment);
		long mode = relationshipCompleteModel.Mode;
		long num = mode - 1;
		if ((ulong)num <= 4uL)
		{
			switch (num)
			{
			case 0L:
				return (ActionResult)(object)((Controller)this).RedirectToAction("Create", "RelationshipCall", (object)new
				{
					RelationId = relationshipCompleteModel.EntityId
				});
			case 1L:
				return (ActionResult)(object)((Controller)this).RedirectToAction("Create", "RelationshipMeeting", (object)new
				{
					RelationId = relationshipCompleteModel.EntityId
				});
			case 2L:
				return (ActionResult)(object)((Controller)this).RedirectToAction("Create", "RelationshipMail", (object)new
				{
					RelationId = relationshipCompleteModel.EntityId
				});
			case 3L:
			{
				IRelationship relationship2 = RelationshipManager.Instance.Load(relationshipCompleteModel.EntityId);
				if (relationship2.Contractor != null)
				{
					return (ActionResult)(object)((Controller)this).RedirectToAction("Create", "Sale", (object)new
					{
						contractorId = relationship2.Contractor.Id
					});
				}
				break;
			}
			case 4L:
			{
				IRelationship relationship = RelationshipManager.Instance.Load(relationshipCompleteModel.EntityId);
				if (relationship.Lead == null)
				{
					throw new Exception(SR.T("Не указан потенциальный клиент"));
				}
				return (ActionResult)(object)((Controller)this).RedirectToAction("Convert", "Lead", (object)new
				{
					id = relationship.Lead.Id
				});
			}
			}
		}
		return (ActionResult)(object)((Controller)this).Redirect(relationshipCompleteModel.RedirectUrl);
	}

	[HttpPost]
	public ActionResult AddDay(RelationshipAddDayModel relationshipAddDayModel)
	{
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, base.Manager.Load(relationshipAddDayModel.EntityId)))
		{
			base.Notifier.Error(SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
			return (ActionResult)(object)((Controller)this).Redirect(relationshipAddDayModel.RedirectUrl);
		}
		if (relationshipAddDayModel.UseDates)
		{
			RelationshipManager.ChangeTime(relationshipAddDayModel.EntityId, relationshipAddDayModel.StartDate, relationshipAddDayModel.EndDate, relationshipAddDayModel.Comment);
		}
		else
		{
			RelationshipManager.AddDay(relationshipAddDayModel.EntityId, relationshipAddDayModel.Comment);
		}
		return (ActionResult)(object)((Controller)this).Redirect(relationshipAddDayModel.RedirectUrl);
	}

	[HttpPost]
	public ActionResult ChangeTime(RelationshipChangeTimeModel relationshipChangeTimeModel)
	{
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, base.Manager.Load(relationshipChangeTimeModel.EntityId)))
		{
			base.Notifier.Error(SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
			return (ActionResult)(object)((Controller)this).Redirect(relationshipChangeTimeModel.RedirectUrl);
		}
		RelationshipManager.Instance.ChangeTime(relationshipChangeTimeModel.EntityId, relationshipChangeTimeModel.StartDate, relationshipChangeTimeModel.EndDate, relationshipChangeTimeModel.Comment);
		return (ActionResult)(object)((Controller)this).Redirect(relationshipChangeTimeModel.RedirectUrl);
	}

	[Obsolete("Метод устарел, используйте GetSuccessfulSaveMvcNotification", true)]
	public virtual string GetSuccessfulSaveNotification(TRelationshipEntity entity)
	{
		return string.Empty;
	}

	[Obsolete("Используйте GetSuccessfulSaveMvcNotification")]
	private MvcHtmlString GetSuccessfulSaveObsNotification(TRelationshipEntity entity)
	{
		return MvcHtmlString.Create(GetSuccessfulSaveNotification(entity).HtmlEncode());
	}

	public virtual MvcHtmlString GetSuccessfulSaveMvcNotification(TRelationshipEntity entity)
	{
		return GetSuccessfulSaveObsNotification(entity);
	}

	public MvcHtmlString GetSuccessfulSaveMvcNotification(IEnumerable<TRelationshipEntity> entities)
	{
		return MvcHtmlString.Create(string.Join("<br/>", entities.Select(GetSuccessfulSaveMvcNotification)));
	}

	[Obsolete("Метод устарел, используйте GetSuccessfulSaveMvcNotification", true)]
	public virtual string GetSuccessfulDeleteNotification(TRelationshipEntity entity)
	{
		return string.Empty;
	}

	[Obsolete("Используйте GetSuccessfulSaveMvcNotification")]
	private MvcHtmlString GetSuccessfulDeleteObsNotification(TRelationshipEntity entity)
	{
		return MvcHtmlString.Create(GetSuccessfulDeleteNotification(entity).HtmlEncode());
	}

	public virtual MvcHtmlString GetSuccessfulDeleteMvcNotification(TRelationshipEntity entity)
	{
		return GetSuccessfulDeleteObsNotification(entity);
	}

	private void CheckCreateElement(TRelationshipEntityModel model)
	{
		if (model.IsMultiCreation)
		{
			if (model.Contractors != null)
			{
				foreach (IContractor contractor in model.Contractors)
				{
					CreateElement(contractor.Id, 0L, 0L, 0L);
				}
			}
			if (model.Leads != null)
			{
				foreach (ILead lead in model.Leads)
				{
					CreateElement(0L, 0L, lead.Id, 0L);
				}
			}
			if (model.Sales != null)
			{
				foreach (ISale sale in model.Sales)
				{
					CreateElement(0L, 0L, 0L, sale.Id);
				}
			}
			if (model.Contacts == null)
			{
				return;
			}
			{
				foreach (IContact contact in model.Contacts)
				{
					CreateElement(0L, contact.Id, 0L, 0L);
				}
				return;
			}
		}
		long contractorId = ((model.Entity.Contractor != null) ? model.Entity.Contractor.Id : 0);
		long contactId = ((model.Entity.Contact != null) ? model.Entity.Contact.Id : 0);
		long leadId = ((model.Entity.Lead != null) ? model.Entity.Lead.Id : 0);
		long saleId = ((model.Entity.Sale != null) ? model.Entity.Sale.Id : 0);
		if (!model.LinkReadOnly)
		{
			switch (model.Link)
			{
			case RelationshipLink.Contractor:
				contactId = 0L;
				leadId = 0L;
				break;
			case RelationshipLink.Contact:
				contractorId = 0L;
				leadId = 0L;
				saleId = 0L;
				break;
			case RelationshipLink.Lead:
				contractorId = 0L;
				contactId = 0L;
				saleId = 0L;
				break;
			}
		}
		if (!CreateElement(contractorId, contactId, leadId, saleId))
		{
			throw new SecurityException(SR.T("Недостаточно прав для создания взаимоотношения"));
		}
	}

	private bool CreateElement(long ContractorId = 0L, long ContactId = 0L, long LeadId = 0L, long SaleId = 0L)
	{
		if (SaleId > 0)
		{
			ISale sale = SaleManager.Instance.LoadOrNull(SaleId);
			if (sale != null)
			{
				if (sale.SaleStatus != SaleStatus.NegativeClosed && sale.SaleStatus != SaleStatus.PositiveClosed)
				{
					bool num = base.SecurityService.HasPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale);
					if (num)
					{
						return num;
					}
				}
				throw new SecurityException(SR.T("Недостаточно прав для привязки взаимоотношения к сделке"));
			}
		}
		else if (ContractorId > 0)
		{
			IContractor contractor = ContractorManager.Instance.LoadOrNull(ContractorId);
			if (contractor != null)
			{
				bool num2 = base.SecurityService.HasPermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor);
				if (!num2)
				{
					throw new SecurityException(SR.T("Недостаточно прав для привязки взаимоотношения к контрагенту"));
				}
				return num2;
			}
		}
		else
		{
			if (ContactId > 0)
			{
				IContact target = ContactManager.Instance.LoadOrNull(ContactId);
				bool num3 = base.SecurityService.HasPermission(CRMPermissionProvider.CRMContactCreateElementPermission, target);
				if (!num3)
				{
					throw new SecurityException(SR.T("Недостаточно прав для привязки взаимоотношения к контакту."));
				}
				return num3;
			}
			if (LeadId > 0)
			{
				ILead target2 = LeadManager.Instance.LoadOrNull(LeadId);
				bool num4 = base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, target2);
				if (!num4)
				{
					throw new SecurityException(SR.T("Недостаточно прав для привязки взаимоотношения к потенциальному клиенту"));
				}
				return num4;
			}
		}
		return true;
	}
}
