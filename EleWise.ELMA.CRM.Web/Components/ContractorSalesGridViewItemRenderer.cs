// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ContractorSalesGridViewItemRenderer
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class ContractorSalesGridViewItemRenderer : 
    ViewItemRendererBase<ContractorSalesGridViewItem>,
    ICountViewItemRenderer
  {
    public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model) => !CRMPermissionProvider.HasPermission(CRMPermissionProvider.SalesAccessPermission) ? MvcHtmlString.Empty : base.Render(html, viewItem, model);

    public long? Count(object model, ICountViewItem viewItem)
    {
      ISaleFilter filter = InterfaceActivator.Create<ISaleFilter>();
      filter.Contractors.Add((IContractor) model);
      return new long?(SaleManager.Instance.Count((IEntityFilter) filter));
    }
  }
}
