// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ContactContractorPropertyViewItemAdjustment
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class ContactContractorPropertyViewItemAdjustment : 
    IPropertyViewItemAdjustment,
    IPropertyViewItemAdjustmentRuntime2
  {
    public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
    {
      Guid guid = InterfaceActivator.PropertyUid<IContact>((Expression<Func<IContact, object>>) (m => m.Contractor));
      if (propertyViewItem.PropertyUid != guid)
        return;
      propertyViewItem.Attributes.EntityFilterProvider = ContactSupportFilterProvider.UID;
    }
  }
}
