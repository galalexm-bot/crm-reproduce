// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.RelationshipHidePropertyAdjustment
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.CRM.Web.Components
{
  internal static class RelationshipHidePropertyAdjustment
  {
    internal static void Hide(
      PropertyViewItem propertyViewItem,
      IRelationship relationship,
      ViewType viewType,
      Expression<Func<IRelationship, object>> expr)
    {
      Guid guid = InterfaceActivator.PropertyUid<IRelationship>(expr);
      if (propertyViewItem.PropertyUid != guid || relationship == null)
        return;
      FormViewItem formViewItem = propertyViewItem.FormViewItem;
      EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(relationship.GetType()) as EntityMetadata;
      if (formViewItem == null || entityMetadata == null || formViewItem.Uid != entityMetadata.DefaultForms.GetForm(ViewType.Display).Uid || expr.Compile()(relationship) != null || formViewItem.HideEmptySettings == HideEmptyEnum.HideEmpty && propertyViewItem.Attributes.ShowEmpty)
        return;
      propertyViewItem.Hide = true;
    }
  }
}
