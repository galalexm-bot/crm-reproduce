using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Enums;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class FolderManager<T, TId> : DmsObjectManager<T, TId> where T : IFolder, IEntity<TId>
{
	public override SecurityException CreateSecurityException(string text, object id)
	{
		IMetadata metadata = MetadataLoader.LoadMetadata(typeof(T));
		return new EntitySecurityException(text)
		{
			TypeUid = metadata.Uid,
			EntityId = Convert.ToInt64(id),
			Permissions = new List<Guid>
			{
				PermissionProvider.DocumentFullAccessPermission.Id,
				PermissionProvider.DocumentManagerAccessPermission.Id
			}
		};
	}

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	[ContextCache]
	public virtual bool IsFolder(Guid typeUid)
	{
		return GetFolderTypes(onlyChild: false).Any((ClassMetadata t) => t.Uid == typeUid);
	}

	[ContextCache]
	public virtual IEnumerable<ClassMetadata> GetFolderTypes(bool onlyChild = true)
	{
		return GenerateFolderTypes(onlyChild);
	}

	protected virtual IEnumerable<ClassMetadata> GenerateFolderTypes(bool onlyChild)
	{
		ClassMetadata classMetadata = (ClassMetadata)InterfaceActivator.LoadMetadata<IFolder>();
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(classMetadata);
		if (!onlyChild)
		{
			childClasses.Insert(0, classMetadata);
		}
		return childClasses;
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public class FolderManager : FolderManager<IFolder, long>
{
	internal class DocumentNameWithFiles
	{
		public string Name { get; set; }

		public string File { get; set; }
	}

	private const string RootCacheKey = "FOLDERROOT";

	private const string RootCacheTimestampKey = "FOLDERROOTTIMESTAMP";

	private const string RootCacheTimestampRegionKey = "FOLDERROOTTIMESTAMPREGION";

	private const string PathCacheKey = "FOLDERPATH";

	private const string PathCacheTimestampKey = "FOLDERPATHTIMESTAMP";

	private const string PathCacheTimestampRegionKey = "FOLDERPATHTIMESTAMPREGION";

	private const string FolderRootsCacheKey = "FOLDERROOTS";

	private const string FolderFullTreeForAdminName = "FOLDERFULLTREEFORADMIN";

	private const string FolderTreeDownByStateForAdminName = "FOLDERTREEFORADMIN";

	private const string FolderFullTreeForUserName = "FOLDERFULLTREEFORUSER";

	private const string FolderTreeDownByStateForUserName = "FOLDERTREEFORUSER";

	private const string FolderRootsCacheTimestampKey = "FOLDERROOTSTIMESTAMP";

	private const string FolderRootsCacheTimestampRegionKey = "FOLDERROOTSTIMESTAMPREGION";

	private const string FolderFullTreeForUserTimestamp = "FOLDERFULLTREEFORUSERTIMESTAMP";

	private const string FolderFullTreeForUserTimestampRegion = "FOLDERFULLTREEFORUSERTIMESTAMPREGION";

	private const string FolderTreeForUserTimestamp = "FOLDERTREEFORUSERTIMESTAMP";

	private const string FolderTreeForUserTimestampRegion = "FOLDERTREEFORUSERTIMESTAMPREGION";

	private static DocumentsSettingsModule documentsSettingsModule;

	[NotNull]
	public new static FolderManager Instance => Locator.GetServiceNotNull<FolderManager>();

	public IFullTextTreeService FullTextTreeService { get; set; }

	private static DocumentsSettingsModule DocumentsSettingsModule => documentsSettingsModule ?? (documentsSettingsModule = Locator.GetService<DocumentsSettingsModule>());

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	public void ClearFolderTreeCache()
	{
		base.ComplexCacheService.RefreshTimestampRegion("FOLDERTREEFORUSERTIMESTAMPREGION");
		base.ComplexCacheService.RefreshTimestampRegion("FOLDERFULLTREEFORUSERTIMESTAMPREGION");
		base.ComplexCacheService.RefreshTimestampRegion("FOLDERROOTTIMESTAMPREGION");
		base.ComplexCacheService.RefreshTimestampRegion("FOLDERPATHTIMESTAMPREGION");
		base.ComplexCacheService.RefreshTimestampRegion("FOLDERROOTSTIMESTAMPREGION");
	}

	public void ClearFolderTreeCacheForCurrentUser(long? rootId, string treeId)
	{
		string text = base.DmsObjectTreeNodeStateService.TreeIdToHashString(treeId);
		long id = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id;
		string timestampKey = "FOLDERTREEFORUSERTIMESTAMP" + id + (rootId ?? 0) + text;
		base.ComplexCacheService.RefreshTimestamp(timestampKey);
	}

	public override ActionCheckResult CanSave(IFolder obj)
	{
		if (obj == null)
		{
			return ActionCheckResult.False(SR.T("Невозможно сохранить пустую ссылку"));
		}
		if (obj.Folder != null)
		{
			if (base.SecurityServiceExists && !base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, obj.Folder))
			{
				return ActionCheckResult.False(SR.T("Невозможно сохранить папку \"{0}\" в папке \"{1}\", так как у папки нет привилегии \"Редактирование\"", obj.Name, obj.Folder));
			}
			if (CheckFolderWithSameName(obj))
			{
				return ActionCheckResult.False(SR.T("Невозможно сохранить папку \"{0}\" в папке \"{1}\", так как в папке \"{1}\" существует папка с именем \"{0}\"", obj.Name, obj.Folder));
			}
		}
		return ActionCheckResult.True;
	}

	public IEnumerable<FolderTreeNode> LoadTree()
	{
		return LoadTree(null);
	}

	internal IEnumerable<FolderTreeNode> LoadTree(long? rootId, LoadTreeMode mode = LoadTreeMode.Full, string treeId = null)
	{
		bool full = mode == LoadTreeMode.Full;
		string treeUid = (full ? string.Empty : base.DmsObjectTreeNodeStateService.TreeIdToHashString(treeId));
		bool isAdmin = base.SecurityService.HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission);
		long userId = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id;
		long validRootId = rootId ?? 0;
		string query = ((!isAdmin) ? (full ? "FOLDERFULLTREEFORUSER" : "FOLDERTREEFORUSER") : (full ? "FOLDERFULLTREEFORADMIN" : "FOLDERTREEFORADMIN"));
		Func<IEnumerable<FolderTreeNode>> valueAccessor = () => base.Session.GetNamedQuery(query).CleanUpCache(cleanUpCache: false).SetInt64("rootId", validRootId)
			.SetInt64("userId", userId)
			.SetString("treeId", treeUid)
			.SetResultTransformer((IResultTransformer)(object)new FolderTreeNodeResultTransformer(null, isAdmin))
			.List<FolderTreeNode>();
		if (!full && validRootId > 0)
		{
			return valueAccessor();
		}
		string key = (full ? "FOLDERFULLTREEFORUSER" : "FOLDERTREEFORUSER") + userId + validRootId + treeUid;
		string timestampKey = (full ? "FOLDERFULLTREEFORUSERTIMESTAMP" : "FOLDERTREEFORUSERTIMESTAMP") + userId + validRootId + treeUid;
		string timestampRegionKey = (full ? "FOLDERFULLTREEFORUSERTIMESTAMPREGION" : "FOLDERTREEFORUSERTIMESTAMPREGION");
		return base.ComplexCacheService.GetOrAdd(key, timestampKey, timestampRegionKey, delegate
		{
			if (full && validRootId <= 0)
			{
				IEnumerable<FolderTreeNode> enumerable = FullTextTreeService.LoadTreeFromIndex();
				return enumerable ?? valueAccessor();
			}
			return valueAccessor();
		}, TimeSpan.FromDays(7.0));
	}

	public IEnumerable<FolderTreeNode> LoadTreeAll()
	{
		return base.ComplexCacheService.GetOrAdd("FOLDERFULLTREEFORUSER", "FOLDERFULLTREEFORUSERTIMESTAMP", "FOLDERFULLTREEFORUSERTIMESTAMPREGION", () => base.Session.GetNamedQuery("FolderFullTree").CleanUpCache(cleanUpCache: false).SetInt64("rootId", 0L)
			.SetResultTransformer((IResultTransformer)(object)new FolderTreeNodeResultTransformer())
			.List<FolderTreeNode>(), TimeSpan.FromDays(7.0));
	}

	public IFolder GetRoot(IFolder folder)
	{
		FolderTreeNode node = base.ComplexCacheService.GetOrAdd("FOLDERROOT" + folder.Id, "FOLDERROOTTIMESTAMP" + folder.Id, "FOLDERROOTTIMESTAMPREGION", () => base.Session.GetNamedQuery("GETROOTQUERY").CleanUpCache(cleanUpCache: false).SetInt64("folderId", folder.Id)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(FolderTreeNode)))
			.List<FolderTreeNode>()
			.LastOrDefault(), TimeSpan.FromDays(7.0));
		if (node == null)
		{
			return null;
		}
		IFolder root = null;
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			root = Load(node.Id);
		});
		return root;
	}

	public string GetFolderPathWithMyDocuments(IFolder folder)
	{
		return GetFolderPath(folder, convertMyDocuments: false, convertForAll: true);
	}

	public string GetFolderPath(IFolder folder, bool convertMyDocuments = false)
	{
		return GetFolderPath(folder, convertMyDocuments, convertForAll: false);
	}

	public string GetFolderPath(IFolder folder, bool convertMyDocuments, bool convertForAll)
	{
		Contract.ArgumentNotNull(folder, "folder");
		return GetFolderPath(folder.Id, convertMyDocuments, convertForAll);
	}

	public string GetFolderPath(long folderId, bool convertMyDocuments, bool convertForAll)
	{
		long currentUserId = (long)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId();
		string text = $"{folderId}_{currentUserId}_{convertMyDocuments}_{convertForAll}";
		return base.ComplexCacheService.GetOrAdd("FOLDERPATH" + text, "FOLDERPATHTIMESTAMP" + text, "FOLDERPATHTIMESTAMPREGION", delegate
		{
			IList<FolderTreeNode> folderPath = GetFolderPath(folderId);
			long[] idArray = (from f in folderPath
				where f.FolderType == 1
				select f.CreationAuthor).Distinct().ToArray();
			Dictionary<long, EleWise.ELMA.Security.Models.IUser> authorsId = UserManager.Instance.FindByIdArray(idArray).ToDictionary((EleWise.ELMA.Security.Models.IUser x) => x.Id, (EleWise.ELMA.Security.Models.IUser v) => v);
			Func<FolderTreeNode, bool> shouldConvert = (FolderTreeNode f) => f.FolderType == 1 && f.CreationAuthor != currentUserId;
			return string.Join("/", ((convertForAll || convertMyDocuments) ? folderPath.Select((FolderTreeNode f) => (!shouldConvert(f)) ? f.Name : SR.T("Документы ({0})", authorsId[f.CreationAuthor].FullName)) : folderPath.Select((FolderTreeNode f) => f.Name)).Reverse());
		}, TimeSpan.FromDays(7.0));
	}

	public IList<FolderTreeNode> GetFolderPath(long folderId)
	{
		return base.Session.GetNamedQuery("GETROOTQUERY").CleanUpCache(cleanUpCache: false).SetInt64("folderId", folderId)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(FolderTreeNode)))
			.List<FolderTreeNode>();
	}

	public List<IFolder> GetRoots()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return base.ComplexCacheService.GetOrAdd("FOLDERROOTS" + currentUser.Id, "FOLDERROOTSTIMESTAMP" + currentUser.Id, "FOLDERROOTSTIMESTAMPREGION", () => (from f in CreateCriteria().Add((ICriterion)(object)Restrictions.IsNull("Folder")).List<IFolder>()
			where f != null && Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentViewPermission, f)
			select f).ToList(), TimeSpan.FromDays(7.0));
	}

	public List<IFolder> GetRootsAll()
	{
		return base.ComplexCacheService.GetOrAdd("FOLDERROOTS", "FOLDERROOTSTIMESTAMP", "FOLDERROOTSTIMESTAMPREGION", () => CreateCriteria().Add((ICriterion)(object)Restrictions.IsNull("Folder")).List<IFolder>().ToList(), TimeSpan.FromDays(7.0));
	}

	public IEnumerable<IFolder> GetAllSubFolders(IFolder folder)
	{
		if (folder == null)
		{
			throw new NullReferenceException("Папка не может быть null");
		}
		SqlSubQuery sqlSubQuery = base.Session.GetNamedSubQuery("GetSubfoldersQuery").SetParameter("folderId", folder.Id);
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)NHQueryExtensions.Sql("{Folder} in (" + sqlSubQuery.Sql + ")", sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes));
		IList<IFolder> list = obj.List<IFolder>();
		if (!list.Contains(folder))
		{
			list.Add(folder);
		}
		return list;
	}

	public IEnumerable<long> GetAllSubFoldersId(long folderId)
	{
		List<long> list = (from n in base.Session.GetNamedQuery("GetSubfoldersQuery").CleanUpCache(cleanUpCache: false).SetInt64("folderId", folderId)
				.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(FolderTreeNode)))
				.List<FolderTreeNode>()
				.ToList()
			select n.Id).ToList();
		if (!list.Contains(folderId))
		{
			list.Add(folderId);
		}
		return list;
	}

	public bool IsParentFolder(IFolder folder, IFolder toFolder)
	{
		if (folder == null || toFolder == null)
		{
			return false;
		}
		List<long> list = (from n in base.Session.GetNamedQuery("GETROOTQUERY").CleanUpCache(cleanUpCache: false).SetInt64("folderId", toFolder.Id)
				.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(FolderTreeNode)))
				.List<FolderTreeNode>()
			select n.Id).ToList();
		if (list != null && list.Exists((long n) => n == folder.Id && n != toFolder.Id))
		{
			return true;
		}
		return false;
	}

	public virtual bool HasChildsByType(IFolder folder, Guid typeUid)
	{
		return GetAllChildIdsByType(folder, typeUid).Count > 0;
	}

	public List<long> GetAllChildIdsByType(IFolder folder, Guid typeUid)
	{
		Contract.ArgumentNotNull(folder, "folder");
		return GetAllChildIdsByType(folder.Id, typeUid);
	}

	public List<long> GetAllChildIdsByType(long folderId, Guid typeUid)
	{
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeUid);
		List<ClassMetadata> childMetadaties = MetadataLoader.GetChildClasses(classMetadata);
		childMetadaties.Add(classMetadata);
		return (from r in base.Session.GetNamedQuery("GetSubDmsObjectsQuery").CleanUpCache(cleanUpCache: false).SetInt64("folderId", folderId)
				.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(FolderTreeNode)))
				.List<FolderTreeNode>()
				.ToList()
			where childMetadaties.Any((ClassMetadata m) => m.Uid == r.NodeTypeUid)
			select r into n
			select n.Id).ToList();
	}

	public bool HasNestedFolders(IFolder folder)
	{
		Contract.ArgumentNotNull(folder, "folder");
		string arg = string.Format("\r\n                select r.{1} from {0} r\r\n                inner join {2} f on r.{1}= f.{3}\r\n                inner join {6} d on d.{3}= f.{3}\r\n                where r.{4}={5}folderId and r.{1}<>{5}folderId and d.{7}<>1", base.TransformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), base.TransformationProvider.Dialect.QuoteIfNeeded("Child"), base.TransformationProvider.Dialect.QuoteIfNeeded("Folder"), base.TransformationProvider.Dialect.QuoteIfNeeded("Id"), base.TransformationProvider.Dialect.QuoteIfNeeded("Parent"), base.TransformationProvider.ParameterSeparator, base.TransformationProvider.Dialect.QuoteIfNeeded("DmsObject"), base.TransformationProvider.Dialect.QuoteIfNeeded("IsDeleted"));
		string sql = string.Format("select 1 v from {0} where exists ({1})", base.TransformationProvider.Dialect.QuoteIfNeeded("Sys_PreUpdateVersion"), arg);
		Dictionary<string, object> paramValues = new Dictionary<string, object> { { "folderId", folder.Id } };
		using IDataReader dataReader = base.TransformationProvider.ExecuteQuery(sql, paramValues);
		return dataReader.Read();
	}

	public bool CheckFolderWithSameName(IFolder obj)
	{
		if (obj != null)
		{
			return CheckFolderWithSameNameInternal(obj.Folder, obj.Name);
		}
		return false;
	}

	public bool CheckFolderWithSameName(IFolder parent, string folderName)
	{
		return CheckFolderWithSameNameInternal(parent, folderName);
	}

	internal long DocumentsWithAttachmentsCount(IFolder folder)
	{
		return Convert.ToInt64(((IQuery)base.Session.CreateSQLQuery(string.Format("\r\n                    select Count(*) from {0} dms\r\n                    left outer join {1} d on dms.{2} = d.{2}\r\n                    left outer join {3} dv on d.{4} = dv.{2}\r\n                    where \r\n                        {5} = :folderId \r\n                        and d.{4} is not null\r\n                        and {6} = :falseValue\r\n                        and {7} = :falseValue", base.Transformation.Dialect.QuoteIfNeeded("DmsObject"), base.Transformation.Dialect.QuoteIfNeeded("Document"), base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("DocumentVersion"), base.Transformation.Dialect.QuoteIfNeeded("CurrentVersion"), base.Transformation.Dialect.QuoteIfNeeded("Folder"), base.Transformation.Dialect.IsNull("dms." + base.Transformation.Dialect.QuoteIfNeeded("IsDeleted"), ":falseValue"), base.Transformation.Dialect.IsNull("dms." + base.Transformation.Dialect.QuoteIfNeeded("IsArchived"), ":falseValue")))).SetParameter<long>("folderId", folder.Id).SetParameter<bool>("falseValue", false).CleanUpCache(cleanUpCache: false)
			.UniqueResult());
	}

	internal IEnumerable<DocumentNameWithFiles> GetDocumentsWithAttachments(IFolder folder)
	{
		return ((IQuery)base.Session.CreateSQLQuery(string.Format("\r\n                    select dms.{0}, dv.{1} from {2} dms\r\n                    left outer join {3} d on dms.{4} = d.{4}\r\n                    left outer join {5} dv on d.{6} = dv.{4}\r\n                    where \r\n                        {7} = :folderId\r\n                        and d.{6} is not null\r\n                        and {8} = :falseValue\r\n                        and {9} = :falseValue", base.Transformation.Dialect.QuoteIfNeeded("Name"), base.Transformation.Dialect.QuoteIfNeeded("File"), base.Transformation.Dialect.QuoteIfNeeded("DmsObject"), base.Transformation.Dialect.QuoteIfNeeded("Document"), base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("DocumentVersion"), base.Transformation.Dialect.QuoteIfNeeded("CurrentVersion"), base.Transformation.Dialect.QuoteIfNeeded("Folder"), base.Transformation.Dialect.IsNull("dms." + base.Transformation.Dialect.QuoteIfNeeded("IsDeleted"), ":falseValue"), base.Transformation.Dialect.IsNull("dms." + base.Transformation.Dialect.QuoteIfNeeded("IsArchived"), ":falseValue")))).SetParameter<long>("folderId", folder.Id).SetParameter<bool>("falseValue", false).CleanUpCache(cleanUpCache: false)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(DocumentNameWithFiles)))
			.List<DocumentNameWithFiles>();
	}

	private static bool CheckFolderWithSameNameInternal(IFolder parent, string folderName)
	{
		DocumentsSettings documentsSettings = DocumentsSettingsModule?.Settings;
		if (documentsSettings == null)
		{
			return false;
		}
		if (documentsSettings.CanSaveFolderWithSameName)
		{
			return false;
		}
		if (parent == null || !parent.HasChildFolders)
		{
			return false;
		}
		IDmsObjectFilter dmsObjectFilter = InterfaceActivator.Create<IDmsObjectFilter>();
		dmsObjectFilter.Query = $"Folder = {parent.Id} AND Name like '{folderName}'";
		return EntityManager<IFolder>.Instance.Exists(dmsObjectFilter);
	}

	[PublicApiMember]
	public virtual IFolder CreateFolder(IFolder parentFolder, string folderName, bool inherit, bool duplicateNames)
	{
		IFolder folder = InterfaceActivator.Create<IFolder>();
		folder.Folder = parentFolder;
		folder.InheritPermissions = inherit;
		if (duplicateNames)
		{
			folder.Name = (folderName.IsNullOrEmpty() ? SR.T("Новая папка") : folderName);
		}
		else
		{
			IDmsObjectFilter dmsObjectFilter = InterfaceActivator.Create<IDmsObjectFilter>();
			dmsObjectFilter.Folder = parentFolder;
			ICollection<IFolder> collection = EntityManager<IFolder>.Instance.Find(dmsObjectFilter, null);
			string text = ((folderName == "") ? SR.T("Новая папка") : folderName);
			bool flag = false;
			foreach (IFolder item in collection)
			{
				if (item.Name == text)
				{
					flag = true;
				}
			}
			if (flag)
			{
				int num = 1;
				string arg = text;
				while (flag)
				{
					flag = false;
					text = $"{arg} ({num})";
					num++;
					foreach (IFolder item2 in collection)
					{
						if (item2.Name == text)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						folder.Name = text;
					}
				}
			}
			else
			{
				folder.Name = text;
			}
		}
		folder.Save();
		return folder;
	}

	[PublicApiMember]
	public virtual IFolder CreateFolder(IFolder parentFolder, string folderName)
	{
		return CreateFolder(parentFolder, folderName, inherit: true, duplicateNames: true);
	}

	[PublicApiMember]
	public virtual IFolder CreateFolder(IFolder parentFolder, string folderName, bool inherit)
	{
		return CreateFolder(parentFolder, folderName, inherit, duplicateNames: true);
	}

	[PublicApiMember]
	public virtual IFolder CreateFolder(IFolder parentFolder)
	{
		return CreateFolder(parentFolder, null, inherit: true, duplicateNames: true);
	}

	[PublicApiMember]
	public virtual void Move(IFolder oldParentFolder, IFolder removedFolder, IFolder newParentFolder)
	{
		IDmsObjectFilter dmsObjectFilter = InterfaceActivator.Create<IDmsObjectFilter>();
		dmsObjectFilter.Folder = oldParentFolder;
		dmsObjectFilter.Id = removedFolder.Id;
		IFolder obj = EntityManager<IFolder>.Instance.Find(dmsObjectFilter, null).FirstOrDefault() ?? throw new NullReferenceException(SR.T("Перемещаемая папка не найдена"));
		obj.Folder = newParentFolder;
		obj.Save();
	}

	[PublicApiMember]
	public virtual IEnumerable<IDocument> GetAllDocuments(IFolder folder)
	{
		return Instance.GetAllDocuments(folder, searchInInnerFolders: false);
	}

	[PublicApiMember]
	public virtual IEnumerable<IDocument> GetAllDocuments(IFolder folder, bool searchInInnerFolders)
	{
		if (folder == null)
		{
			throw new ArgumentNullException("folder не может быть null");
		}
		IDocumentFilter documentFilter = InterfaceActivator.Create<IDocumentFilter>();
		if (!searchInInnerFolders)
		{
			documentFilter.Folder = folder;
		}
		else
		{
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			IEnumerable<long> collection = ((IQuery)(object)base.Session.CreateSQLQuery(string.Format("select {0} from {1}", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.TableFunction("GetSubfolders", ":folderId")))).CleanUpCache(cleanUpCache: false).SetParameter<long>("folderId", folder.Id).List<object>()
				.Select(Convert.ToInt64);
			documentFilter.Query = string.Format("Folder in ({0})", collection.ToSeparatedString(", "));
		}
		return AbstractNHEntityManager<IDocument, long>.Instance.Find(documentFilter, null);
	}

	[PublicApiMember]
	public virtual IEnumerable<IDmsObject> GetAllChildren(IFolder folder)
	{
		if (folder == null)
		{
			throw new NullReferenceException(SR.T("Папка не может быть null"));
		}
		IDmsObjectFilter dmsObjectFilter = InterfaceActivator.Create<IDmsObjectFilter>();
		dmsObjectFilter.Folder = folder;
		return EntityManager<IDmsObject>.Instance.Find(dmsObjectFilter, null);
	}

	[PublicApiMember]
	public virtual IEnumerable<IFolder> FindFolders(string folderName)
	{
		IDmsObjectFilter dmsObjectFilter = InterfaceActivator.Create<IDmsObjectFilter>();
		dmsObjectFilter.Name = folderName;
		return EntityManager<IFolder>.Instance.Find(dmsObjectFilter, null);
	}

	[PublicApiMember]
	public virtual IEnumerable<IFolder> FindFolders(IFolder parentFolder, string folderName)
	{
		IDmsObjectFilter dmsObjectFilter = InterfaceActivator.Create<IDmsObjectFilter>();
		dmsObjectFilter.Folder = parentFolder;
		dmsObjectFilter.Name = folderName;
		return EntityManager<IFolder>.Instance.Find(dmsObjectFilter, null);
	}

	[PublicApiMember]
	public virtual IMyDocumentFolder GetMyDocumentFolder(EleWise.ELMA.Security.Models.IUser user)
	{
		if (user == null)
		{
			throw new NullReferenceException(SR.T("Пользователь не может быть null"));
		}
		return EntityManager<IMyDocumentFolder>.Instance.Find(new Filter
		{
			Query = $"Owner = {user.Id}"
		}, null).FirstOrDefault();
	}
}
