using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.Services;

[Component]
internal class CatalogPropertyPermissionAdapter : PropertyPermissionAdapter<ICatalogProfile, IPropertyProfile, IPropertyAccess>, IInitHandler
{
	private Func<Type, IEnumerable<Type>> getChildTypes;

	private bool initialized;

	public PropertyAccessManager PropertyAccessManager { get; set; }

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public override event EventHandler<PropertyPermissionsChangedEventArgs> PermissionsChanged;

	void IInitHandler.Init()
	{
	}

	void IInitHandler.InitComplete()
	{
		initialized = true;
		getChildTypes = MetadataLoader.UseCachingForFunc((Type t) => GenerateChildTypes(t));
	}

	public override bool IsSupportedModelType(Type modelType)
	{
		return typeof(IEntity).IsAssignableFrom(modelType);
	}

	public override IEnumerable<Type> GetChildTypes(Type modelType)
	{
		if (!initialized)
		{
			return GenerateChildTypes(modelType);
		}
		return getChildTypes(modelType);
	}

	public override IEntityMetadata GetMetadata(Type modelType, bool includeInheritedProperties)
	{
		return (IEntityMetadata)MetadataLoader.LoadMetadata(modelType, includeInheritedProperties);
	}

	public override Guid GetHidePermissionId()
	{
		return PermissionProvider.PropertyHidePermission.Id;
	}

	public override Guid GetViewPermissionId()
	{
		return PermissionProvider.PropertyViewPermission.Id;
	}

	public override Guid GetEditPermissionId()
	{
		return PermissionProvider.PropertyEditPermission.Id;
	}

	protected override IEnumerable<IPropertyProfile> GetPropertyProfiles(ICatalogProfile owner)
	{
		new List<object>();
		ReferenceOnEntityType catalogType = owner.CatalogType;
		return PropertyManager.Instance.LoadPropertyProfileByCatalogType(catalogType);
	}

	protected override IMetadata GetMetadata(ICatalogProfile owner)
	{
		if (owner == null)
		{
			return null;
		}
		return GetMetadata(owner.CatalogType);
	}

	protected override IMetadata GetMetadata(IPropertyProfile profile)
	{
		if (profile == null)
		{
			return null;
		}
		return GetMetadata(profile.CatalogType);
	}

	protected override IEnumerable<IPropertyMetadata> GetPropertyMetadataList(ICatalogProfile owner)
	{
		if (owner == null)
		{
			return new IPropertyMetadata[0];
		}
		List<IPropertyMetadata> list = new List<IPropertyMetadata>();
		(from i in (MetadataRuntimeService.GetMetadata(owner.CatalogType.TypeUid) as ClassMetadata).Properties
			where i.DeclaringType.Equals(owner.CatalogType.EntityType)
			select i into c
			orderby c.DisplayName
			select c).ToList().ForEach(delegate(PropertyMetadata i)
		{
			if (i.ViewSettings.GetForView(ViewType.Create).Visibility == Visibility.Visible || i.ViewSettings.GetForView(ViewType.Edit).Visibility == Visibility.Visible || i.ViewSettings.GetForView(ViewType.Display).Visibility == Visibility.Visible || i.ViewSettings.GetForView(ViewType.List).Visibility == Visibility.Visible || i.ViewSettings.GetForView(ViewType.Filter).Visibility == Visibility.Visible)
			{
				list.Add(i);
			}
		});
		return list;
	}

	protected override IPropertyProfile CreateProfile(ICatalogProfile owner, Guid propertyUid)
	{
		Contract.ArgumentNotNull(owner, "owner");
		IPropertyProfile obj = EntityHelper.GetEntityManager(typeof(IPropertyProfile)).Create() as IPropertyProfile;
		obj.PropertyGuid = propertyUid;
		obj.CatalogType = owner.CatalogType;
		obj.Name = owner.Name;
		return obj;
	}

	protected override void SaveProfiles(ICatalogProfile owner, IEnumerable<IPropertyProfile> profiles)
	{
		List<IPropertyProfile> source = GetPropertyProfiles(owner).ToList();
		List<long> list = Enumerable.Except(second: profiles.Select((IPropertyProfile p) => p.Id).ToArray(), first: source.Select((IPropertyProfile l) => l.Id)).ToList();
		IEntityManager profileManager = EntityHelper.GetEntityManager(typeof(IPropertyProfile));
		list.ForEach(delegate(long i)
		{
			IPropertyProfile propertyProfile = profileManager.Load(i) as IPropertyProfile;
			PropertyManager.Instance.GetAccessesByProfile(propertyProfile).ToList().ForEach(delegate(IPropertyAccess l)
			{
				l.Delete();
			});
			propertyProfile.Delete();
		});
		if (PermissionsChanged != null)
		{
			Type entityType = owner.CatalogType.EntityType;
			PermissionsChanged(this, new PropertyPermissionsChangedEventArgs(entityType));
		}
	}

	protected override IEnumerable<IPropertyAccess> GetAccesses(Type modelType)
	{
		List<ReferenceOnEntityType> typeReferences = new List<ReferenceOnEntityType>
		{
			new ReferenceOnEntityType
			{
				EntityType = modelType
			}
		};
		return PropertyAccessManager.Instance.GetPropertyAccessList(typeReferences);
	}

	private IEnumerable<Type> GenerateChildTypes(Type modelType)
	{
		if (!(MetadataLoader.LoadMetadata(modelType, inherit: false) is EntityMetadata metadata))
		{
			yield break;
		}
		IEnumerable<Type> enumerable = from md in MetadataLoader.GetChildClasses(metadata, loadImplementation: false)
			select MetadataRuntimeService.GetTypeByUidOrNull(md.Uid, loadImplementation: false);
		foreach (Type item in enumerable)
		{
			if (item != null)
			{
				yield return item;
			}
		}
	}

	private IMetadata GetMetadata(ReferenceOnEntityType catalogType)
	{
		if (catalogType == null)
		{
			return null;
		}
		return MetadataLoader.LoadMetadata(catalogType.TypeUid);
	}
}
