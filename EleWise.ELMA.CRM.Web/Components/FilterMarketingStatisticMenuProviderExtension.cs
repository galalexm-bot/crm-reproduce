// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.FilterMarketingStatisticMenuProviderExtension
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 12)]
  public class FilterMarketingStatisticMenuProviderExtension : IFilterMenuProviderExtension
  {
    public IContentActionRegistry ContentActionRegistry { get; set; }

    public IComponentManager ComponentManager { get; set; }

    public bool SupportedFilter(IFilterFolder filterFolder) => filterFolder.Uid == CrmConstants.MarketingStatisticActionFilter;

    public void GetTreeNodeParameters(
      IFilterFolder filterFolder,
      UrlHelper urlHelper,
      bool isDefault,
      bool isSystemDefault,
      out string type,
      out string icon,
      out string href,
      out bool canMakeDefault,
      ActionRoute routes,
      string filterIdParameter = null,
      string urlAction = null)
    {
      type = (string) null;
      icon = (string) null;
      href = (string) null;
      if (urlHelper != null)
        href = urlHelper.Action("MarketingStatistic", "MarketingActivity", (object) new
        {
          area = "EleWise.ELMA.CRM.Web"
        });
      canMakeDefault = true;
      if (!(filterFolder is IFilterActionLink))
        return;
      type = "action";
      icon = "#statistic.svg";
    }
  }
}
