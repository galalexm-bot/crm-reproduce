// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Portlets.InpaymentPortletPersonalization
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Web.Mvc.Portlets;
using System;
using System.ComponentModel;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Portlets
{
  [Serializable]
  public class InpaymentPortletPersonalization : PortletPersonalization
  {
    [Personalization(PersonalizationScope.User)]
    [HiddenInput(DisplayValue = false)]
    public virtual long? FilterId { get; set; }

    [HiddenInput(DisplayValue = false)]
    public virtual IFilter Filter
    {
      get => this.FilterId.HasValue ? EntityManager<IFilter>.Instance.LoadOrNull((object) this.FilterId.Value) : (IFilter) null;
      set
      {
        if (value != null)
          this.FilterId = new long?(value.Id);
        else
          this.FilterId = new long?();
      }
    }

    [Personalization(PersonalizationScope.User)]
    [DefaultValue(false)]
    [HiddenInput(DisplayValue = false)]
    public virtual bool ShowOnlyMy { get; set; }

    [Personalization(PersonalizationScope.User)]
    [DefaultValue(true)]
    [HiddenInput(DisplayValue = false)]
    public virtual bool SplitByPeriods { get; set; }
  }
}
