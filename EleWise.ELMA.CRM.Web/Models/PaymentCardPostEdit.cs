// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.PaymentCardPostEdit
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models.BillingInformation;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class PaymentCardPostEdit
  {
    public string RowId { get; set; }

    public string Name { get; set; }

    public IPaymentSystem PaymentSystem { get; set; }

    public string Number { get; set; }

    public DateTime ValidTo { get; set; }

    public AccountStatus Status { get; set; }

    public string Comment { get; set; }
  }
}
