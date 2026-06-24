using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Common.Services;

[Service(Type = ComponentType.Server)]
internal class CatalogProfileUpdaterService : ICatalogProfileUpdaterService
{
	private readonly UserGroupManager userGroupManager;

	private readonly CatalogManager catalogManager;

	public IEnumerable<IEntityPermissionsTypeExtensionPoint> EntityPermissionsTypeExtensionPoint { get; set; }

	public CatalogProfileUpdaterService(UserGroupManager userGroupManager, CatalogManager catalogManager)
	{
		this.userGroupManager = userGroupManager;
		this.catalogManager = catalogManager;
	}

	public void CreateProfiles(IEnumerable<ClassMetadata> newMetadataList)
	{
		List<ClassMetadata> list = newMetadataList.Where((ClassMetadata m) => !(m is EntityMetadata entityMetadata) || entityMetadata.Type == EntityMetadataType.Entity || entityMetadata.Type == EntityMetadataType.Interface).ToList();
		if (list.Count <= 0)
		{
			return;
		}
		Dictionary<Guid, ICatalogProfile> catalogProfiles = catalogManager.LoadByCatalogs(list.Select((ClassMetadata c) => c.Uid).ToList());
		ICatalogProfile value;
		List<ClassMetadata> list2 = list.Where((ClassMetadata c) => !catalogProfiles.TryGetValue(c.Uid, out value)).ToList();
		if (list2.Count <= 0)
		{
			return;
		}
		IUserGroup userGroup = userGroupManager.Load(SecurityConstants.AdminGroupUid);
		long groupMask = UserSecuritySetHelper.GetGroupMask(userGroup.Id);
		IUserGroup allUsers = userGroupManager.Load(SecurityConstants.AllUsersGroupUid);
		foreach (ClassMetadata item in list2)
		{
			CreateCatalogProfile(item, allUsers, userGroup, groupMask);
		}
	}

	public void UpdateProfiles()
	{
		IMetadataRuntimeService service = Locator.GetService<IMetadataRuntimeService>();
		if (service == null)
		{
			return;
		}
		IEnumerable<AssemblyModelsMetadata> previousAssemblyModelsMetadataList = service.GetPreviousAssemblyModelsMetadataList();
		IEnumerable<AssemblyModelsMetadata> assemblyModelsMetadataList = service.GetAssemblyModelsMetadataList();
		Dictionary<Guid, ClassMetadata> prevCatalogs = GetShowInListCatalogs(previousAssemblyModelsMetadataList);
		Dictionary<Guid, ClassMetadata> curCatalogs = GetShowInListCatalogs(assemblyModelsMetadataList);
		HashSet<Guid> first = new HashSet<Guid>(curCatalogs.Keys);
		List<Guid> list = first.Intersect(prevCatalogs.Keys).ToList();
		List<ClassMetadata> list2 = (from k in list
			where curCatalogs[k].DisplayName != prevCatalogs[k].DisplayName
			select curCatalogs[k]).ToList();
		List<ClassMetadata> list3 = (from k in first.Except(list)
			select curCatalogs[k]).ToList();
		bool flag = false;
		CatalogManager instance = CatalogManager.Instance;
		IUserGroup userGroup = UserGroupManager.Instance.Load(SecurityConstants.AdminGroupUid);
		long groupMask = UserSecuritySetHelper.GetGroupMask(userGroup.Id);
		IUserGroup allUsers = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		Dictionary<Guid, string> dictionary = instance.LoadNamesByCatalogs(list3.Select((ClassMetadata c) => c.Uid).ToList());
		foreach (ClassMetadata item in list3)
		{
			if (!dictionary.TryGetValue(item.Uid, out var value))
			{
				CreateCatalogProfile(item, allUsers, userGroup, groupMask);
			}
			else if (item.DisplayName != value)
			{
				list2.Add(item);
			}
		}
		Dictionary<Guid, ICatalogProfile> dictionary2 = instance.LoadByCatalogs(list2.Select((ClassMetadata c) => c.Uid).ToList());
		foreach (ClassMetadata item2 in list2)
		{
			if (!dictionary2.TryGetValue(item2.Uid, out var value2))
			{
				CreateCatalogProfile(item2, allUsers, userGroup, groupMask);
				continue;
			}
			value2.Name = item2.DisplayName;
			value2.Save();
			flag = true;
		}
		if (flag)
		{
			instance.LoadCache();
		}
		IEnumerable<EntityMetadata> source = prevCatalogs.Select((KeyValuePair<Guid, ClassMetadata> a) => a.Value).OfType<EntityMetadata>();
		foreach (KeyValuePair<Guid, ClassMetadata> item3 in curCatalogs)
		{
			if (!Guid.Empty.Equals(item3.Value.BaseClassUid))
			{
				continue;
			}
			EntityMetadata entityCatalog = item3.Value as EntityMetadata;
			if (entityCatalog == null || !entityCatalog.CanUsePermissions())
			{
				continue;
			}
			EntityMetadata entityMetadata = source.FirstOrDefault((EntityMetadata a) => a.Uid == entityCatalog.Uid);
			if (entityMetadata == null || entityMetadata.CanUsePermissions())
			{
				continue;
			}
			foreach (IEntityPermissionsTypeExtensionPoint item4 in EntityPermissionsTypeExtensionPoint)
			{
				item4.UpdatePermissions(entityCatalog, needDropOldData: false);
			}
		}
	}

	private static Dictionary<Guid, ClassMetadata> GetShowInListCatalogs(IEnumerable<AssemblyModelsMetadata> assemblyModelsMetadataList)
	{
		return (from classMetadata in assemblyModelsMetadataList.SelectMany((AssemblyModelsMetadata asm) => asm.RestoreMetadata()).OfType<ClassMetadata>().Where(delegate(ClassMetadata classMetadata)
			{
				EntityMetadata entityMetadata = classMetadata as EntityMetadata;
				return (classMetadata is IEntityMetadata && entityMetadata == null) || (entityMetadata != null && (entityMetadata.Type == EntityMetadataType.Entity || entityMetadata.Type == EntityMetadataType.Interface) && entityMetadata.ShowInCatalogList);
			})
			group classMetadata by classMetadata.Uid into classMetadata
			select classMetadata.First()).ToDictionary((ClassMetadata classMetadata) => classMetadata.Uid);
	}

	private bool IsShowInCatalogList(ClassMetadata classMetadata)
	{
		EntityMetadata entityMetadata = classMetadata as EntityMetadata;
		if (classMetadata is IEntityMetadata && entityMetadata == null)
		{
			return true;
		}
		if (entityMetadata != null)
		{
			if (entityMetadata.Type == EntityMetadataType.Entity || entityMetadata.Type == EntityMetadataType.Interface)
			{
				return entityMetadata.ShowInCatalogList;
			}
			return false;
		}
		return false;
	}

	private void CreateCatalogProfile(ClassMetadata item, IUserGroup allUsers, IUserGroup adminGroup, long idAdminGroup)
	{
		ICatalogProfile catalogProfile = InterfaceActivator.Create<ICatalogProfile>();
		catalogProfile.CatalogType = new ReferenceOnEntityType
		{
			TypeUid = item.Uid
		};
		catalogProfile.Name = item.DisplayName;
		ISet<ICatalogAccess> permission = catalogProfile.Permission;
		InstanceOf<ICatalogAccess> instanceOf = new InstanceOf<ICatalogAccess>();
		instanceOf.New.CatalogProfile = catalogProfile;
		instanceOf.New.PermissionId = PermissionProvider.CatalogViewPermission.Id;
		instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf.New.Group = allUsers;
		instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(allUsers.Id);
		permission.Add(instanceOf.New);
		ISet<ICatalogAccess> permission2 = catalogProfile.Permission;
		InstanceOf<ICatalogAccess> instanceOf2 = new InstanceOf<ICatalogAccess>();
		instanceOf2.New.CatalogProfile = catalogProfile;
		instanceOf2.New.PermissionId = PermissionProvider.CatalogAddPermission.Id;
		instanceOf2.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf2.New.Group = adminGroup;
		instanceOf2.New.UserSecuritySetCacheId = idAdminGroup;
		permission2.Add(instanceOf2.New);
		ISet<ICatalogAccess> permission3 = catalogProfile.Permission;
		InstanceOf<ICatalogAccess> instanceOf3 = new InstanceOf<ICatalogAccess>();
		instanceOf3.New.CatalogProfile = catalogProfile;
		instanceOf3.New.PermissionId = PermissionProvider.CatalogEditPermission.Id;
		instanceOf3.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf3.New.Group = adminGroup;
		instanceOf3.New.UserSecuritySetCacheId = idAdminGroup;
		permission3.Add(instanceOf3.New);
		ISet<ICatalogAccess> permission4 = catalogProfile.Permission;
		InstanceOf<ICatalogAccess> instanceOf4 = new InstanceOf<ICatalogAccess>();
		instanceOf4.New.CatalogProfile = catalogProfile;
		instanceOf4.New.PermissionId = PermissionProvider.CatalogDeletePermission.Id;
		instanceOf4.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf4.New.Group = adminGroup;
		instanceOf4.New.UserSecuritySetCacheId = idAdminGroup;
		permission4.Add(instanceOf4.New);
		ISet<ICatalogAccess> permission5 = catalogProfile.Permission;
		InstanceOf<ICatalogAccess> instanceOf5 = new InstanceOf<ICatalogAccess>();
		instanceOf5.New.CatalogProfile = catalogProfile;
		instanceOf5.New.PermissionId = PermissionProvider.CatalogExportPermission.Id;
		instanceOf5.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf5.New.Group = adminGroup;
		instanceOf5.New.UserSecuritySetCacheId = idAdminGroup;
		permission5.Add(instanceOf5.New);
		ISet<ICatalogAccess> permission6 = catalogProfile.Permission;
		InstanceOf<ICatalogAccess> instanceOf6 = new InstanceOf<ICatalogAccess>();
		instanceOf6.New.CatalogProfile = catalogProfile;
		instanceOf6.New.PermissionId = PermissionProvider.CatalogEditGlobalFiltersPermission.Id;
		instanceOf6.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf6.New.Group = adminGroup;
		instanceOf6.New.UserSecuritySetCacheId = idAdminGroup;
		permission6.Add(instanceOf6.New);
		catalogProfile.Save();
	}
}
