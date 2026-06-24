// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.PaymentCardModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class PaymentCardModel : DynamicEntityViewModel<IPaymentCard>
  {
    public PaymentCardModel()
      : base(InterfaceActivator.Create<IPaymentCard>(), ViewType.Create)
    {
    }

    public PaymentCardModel(IPaymentCard paymentCard, ViewType viewType)
      : base(paymentCard, viewType)
    {
    }

    public string DefaultFormId { get; set; }

    public string Prefix { get; set; }

    public string ButtonText { get; set; }

    public string CallbackFunc { get; set; }

    public string PostAction { get; set; }

    public string PostController { get; set; }

    public string RowId { get; set; }

    public string PopupId { get; set; }
  }
}
