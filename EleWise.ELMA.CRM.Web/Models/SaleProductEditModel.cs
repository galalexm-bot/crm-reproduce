// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SaleProductEditModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class SaleProductEditModel : EntityModel<ISaleProduct>
  {
    public SaleProductEditModel() => this.Entity = InterfaceActivator.Create<ISaleProduct>();

    public SaleProductEditModel(ISale sale) => this.Entity = new InstanceOf<ISaleProduct>()
    {
      New = {
        Sale = sale,
        Quantity = 1L
      }
    }.New;
  }
}
