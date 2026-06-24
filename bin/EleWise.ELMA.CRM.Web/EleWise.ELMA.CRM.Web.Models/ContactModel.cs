using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

[Component]
public class ContactModel : DynamicEntityViewModel<IContact>
{
	public bool SameAddress { get; set; }

	public bool LockEditPermission { get; set; }

	public override FormViewItem View
	{
		get
		{
			if (view != null)
			{
				return view;
			}
			view = base.View;
			view = view.Transformate(CRMContactFormViewTransformate.GetTransformation(Metadata<EntityMetadata>(), view.ViewType));
			return view;
		}
	}

	public ContactModel(IContact contact)
		: this(contact, ViewType.Create)
	{
	}

	public ContactModel(IContact contact, ViewType viewType)
		: base(contact, viewType)
	{
		SameAddress = base.Entity.ResidenceAddress.IsEqual(base.Entity.RegistrationAddress);
	}

	public ContactModel()
	{
		base.ViewType = ViewType.Create;
		SameAddress = true;
	}

	public void Save()
	{
		if (base.Entity.RegistrationAddress != null && base.Entity.RegistrationAddress.Country != null)
		{
			ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault((ICountryInfo p) => p.NeedAdd(base.Entity.RegistrationAddress.Country.Name))?.Adding(base.Entity.RegistrationAddress);
		}
		if (base.Entity.ResidenceAddress != null && base.Entity.ResidenceAddress.Country != null)
		{
			ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault((ICountryInfo p) => p.NeedAdd(base.Entity.ResidenceAddress.Country.Name))?.Adding(base.Entity.ResidenceAddress);
		}
		if (base.Entity.RegistrationAddress != null && base.Entity.ResidenceAddress != null && SameAddress)
		{
			Type type = base.Entity.RegistrationAddress.GetType().CastAsRealType();
			if (base.Entity.ResidenceAddress.GetType().CastAsRealType() != type)
			{
				base.Entity.ResidenceAddress = InterfaceActivator.Create(type) as IAddress;
			}
			base.Entity.ResidenceAddress = base.Entity.RegistrationAddress.CloneTo(base.Entity.ResidenceAddress);
		}
		base.Entity.Save();
	}
}
