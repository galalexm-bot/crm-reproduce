using System;
using System.Collections.Generic;
using System.Linq;
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

namespace EleWise.ELMA.CRM.Web.Models;

public abstract class ContractorBaseModel<T> : DynamicEntityViewModel<T>, IContractorBaseModel2, IContractorBaseModel, IDeleteCategoriesDialogModel where T : class, IContractor
{
	public bool SameAddress { get; set; }

	public IContractor Contractor => base.Entity;

	public override FormViewItem View
	{
		get
		{
			if (view != null)
			{
				return view;
			}
			view = base.View;
			view = view.Transformate(CRMContractorFormViewTransformate.GetTransformation(Metadata<EntityMetadata>(), base.ViewType));
			return view;
		}
	}

	public Guid ContratorTypeUid => InterfaceActivator.UID<T>();

	public abstract string EditorViewName { get; }

	public abstract string EditorFieldsViewName { get; }

	public bool? UnassignOldCategories { get; set; }

	public IEnumerable<ICategory> CategoriesToDelete { get; set; }

	public bool CurrentUserIsWatching { get; private set; }

	public Guid ContractorTypeUid => InterfaceActivator.UID<T>();

	protected IUser CurrentUser => AuthenticationService.GetCurrentUser<IUser>();

	public ContractorBaseModel(T contractor)
		: this(contractor, ViewType.Create)
	{
	}

	public ContractorBaseModel(T contractor, ViewType viewType)
		: base(contractor, viewType)
	{
		if (viewType == ViewType.Create)
		{
			base.Entity.Responsible = CurrentUser;
		}
		SameAddress = base.Entity.LegalAddress.IsEqual(base.Entity.PostalAddress);
		CurrentUserIsWatching = contractor != null && WatchManager.Instance.IsWatchExsist(ContractorTypeUid, contractor.Id, CurrentUser);
	}

	public ContractorBaseModel()
	{
		if (Locator.GetService<T>() != null)
		{
			base.Entity = InterfaceActivator.Create<T>();
			base.ViewType = ViewType.Create;
			base.Entity.Responsible = CurrentUser;
			SameAddress = false;
			CurrentUserIsWatching = false;
		}
		else
		{
			base.Entity = null;
		}
	}

	public virtual void PrepareSave()
	{
		if (base.Entity.LegalAddress != null && base.Entity.LegalAddress.Country != null)
		{
			ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault((ICountryInfo p) => p.NeedAdd(base.Entity.LegalAddress.Country.Name))?.Adding(base.Entity.LegalAddress);
		}
		if (base.Entity.PostalAddress != null && base.Entity.PostalAddress.Country != null)
		{
			ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault((ICountryInfo p) => p.NeedAdd(base.Entity.PostalAddress.Country.Name))?.Adding(base.Entity.PostalAddress);
		}
		if (base.Entity.LegalAddress != null && base.Entity.PostalAddress != null && SameAddress)
		{
			if (base.Entity.LegalAddress.Id == 0L)
			{
				Type t = base.Entity.LegalAddress.GetType().CastAsRealType();
				base.Entity.PostalAddress = InterfaceActivator.Create(t) as IAddress;
			}
			base.Entity.PostalAddress = base.Entity.LegalAddress.CloneTo(base.Entity.PostalAddress);
		}
	}

	public SaveWithCategoryRulesResult SaveWithCategoryRules(RuleDeletedCategoryAction ruleDeletedCategoryAction = RuleDeletedCategoryAction.Delete)
	{
		PrepareSave();
		return ContractorManager.Instance.SaveWithCategoryRules(Contractor, ruleDeletedCategoryAction);
	}

	public IContractorBaseModel CreateFromContrator(IContractor contractor)
	{
		return CreateFromContrator(contractor, ViewType.Create);
	}

	public IContractorBaseModel CreateFromContrator(IContractor contractor, ViewType viewType)
	{
		return CreateModel(contractor, viewType, null);
	}

	public IContractorBaseModel CreateFromContractor(IContractor contractor, Guid customFormUid)
	{
		return CreateModel(contractor, ViewType.Custom, customFormUid);
	}

	protected IContractorBaseModel CreateModel(IContractor contractor, ViewType viewType, Guid? customFormUid)
	{
		if (!(contractor.CastAsRealType() is T entity))
		{
			return null;
		}
		if (customFormUid.HasValue)
		{
			viewType = ViewType.Custom;
		}
		return CreateConcreteModel(entity, viewType, customFormUid);
	}

	protected abstract IContractorBaseModel CreateConcreteModel(T entity, ViewType viewType, Guid? customFormUid);
}
