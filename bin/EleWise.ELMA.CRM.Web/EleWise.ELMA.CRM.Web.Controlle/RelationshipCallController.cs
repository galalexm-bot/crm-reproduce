using System;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
[RouteArea("EleWise.ELMA.CRM.Web")]
public class RelationshipCallController : RelationshipControllerAbstract<IRelationshipCall, RelationshipCallModel>
{
	[EntityForm("Create", "EleWise.ELMA.CRM.Web")]
	public ActionResult CreatePopup([ParameterContainer] IRelationshipCall call, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		RelationshipCallModel relationshipCallModel = new RelationshipCallModel(call, (!viewType.HasValue) ? ViewType.Create : viewType.Value)
		{
			FormUid = formUid,
			FormReadOnly = formReadOnly,
			FormId = formId
		};
		InitNewModel(relationshipCallModel);
		relationshipCallModel.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = relationshipCallModel.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + relationshipCallModel.View.Uid;
		return (ActionResult)(object)((Controller)this).PartialView("RelationshipCall/RelationshipCallEditForm", (object)relationshipCallModel);
	}

	[RelationshipCreate(Name = "SR.M('Звонок')", ImageUrl = "#add_call.svg")]
	[ContentItem(Name = "SR.M('Звонок')", Image24 = "#add_call.svg", Id = "crm-create-ring")]
	public ActionResult Create(long ContractorId = 0L, long ContactId = 0L, long LeadId = 0L, long SaleId = 0L, long RelationId = 0L, string start = "", string end = "", string uniqueId = "", RelationshipCallType calltype = RelationshipCallType.Output)
	{
		return Create(ContractorId, ContactId, LeadId, SaleId, RelationId, TZ.ToRuntimeDateTimeFromClient(start), TZ.ToRuntimeDateTimeFromClient(end), delegate(RelationshipCallModel model)
		{
			if (model.Entity != null)
			{
				model.Entity.Type = calltype;
				model.Entity.UniqueId = uniqueId;
			}
		});
	}

	protected override RelationshipCallModel InitNewModel(IRelationshipCall entity, ViewType viewType)
	{
		if (entity != null)
		{
			return new RelationshipCallModel(entity, viewType);
		}
		return new RelationshipCallModel(viewType);
	}

	public new ActionResult CreateMany(long[] contactsId, long[] contractorsId, long[] leadsId, long[] salesId)
	{
		return base.CreateMany(contactsId, contractorsId, leadsId, salesId);
	}

	public override MvcHtmlString GetSuccessfulSaveMvcNotification(IRelationshipCall entity)
	{
		string text = ((Controller)this).get_Url().Entity(entity);
		return MvcHtmlString.Create(SR.T("Звонок <a href=\"{1}\">{0}</a> сохранен успешно", entity.Theme.HtmlEncode(), text));
	}

	public override MvcHtmlString GetSuccessfulDeleteMvcNotification(IRelationshipCall entity)
	{
		return MvcHtmlString.Create(SR.T("Звонок \"{0}\" успешно удален", entity.Theme.HtmlEncode()));
	}
}
