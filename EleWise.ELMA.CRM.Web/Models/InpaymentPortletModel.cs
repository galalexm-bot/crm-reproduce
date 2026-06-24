// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.InpaymentPortletModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class InpaymentPortletModel
  {
    public long? FilterId { get; set; }

    public bool ShowOnlyMy { get; set; }

    public bool SplitByPeriods { get; set; }

    public Guid InstanceId { get; set; }
  }
}
