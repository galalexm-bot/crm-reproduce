// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ProductViewModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using System;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class ProductViewModel : EntityModel<IProduct>
  {
    private FormViewItem view;

    public ProductViewModel(IProduct product, ViewType viewType)
    {
      this.Entity = product ?? InterfaceActivator.Create<IProduct>();
      this.ViewType = viewType;
    }

    public ProductViewModel(IProduct product)
      : this(product, ViewType.Create)
    {
    }

    public ProductViewModel()
      : this((IProduct) null)
    {
    }

    public IProduct CurrentFolderObject { get; set; }

    public FilterModel Filter { get; set; }

    public string GridId { get; set; }

    public Guid? FormUid { get; set; }

    public ViewType ViewType { get; set; }

    public FormViewItem View
    {
      get
      {
        if (this.view != null)
          return this.view;
        EntityMetadata entityMetadata = this.Metadata<EntityMetadata>();
        this.view = !this.FormUid.HasValue || !(this.FormUid.Value != Guid.Empty) ? entityMetadata.DefaultForms.GetForm(this.ViewType) : entityMetadata.GetForms().FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (q =>
        {
          Guid uid = q.Uid;
          Guid? formUid = this.FormUid;
          return formUid.HasValue && uid == formUid.GetValueOrDefault();
        }));
        if (this.view == null)
          return (FormViewItem) null;
        if (this.view.ViewType == ViewType.Display)
          this.view = (FormViewItem) this.view.CloneAsReadOnly();
        return this.view;
      }
    }
  }
}
