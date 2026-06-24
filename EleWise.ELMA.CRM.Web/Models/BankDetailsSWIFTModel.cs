// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.BankDetailsSWIFTModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class BankDetailsSWIFTModel : DynamicEntityViewModel<IBankDetailsSWIFT>
  {
    public BankDetailsSWIFTModel(IBankDetailsSWIFT bankDetailsSwift, ViewType viewType)
      : base(bankDetailsSwift, viewType)
    {
    }

    public BankDetailsSWIFTModel()
      : base(InterfaceActivator.Create<IBankDetailsSWIFT>(), ViewType.Create)
    {
    }
  }
}
