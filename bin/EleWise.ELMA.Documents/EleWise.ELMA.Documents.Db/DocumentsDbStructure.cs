using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Transform;

namespace EleWise.ELMA.Documents.Db;

public class DocumentsDbStructure : DbStructureExtension
{
	private UserManager userManager;

	private ISessionProvider sessionProvider;

	private string dmsObjectRelationTableTempName = "Sys_DmsObjectRelationTemp";

	private static readonly Permission[] DefaultPermissions = new Permission[6]
	{
		PermissionProvider.DocumentViewPermission,
		PermissionProvider.DocumentLoadPermission,
		PermissionProvider.DocumentEditPermission,
		PermissionProvider.DocumentManagerAccessPermission,
		PermissionProvider.DocumentCreatePermission,
		PermissionProvider.DocumentFullAccessPermission
	};

	private UserManager UserManager => userManager ?? (userManager = UserManager.Instance);

	private ISessionProvider SessionProvider => sessionProvider ?? (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());

	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(SecurityDbStructure) };

	public void CreateMetadataRootFolder()
	{
		EleWise.ELMA.Security.Models.IUser creationAuthor = UserManager.Instance.Load(SecurityConstants.AdminUserUid);
		if (DocumentMetadataGroupManager.Instance.LoadOrNull(DocumentConstants.RootDocumentFolderUid) == null)
		{
			InstanceOf<IDocumentMetadataGroup> instanceOf = new InstanceOf<IDocumentMetadataGroup>();
			instanceOf.New.Uid = DocumentConstants.RootDocumentFolderUid;
			instanceOf.New.Name = SR.T("Все типы документов");
			instanceOf.New.GroupType = DocumentConstants.RootMetadataFolderUid;
			instanceOf.New.CreationAuthor = creationAuthor;
			instanceOf.New.CreationDate = DateTime.Now;
			instanceOf.New.MetadataType = new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}");
			instanceOf.New.Save();
		}
	}

	public void CreateMetadataRecycle()
	{
		EleWise.ELMA.Security.Models.IUser creationAuthor = UserManager.Instance.Load(SecurityConstants.AdminUserUid);
		if (DocumentMetadataGroupManager.Instance.LoadOrNull(DocumentConstants.RecycleDocumentFolderUid) == null)
		{
			InstanceOf<IDocumentMetadataGroup> instanceOf = new InstanceOf<IDocumentMetadataGroup>();
			instanceOf.New.Uid = DocumentConstants.RecycleDocumentFolderUid;
			instanceOf.New.Name = SR.T("Корзина");
			instanceOf.New.GroupType = DocumentConstants.RecycleMetadataFolderUid;
			instanceOf.New.CreationAuthor = creationAuthor;
			instanceOf.New.CreationDate = DateTime.Now;
			instanceOf.New.MetadataType = new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}");
			instanceOf.New.Save();
		}
	}

	public void CreateDocumentHeads()
	{
		IDocumentMetadataGroup group = DocumentMetadataGroupManager.Instance.Load(new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}"), DocumentConstants.RootMetadataFolderUid);
		(from m in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
			where m.Type == EntityMetadataType.Interface
			select m).ToList().ForEach(delegate(DocumentMetadata d)
		{
			InstanceOf<IDocumentMetadataHeadFilter> instanceOf = new InstanceOf<IDocumentMetadataHeadFilter>();
			instanceOf.New.DocumentTypeUid = d.Uid;
			IDocumentMetadataHeadFilter @new = instanceOf.New;
			if (!AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Exists(@new))
			{
				InstanceOf<IDocumentMetadataHead> instanceOf2 = new InstanceOf<IDocumentMetadataHead>();
				instanceOf2.New.DocumentTypeUid = d.Uid;
				instanceOf2.New.Group = group;
				instanceOf2.New.MetadataType = new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}");
				instanceOf2.New.Save();
			}
		});
	}

	public void CreateArchiveFolder()
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(SecurityConstants.AdminUserUid);
		UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		IFilterDocumentFolder filterDocumentFolder = FilterDocumentFolderManager.Instance.LoadOrNull(DocumentConstants.ArchiveFolderUid);
		if (filterDocumentFolder == null)
		{
			InstanceOf<IFilterDocumentFolder> instanceOf = new InstanceOf<IFilterDocumentFolder>();
			instanceOf.New.Uid = DocumentConstants.ArchiveFolderUid;
			instanceOf.New.CreationAuthor = user;
			instanceOf.New.Name = SR.T("Архив");
			instanceOf.New.ImageUrl = "#messages_all_written.svg";
			instanceOf.New.SearchOnOpen = true;
			instanceOf.New.SortTypeId = 2000L;
			instanceOf.New.Virtual = true;
			filterDocumentFolder = instanceOf.New;
			ISet<IDmsObjectPermission> permissions = filterDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf2 = new InstanceOf<IDmsObjectPermission>();
			instanceOf2.New.DmsObject = filterDocumentFolder;
			instanceOf2.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf2.New.User = user;
			instanceOf2.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions.Add(instanceOf2.New);
			ISet<IDmsObjectPermission> permissions2 = filterDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf3 = new InstanceOf<IDmsObjectPermission>();
			instanceOf3.New.DmsObject = filterDocumentFolder;
			instanceOf3.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf3.New.User = user;
			instanceOf3.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions2.Add(instanceOf3.New);
			ISet<IDmsObjectPermission> permissions3 = filterDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf4 = new InstanceOf<IDmsObjectPermission>();
			instanceOf4.New.DmsObject = filterDocumentFolder;
			instanceOf4.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf4.New.User = user;
			instanceOf4.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions3.Add(instanceOf4.New);
			ISet<IDmsObjectPermission> permissions4 = filterDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf5 = new InstanceOf<IDmsObjectPermission>();
			instanceOf5.New.DmsObject = filterDocumentFolder;
			instanceOf5.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
			instanceOf5.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf5.New.User = user;
			instanceOf5.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions4.Add(instanceOf5.New);
			ISet<IDmsObjectPermission> permissions5 = filterDocumentFolder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf6 = new InstanceOf<IDmsObjectPermission>();
			instanceOf6.New.DmsObject = filterDocumentFolder;
			instanceOf6.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
			instanceOf6.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf6.New.User = user;
			instanceOf6.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions5.Add(instanceOf6.New);
			IDocumentFilter documentFilter = InterfaceActivator.Create<IDocumentFilter>();
			documentFilter.IsArchived = true;
			filterDocumentFolder.DocumentFilter = UniversalFilterSaver.Pack(documentFilter);
			filterDocumentFolder.Save();
		}
	}

	public void CreateSharedFolder()
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(SecurityConstants.AdminUserUid);
		IUserGroup userGroup = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		IFolder folder = FolderManager.Instance.LoadOrNull(DocumentConstants.SharedFolderUid);
		if (folder == null)
		{
			InstanceOf<IFolder> instanceOf = new InstanceOf<IFolder>();
			instanceOf.New.CreationAuthor = user;
			instanceOf.New.FolderType = FolderType.SharedFolder;
			instanceOf.New.Uid = DocumentConstants.SharedFolderUid;
			instanceOf.New.Name = SR.T("Общие папки");
			instanceOf.New.SortTypeId = 1000L;
			folder = instanceOf.New;
			ISet<IDmsObjectPermission> permissions = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf2 = new InstanceOf<IDmsObjectPermission>();
			instanceOf2.New.DmsObject = folder;
			instanceOf2.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf2.New.Group = userGroup;
			instanceOf2.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(userGroup.Id);
			permissions.Add(instanceOf2.New);
			ISet<IDmsObjectPermission> permissions2 = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf3 = new InstanceOf<IDmsObjectPermission>();
			instanceOf3.New.DmsObject = folder;
			instanceOf3.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf3.New.Group = userGroup;
			instanceOf3.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(userGroup.Id);
			permissions2.Add(instanceOf3.New);
			ISet<IDmsObjectPermission> permissions3 = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf4 = new InstanceOf<IDmsObjectPermission>();
			instanceOf4.New.DmsObject = folder;
			instanceOf4.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf4.New.User = user;
			instanceOf4.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions3.Add(instanceOf4.New);
			ISet<IDmsObjectPermission> permissions4 = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf5 = new InstanceOf<IDmsObjectPermission>();
			instanceOf5.New.DmsObject = folder;
			instanceOf5.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
			instanceOf5.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf5.New.User = user;
			instanceOf5.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions4.Add(instanceOf5.New);
			ISet<IDmsObjectPermission> permissions5 = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf6 = new InstanceOf<IDmsObjectPermission>();
			instanceOf6.New.DmsObject = folder;
			instanceOf6.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
			instanceOf6.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf6.New.User = user;
			instanceOf6.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions5.Add(instanceOf6.New);
			ISet<IDmsObjectPermission> permissions6 = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf7 = new InstanceOf<IDmsObjectPermission>();
			instanceOf7.New.DmsObject = folder;
			instanceOf7.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
			instanceOf7.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf7.New.User = user;
			instanceOf7.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions6.Add(instanceOf7.New);
			ISet<IDmsObjectPermission> permissions7 = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf8 = new InstanceOf<IDmsObjectPermission>();
			instanceOf8.New.DmsObject = folder;
			instanceOf8.New.PermissionId = PermissionProvider.DocumentCreatePermission.Id;
			instanceOf8.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf8.New.User = user;
			instanceOf8.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions7.Add(instanceOf8.New);
			ISet<IDmsObjectPermission> permissions8 = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf9 = new InstanceOf<IDmsObjectPermission>();
			instanceOf9.New.DmsObject = folder;
			instanceOf9.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
			instanceOf9.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf9.New.User = user;
			instanceOf9.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
			permissions8.Add(instanceOf9.New);
			folder.Save();
		}
	}

	public void UpdateIconDocumentFolders1()
	{
		IFilterDocumentFolder filterDocumentFolder = FilterDocumentFolderManager.Instance.LoadOrNull(DocumentConstants.ArchiveFolderUid);
		if (filterDocumentFolder != null && (string.IsNullOrWhiteSpace(filterDocumentFolder.ImageUrl) || (!string.IsNullOrWhiteSpace(filterDocumentFolder.ImageUrl) && !filterDocumentFolder.ImageUrl.EndsWith(".svg"))))
		{
			filterDocumentFolder.ImageUrl = "#messages_all_written.svg";
			filterDocumentFolder.Save();
		}
	}

	public void CreateDefaultFolders()
	{
		CreateSharedFolder();
	}

	public void CreateDocumentMetadataProfiles()
	{
		List<DocumentMetadata> list = (from dm in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
			where dm.Type == EntityMetadataType.Interface
			select dm).ToList();
		IUserGroup allUsers = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		list.ForEach(delegate(DocumentMetadata m)
		{
			IDocumentMetadataProfile profile = InterfaceActivator.Create<IDocumentMetadataProfile>();
			profile.DocumentType = new ReferenceOnEntityType
			{
				TypeUid = m.Uid
			};
			profile.CreationAuthor = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
			ISet<IDmsObjectDefaultPermissions> permissions = profile.Permissions;
			InstanceOf<IDmsObjectDefaultPermissions> instanceOf = new InstanceOf<IDmsObjectDefaultPermissions>();
			instanceOf.New.DocumentMetadataProfile = profile;
			instanceOf.New.PermissionId = PermissionProvider.DocumentMetadataCreateInstance.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf.New.Group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupDescriptor.Uid);
			instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(allUsers.Id);
			permissions.Add(instanceOf.New);
			(from p in ComponentManager.Current.GetExtensionPoints<IDocumentMetadataProfileInitProvider>()
				where p.CheckType(m.Uid)
				select p).ToList().ForEach(delegate(IDocumentMetadataProfileInitProvider p)
			{
				p.Init(profile);
			});
			profile.Save();
		});
	}

	public void UpdateDocumentMetadataProfiles()
	{
		DocumentMetadataProfileManager.Instance.FindAll().ToList().ForEach(delegate(IDocumentMetadataProfile p)
		{
			p.CreationAuthor = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
		});
	}

	public void CreateAccessToAllDocumentsGroup()
	{
		IUserGroup userGroup = UserGroupManager.Instance.Find((IUserGroup g) => g.Uid == DocumentConstants.AccessToAllDocumentsGroupUid).FirstOrDefault();
		if (userGroup == null)
		{
			EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
			if (user == null)
			{
				throw new InvalidOperationException(SR.T("Не удалось найти пользователя \"Администратор\" Uid={0}", SecurityConstants.AdminUserUid));
			}
			InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
			instanceOf.New.Name = DocumentConstants.AccessToAllDocumentsGroupDescriptor.Name;
			instanceOf.New.Description = DocumentConstants.AccessToAllDocumentsGroupDescriptor.Description;
			instanceOf.New.CreationAuthor = user;
			instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>();
			userGroup = instanceOf.New;
		}
		userGroup.Uid = DocumentConstants.AccessToAllDocumentsGroupUid;
		userGroup.IsSystem = true;
		userGroup.Save();
		Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
	}

	public void CreateLifeCycleStatuses1()
	{
		Func<string, Guid, ILifeCycleStatus> obj = delegate(string name, Guid uid)
		{
			ILifeCycleStatus lifeCycleStatus = LifeCycleStatusManager.Instance.LoadByName(name);
			if (lifeCycleStatus == null)
			{
				lifeCycleStatus = LifeCycleStatusManager.Instance.Create();
				lifeCycleStatus.Uid = uid;
				lifeCycleStatus.Name = name;
				lifeCycleStatus.Save();
			}
			else if (lifeCycleStatus.Uid != uid)
			{
				lifeCycleStatus.Uid = uid;
				lifeCycleStatus.Save();
			}
			return lifeCycleStatus;
		};
		obj(DocumentConstants.DocumentStatusNewName, DocumentConstants.DocumentStatusNewUID);
		obj(DocumentConstants.DocumentStatusActiveName, DocumentConstants.DocumentStatusActiveUID);
		obj(DocumentConstants.DocumentStatusCancelName, DocumentConstants.DocumentStatusCancelUID);
		Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
	}

	public void UpdateDmsPermissionUids()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.Update("DmsObjectPermission", new string[1] { "Uid" }, new object[1] { Guid.Empty }, serviceNotNull.Dialect.QuoteIfNeeded("Uid") + " is null");
	}

	public void UpdateFilterDocumentFolderTypeGridState()
	{
		foreach (IFilterDocumentFolder item in FilterDocumentFolderManager.Instance.FindAll())
		{
			GridState gridState = ((item.GridState != null) ? GridState.Deserialize(item.GridState) : null);
			if (gridState != null && gridState.TypeGridState != null && item.DocumentFilter != null && item.DocumentFilter is SerializableFilter)
			{
				IDocumentFilter documentFilter = (IDocumentFilter)UniversalFilterSaver.UnPack(item.DocumentFilter);
				Type type = ((documentFilter.Types != null && documentFilter.Types.Count == 1) ? documentFilter.Types.First().EntityType : typeof(IDmsObject));
				Type type2 = ((gridState.TypeGridState == null) ? type : null);
				if (type2 != null)
				{
					gridState.TypeGridState = type2;
					FilterDocumentFolderManager.Instance.Save(item);
				}
			}
		}
	}

	public void AddManagerAccessToPermissions()
	{
		Filter filter = new Filter
		{
			Query = string.Format("PermissionId=Guid('{0}')", "38C8CB42-F887-4DF3-A1C6-36F331E9D8AC")
		};
		AbstractNHEntityManager<IDmsObjectPermission, long>.Instance.Find(filter, FetchOptions.All).ToList().ForEach(delegate(IDmsObjectPermission p)
		{
			InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
			instanceOf.New.DmsObject = p.DmsObject;
			instanceOf.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
			instanceOf.New.TypeRoleId = p.TypeRoleId;
			instanceOf.New.Group = p.Group;
			instanceOf.New.User = p.User;
			instanceOf.New.OrganizationItemPosition = p.OrganizationItemPosition;
			instanceOf.New.OrganizationItemEmployee = p.OrganizationItemEmployee;
			instanceOf.New.UserSecuritySetCacheId = p.UserSecuritySetCacheId;
			instanceOf.New.PermissionRole = p.PermissionRole;
			instanceOf.New.InheritedFromFolder = p.InheritedFromFolder;
			instanceOf.New.Save();
		});
	}

	public void AddCreateDocumentAccessToPermissions()
	{
		Filter filter = new Filter
		{
			Query = $"PermissionId=Guid('{PermissionProvider.DocumentEditPermission.Id}') and DmsObject in (select Id from Folder where Id > 0)"
		};
		AbstractNHEntityManager<IDmsObjectPermission, long>.Instance.Find(filter, FetchOptions.All).ToList().ForEach(delegate(IDmsObjectPermission p)
		{
			InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
			instanceOf.New.DmsObject = p.DmsObject;
			instanceOf.New.PermissionId = PermissionProvider.DocumentCreatePermission.Id;
			instanceOf.New.TypeRoleId = p.TypeRoleId;
			instanceOf.New.Group = p.Group;
			instanceOf.New.User = p.User;
			instanceOf.New.OrganizationItemPosition = p.OrganizationItemPosition;
			instanceOf.New.OrganizationItemEmployee = p.OrganizationItemEmployee;
			instanceOf.New.UserSecuritySetCacheId = p.UserSecuritySetCacheId;
			instanceOf.New.PermissionRole = p.PermissionRole;
			instanceOf.New.InheritedFromFolder = p.InheritedFromFolder;
			instanceOf.New.Save();
		});
	}

	public void DeleteDublicateFavoriteFolders()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("select ff.{1} from {2} ff\r\ninner join {3} dob on dob.{1} = ff.{1}\r\nwhere {0} in (\r\nselect {0} from {2}\r\ngroup by {0}\r\nhaving count({1}) > 1) and\r\n((select count({1}) from {3} where {4} = ff.{1}) = 0) ", serviceNotNull.Dialect.QuoteIfNeeded("Owner"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("FavoritesFolder"), serviceNotNull.Dialect.QuoteIfNeeded("DmsObject"), serviceNotNull.Dialect.QuoteIfNeeded("Folder"));
		List<long> list = new List<long>();
		using (IDataReader dataReader = serviceNotNull.ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				long num = Convert.ToInt64(dataReader[0]);
				if (num > 0)
				{
					list.Add(num);
				}
			}
		}
		foreach (long item in list)
		{
			FavoritesFolderManager.Instance.Load(item).Delete();
		}
	}

	public void CreateDefaultHistoryProfile()
	{
		if (DocumentHistoryProfileManager.Instance.LoadDefaultSettings() == null)
		{
			DocumentHistoryProfileManager.Instance.CreateNew(null, DocumentConstants.DefaultDocumentHistoryProfileUid);
		}
	}

	public void CreateDefaultActionsProfile()
	{
		if (DocumentActionsProfileManager.Instance.LoadDefaultSettings() == null)
		{
			DocumentActionSettingsHolder holder = DocumentActionsProfileManager.Instance.CreateNew();
			DocumentActionsProfileManager.Instance.SaveDefaultSettings(holder);
		}
	}

	public void FullRecreateSendableCache()
	{
		DocumentSendStatusCacheManager.Instance.Recreate();
	}

	public void UpdateDocumentVersionEncrypt()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.ExecuteNonQuery(string.Format("update {0} set {1}=0 where {1} is null", serviceNotNull.Dialect.QuoteIfNeeded("DocumentVersion"), serviceNotNull.Dialect.QuoteIfNeeded("Encrypt")));
		serviceNotNull.ExecuteNonQuery(string.Format("update {0} set {1}=0 where {1} is null", serviceNotNull.Dialect.QuoteIfNeeded("Document"), serviceNotNull.Dialect.QuoteIfNeeded("Encrypt")));
	}

	public void ClearDmsObjectPermissionsByGroups()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("delete from {0} where {1} not in (select {2} from {3})", serviceNotNull.Dialect.QuoteIfNeeded("DmsObjectPermission"), serviceNotNull.Dialect.QuoteIfNeeded("Group"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("UserGroup"));
		serviceNotNull.ExecuteNonQuery(sql);
	}

	public void FixOldInheariteDmsObjectPermissions()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("\r\ndelete from {0}\r\nwhere {1} in (\r\n\tselect dop.{1} from {0} dop\r\n\tinner join {2} dmso ON dmso.{1} = dop.{2}\r\n\twhere dmso.{3} = 0 AND dop.{4} IS NOT NULL\r\n)\r\n", serviceNotNull.Dialect.QuoteIfNeeded("DmsObjectPermission"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("DmsObject"), serviceNotNull.Dialect.QuoteIfNeeded("InheritPermissions"), serviceNotNull.Dialect.QuoteIfNeeded("InheritedFromFolder"));
		serviceNotNull.ExecuteNonQuery(sql);
	}

	public void CopySendData()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		ControlOnSendingInfo controlOnSendingInfo = DocumentMetadataHeadManager.Instance.PutControlOnSendingChanges();
		if (controlOnSendingInfo == null)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (ControlOnSendingItem info in controlOnSendingInfo.Infos)
		{
			DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(info.ParentMetadata);
			new List<DocumentMetadata>();
			if (info.ChildMetadata == null)
			{
				continue;
			}
			foreach (Guid childMetadatum in info.ChildMetadata)
			{
				DocumentMetadata documentMetadata2 = (DocumentMetadata)MetadataLoader.LoadMetadata(childMetadatum);
				List<string> list2 = new List<string>();
				foreach (string sendableDocumentProperty in DocumentMetadata.SendableDocumentProperties)
				{
					string item = string.Format("{0}=(select {4} from {1} where {2}={3}.{2})", serviceNotNull.Dialect.QuoteIfNeeded(sendableDocumentProperty), serviceNotNull.Dialect.QuoteIfNeeded(documentMetadata2.TableName), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded(documentMetadata.TableName), serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull.GetDeletingColumnTemporaryName(documentMetadata2.TableName, sendableDocumentProperty)));
					list2.Add(item);
				}
				string item2 = string.Format("update {0} set {1} where {2} in (select {2} from {3})", serviceNotNull.Dialect.QuoteIfNeeded(documentMetadata.TableName), string.Join(", ", list2), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded(documentMetadata2.TableName));
				list.Add(item2);
			}
		}
		foreach (string item3 in list)
		{
			try
			{
				serviceNotNull.ExecuteNonQuery(item3);
			}
			catch (Exception ex)
			{
				Logger.Log.Error(ex.Message, ex);
			}
		}
	}

	public void SetMyDocumentFolder()
	{
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		string text = string.Format("\r\n                select usr.* from {0} usr \r\n                left join {1} mdf on usr.{2} = mdf.{3} \r\n                where mdf.{3} is null and usr.{2} in \r\n                    (select dms.{4} from {5} dms \r\n                    inner join {6} doc on dms.{2} = doc.{2} \r\n                    where {7} is null)", base.Transformation.Dialect.QuoteIfNeeded("User"), base.Transformation.Dialect.QuoteIfNeeded("MyDocumentFolder"), base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("Owner"), base.Transformation.Dialect.QuoteIfNeeded("CreationAuthor"), base.Transformation.Dialect.QuoteIfNeeded("DmsObject"), base.Transformation.Dialect.QuoteIfNeeded("Document"), base.Transformation.Dialect.QuoteIfNeeded("Folder"));
		((IQuery)(object)session.CreateSQLQuery(text)).CleanUpCache(cleanUpCache: false).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(EleWise.ELMA.Security.Models.IUser))).List<EleWise.ELMA.Security.Models.IUser>()
			.ForEach(delegate(EleWise.ELMA.Security.Models.IUser u)
			{
				CreateDefaultPermissions(MyDocumentFolderManager.Instance.CreateForUser(u, createFavorite: false));
			});
		string query = string.Format("{0} from {1} where {2} = {3}", base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("MyDocumentFolder"), base.Transformation.Dialect.QuoteIfNeeded("Owner"), base.Transformation.Dialect.QuoteIfNeeded("CreationAuthor"));
		query = base.Transformation.SetupFetchOptions(query, new FetchOptions(0, 1));
		base.Transformation.ExecuteNonQuery(string.Format("\r\n                    update {1} set {2} = ({0}) \r\n                    where {3} in \r\n                        (select dms.{3} from {1} dms \r\n                        join {4} doc on dms.{3} = doc.{3} \r\n                        where {2} is null)", query, base.Transformation.Dialect.QuoteIfNeeded("DmsObject"), base.Transformation.Dialect.QuoteIfNeeded("Folder"), base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("Document")));
	}

	public void CreateDmsObjectRelationTable()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		Table table = new Table
		{
			Name = "Sys_DmsObjectRelation",
			Columns = new List<Column>
			{
				new Column("Parent", DbType.Int64),
				new Column("Child", DbType.Int64),
				new Column("Depth", DbType.Int64),
				new Column("Owner", DbType.Int64)
			}
		};
		serviceNotNull.AddTable(table);
		Table table2 = new Table
		{
			Name = dmsObjectRelationTableTempName,
			Columns = new List<Column>
			{
				new Column("Parent", DbType.Int64),
				new Column("Child", DbType.Int64),
				new Column("Depth", DbType.Int64),
				new Column("Owner", DbType.Int64)
			}
		};
		serviceNotNull.AddTable(table2);
	}

	public void CreateDmsObjectTreeNodeStateTable()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		Table table = new Table
		{
			Name = "Sys_DmsObjectTreeNodeState",
			Columns = new List<Column>
			{
				new Column("TreeId", DbType.String, 32),
				new Column("User", DbType.Int64),
				new Column("DmsObject", DbType.Int64),
				new Column("Expanded", DbType.Boolean),
				new Column("ParentExpanded", DbType.Boolean),
				new Column("Timestamp", DbType.DateTime)
			},
			ForeignKeys = new List<ForeignKey>
			{
				new ForeignKey
				{
					TableName = "Sys_DmsObjectTreeNodeState",
					Name = "FK_M_IDX_" + "User",
					Columns = new List<string> { "User" },
					RefTableName = "User",
					RefColumns = new List<string> { "Id" }
				}
			}
		};
		serviceNotNull.AddTable(table);
	}

	public void FillDmsObjectRelation()
	{
		string tableName = "Sys_DmsObjectRelation";
		string[] columns = new string[4] { "Parent", "Child", "Depth", "Owner" };
		Func<string, string> func = (string alias) => base.Transformation.NoLockTableExpression("Sys_DmsObjectRelation", alias);
		Func<string, string> sqlTableNameTemp = (string alias) => base.Transformation.NoLockTableExpression(dmsObjectRelationTableTempName, alias);
		string colParent = base.Transformation.Dialect.QuoteIfNeeded("Parent");
		string colChild = base.Transformation.Dialect.QuoteIfNeeded("Child");
		string colDepth = base.Transformation.Dialect.QuoteIfNeeded("Depth");
		string colOwner = base.Transformation.Dialect.QuoteIfNeeded("Owner");
		string selectColumnsName = $"res.{colParent}, res.{colChild}, res.{colDepth}, res.{colOwner}";
		Action action = delegate
		{
			base.Transformation.Insert(tableName, columns, selectColumnsName, string.Format("(select {0}, {1}, {2}, {3} from {4}) res", colParent, colChild, colDepth, colOwner, sqlTableNameTemp("s")), isNeedInsertId: false);
			base.Transformation.ExecuteNonQuery($"delete from {base.Transformation.Dialect.QuoteIfNeeded(dmsObjectRelationTableTempName)}");
		};
		base.Transformation.Insert(tableName, columns, new object[4] { 0, 0, 0, 0 });
		base.Transformation.Insert(tableName, columns, selectColumnsName, string.Format("(select distinct {0} {1}, d.{2} {3}, 1 {4}, {5} {6}\r\nfrom {7}\r\nleft join {8} on mdf.{2} = d.{2}) res", base.Transformation.Dialect.IsNull(base.Transformation.Dialect.QuoteIfNeeded("Folder"), "0"), colParent, base.Transformation.Dialect.QuoteIfNeeded("Id"), colChild, colDepth, base.Transformation.Dialect.IsNull(colOwner, "0"), colOwner, base.Transformation.NoLockTableExpression("DmsObject", "d"), base.Transformation.NoLockTableExpression("MyDocumentFolder", "mdf")), isNeedInsertId: false);
		string text = string.Format("(select s.{0} from {1} s where s.{2} = {1}.{3} and {5} != 0 and s.{4} = 1)", colOwner, base.Transformation.Dialect.QuoteIfNeeded(tableName), colChild, colParent, colDepth, base.Transformation.Dialect.IsNull("s." + colOwner, "0"));
		string sql = string.Format("update {0} set {1} = {2} where {3} = 0 and not {2} is null", tableName, colOwner, text, base.Transformation.Dialect.IsNull(colOwner, "0"));
		while (base.Transformation.ExecuteNonQuery(sql) != 0)
		{
		}
		base.Transformation.Update(tableName, new string[1] { "Owner" }, new object[1] { 0 }, $"{colOwner} is null");
		base.Transformation.Insert(dmsObjectRelationTableTempName, columns, selectColumnsName, string.Format("(select s.{1} {0}, s.{1} {1}, 0 {2}, s.{3} from {4} where s.{1} <> 0) res", colParent, colChild, colDepth, colOwner, func("s")), isNeedInsertId: false);
		action();
		int num = 1;
		bool flag;
		do
		{
			flag = base.Transformation.Insert(dmsObjectRelationTableTempName, columns, selectColumnsName, string.Format("(select parentTable.{0} {0}, childTable.{1} {1}, childTable.{2} + 1 {2}, childTable.{3} {3}\r\nfrom {4}\r\ninner join {5} on parentTable.{1} = childTable.{0}\r\nwhere parentTable.{2} = 1 and childTable.{2} = {6}) res", colParent, colChild, colDepth, colOwner, func("childTable"), func("parentTable"), num), isNeedInsertId: false) != 0;
			if (flag)
			{
				action();
			}
			num++;
		}
		while (flag);
		base.Transformation.RemoveTable(dmsObjectRelationTableTempName, removeSequence: false);
	}

	public void UpdateHasChildFolders()
	{
		base.Transformation.Update("Folder", new string[1] { "HasChildFolders" }, new object[1] { 1 }, string.Format("{0} in (select distinct d.{1} from {2}\r\n                inner join {3} on d.{0} = f.{0}\r\n                where not d.{1} is null)", base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("Folder"), base.Transformation.NoLockTableExpression("Folder", "f"), base.Transformation.NoLockTableExpression("DmsObject", "d")));
		base.Transformation.Update("Folder", new string[1] { "HasChildFolders" }, new object[1] { 0 }, string.Format("{0} is null", base.Transformation.Dialect.QuoteIfNeeded("HasChildFolders")));
	}

	internal void CreateMyDocumentsAndFavoritesFolders1()
	{
		string sql = string.Format("select usr.{2} from {0} usr \r\n                                        left join {1} mdf on usr.{2} = mdf.{3} \r\n                                        where mdf.{3} is null and {4} <> {5}", base.Transformation.Dialect.QuoteIfNeeded("User"), base.Transformation.Dialect.QuoteIfNeeded("MyDocumentFolder"), base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("Owner"), base.Transformation.Dialect.QuoteIfNeeded("Status"), 100);
		IDataReader dataReader = base.Transformation.ExecuteQuery(sql);
		List<long> list = new List<long>();
		using (dataReader)
		{
			while (dataReader.Read())
			{
				list.Add(Convert.ToInt64(dataReader["Id"]));
			}
		}
		if (list.Count != 0)
		{
			int num = 0;
			do
			{
				int count = Math.Min(1000, list.Count - num);
				long[] array = list.GetRange(num, count).ToArray();
				ProcessUserFolders(array);
				num += array.Length;
			}
			while (num < list.Count);
		}
	}

	internal void CopyTaskDocumentAttachments()
	{
		base.Transformation.Insert("M_Task_DAS", new string[2] { "TaskId", "DocumentAttachmentId" }, string.Format("dta.{0} task_Id, dta.{1} attachment_Id", base.Transformation.Dialect.QuoteIfNeeded("TaskId"), base.Transformation.Dialect.QuoteIfNeeded("DocumentAttachmentId")), "M_Task_DocumentAttachments dta", isNeedInsertId: false);
	}

	internal void UpdateDocumentMetadata(long[] metadataItemIds)
	{
		if (metadataItemIds.Length == 0)
		{
			return;
		}
		List<IMetadataItem> list = new List<IMetadataItem>();
		ICollection<IMetadataItem> collection = MetadataItemManager.Instance.FindByIdArray(metadataItemIds);
		List<Guid> list2 = new List<Guid>();
		foreach (IMetadataItem item in collection)
		{
			if (!(item.Metadata is DocumentMetadata documentMetadata) || documentMetadata.FormsScheme != 0)
			{
				continue;
			}
			switch (documentMetadata.Type)
			{
			case EntityMetadataType.InterfaceExtension:
				if (ShouldUpdateFormScheme(documentMetadata))
				{
					documentMetadata.FormsScheme = ClassFormsScheme.FormConstructor;
					list.Add(item);
					list2.Add(documentMetadata.Uid);
				}
				break;
			case EntityMetadataType.Interface:
				documentMetadata.FormsScheme = ClassFormsScheme.FormConstructor;
				list.Add(item);
				list2.Add(documentMetadata.Uid);
				break;
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		MetadataItemManager.Instance.Save(list);
		foreach (Guid item2 in list2)
		{
			if (MetadataLoader.LoadMetadataOrNull(item2) is DocumentMetadata documentMetadata2 && documentMetadata2.FormsScheme == ClassFormsScheme.Simple)
			{
				documentMetadata2.FormsScheme = ClassFormsScheme.FormConstructor;
			}
		}
		string sql = string.Format("update {0} set {1} = 1", base.Transformation.Dialect.QuoteIfNeeded("Sys_PreUpdateVersion"), base.Transformation.Dialect.QuoteIfNeeded("NeedRecompileCfgModel"));
		base.Transformation.ExecuteNonQuery(sql);
		base.Transformation.CommitTransaction();
	}

	private static bool ShouldUpdateFormScheme(DocumentMetadata documentMetadata)
	{
		if (documentMetadata.FormsScheme == ClassFormsScheme.Simple)
		{
			if (!(MetadataLoader.LoadMetadataOrNull(documentMetadata.BaseClassUid, inherit: false, loadImplementation: false) is DocumentMetadata documentMetadata2))
			{
				return false;
			}
			if (documentMetadata2.FormsScheme == ClassFormsScheme.Simple)
			{
				Guid guid = new Guid("2b660715-d111-4cc6-acfd-965661719fba");
				if (documentMetadata2.BaseClassUid == guid)
				{
					return false;
				}
				return ShouldUpdateFormScheme(documentMetadata2);
			}
			return true;
		}
		return false;
	}

	internal void CreateDmsObjectPermissionUpdateQueueItemTable()
	{
		if (!base.Transformation.TableExists("DmsObjectPermissionUpdateQueueItem"))
		{
			Table table = new Table
			{
				Name = "DmsObjectPermissionUpdateQueueItem",
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64, ColumnProperty.PrimaryKey),
					new Column("DmsObject", DbType.Int64),
					new Column("Patch", DbType.Binary),
					new Column("CreationDate", DbType.DateTime),
					new Column("Attempt", DbType.Int32),
					new Column("LastUpdateDate", DbType.DateTime),
					new Column("NextUpdateDate", DbType.DateTime),
					new Column("ServerConnectionUid", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("FolderId", DbType.Int64),
					new Column("FolderName", DbType.String)
				},
				Sequence = true
			};
			base.Transformation.AddTable(table);
		}
	}

	public static void DeleteFolderRecursive(IFolder folder)
	{
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		FindReferenceService serviceNotNull = Locator.GetServiceNotNull<FindReferenceService>();
		DeleteFolderRecursive(folder, serviceNotNull, session);
		session.Flush();
		DeleteEmptyDmsPermissions();
	}

	private static void DeleteFolderRecursive(IFolder folder, FindReferenceService entityRefService, ISession session)
	{
		foreach (IDmsObject item in EntityManager<IDmsObject>.Instance.Find((IDmsObject o) => o.Folder == folder))
		{
			IDmsObject dmsObject = item.CastAsRealType();
			if (dmsObject is IFolder folder2)
			{
				DeleteFolderRecursive(folder2, entityRefService, session);
				continue;
			}
			entityRefService.DeleteEntityReferences(dmsObject, null, session);
			dmsObject.HardDelete = true;
			dmsObject.Save();
			dmsObject.Delete();
		}
		entityRefService.DeleteEntityReferences(folder, null, session);
		folder.HardDelete = true;
		folder.Save();
		folder.Delete();
	}

	private static void DeleteEmptyDmsPermissions()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.ExecuteNonQuery(string.Format("delete from {0} where {1} is null", serviceNotNull.Dialect.QuoteIfNeeded("DmsObjectPermission"), serviceNotNull.Dialect.QuoteIfNeeded("DmsObject")));
	}

	private void SaveAndFlush<T>(IEnumerable<T> entities, Action<T> defaultPermissions) where T : IEntity<long>
	{
		foreach (T entity in entities)
		{
			defaultPermissions(entity);
			entity.Save();
		}
		SessionProvider.GetSession("").Flush();
	}

	private void ProcessUserFolders(long[] userIds)
	{
		ICollection<EleWise.ELMA.Security.Models.IUser> source = UserManager.FindByIdArray(userIds);
		string myDocFolderName = SR.T("Мои документы");
		string favouriteFolderName = SR.T("Избранное");
		Dictionary<EleWise.ELMA.Security.Models.IUser, IMyDocumentFolder> dictionary = source.ToDictionary((EleWise.ELMA.Security.Models.IUser user) => user, delegate(EleWise.ELMA.Security.Models.IUser user)
		{
			InstanceOf<IMyDocumentFolder> instanceOf2 = new InstanceOf<IMyDocumentFolder>();
			instanceOf2.New.Owner = user;
			instanceOf2.New.CreationAuthor = user;
			instanceOf2.New.Name = myDocFolderName;
			instanceOf2.New.FolderType = FolderType.MyDocuments;
			instanceOf2.New.SortTypeId = 500L;
			instanceOf2.New.HasChildFolders = true;
			return instanceOf2.New;
		});
		SaveAndFlush(dictionary.Values, CreateDefaultPermissions);
		Dictionary<IFavoritesFolder, IMyDocumentFolder> favToDocFolders = dictionary.ToDictionary(delegate(KeyValuePair<EleWise.ELMA.Security.Models.IUser, IMyDocumentFolder> pair)
		{
			InstanceOf<IFavoritesFolder> instanceOf = new InstanceOf<IFavoritesFolder>();
			instanceOf.New.Owner = pair.Key;
			instanceOf.New.CreationAuthor = pair.Key;
			instanceOf.New.Folder = pair.Value;
			instanceOf.New.Name = favouriteFolderName;
			instanceOf.New.FolderType = FolderType.Favorites;
			return instanceOf.New;
		}, (KeyValuePair<EleWise.ELMA.Security.Models.IUser, IMyDocumentFolder> pair) => pair.Value);
		SaveAndFlush(favToDocFolders.Keys, delegate(IFavoritesFolder favFolder)
		{
			CreateDefaultPermissionsForFavouriteFolder(favFolder, favToDocFolders[favFolder]);
		});
		IEnumerable<IDmsObject> enumerable = favToDocFolders.Values.OfType<IDmsObject>().Union(favToDocFolders.Keys);
		IDmsObjectRelationService serviceNotNull = Locator.GetServiceNotNull<IDmsObjectRelationService>();
		foreach (IDmsObject item in enumerable)
		{
			serviceNotNull.Insert(item);
		}
	}

	private static void AddDefaultPermissions(IDmsObject folder, EleWise.ELMA.Security.Models.IUser owner, IFolder inheritedFrom, Permission[] permissions)
	{
		long userMask;
		PermissionRoleType typeRole;
		if (folder != null)
		{
			userMask = UserSecuritySetHelper.GetUserMask(owner.Id);
			typeRole = CommonRoleTypes.User;
			for (int i = 0; i < permissions.Length; i++)
			{
				AddPermission(permissions[i]);
			}
		}
		void AddPermission(Permission permission)
		{
			ISet<IDmsObjectPermission> permissions2 = folder.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
			instanceOf.New.DmsObject = folder;
			instanceOf.New.PermissionId = permission.Id;
			instanceOf.New.TypeRoleId = typeRole.Id;
			instanceOf.New.User = owner;
			instanceOf.New.UserSecuritySetCacheId = userMask;
			instanceOf.New.InheritedFromFolder = inheritedFrom;
			permissions2.Add(instanceOf.New);
		}
	}

	private static void CreateDefaultPermissions(IMyDocumentFolder folder)
	{
		AddDefaultPermissions(folder, folder.Owner, null, DefaultPermissions);
	}

	private static void CreateDefaultPermissions(IDmsObject folder, EleWise.ELMA.Security.Models.IUser owner)
	{
		AddDefaultPermissions(folder, owner, null, DefaultPermissions);
	}

	private static void CreateDefaultPermissionsForFavouriteFolder(IFavoritesFolder folder, IMyDocumentFolder myDocFolder)
	{
		if (folder != null)
		{
			CreateDefaultPermissions(folder, folder.Owner);
			AddDefaultPermissions(folder, folder.Owner, myDocFolder, DefaultPermissions);
		}
	}
}
