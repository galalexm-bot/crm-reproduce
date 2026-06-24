// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SalesPlan.PaymentModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Models.SalesPlan
{
  public class PaymentModel : EntityModel<IPayment>
  {
    public PaymentModel(IPayment payment) => this.Entity = payment;

    public PaymentModel() => this.Entity = InterfaceActivator.Create<IPayment>();

    public void Save()
    {
      if (this.Entity.IsNew())
        this.Entity.PaymentStatus = PaymentStatus.Planned;
      this.Entity.Save();
    }
  }
}
