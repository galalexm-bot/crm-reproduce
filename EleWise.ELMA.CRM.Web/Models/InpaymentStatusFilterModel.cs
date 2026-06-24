// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.InpaymentStatusFilterModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  [Serializable]
  public class InpaymentStatusFilterModel
  {
    public InpaymentStatusFilterModel()
    {
      this.IsOverdue = true;
      this.InPlan = true;
      this.Received = true;
      this.Cancelled = true;
    }

    public bool IsOverdue { get; set; }

    public bool InPlan { get; set; }

    public bool Received { get; set; }

    public bool Cancelled { get; set; }
  }
}
