// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ContractorSalesTabViewItemRenderer
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Components;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  [Obsolete]
  public class ContractorSalesTabViewItemRenderer : TabViewItemRenderer
  {
    public override bool CanRender(ViewItem viewItem) => viewItem.GetType() == typeof (ContractorSalesTabViewItem);

    public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
    {
      if (!CRMPermissionProvider.HasPermission(CRMPermissionProvider.SalesAccessPermission))
        return MvcHtmlString.Empty;
      ((TabViewItem) viewItem).CaptionViewName = "ViewItems/ContractorSalesTabCaption";
      return base.Render(html, viewItem, model);
    }
  }
}
