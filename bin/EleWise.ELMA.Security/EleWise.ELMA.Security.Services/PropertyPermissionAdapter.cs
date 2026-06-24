using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services;

public abstract class PropertyPermissionAdapter<TOwner, TPropertyProfile, TPropertyAccess> : IPropertyPermissionAdapter, IClassMetadataPropertyPermissionAdapter where TOwner : class, IPropertyOwnerProfile where TPropertyProfile : class, IAbstractPropertyProfile where TPropertyAccess : class, IAbstractPropertyAccess
{
	internal static object W1f9kkPVFZwNSANnPy0;

	public abstract event EventHandler<PropertyPermissionsChangedEventArgs> PermissionsChanged;

	public virtual bool IsSupportedOwnerType(Type ownerType)
	{
		return typeof(TOwner).IsAssignableFrom(ownerType);
	}

	public virtual bool IsSupportedProfileType(Type profileType)
	{
		return typeof(TPropertyProfile).IsAssignableFrom(profileType);
	}

	public abstract bool IsSupportedModelType(Type modelType);

	IEnumerable<IAbstractPropertyProfile> IPropertyPermissionAdapter.GetPropertyProfiles(IPropertyOwnerProfile owner)
	{
		return GetPropertyProfiles((TOwner)owner).Cast<IAbstractPropertyProfile>();
	}

	IEntityMetadata IPropertyPermissionAdapter.GetMetadata(IAbstractPropertyProfile profile)
	{
		return GetMetadata((TPropertyProfile)profile) as IEntityMetadata;
	}

	IEntityMetadata IPropertyPermissionAdapter.GetMetadata(IPropertyOwnerProfile owner)
	{
		return GetMetadata((TOwner)owner) as IEntityMetadata;
	}

	IMetadata IClassMetadataPropertyPermissionAdapter.GetBaseMetadata(IAbstractPropertyProfile profile)
	{
		return GetMetadata((TPropertyProfile)profile);
	}

	IMetadata IClassMetadataPropertyPermissionAdapter.GetBaseMetadata(IPropertyOwnerProfile owner)
	{
		return GetMetadata((TOwner)owner);
	}

	IEnumerable<IPropertyMetadata> IPropertyPermissionAdapter.GetPropertyMetadataList(IPropertyOwnerProfile owner)
	{
		return GetPropertyMetadataList((TOwner)owner);
	}

	IAbstractPropertyProfile IPropertyPermissionAdapter.CreateProfile(IPropertyOwnerProfile owner, Guid propertyUid)
	{
		return CreateProfile((TOwner)owner, propertyUid);
	}

	void IPropertyPermissionAdapter.SaveProfiles(IPropertyOwnerProfile owner, IEnumerable<IAbstractPropertyProfile> profiles)
	{
		SaveProfiles((TOwner)owner, profiles.Cast<TPropertyProfile>());
	}

	IEnumerable<IAbstractPropertyAccess> IPropertyPermissionAdapter.GetAccesses(Type modelType)
	{
		return GetAccesses(modelType).Cast<IAbstractPropertyAccess>();
	}

	public abstract IEntityMetadata GetMetadata(Type modelType, bool includeInheritedProperties);

	public abstract IEnumerable<Type> GetChildTypes(Type modelType);

	public abstract Guid GetHidePermissionId();

	public abstract Guid GetViewPermissionId();

	public abstract Guid GetEditPermissionId();

	protected abstract IEnumerable<TPropertyProfile> GetPropertyProfiles(TOwner owner);

	protected abstract IMetadata GetMetadata(TOwner owner);

	protected abstract IMetadata GetMetadata(TPropertyProfile profile);

	protected abstract IEnumerable<IPropertyMetadata> GetPropertyMetadataList(TOwner owner);

	protected abstract TPropertyProfile CreateProfile(TOwner owner, Guid propertyUid);

	protected abstract void SaveProfiles(TOwner owner, IEnumerable<TPropertyProfile> profiles);

	protected abstract IEnumerable<TPropertyAccess> GetAccesses(Type modelType);

	protected PropertyPermissionAdapter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SBVCSGPQnvunOVvqBDF()
	{
		return W1f9kkPVFZwNSANnPy0 == null;
	}

	internal static object HxJaAtPdeAcY61NUYWh()
	{
		return W1f9kkPVFZwNSANnPy0;
	}
}
