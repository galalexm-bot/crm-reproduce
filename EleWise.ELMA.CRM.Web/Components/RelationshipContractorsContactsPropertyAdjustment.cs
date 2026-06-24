// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.RelationshipContractorsContactsPropertyAdjustment
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class RelationshipContractorsContactsPropertyAdjustment : 
    IPropertyViewItemAdjustment,
    IPropertyViewItemAdjustmentRuntime2
  {
    public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
    {
      Guid guid = InterfaceActivator.PropertyUid<IRelationship>((Expression<Func<IRelationship, object>>) (m => m.ContractorsContacts));
      if (propertyViewItem.PropertyUid != guid || !(model is IRelationship relationship) || relationship.Contractor != null && relationship.ContractorsContacts != null && relationship.ContractorsContacts.Any<IContact>())
        return;
      FormViewItem formViewItem = propertyViewItem.FormViewItem;
      EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(relationship.GetType()) as EntityMetadata;
      if (formViewItem == null || entityMetadata == null || formViewItem.Uid != entityMetadata.DefaultForms.GetForm(ViewType.Display).Uid || formViewItem.HideEmptySettings == HideEmptyEnum.HideEmpty && propertyViewItem.Attributes.ShowEmpty)
        return;
      propertyViewItem.Hide = true;
    }
  }
}
