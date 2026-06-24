using System;
using System.Web.Mvc;
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
public class RelationshipMailController : RelationshipControllerAbstract<IRelationshipMail, RelationshipMailModel>
{
	[EntityForm("Create", "EleWise.ELMA.CRM.Web")]
	public ActionResult CreatePopup([ParameterContainer] IRelationshipMail mail, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		RelationshipMailModel relationshipMailModel = new RelationshipMailModel(mail, (!viewType.HasValue) ? ViewType.Create : viewType.Value)
		{
			FormUid = formUid,
			FormReadOnly = formReadOnly,
			FormId = formId
		};
		InitNewModel(relationshipMailModel);
		relationshipMailModel.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = relationshipMailModel.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + relationshipMailModel.View.Uid;
		return (ActionResult)(object)((Controller)this).PartialView("RelationshipMail/RelationshipMailEditForm", (object)relationshipMailModel);
	}

	[RelationshipCreate(Name = "SR.M('Письмо')", ImageUrl = "#add_message.svg", SmallImageUrl = "#add_message.svg", ToActions = true)]
	[ContentItem(Name = "SR.M('Письмо')", Image24 = "#add_message.svg", Id = "crm-create-mail")]
	public ActionResult Create(long ContractorId = 0L, long ContactId = 0L, long LeadId = 0L, long SaleId = 0L, long RelationId = 0L, string start = "", string end = "")
	{
		return Create(ContractorId, ContactId, LeadId, SaleId, RelationId, TZ.ToRuntimeDateTimeFromClient(start), TZ.ToRuntimeDateTimeFromClient(end), null);
	}

	protected override RelationshipMailModel InitNewModel(IRelationshipMail entity, ViewType viewType)
	{
		if (entity != null)
		{
			return new RelationshipMailModel(entity, viewType);
		}
		return new RelationshipMailModel(viewType);
	}

	public new ActionResult CreateMany(long[] contactsId, long[] contractorsId, long[] leadsId, long[] salesId)
	{
		return base.CreateMany(contactsId, contractorsId, leadsId, salesId);
	}

	public override MvcHtmlString GetSuccessfulSaveMvcNotification(IRelationshipMail entity)
	{
		string text = ((Controller)this).get_Url().Entity(entity);
		return MvcHtmlString.Create(SR.T("Письмо <a href=\"{1}\">{0}</a> сохранено успешно", entity.Theme.HtmlEncode(), text));
	}

	public override MvcHtmlString GetSuccessfulDeleteMvcNotification(IRelationshipMail entity)
	{
		return MvcHtmlString.Create(SR.T("Письмо \"{0}\" успешно удалено", entity.Theme.HtmlEncode()));
	}
}
