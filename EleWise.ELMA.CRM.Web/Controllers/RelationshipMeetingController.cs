// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.RelationshipMeetingController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class RelationshipMeetingController :
      RelationshipControllerAbstract<IRelationshipMeeting, RelationshipMeetingModel>
    {
        [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
        public ActionResult CreatePopup(
          [ParameterContainer] IRelationshipMeeting meeting,
          Guid? formUid = null,
          EleWise.ELMA.Model.Views.ViewType? viewType = null,
          bool formReadOnly = false,
          string parentFormId = "",
          string formId = "")
        {
            RelationshipMeetingModel relationshipMeetingModel = new RelationshipMeetingModel(meeting, viewType.HasValue ? viewType.Value : EleWise.ELMA.Model.Views.ViewType.Create);
            relationshipMeetingModel.FormUid = formUid;
            relationshipMeetingModel.FormReadOnly = formReadOnly;
            relationshipMeetingModel.FormId = formId;
            RelationshipMeetingModel model = relationshipMeetingModel;
            this.InitNewModel(model);
            model.DynamicFormSettings.ParentFormId = parentFormId;
            DynamicFormSettings dynamicFormSettings = model.DynamicFormSettings;
            dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + (object)model.View.Uid;
            return PartialView("RelationshipMeeting/RelationshipMeetingEditForm", (object)model);
        }

        [RelationshipCreate(Name = "SR.M('Встречу')", ImageUrl = "#users.svg", SmallImageUrl = "#users.svg", ToActions = true)]
        [ContentItem(Name = "SR.M('Встречу')", Image24 = "#users.svg", Id = "crm-create-meeting")]
        public ActionResult Create(long ContractorId = 0L, long ContactId = 0L, long LeadId = 0L, long SaleId = 0L, long RelationId = 0L, string start = "", string end = "", long schedule = 0L)
        {
            if (SaleId == 0L && LeadId == 0L && ContactId == 0L && ContractorId == 0L)
            {
                base.ActiveMenuItem = "SchedulerController.CalendarItems";
            }
            return Create(ContractorId, ContactId, LeadId, SaleId, RelationId, TZ.ToRuntimeDateTimeFromClient(start), TZ.ToRuntimeDateTimeFromClient(end), schedule, null);
        }

        protected override RelationshipMeetingModel InitNewModel(
          IRelationshipMeeting entity,
          EleWise.ELMA.Model.Views.ViewType viewType)
        {
            return entity != null ? new RelationshipMeetingModel(entity, viewType) : new RelationshipMeetingModel(viewType);
        }

        public new ActionResult CreateMany(
          long[] contactsId,
          long[] contractorsId,
          long[] leadsId,
          long[] salesId)
        {
            return base.CreateMany(contactsId, contractorsId, leadsId, salesId);
        }

        public override MvcHtmlString GetSuccessfulSaveMvcNotification(IRelationshipMeeting entity)
        {
            string str = ((Controller)this).Url.Entity((IEntity)entity);
            return MvcHtmlString.Create(EleWise.ELMA.SR.T("Встреча <a href=\"{1}\">{0}</a> сохранена успешно", (object)entity.Theme.HtmlEncode(), (object)str));
        }

        public override MvcHtmlString GetSuccessfulDeleteMvcNotification(IRelationshipMeeting entity) => MvcHtmlString.Create(EleWise.ELMA.SR.T("Встреча \"{0}\" успешно удалена", (object)entity.Theme.HtmlEncode()));

        public override ActionResult Create(RelationshipMeetingModel model)
        {
            model.BindSchedules(model.AllowSchedules);
            RelationshipMeetingManager.Instance.ClarifyTime(model.Entity);
            return base.Create(model);
        }

        public override ActionResult Edit(RelationshipMeetingModel model)
        {
            model.BindSchedules(model.AllowSchedules);
            RelationshipMeetingManager.Instance.ClarifyTime(model.Entity);
            return base.Edit(model);
        }

        public override ActionResult Edit(long id)
        {
            try
            {
                IRelationshipMeeting relationshipMeeting = AbstractNHEntityManager<IRelationshipMeeting, long>.Instance.Load(id);
                ThrowExceptionIfDeleted((ISoftDeletable)relationshipMeeting);
                if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, (object)relationshipMeeting))
                {
                    Notifier.Error(EleWise.ELMA.SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
                    return RedirectToAction("Details", (object)new
                    {
                        id = id
                    });
                }
                RelationshipMeetingModel model = this.InitNewModel(relationshipMeeting, EleWise.ELMA.Model.Views.ViewType.Edit);
                RelationshipLink relationshipLink = RelationshipLink.Contractor;
                if (relationshipMeeting.Contractor != null)
                {
                    model.PrevContractorId = new long?(relationshipMeeting.Contractor.Id);
                    foreach (IContact contractorsContact in (IEnumerable<IContact>)relationshipMeeting.ContractorsContacts)
                        model.PrevContractorContactsIds.Add(contractorsContact.Id);
                    relationshipLink = RelationshipLink.Contractor;
                }
                else if (relationshipMeeting.Contact != null)
                {
                    model.PrevContactId = new long?(relationshipMeeting.Contact.Id);
                    relationshipLink = RelationshipLink.Contact;
                }
                else if (relationshipMeeting.Lead != null)
                {
                    model.PrevLeadId = new long?(relationshipMeeting.Lead.Id);
                    relationshipLink = RelationshipLink.Lead;
                }
                else
                    base.ActiveMenuItem = "SchedulerController.CalendarItems";

                model.Link = relationshipLink;
                model.WholeDay = relationshipMeeting.StartDate.TimeOfDay == new TimeSpan(0, 0, 10) && relationshipMeeting.EndDate.TimeOfDay == new TimeSpan(23, 59, 50);
                return View((object)model);
            }
            catch (Exception ex)
            {
                Notifier.Error(ex);
                return RedirectToAction("Index", "Contractor");
            }
        }

        [DetailsAction]
        [EntityLink]
        public override ActionResult Details(long id)
        {
            try
            {
                RelationshipMeetingModel model = this.InitNewModel(base.Manager.Load(id), EleWise.ELMA.Model.Views.ViewType.Display);
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
                model.WholeDay = model.Entity.StartDate.TimeOfDay == new TimeSpan(0, 0, 10) && model.Entity.EndDate.TimeOfDay == new TimeSpan(23, 59, 50);
                return model.PrivateAccess ? View("RelationshipIsPrivate", (object)model) : View((object)model);
            }
            catch (Exception ex)
            {
                Notifier.Error(ex);
                return Redirect(((Controller)this).Url.ReturnUrl(true));
            }
        }
    }
}
