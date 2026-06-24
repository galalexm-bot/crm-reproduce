// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.RelationshipControllerAbstract`2
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    public abstract class RelationshipControllerAbstract<TRelationshipEntity, TRelationshipEntityModel> :
      BPMController<TRelationshipEntity, long>
      where TRelationshipEntity : class, IRelationship
      where TRelationshipEntityModel : RelationshipModel<TRelationshipEntity>, new()
    {
        [NotNull]
        public IEntityActionHandler EntityActionHandler { get; set; }

        [NotNull]
        public IUnitOfWorkManager UnitOfWorkManager { get; set; }

        [NotNull]
        public RelationshipManager RelationshipManager { get; set; }

        protected virtual void InitNewModel(TRelationshipEntityModel model)
        {
        }

        protected abstract TRelationshipEntityModel InitNewModel(
          TRelationshipEntity entity,
          EleWise.ELMA.Model.Views.ViewType viewType);

        protected ActionResult Create(
          long ContractorId = 0,
          long ContactId = 0,
          long LeadId = 0,
          long SaleId = 0,
          long RelationId = 0,
          string start = "",
          string end = "",
          Action<TRelationshipEntityModel> createAction = null)
        {
            return this.Create(ContractorId, ContactId, LeadId, SaleId, RelationId, start, end, 0L, createAction);
        }

        protected ActionResult Create(
          long ContractorId,
          long ContactId,
          long LeadId,
          long SaleId,
          long RelationId,
          string start,
          string end,
          long scheduleId,
          Action<TRelationshipEntityModel> createAction = null)
        {
            if (!this.CreateElement(ContractorId, ContactId, LeadId, SaleId))
                throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для создания взаимоотношения"));
            if (SaleId == 0L && LeadId == 0L && ContactId == 0L && ContractorId == 0L)
                base.ActiveMenuItem = "SchedulerController.CalendarItems";
            TRelationshipEntityModel model = this.InitNewModel(default(TRelationshipEntity), EleWise.ELMA.Model.Views.ViewType.Create);
            DateTime result = DateTime.Now;
            if (DateTime.TryParse(start, out result))
                model.Entity.StartDate = result;
            if (DateTime.TryParse(end, out result))
                model.Entity.EndDate = result;
            if (scheduleId > 0L)
            {
                ISchedule schedule = (ISchedule)null;
                try
                {
                    schedule = ScheduleManager.Instance.LoadOrNull(scheduleId);
                }
                catch (Exception ex)
                {
                }
                if (schedule != null && schedule.Owner == null)
                    model.Entity.Schedules.Add(schedule);
            }
            if (RelationId > 0L)
            {
                IRelationship relationship = EntityManager<IRelationship>.Instance.Load((object)RelationId);
                if (relationship.Contact != null)
                {
                    ContactId = relationship.Contact.Id;
                    model.Link = RelationshipLink.Contact;
                }
                if (relationship.Contractor != null)
                {
                    ContractorId = relationship.Contractor.Id;
                    model.Link = RelationshipLink.Contractor;
                }
                if (relationship.Lead != null)
                {
                    LeadId = relationship.Lead.Id;
                    model.Link = RelationshipLink.Lead;
                }
                model.PrevRelationshipId = new long?(RelationId);
            }
            else
                model.LinkReadOnly = ContractorId > 0L || ContactId > 0L || LeadId > 0L || SaleId > 0L;
            if (ContractorId > 0L)
            {
                model.Entity.Contractor = ContractorManager.Instance.Load(ContractorId);
                model.Link = RelationshipLink.Contractor;
                ((Controller)this).SetCurrentMenuItem("crm-contractors");
            }
            if (ContactId > 0L)
            {
                model.Entity.Contact = ContactManager.Instance.Load(ContactId);
                model.Link = RelationshipLink.Contact;
                ((Controller)this).SetCurrentMenuItem("crm-contacts");
            }
            if (LeadId > 0L)
            {
                model.Entity.Lead = LeadManager.Instance.Load(LeadId);
                model.Link = RelationshipLink.Lead;
                ((Controller)this).SetCurrentMenuItem("crm-leads");
            }
            if (SaleId > 0L)
            {
                model.Entity.Sale = SaleManager.Instance.Load(SaleId);
                model.Entity.Contractor = model.Entity.Sale.Contractor;
                model.Link = RelationshipLink.Contractor;
                ((Controller)this).SetCurrentMenuItem("crm-salies");
            }
            if (createAction != null)
                createAction(model);
            return View((object)model);
        }

        protected ActionResult CreateMany(
          long[] contactsId,
          long[] contractorsId,
          long[] leadsId,
          long[] salesId)
        {
            TRelationshipEntityModel model = this.InitNewModel(default(TRelationshipEntity), EleWise.ELMA.Model.Views.ViewType.Create);
            model.IsMultiCreation = true;
            model.LinkReadOnly = true;
            if (contactsId != null)
            {
                if (contactsId.Length == 1)
                    return RedirectToAction("Create", (object)new
                    {
                        ContactId = contactsId[0]
                    });
                model.Contacts = (IList<IContact>)new List<IContact>();
                foreach (long id in contactsId)
                    model.Contacts.Add(ContactManager.Instance.Load(id));
                ((Controller)this).SetCurrentMenuItem("crm-contacts");
            }
            if (contractorsId != null)
            {
                if (contractorsId.Length == 1)
                    return RedirectToAction("Create", (object)new
                    {
                        ContractorId = contractorsId[0]
                    });
                model.Contractors = (IList<IContractor>)new List<IContractor>();
                foreach (long id in contractorsId)
                    model.Contractors.Add(ContractorManager.Instance.Load(id));
                ((Controller)this).SetCurrentMenuItem("crm-contractors");
            }
            if (leadsId != null)
            {
                if (leadsId.Length == 1)
                    return RedirectToAction("Create", (object)new
                    {
                        LeadId = leadsId[0]
                    });
                model.Leads = (IList<ILead>)new List<ILead>();
                foreach (long id in leadsId)
                    model.Leads.Add(LeadManager.Instance.Load(id));
                ((Controller)this).SetCurrentMenuItem("crm-leads");
            }
            if (salesId != null)
            {
                if (salesId.Length == 1)
                    return RedirectToAction("Create", (object)new
                    {
                        SalesId = salesId[0]
                    });
                model.Sales = (IList<ISale>)new List<ISale>();
                foreach (long id in salesId)
                    model.Sales.Add(SaleManager.Instance.Load(id));
                ((Controller)this).SetCurrentMenuItem("crm-salies");
            }
            return View("Create", (object)model);
        }

        [HttpPost]
        public virtual ActionResult CreateMany(TRelationshipEntityModel model)
        {
            this.CheckCreateElement(model);
            try
            {
                using (IUnitOfWork unitOfWork = this.UnitOfWorkManager.Create(string.Empty, true))
                {
                    model.Save();
                    this.EntityActionHandler.ActionExecuted(new EntityActionEventArgs((IEntity)null, (IEntity)model.Entity, "70c5300a-fafb-495c-bda9-4c5dc12cc8bd"));
                    unitOfWork.Commit();
                }
                // ISSUE: explicit non-virtual call
                Notifier.Information(this.GetSuccessfulSaveMvcNotification(model.Entities));
                if (model.Contacts != null)
                    return RedirectToAction("Index", "Contact");
                if (model.Contractors != null)
                    return RedirectToAction("Index", "Contractor");
                if (model.Leads != null)
                    return RedirectToAction("Index", "Lead");
                return model.Sales != null ? RedirectToAction("Index", "Sale") : RedirectToAction("Index", "Contractor");
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
        public virtual ActionResult Create(TRelationshipEntityModel model)
        {
            this.CheckCreateElement(model);
            try
            {
                this.FillContractorClients(model);
                this.FillLeadContacts(model);
                model.Save();
                this.EntityActionHandler.ActionExecuted(new EntityActionEventArgs((IEntity)null, (IEntity)model.Entity, "70c5300a-fafb-495c-bda9-4c5dc12cc8bd"));
                // ISSUE: explicit non-virtual call
                Notifier.Information(this.GetSuccessfulSaveMvcNotification(model.Entity));
                if (IsCustomViewRequest())
                    return HandleCustomViewJsonCallback((IEntity)model.Entity);
                return model.Entity.Contractor == null && model.Entity.Contact == null && model.Entity.Lead == null && model.Entity.Sale == null ? (!((BaseController)this).IsCreatorRequest() ? RedirectToAction("Index", "Scheduler", "EleWise.ELMA.BPM.Web.Calendar") : ((BaseController)this).CreatorJson((IEntity)model.Entity)) : (!((BaseController)this).IsCreatorRequest() ? RedirectToAction("Details", (object)new
                {
                    id = model.Entity.Id
                }) : ((BaseController)this).CreatorJson((IEntity)model.Entity));
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return !((BaseController)this).IsCreatorRequest() ? View((object)model) : ((BaseController)this).CreatorJson((IEntity)null, ex.Message);
            }
        }

        private void FillContractorClients(TRelationshipEntityModel model)
        {
            model.Entity.ContractorsContacts.Clear();
            if (model.ContractorContacts == null)
                return;
            model.Entity.ContractorsContacts.AddAll((ICollection<IContact>)model.ContractorContacts);
        }

        private void FillLeadContacts(TRelationshipEntityModel model)
        {
            model.Entity.LeadContacts.Clear();
            if (model.LeadContacts == null)
                return;
            model.Entity.LeadContacts.AddAll((ICollection<ILeadContact>)model.LeadContacts);
        }

        [DetailsAction]
        [EntityLink]
        public virtual ActionResult Details(long id)
        {
            try
            {
                TRelationshipEntityModel model = this.InitNewModel(base.Manager.Load(id), EleWise.ELMA.Model.Views.ViewType.Display);
                ThrowExceptionIfDeleted((ISoftDeletable)model.Entity);
                if (model.Entity.Contractor != null)
                    ((Controller)this).SetCurrentMenuItem("crm-contractors");
                else if (model.Entity.Contact != null)
                    ((Controller)this).SetCurrentMenuItem("crm-contacts");
                else if (model.Entity.Lead != null)
                    ((Controller)this).SetCurrentMenuItem("crm-leads");
                else if (model.Entity.Sale != null)
                    ((Controller)this).SetCurrentMenuItem("crm-salies");
                else
                    base.ActiveMenuItem = "SchedulerController.CalendarItems";
                ((BaseController)this).SetAsReadForFeed((IEntity)model.Entity);
                return model.PrivateAccess ? View("RelationshipIsPrivate", (object)model) : View((object)model);
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return Redirect(((Controller)this).Url.ReturnUrl(true));
            }
        }

        public virtual ActionResult Edit(long id)
        {
            try
            {
                TRelationshipEntity relationshipEntity = AbstractNHEntityManager<TRelationshipEntity, long>.Instance.Load(id);
                ThrowExceptionIfDeleted((ISoftDeletable)relationshipEntity);
                // ISSUE: explicit non-virtual call
                if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, (object)relationshipEntity))
                {
                    // ISSUE: explicit non-virtual call
                    Notifier.Error(EleWise.ELMA.SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
                    return RedirectToAction("Details", (object)new
                    {
                        id = id
                    });
                }
                TRelationshipEntityModel model = this.InitNewModel(relationshipEntity, EleWise.ELMA.Model.Views.ViewType.Edit);
                RelationshipLink relationshipLink = RelationshipLink.Contractor;
                if (relationshipEntity.Contractor != null)
                {
                    model.PrevContractorId = new long?(relationshipEntity.Contractor.Id);
                    foreach (IContact contractorsContact in (IEnumerable<IContact>)relationshipEntity.ContractorsContacts)
                        model.PrevContractorContactsIds.Add(contractorsContact.Id);
                    relationshipLink = RelationshipLink.Contractor;
                }
                else if (relationshipEntity.Contact != null)
                {
                    model.PrevContactId = new long?(relationshipEntity.Contact.Id);
                    relationshipLink = RelationshipLink.Contact;
                }
                else if (relationshipEntity.Lead != null)
                {
                    model.PrevLeadId = new long?(relationshipEntity.Lead.Id);
                    relationshipLink = RelationshipLink.Lead;
                }
                else
                    base.ActiveMenuItem = "SchedulerController.CalendarItems";
                model.Link = relationshipLink;
                return model.PrivateAccess ? View("RelationshipIsPrivate", (object)model) : View((object)model);
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
        public virtual ActionResult Edit(TRelationshipEntityModel model)
        {
            this.CheckCreateElement(model);
            try
            {
                this.FillContractorClients(model);
                this.FillLeadContacts(model);
                model.Save();
                this.EntityActionHandler.ActionExecuted(new EntityActionEventArgs((IEntity)null, (IEntity)model.Entity, "687e895b-0cae-42e1-b882-e431b66535ae"));
                // ISSUE: explicit non-virtual call
                Notifier.Information(this.GetSuccessfulSaveMvcNotification(model.Entity));
                return model.Entity.Contractor == null && model.Entity.Contact == null && model.Entity.Lead == null && model.Entity.Sale == null ? RedirectToAction("Index", "Scheduler", "EleWise.ELMA.BPM.Web.Calendar") : RedirectToAction("Details", (object)new
                {
                    id = model.Entity.Id
                });
            }
            catch (Exception ex)
            {
                Notifier.Error(ex);
                return View((object)model);
            }
        }

        public ActionResult AddComment(long id) => (ActionResult)null;

        [HttpGet]
        [TransactionAction]
        public virtual ActionResult Delete(long id)
        {
            try
            {
                TRelationshipEntity relationshipEntity = base.Manager.Load(id);
                if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, (object)relationshipEntity) || !base.SecurityService.HasPermission(CRMPermissionProvider.CRMDeletePermission))
                {
                    Notifier.Error(EleWise.ELMA.SR.T("Текущий пользователь не имеет прав на удаление взаимоотношения"));
                    return RedirectToAction("Index", "Contractor");
                }
                IEntity<long> currentParentEntity;
                RelationshipManager.Instance.DeleteRelationship((IRelationship)relationshipEntity, out currentParentEntity);

                Notifier.Information(this.GetSuccessfulDeleteMvcNotification(relationshipEntity));
                return (currentParentEntity != null) ? ((ActionResult)Redirect(base.Url.Entity(currentParentEntity))) : ((ActionResult)RedirectToAction("Index", "Scheduler", "EleWise.ELMA.BPM.Web.Calendar"));
            }
            catch (Exception ex)
            {
                Notifier.Error(ex);
                return RedirectToAction("Index", "Contractor");
            }
        }

        [HttpPost]
        public ActionResult Complete(
          RelationshipCompleteModel relationshipCompleteModel)
        {
            if (!base.SecurityService.HasPermission(CRMPermissionProvider.ExecuteRelationshipPermission, (object)base.Manager.Load(relationshipCompleteModel.EntityId)))
            {
                Notifier.Error(EleWise.ELMA.SR.T("Текущий пользователь не имеет прав на выполнение взаимоотношения"));
                return Redirect(relationshipCompleteModel.RedirectUrl);
            }
            RelationshipManager.Instance.Complete(relationshipCompleteModel.EntityId, relationshipCompleteModel.Comment);
            switch (relationshipCompleteModel.Mode - 1L)
            {
                case 0:
                    return RedirectToAction("Create", "RelationshipCall", (object)new
                    {
                        RelationId = relationshipCompleteModel.EntityId
                    });
                case 1:
                    return RedirectToAction("Create", "RelationshipMeeting", (object)new
                    {
                        RelationId = relationshipCompleteModel.EntityId
                    });
                case 2:
                    return RedirectToAction("Create", "RelationshipMail", (object)new
                    {
                        RelationId = relationshipCompleteModel.EntityId
                    });
                case 3:
                    IRelationship relationship1 = RelationshipManager.Instance.Load(relationshipCompleteModel.EntityId);
                    if (relationship1.Contractor != null)
                        return RedirectToAction("Create", "Sale", (object)new
                        {
                            contractorId = relationship1.Contractor.Id
                        });
                    break;
                case 4:
                    IRelationship relationship2 = RelationshipManager.Instance.Load(relationshipCompleteModel.EntityId);
                    if (relationship2.Lead == null)
                        throw new Exception(EleWise.ELMA.SR.T("Не указан потенциальный клиент"));
                    return RedirectToAction("Convert", "Lead", (object)new
                    {
                        id = relationship2.Lead.Id
                    });
            }
            return Redirect(relationshipCompleteModel.RedirectUrl);
        }

        [HttpPost]
        public ActionResult AddDay(RelationshipAddDayModel relationshipAddDayModel)
        {
            if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, (object)base.Manager.Load(relationshipAddDayModel.EntityId)))
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
                return Redirect(relationshipAddDayModel.RedirectUrl);
            }
            if (relationshipAddDayModel.UseDates)
                this.RelationshipManager.ChangeTime(relationshipAddDayModel.EntityId, relationshipAddDayModel.StartDate, new DateTime?(relationshipAddDayModel.EndDate), relationshipAddDayModel.Comment);
            else
                this.RelationshipManager.AddDay(relationshipAddDayModel.EntityId, relationshipAddDayModel.Comment);
            return Redirect(relationshipAddDayModel.RedirectUrl);
        }

        [HttpPost]
        public ActionResult ChangeTime(
          RelationshipChangeTimeModel relationshipChangeTimeModel)
        {
            if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, (object)base.Manager.Load(relationshipChangeTimeModel.EntityId)))
            {
                Notifier.Error(EleWise.ELMA.SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
                return Redirect(relationshipChangeTimeModel.RedirectUrl);
            }
            RelationshipManager.Instance.ChangeTime(relationshipChangeTimeModel.EntityId, relationshipChangeTimeModel.StartDate, relationshipChangeTimeModel.EndDate, relationshipChangeTimeModel.Comment);
            return Redirect(relationshipChangeTimeModel.RedirectUrl);
        }

        [Obsolete("Метод устарел, используйте GetSuccessfulSaveMvcNotification", true)]
        public virtual string GetSuccessfulSaveNotification(TRelationshipEntity entity) => string.Empty;

        [Obsolete("Используйте GetSuccessfulSaveMvcNotification")]
        private MvcHtmlString GetSuccessfulSaveObsNotification(TRelationshipEntity entity) => MvcHtmlString.Create(this.GetSuccessfulSaveNotification(entity).HtmlEncode());

        public virtual MvcHtmlString GetSuccessfulSaveMvcNotification(TRelationshipEntity entity) => this.GetSuccessfulSaveObsNotification(entity);

        public MvcHtmlString GetSuccessfulSaveMvcNotification(IEnumerable<TRelationshipEntity> entities) => MvcHtmlString.Create(string.Join<MvcHtmlString>("<br/>", entities.Select<TRelationshipEntity, MvcHtmlString>(new Func<TRelationshipEntity, MvcHtmlString>(this.GetSuccessfulSaveMvcNotification))));

        [Obsolete("Метод устарел, используйте GetSuccessfulSaveMvcNotification", true)]
        public virtual string GetSuccessfulDeleteNotification(TRelationshipEntity entity) => string.Empty;

        [Obsolete("Используйте GetSuccessfulSaveMvcNotification")]
        private MvcHtmlString GetSuccessfulDeleteObsNotification(TRelationshipEntity entity) => MvcHtmlString.Create(this.GetSuccessfulDeleteNotification(entity).HtmlEncode());

        public virtual MvcHtmlString GetSuccessfulDeleteMvcNotification(TRelationshipEntity entity) => this.GetSuccessfulDeleteObsNotification(entity);

        private void CheckCreateElement(TRelationshipEntityModel model)
        {
            if (model.IsMultiCreation)
            {
                if (model.Contractors != null)
                {
                    foreach (IEntity<long> contractor in (IEnumerable<IContractor>)model.Contractors)
                        this.CreateElement(contractor.Id);
                }
                if (model.Leads != null)
                {
                    foreach (IEntity<long> lead in (IEnumerable<ILead>)model.Leads)
                        this.CreateElement(LeadId: lead.Id);
                }
                if (model.Sales != null)
                {
                    foreach (IEntity<long> sale in (IEnumerable<ISale>)model.Sales)
                        this.CreateElement(SaleId: sale.Id);
                }
                if (model.Contacts == null)
                    return;
                foreach (IEntity<long> contact in (IEnumerable<IContact>)model.Contacts)
                    this.CreateElement(ContactId: contact.Id);
            }
            else
            {
                long ContractorId = model.Entity.Contractor != null ? model.Entity.Contractor.Id : 0L;
                long ContactId = model.Entity.Contact != null ? model.Entity.Contact.Id : 0L;
                long LeadId = model.Entity.Lead != null ? model.Entity.Lead.Id : 0L;
                long SaleId = model.Entity.Sale != null ? model.Entity.Sale.Id : 0L;
                if (!model.LinkReadOnly)
                {
                    switch (model.Link)
                    {
                        case RelationshipLink.Contractor:
                            ContactId = 0L;
                            LeadId = 0L;
                            break;
                        case RelationshipLink.Contact:
                            ContractorId = 0L;
                            LeadId = 0L;
                            SaleId = 0L;
                            break;
                        case RelationshipLink.Lead:
                            ContractorId = 0L;
                            ContactId = 0L;
                            SaleId = 0L;
                            break;
                    }
                }
                if (!this.CreateElement(ContractorId, ContactId, LeadId, SaleId))
                    throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для создания взаимоотношения"));
            }
        }

        private bool CreateElement(long ContractorId = 0, long ContactId = 0, long LeadId = 0, long SaleId = 0)
        {
            if (SaleId > 0L)
            {
                ISale target = SaleManager.Instance.LoadOrNull(SaleId);
                if (target != null)
                {
                    // ISSUE: explicit non-virtual call
                    int num = target.SaleStatus == SaleStatus.NegativeClosed || target.SaleStatus == SaleStatus.PositiveClosed ? 0 : (base.SecurityService.HasPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, (object)target) ? 1 : 0);
                    if (num != 0)
                        return num != 0;
                    throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для привязки взаимоотношения к сделке"));
                }
            }
            else if (ContractorId > 0L)
            {
                IContractor target = ContractorManager.Instance.LoadOrNull(ContractorId);
                if (target != null)
                {
                    // ISSUE: explicit non-virtual call
                    int num = base.SecurityService.HasPermission(CRMPermissionProvider.CRMContractorCreateElementPermission, (object)target) ? 1 : 0;
                    if (num != 0)
                        return num != 0;
                    throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для привязки взаимоотношения к контрагенту"));
                }
            }
            else
            {
                if (ContactId > 0L)
                {
                    IContact target = ContactManager.Instance.LoadOrNull(ContactId);
                    // ISSUE: explicit non-virtual call
                    int num = base.SecurityService.HasPermission(CRMPermissionProvider.CRMContactCreateElementPermission, (object)target) ? 1 : 0;
                    if (num != 0)
                        return num != 0;
                    throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для привязки взаимоотношения к контакту."));
                }
                if (LeadId > 0L)
                {
                    ILead target = LeadManager.Instance.LoadOrNull(LeadId);
                    // ISSUE: explicit non-virtual call
                    int num = base.SecurityService.HasPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, (object)target) ? 1 : 0;
                    if (num != 0)
                        return num != 0;
                    throw new SecurityException(EleWise.ELMA.SR.T("Недостаточно прав для привязки взаимоотношения к потенциальному клиенту"));
                }
            }
            return true;
        }
    }
}
