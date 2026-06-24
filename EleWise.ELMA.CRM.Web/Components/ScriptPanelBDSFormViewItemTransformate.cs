// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ScriptPanelBDSFormViewItemTransformate
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using System;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  internal class ScriptPanelBDSFormViewItemTransformate : IFormViewItemTransformate
  {
    public FormViewItem Transformate(FormViewItem formViewItem, object model)
    {
      if (!formViewItem.IsReadOnly())
      {
        switch (model)
        {
          case BankDetailsSWIFTModel _:
label_3:
            return formViewItem.Transformate<IBankDetailsSWIFT>((Action<FormViewItemTransformationBuilder<IBankDetailsSWIFT>>) (t =>
            {
              ViewItemTransformationBuilder<IBankDetailsSWIFT> transformationBuilder = t.ForItem(formViewItem.Uid);
              PanelViewItem panelViewItem = new PanelViewItem();
              panelViewItem.CustomViewName = "ScriptPanelBDS";
              Guid? afterItem = new Guid?();
              Guid? beforeItem = new Guid?();
              transformationBuilder.Add((ViewItem) panelViewItem, afterItem, beforeItem);
            }));
          case CatalogItemModel _:
            if (!((model as CatalogItemModel).Entity is IBankDetailsSWIFT))
              break;
            goto label_3;
        }
      }
      return formViewItem;
    }
  }
}
