// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SalesPlan.Month
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models.SalesPlan
{
  public class Month
  {
    public Month() => this.Weeks = new List<Week>();

    public string Name { get; set; }

    public List<Week> Weeks { get; set; }
  }
}
