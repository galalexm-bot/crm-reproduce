// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.SaleProductsGridViewItemRenderer
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class SaleProductsGridViewItemRenderer : 
    ViewItemRendererBase<SaleProductsGridViewItem>,
    ICountViewItemRenderer
  {
    public long? Count(object model, ICountViewItem viewItem) => new long?((long) ((ISale) model).Products.Count<ISaleProduct>((Func<ISaleProduct, bool>) (p => !p.IsDeleted)));
  }
}
