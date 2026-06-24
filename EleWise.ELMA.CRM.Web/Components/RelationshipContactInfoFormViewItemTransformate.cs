// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.RelationshipContactInfoFormViewItemTransformate
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using System;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class RelationshipContactInfoFormViewItemTransformate : IFormViewItemTransformate
  {
    public FormViewItem Transformate(FormViewItem formViewItem, object model) => !(model is RelationshipModel relationshipModel) || formViewItem.Uid != relationshipModel.FormViewItem(ViewType.Display).Uid || relationshipModel.Entity.Contractor != null || relationshipModel.Entity.Contact != null || relationshipModel.Entity.Lead != null ? formViewItem : formViewItem.Transformate<IRelationship>((Action<FormViewItemTransformationBuilder<IRelationship>>) (t => formViewItem.GetAllItems().OfType<RelationshipContactInfoViewItem>().Each<RelationshipContactInfoViewItem>((Action<RelationshipContactInfoViewItem>) (p => t.ForItem<RelationshipContactInfoViewItem>(p.Uid).Hide())))).Transformate<IRelationship>((Action<FormViewItemTransformationBuilder<IRelationship>>) (t => formViewItem.GetAllItems().OfType<RelationshipContactInfoTabViewItem>().Where<RelationshipContactInfoTabViewItem>((Func<RelationshipContactInfoTabViewItem, bool>) (p => p.Items.All<ViewItem>((Func<ViewItem, bool>) (s => s.GetType() == typeof (RelationshipContactInfoViewItem))))).Each<RelationshipContactInfoTabViewItem>((Action<RelationshipContactInfoTabViewItem>) (p => t.ForItem<RelationshipContactInfoTabViewItem>(p.Uid).Hide()))));
  }
}
