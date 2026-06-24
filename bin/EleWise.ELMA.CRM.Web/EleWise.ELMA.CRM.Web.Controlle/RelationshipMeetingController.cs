using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
[RouteArea("EleWise.ELMA.CRM.Web")]
public class RelationshipMeetingController : RelationshipControllerAbstract<IRelationshipMeeting, RelationshipMeetingModel>
{
	[EntityForm("Create", "EleWise.ELMA.CRM.Web")]
	public ActionResult CreatePopup([ParameterContainer] IRelationshipMeeting meeting, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		RelationshipMeetingModel relationshipMeetingModel = new RelationshipMeetingModel(meeting, (!viewType.HasValue) ? ViewType.Create : viewType.Value)
		{
			FormUid = formUid,
			FormReadOnly = formReadOnly,
			FormId = formId
		};
		InitNewModel(relationshipMeetingModel);
		relationshipMeetingModel.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = relationshipMeetingModel.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + relationshipMeetingModel.View.Uid;
		return (ActionResult)(object)((Controller)this).PartialView("RelationshipMeeting/RelationshipMeetingEditForm", (object)relationshipMeetingModel);
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

	protected override RelationshipMeetingModel InitNewModel(IRelationshipMeeting entity, ViewType viewType)
	{
		if (entity != null)
		{
			return new RelationshipMeetingModel(entity, viewType);
		}
		return new RelationshipMeetingModel(viewType);
	}

	public new ActionResult CreateMany(long[] contactsId, long[] contractorsId, long[] leadsId, long[] salesId)
	{
		return base.CreateMany(contactsId, contractorsId, leadsId, salesId);
	}

	public override MvcHtmlString GetSuccessfulSaveMvcNotification(IRelationshipMeeting entity)
	{
		string text = ((Controller)this).get_Url().Entity(entity);
		return MvcHtmlString.Create(SR.T("Встреча <a href=\"{1}\">{0}</a> сохранена успешно", entity.Theme.HtmlEncode(), text));
	}

	public override MvcHtmlString GetSuccessfulDeleteMvcNotification(IRelationshipMeeting entity)
	{
		return MvcHtmlString.Create(SR.T("Встреча \"{0}\" успешно удалена", entity.Theme.HtmlEncode()));
	}

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
			ThrowExceptionIfDeleted(relationshipMeeting);
			if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, relationshipMeeting))
			{
				base.Notifier.Error(SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
				return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { id });
			}
			RelationshipMeetingModel relationshipMeetingModel = InitNewModel(relationshipMeeting, ViewType.Edit);
			RelationshipLink link = RelationshipLink.Contractor;
			if (relationshipMeeting.Contractor != null)
			{
				relationshipMeetingModel.PrevContractorId = relationshipMeeting.Contractor.Id;
				foreach (IContact item in (IEnumerable<IContact>)relationshipMeeting.ContractorsContacts)
				{
					relationshipMeetingModel.PrevContractorContactsIds.Add(item.Id);
				}
				link = RelationshipLink.Contractor;
			}
			else if (relationshipMeeting.Contact != null)
			{
				relationshipMeetingModel.PrevContactId = relationshipMeeting.Contact.Id;
				link = RelationshipLink.Contact;
			}
			else if (relationshipMeeting.Lead != null)
			{
				relationshipMeetingModel.PrevLeadId = relationshipMeeting.Lead.Id;
				link = RelationshipLink.Lead;
			}
			else
			{
				base.ActiveMenuItem = "SchedulerController.CalendarItems";
			}
			relationshipMeetingModel.Link = link;
			relationshipMeetingModel.WholeDay = relationshipMeeting.StartDate.TimeOfDay == new TimeSpan(0, 0, 10) && relationshipMeeting.EndDate.TimeOfDay == new TimeSpan(23, 59, 50);
			return (ActionResult)(object)((Controller)this).View((object)relationshipMeetingModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Contractor");
		}
	}

	[DetailsAction]
	[EntityLink]
	public override ActionResult Details(long id)
	{
		try
		{
			RelationshipMeetingModel relationshipMeetingModel = InitNewModel(base.Manager.Load(id), ViewType.Display);
			ThrowExceptionIfDeleted(relationshipMeetingModel.Entity);
			if (relationshipMeetingModel.Entity.Contractor != null)
			{
				((Controller)(object)this).SetCurrentMenuItem("crm-contractors");
			}
			else if (relationshipMeetingModel.Entity.Contact != null)
			{
				((Controller)(object)this).SetCurrentMenuItem("crm-contacts");
			}
			else if (relationshipMeetingModel.Entity.Lead != null)
			{
				((Controller)(object)this).SetCurrentMenuItem("crm-leads");
			}
			else if (relationshipMeetingModel.Entity.Sale != null)
			{
				((Controller)(object)this).SetCurrentMenuItem("crm-salies");
			}
			else
			{
				base.ActiveMenuItem = "SchedulerController.CalendarItems";
			}
			SetAsReadForFeed(relationshipMeetingModel.Entity);
			relationshipMeetingModel.WholeDay = relationshipMeetingModel.Entity.StartDate.TimeOfDay == new TimeSpan(0, 0, 10) && relationshipMeetingModel.Entity.EndDate.TimeOfDay == new TimeSpan(23, 59, 50);
			if (relationshipMeetingModel.PrivateAccess)
			{
				return (ActionResult)(object)((Controller)this).View("RelationshipIsPrivate", (object)relationshipMeetingModel);
			}
			return (ActionResult)(object)((Controller)this).View((object)relationshipMeetingModel);
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
		}
	}
}
