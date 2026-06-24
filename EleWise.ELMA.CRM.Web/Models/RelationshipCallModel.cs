// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.RelationshipCallModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  [Component]
  public class RelationshipCallModel : RelationshipModel<IRelationshipCall>
  {
    public RelationshipCallModel(IRelationshipCall relationship)
      : base(relationship)
    {
    }

    public RelationshipCallModel() => this.Entity.Type = RelationshipCallType.Output;

    public RelationshipCallModel(ViewType viewType)
      : base(viewType)
    {
      this.Entity.Type = RelationshipCallType.Output;
    }

    public RelationshipCallModel(IRelationshipCall relationship, ViewType viewType)
      : base(relationship, viewType)
    {
    }

    protected override void SaveEntityAndCreateNew()
    {
      this.SaveEntity();
      IRelationshipCall relationshipCall = this.BaseCreateNew<IRelationshipCall>();
      relationshipCall.EndDate = relationshipCall.StartDate.AddMinutes(10.0);
      relationshipCall.Type = this.Entity.Type;
      this.Entity = relationshipCall;
    }

    protected override void SaveEntity()
    {
      this.Entity.EndDate = this.Entity.StartDate.AddMinutes(10.0);
      base.SaveEntity();
    }

    protected override IRelationshipBaseModel CreateConcreteModel(
      IRelationshipCall entity,
      ViewType viewType,
      Guid? customFormUid)
    {
      RelationshipCallModel concreteModel = new RelationshipCallModel(entity, viewType);
      concreteModel.FormUid = customFormUid;
      return (IRelationshipBaseModel) concreteModel;
    }

    public override string EditorViewName => "RelationshipCall/Editors/RelationshipCallEdit";
  }
}
