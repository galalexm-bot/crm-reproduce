// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.RelationshipCallController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Enums;
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
  public class RelationshipCallController : RelationshipControllerAbstract<IRelationshipCall, RelationshipCallModel>
  {
    [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
    public ActionResult CreatePopup(
      [ParameterContainer] IRelationshipCall call,
      Guid? formUid = null,
      EleWise.ELMA.Model.Views.ViewType? viewType = null,
      bool formReadOnly = false,
      string parentFormId = "",
      string formId = "")
    {
      RelationshipCallModel relationshipCallModel = new RelationshipCallModel(call, viewType.HasValue ? viewType.Value : EleWise.ELMA.Model.Views.ViewType.Create);
      relationshipCallModel.FormUid = formUid;
      relationshipCallModel.FormReadOnly = formReadOnly;
      relationshipCallModel.FormId = formId;
      RelationshipCallModel model = relationshipCallModel;
      this.InitNewModel(model);
      model.DynamicFormSettings.ParentFormId = parentFormId;
      DynamicFormSettings dynamicFormSettings = model.DynamicFormSettings;
      dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + (object) model.View.Uid;
      return PartialView("RelationshipCall/RelationshipCallEditForm", (object) model);
    }

    [RelationshipCreate(Name = "SR.M('Звонок')", ImageUrl = "#add_call.svg")]
    [ContentItem(Name = "SR.M('Звонок')", Image24 = "#add_call.svg", Id = "crm-create-ring")]
    public ActionResult Create(
      long ContractorId = 0,
      long ContactId = 0,
      long LeadId = 0,
      long SaleId = 0,
      long RelationId = 0,
      string start = "",
      string end = "",
      string uniqueId = "",
      RelationshipCallType calltype = RelationshipCallType.Output)
    {
      return this.Create(ContractorId, ContactId, LeadId, SaleId, RelationId, TZ.ToRuntimeDateTimeFromClient(start), TZ.ToRuntimeDateTimeFromClient(end), (Action<RelationshipCallModel>) (model =>
      {
        if (model.Entity == null)
          return;
        model.Entity.Type = calltype;
        model.Entity.UniqueId = uniqueId;
      }));
    }

    protected override RelationshipCallModel InitNewModel(
      IRelationshipCall entity,
      EleWise.ELMA.Model.Views.ViewType viewType)
    {
      return entity != null ? new RelationshipCallModel(entity, viewType) : new RelationshipCallModel(viewType);
    }

    public new ActionResult CreateMany(
      long[] contactsId,
      long[] contractorsId,
      long[] leadsId,
      long[] salesId)
    {
      return base.CreateMany(contactsId, contractorsId, leadsId, salesId);
    }

    public override MvcHtmlString GetSuccessfulSaveMvcNotification(IRelationshipCall entity)
    {
      string str = ((Controller) this).Url.Entity((IEntity) entity);
      return MvcHtmlString.Create(EleWise.ELMA.SR.T("Звонок <a href=\"{1}\">{0}</a> сохранен успешно", (object) entity.Theme.HtmlEncode(), (object) str));
    }

    public override MvcHtmlString GetSuccessfulDeleteMvcNotification(IRelationshipCall entity) => MvcHtmlString.Create(EleWise.ELMA.SR.T("Звонок \"{0}\" успешно удален", (object) entity.Theme.HtmlEncode()));
  }
}
