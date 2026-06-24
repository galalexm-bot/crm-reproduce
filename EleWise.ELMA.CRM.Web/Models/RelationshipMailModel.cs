// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.RelationshipMailModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  [Component]
  public class RelationshipMailModel : RelationshipModel<IRelationshipMail>
  {
    public RelationshipMailModel(IRelationshipMail relationship)
      : base(relationship)
    {
    }

    public RelationshipMailModel()
    {
    }

    public RelationshipMailModel(IRelationshipMail relationship, ViewType viewType)
      : base(relationship, viewType)
    {
    }

    public RelationshipMailModel(ViewType viewType)
      : base(viewType)
    {
    }

    protected override void SaveEntityAndCreateNew()
    {
      this.SaveEntity();
      IRelationshipMail relationshipMail = this.BaseCreateNew<IRelationshipMail>();
      relationshipMail.EndDate = relationshipMail.StartDate.AddMinutes(10.0);
      this.Entity = relationshipMail;
    }

    protected override void SaveEntity()
    {
      this.Entity.EndDate = this.Entity.StartDate.AddMinutes(10.0);
      base.SaveEntity();
    }

    protected override IRelationshipBaseModel CreateConcreteModel(
      IRelationshipMail entity,
      ViewType viewType,
      Guid? customFormUid)
    {
      RelationshipMailModel concreteModel = new RelationshipMailModel(entity, viewType);
      concreteModel.FormUid = customFormUid;
      return (IRelationshipBaseModel) concreteModel;
    }

    public override string EditorViewName => "RelationshipMail/Editors/RelationshipMailEdit";
  }
}
