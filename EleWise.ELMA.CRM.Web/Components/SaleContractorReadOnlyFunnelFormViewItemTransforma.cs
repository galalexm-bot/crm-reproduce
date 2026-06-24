// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.SaleContractorReadOnlyFunnelFormViewItemTransformate
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class SaleContractorReadOnlyFunnelFormViewItemTransformate : IFormViewItemTransformate
  {
    public FormViewItem Transformate(FormViewItem formViewItem, object model)
    {
      if (!formViewItem.IsUid(new Guid("c0a539e1-a9e8-4c62-bf4f-c695a52360a3")) || !(model is SaleModel) || !(model as SaleModel).ContractorReadOnly)
        return formViewItem;
      Guid contractorPropertyUid = InterfaceActivator.PropertyUid<ISale>((Expression<Func<ISale, object>>) (m => m.Contractor));
      return formViewItem.Transformate<ISale>((Action<FormViewItemTransformationBuilder<ISale>>) (t =>
      {
        formViewItem.GetAllItems().OfType<PropertyViewItem>().Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (p => p.PropertyUid == contractorPropertyUid)).Each<PropertyViewItem>((Action<PropertyViewItem>) (p => t.ForItem<PropertyViewItem>(p.Uid).SetPropertyValue<bool?>((Expression<Func<PropertyViewItem, bool?>>) (prop => prop.Attributes.ReadOnly), new bool?(true))));
        ViewItemTransformationBuilder<ISale> transformationBuilder = t.ForItem(formViewItem.Uid);
        PanelViewItem panelViewItem = new PanelViewItem();
        panelViewItem.CustomViewName = "ViewItems/SaleContractorId";
        Guid? afterItem = new Guid?();
        Guid? beforeItem = new Guid?();
        transformationBuilder.Add((ViewItem) panelViewItem, afterItem, beforeItem);
      }));
    }
  }
}
