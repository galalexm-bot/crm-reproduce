// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ContractorDublicatesPropertyViewItemAdjustment
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
  public class ContractorDublicatesPropertyViewItemAdjustment : 
    IPropertyViewItemAdjustment,
    IPropertyViewItemAdjustmentRuntime2
  {
    public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
    {
      Guid guid = InterfaceActivator.PropertyUid<IContractor>((Expression<Func<IContractor, object>>) (m => m.Dublicates));
      if (propertyViewItem.PropertyUid != guid)
        return;
      FormViewItem formViewItem = propertyViewItem.FormViewItem;
      IContractor contractor = model as IContractor;
      Guid uid = new Guid("43452920-ec84-4f11-b3c2-4efaeb99540c");
      if (!formViewItem.IsUid(uid) || contractor == null || contractor.Dublicates != null && contractor.Dublicates.Count != 0)
        return;
      propertyViewItem.Hide = true;
    }
  }
}
