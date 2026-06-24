// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SaleModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class SaleModel : DynamicEntityViewModel<ISale>
  {
    public SaleModel(ISale sale)
      : this(sale, ViewType.Create)
    {
    }

    public SaleModel(ISale sale, ViewType viewType)
      : base(sale, viewType)
    {
      this.ContractorReadOnly = false;
    }

    public SaleModel()
    {
      this.ViewType = ViewType.Create;
      this.Entity.Responsible = AuthenticationService.GetCurrentUser<IUser>();
      CrmSettingsModule serviceNotNull = Locator.GetServiceNotNull<CrmSettingsModule>();
      this.Entity.Currency = serviceNotNull.Settings.DefaultSaleCurrency;
      this.Entity.SaleType = serviceNotNull.Settings.DefaultSaleType;
      this.ContractorReadOnly = false;
    }

    public bool ContractorReadOnly { get; set; }

    public bool LockEditPermission { get; set; }

    public override FormViewItem View
    {
      get
      {
        if (this.view != null)
          return this.view;
        this.view = base.View;
        this.view = this.view.Transformate((ViewItemTransformation) CRMSaleFormViewTransformate.GetTransformation(this.Metadata<EntityMetadata>(), this.view.ViewType));
        return this.view;
      }
    }
  }
}
