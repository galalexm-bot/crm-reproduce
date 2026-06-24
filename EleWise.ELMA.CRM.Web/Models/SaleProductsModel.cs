// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SaleProductsModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class SaleProductsModel : DynamicEntityViewModel<ISaleProduct>
  {
    public SaleProductsModel(ISaleProduct saleProduct, ViewType viewType)
      : base(saleProduct, viewType)
    {
    }

    public SaleProductsModel(ViewType viewType)
      : this(InterfaceActivator.Create<ISaleProduct>(), viewType)
    {
    }

    public SaleProductsModel()
      : this(ViewType.Create)
    {
    }

    public EleWise.ELMA.Web.Mvc.Models.Grids.GridData<ISaleProduct, ISaleProductFilter> GridData { get; set; }

    public bool ReadOnly { get; set; }

    public ISale Sale { get; set; }

    public FilterModel Filter { get; set; }
  }
}
