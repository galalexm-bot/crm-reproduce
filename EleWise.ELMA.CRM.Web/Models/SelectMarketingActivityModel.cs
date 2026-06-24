// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SelectMarketingActivityModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class SelectMarketingActivityModel
  {
    public long[] EntitiesId { get; set; }

    public Guid EntityTypeUid { get; set; }

    public IMarketingGroup MarketingGroup { get; set; }

    public IMarketingActivity MarketingActivity { get; set; }

    public IMarketingEffect MarketingEffect { get; set; }

    public string RedirectControllerName { get; set; }

    public string RedirectActionName { get; set; }

    public string EntitiesName { get; set; }

    public string EntitiesNameForErrorMessage { get; set; }
  }
}
