// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ContractorBaseModel`1
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public abstract class ContractorBaseModel<T> : 
    DynamicEntityViewModel<T>,
    IContractorBaseModel2,
    IContractorBaseModel,
    IDeleteCategoriesDialogModel
    where T : class, IContractor
  {
    public bool SameAddress { get; set; }

    public IContractor Contractor => (IContractor) this.Entity;

    public ContractorBaseModel(T contractor)
      : this(contractor, ViewType.Create)
    {
    }

    public ContractorBaseModel(T contractor, ViewType viewType)
      : base(contractor, viewType)
    {
      if (viewType == ViewType.Create)
        this.Entity.Responsible = this.CurrentUser;
      this.SameAddress = this.Entity.LegalAddress.IsEqual(this.Entity.PostalAddress);
      this.CurrentUserIsWatching = (object) contractor != null && WatchManager.Instance.IsWatchExsist(this.ContractorTypeUid, (object) contractor.Id, this.CurrentUser);
    }

    public ContractorBaseModel()
    {
      if ((object) Locator.GetService<T>() != null)
      {
        this.Entity = InterfaceActivator.Create<T>();
        this.ViewType = ViewType.Create;
        this.Entity.Responsible = this.CurrentUser;
        this.SameAddress = false;
        this.CurrentUserIsWatching = false;
      }
      else
        this.Entity = default (T);
    }

    public override FormViewItem View
    {
      get
      {
        if (this.view != null)
          return this.view;
        this.view = base.View;
        this.view = this.view.Transformate((ViewItemTransformation) CRMContractorFormViewTransformate.GetTransformation(this.Metadata<EntityMetadata>(), this.ViewType));
        return this.view;
      }
    }

    public virtual void PrepareSave()
    {
      if (this.Entity.LegalAddress != null && this.Entity.LegalAddress.Country != null)
        ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault<ICountryInfo>((Func<ICountryInfo, bool>) (p => p.NeedAdd(this.Entity.LegalAddress.Country.Name)))?.Adding(this.Entity.LegalAddress);
      if (this.Entity.PostalAddress != null && this.Entity.PostalAddress.Country != null)
        ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault<ICountryInfo>((Func<ICountryInfo, bool>) (p => p.NeedAdd(this.Entity.PostalAddress.Country.Name)))?.Adding(this.Entity.PostalAddress);
      if (this.Entity.LegalAddress == null || this.Entity.PostalAddress == null || !this.SameAddress)
        return;
      if (this.Entity.LegalAddress.Id == 0L)
        this.Entity.PostalAddress = InterfaceActivator.Create(this.Entity.LegalAddress.GetType().CastAsRealType<Type>()) as IAddress;
      this.Entity.PostalAddress = this.Entity.LegalAddress.CloneTo(this.Entity.PostalAddress);
    }

    public SaveWithCategoryRulesResult SaveWithCategoryRules(
      RuleDeletedCategoryAction ruleDeletedCategoryAction = RuleDeletedCategoryAction.Delete)
    {
      this.PrepareSave();
      return ContractorManager.Instance.SaveWithCategoryRules(this.Contractor, ruleDeletedCategoryAction);
    }

    public Guid ContratorTypeUid => InterfaceActivator.UID<T>();

    public IContractorBaseModel CreateFromContrator(IContractor contractor) => this.CreateFromContrator(contractor, ViewType.Create);

    public IContractorBaseModel CreateFromContrator(IContractor contractor, ViewType viewType) => this.CreateModel(contractor, viewType, new Guid?());

    public IContractorBaseModel CreateFromContractor(IContractor contractor, Guid customFormUid) => this.CreateModel(contractor, ViewType.Custom, new Guid?(customFormUid));

    protected IContractorBaseModel CreateModel(
      IContractor contractor,
      ViewType viewType,
      Guid? customFormUid)
    {
      if (!(contractor.CastAsRealType<IContractor>() is T entity))
        return (IContractorBaseModel) null;
      if (customFormUid.HasValue)
        viewType = ViewType.Custom;
      return this.CreateConcreteModel(entity, viewType, customFormUid);
    }

    protected abstract IContractorBaseModel CreateConcreteModel(
      T entity,
      ViewType viewType,
      Guid? customFormUid);

    public abstract string EditorViewName { get; }

    public abstract string EditorFieldsViewName { get; }

    public bool? UnassignOldCategories { get; set; }

    public IEnumerable<ICategory> CategoriesToDelete { get; set; }

    public bool CurrentUserIsWatching { get; private set; }

    public Guid ContractorTypeUid => InterfaceActivator.UID<T>();

    protected IUser CurrentUser => AuthenticationService.GetCurrentUser<IUser>();
  }
}
