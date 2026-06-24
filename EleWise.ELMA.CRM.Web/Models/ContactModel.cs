// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ContactModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using System;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  [Component]
  public class ContactModel : DynamicEntityViewModel<IContact>
  {
    public bool SameAddress { get; set; }

    public bool LockEditPermission { get; set; }

    public ContactModel(IContact contact)
      : this(contact, ViewType.Create)
    {
    }

    public ContactModel(IContact contact, ViewType viewType)
      : base(contact, viewType)
    {
      this.SameAddress = this.Entity.ResidenceAddress.IsEqual(this.Entity.RegistrationAddress);
    }

    public ContactModel()
    {
      this.ViewType = ViewType.Create;
      this.SameAddress = true;
    }

    public override FormViewItem View
    {
      get
      {
        if (this.view != null)
          return this.view;
        this.view = base.View;
        this.view = this.view.Transformate((ViewItemTransformation) CRMContactFormViewTransformate.GetTransformation(this.Metadata<EntityMetadata>(), this.view.ViewType));
        return this.view;
      }
    }

    public void Save()
    {
      if (this.Entity.RegistrationAddress != null && this.Entity.RegistrationAddress.Country != null)
        ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault<ICountryInfo>((Func<ICountryInfo, bool>) (p => p.NeedAdd(this.Entity.RegistrationAddress.Country.Name)))?.Adding(this.Entity.RegistrationAddress);
      if (this.Entity.ResidenceAddress != null && this.Entity.ResidenceAddress.Country != null)
        ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault<ICountryInfo>((Func<ICountryInfo, bool>) (p => p.NeedAdd(this.Entity.ResidenceAddress.Country.Name)))?.Adding(this.Entity.ResidenceAddress);
      if (this.Entity.RegistrationAddress != null && this.Entity.ResidenceAddress != null && this.SameAddress)
      {
        Type t = this.Entity.RegistrationAddress.GetType().CastAsRealType<Type>();
        if (this.Entity.ResidenceAddress.GetType().CastAsRealType<Type>() != t)
          this.Entity.ResidenceAddress = InterfaceActivator.Create(t) as IAddress;
        this.Entity.ResidenceAddress = this.Entity.RegistrationAddress.CloneTo(this.Entity.ResidenceAddress);
      }
      this.Entity.Save();
    }
  }
}
