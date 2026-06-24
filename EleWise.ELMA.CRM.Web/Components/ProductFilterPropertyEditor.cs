// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ProductFilterPropertyEditor
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc;
using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class ProductFilterPropertyEditor : IFilterPropertyEditorExtension
  {
    public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
    {
      if (!(filterModel.Filter is ISaleFilter))
        return false;
      return property.PropertyUid == InterfaceActivator.PropertyUid<ISaleFilter>((Expression<Func<ISaleFilter, object>>) (p => p.Products));
    }

    public MvcHtmlString PropertyEditor(
      HtmlHelper<object> html,
      FilterMetadataProperty property,
      FilterModel filterModel)
    {
      return (MvcHtmlString) null;
    }

    public void PropertyAction(
      HtmlHelper<object> html,
      FilterMetadataProperty property,
      FilterModel filterModel,
      WebViewAttributes a)
    {
      a.TemplateName = nameof (ProductFilterPropertyEditor);
    }
  }
}
