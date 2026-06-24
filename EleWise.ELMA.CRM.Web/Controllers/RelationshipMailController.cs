// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.RelationshipMailController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
  [RouteArea("EleWise.ELMA.CRM.Web")]
  public class RelationshipMailController : 
    RelationshipControllerAbstract<IRelationshipMail, RelationshipMailModel>
  {
    [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
    public ActionResult CreatePopup(
      [ParameterContainer] IRelationshipMail mail,
      Guid? formUid = null,
      EleWise.ELMA.Model.Views.ViewType? viewType = null,
      bool formReadOnly = false,
      string parentFormId = "",
      string formId = "")
    {
      RelationshipMailModel relationshipMailModel = new RelationshipMailModel(mail, viewType.HasValue ? viewType.Value : EleWise.ELMA.Model.Views.ViewType.Create);
      relationshipMailModel.FormUid = formUid;
      relationshipMailModel.FormReadOnly = formReadOnly;
      relationshipMailModel.FormId = formId;
      RelationshipMailModel model = relationshipMailModel;
      this.InitNewModel(model);
      model.DynamicFormSettings.ParentFormId = parentFormId;
      DynamicFormSettings dynamicFormSettings = model.DynamicFormSettings;
      dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + (object) model.View.Uid;
      return PartialView("RelationshipMail/RelationshipMailEditForm", (object) model);
    }

    [RelationshipCreate(Name = "SR.M('Письмо')", ImageUrl = "#add_message.svg", SmallImageUrl = "#add_message.svg", ToActions = true)]
    [ContentItem(Name = "SR.M('Письмо')", Image24 = "#add_message.svg", Id = "crm-create-mail")]
    public ActionResult Create(
      long ContractorId = 0,
      long ContactId = 0,
      long LeadId = 0,
      long SaleId = 0,
      long RelationId = 0,
      string start = "",
      string end = "")
    {
      return this.Create(ContractorId, ContactId, LeadId, SaleId, RelationId, TZ.ToRuntimeDateTimeFromClient(start), TZ.ToRuntimeDateTimeFromClient(end), (Action<RelationshipMailModel>) null);
    }

    protected override RelationshipMailModel InitNewModel(
      IRelationshipMail entity,
      EleWise.ELMA.Model.Views.ViewType viewType)
    {
      return entity != null ? new RelationshipMailModel(entity, viewType) : new RelationshipMailModel(viewType);
    }

    public new ActionResult CreateMany(
      long[] contactsId,
      long[] contractorsId,
      long[] leadsId,
      long[] salesId)
    {
      return base.CreateMany(contactsId, contractorsId, leadsId, salesId);
    }

    public override MvcHtmlString GetSuccessfulSaveMvcNotification(IRelationshipMail entity)
    {
      string str = ((Controller) this).Url.Entity((IEntity) entity);
      return MvcHtmlString.Create(EleWise.ELMA.SR.T("Письмо <a href=\"{1}\">{0}</a> сохранено успешно", (object) entity.Theme.HtmlEncode(), (object) str));
    }

    public override MvcHtmlString GetSuccessfulDeleteMvcNotification(IRelationshipMail entity) => MvcHtmlString.Create(EleWise.ELMA.SR.T("Письмо \"{0}\" успешно удалено", (object) entity.Theme.HtmlEncode()));
  }
}
