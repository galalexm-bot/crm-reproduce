// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.Lead.DublicateLeadLink
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Web.Models.Lead
{
  public enum DublicateLeadLink
  {
    [DisplayName(typeof (DublicateLeadLink_SR), "Contractor")] Contractor = 1,
    [DisplayName(typeof (DublicateLeadLink_SR), "Lead")] Lead = 3,
    [DisplayName(typeof (DublicateLeadLink_SR), "Sale")] Sale = 4,
  }
}
