using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;
using System.Threading;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Audit;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.FullTextSearch;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using NHibernate.Type;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class DmsObjectManager<T, TId> : EntityManager<T, TId> where T : IDmsObject, IEntity<TId>
{
	private const string DmsObjectType = "DMSOBJECTTYPEUID";

	private const string DmsObjectTypeTimestamp = "DMSOBJECTTYPEUIDTIMESTAMP";

	internal const string EnableInheritPermissionsKey = "EleWise.ELMA.Documents.Managers.DmsObjectManager.EnableInheritPermissions";

	internal const string MoveToKey = "EleWise.ELMA.Documents.Managers.DmsObjectManager.MoveTo";

	public IDmsObjectRelationService DmsObjectRelationService { get; set; }

	public IDmsObjectTreeNodeStateService DmsObjectTreeNodeStateService { get; set; }

	public IComplexCacheService ComplexCacheService => Locator.GetServiceNotNull<IComplexCacheService>();

	public ITransformationProvider TransformationProvider => Locator.GetServiceNotNull<ITransformationProvider>();

	private DmsObjectPermissionPatcherService DmsObjectPermissionPatcherService => DmsObjectPermissionPatcherService.Instance;

	public ISystemFoldersService SystemFoldersService => Locator.GetServiceNotNull<ISystemFoldersService>();

	public IEntityActionHandler EntityActionHandler { get; set; }

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	protected override void SetupFetchOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		if (typeof(T).IsAssignableFrom(entityType) && !(criteria is DetachedCriteriaAdapter))
		{
			criteria.AddOrder(Order.Asc("SortTypeId"));
		}
		base.SetupFetchOptions(criteria, fetchOptions, entityType);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is IDmsObjectFilter dmsObjectFilter))
		{
			return;
		}
		if (dmsObjectFilter.DocumentType.HasValue)
		{
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(dmsObjectFilter.DocumentType.Value);
			List<Guid> list = (from f in MetadataLoader.GetChildClasses(classMetadata)
				select f.Uid).ToList();
			list.Add(classMetadata.Uid);
			if (!dmsObjectFilter.ReturnOnlyDocuments)
			{
				ClassMetadata classMetadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(IFolder));
				List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(classMetadata2);
				list.AddRange(childClasses.Select((ClassMetadata f) => f.Uid));
				list.Add(classMetadata2.Uid);
			}
			criteria.Add((ICriterion)(object)Restrictions.In(GetTypeUidPropertyName(filter), (ICollection)list));
		}
		EleWise.ELMA.Security.IUser user = filter?.PermissionUser ?? base.AuthenticationService.GetCurrentUser();
		if (dmsObjectFilter.Permissions != null && dmsObjectFilter.Permissions.Any() && user != null && !base.SecurityService.HasPermission(user, PermissionProvider.DocumentsAdminAccessPermission))
		{
			_ = ((EntityMetadata)MetadataLoader.LoadMetadata(typeof(T))).TableName;
			string arg = string.Join(",", dmsObjectFilter.Permissions.Select((Guid q) => $"'{q}'"));
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			criteria.Add((ICriterion)(object)Expression.Sql(string.Format("{{alias}}.{0} in (\r\n\t\t\t\t\t\t\t\tSELECT dop.DmsObject\r\n\t\t\t\t\t\t\t\tFROM UserSecuritySetCache sc\r\n\t\t\t\t\t\t\t\tleft join DmsObjectPermission dop on dop.UserSecuritySetCacheId=sc.SetId\r\n\t\t\t\t\t\t\t\twhere sc.UserId={1} and dop.PermissionId in ({2}))", serviceNotNull.Dialect.QuoteIfNeeded("Id"), ((EleWise.ELMA.Security.Models.IUser)user).Id, arg)));
		}
	}

	protected override void SetupAutoFilter(ICriteria criteria, IEntityFilter filter, EntityMetadata metadata, string alias = null)
	{
		Contract.ArgumentNotNull(criteria, "criteria");
		Contract.ArgumentNotNull(filter, "filter");
		Contract.ArgumentNotNull(metadata, "metadata");
		Contract.ServiceNotNull(base.MetadataRuntimeService, "MetadataRuntimeService");
		if (!(filter is IDmsObjectFilter))
		{
			base.SetupAutoFilter(criteria, filter, metadata, alias);
			return;
		}
		IDmsObjectFilter dmsObjectFilter = (IDmsObjectFilter)filter;
		if (!dmsObjectFilter.HierarchicalByFolder && !dmsObjectFilter.IsArchived.HasValue)
		{
			base.SetupAutoFilter(criteria, filter, metadata, alias);
			return;
		}
		foreach (EntityPropertyMetadata property in metadata.Properties)
		{
			if (!property.Filterable)
			{
				continue;
			}
			PropertyInfo reflectionProperty = filter.GetType().GetReflectionProperty(property.Name);
			if (reflectionProperty == null || reflectionProperty.IsDefined(typeof(PropertyAttribute), inherit: true))
			{
				continue;
			}
			ITypeDescriptor typeDescriptor = base.MetadataRuntimeService.GetTypeDescriptor(property.TypeUid, property.SubTypeUid);
			if (typeDescriptor == null || typeDescriptor.GetFilterType(property, metadata) == Guid.Empty)
			{
				continue;
			}
			IFilterableType filterableType = (IFilterableType)base.MetadataRuntimeService.GetTypeDescriptor(typeDescriptor.GetFilterType(property, metadata), property.SubTypeUid);
			if (filterableType == null)
			{
				continue;
			}
			object value = reflectionProperty.GetValue(filter, null);
			if (property.Name == "Folder" && dmsObjectFilter.Folder != null && dmsObjectFilter.Folder.Id > 0 && dmsObjectFilter.HierarchicalByFolder)
			{
				SqlSubQuery sqlSubQuery = base.Session.GetNamedSubQuery("GetSubfoldersQuery").SetParameter("folderId", dmsObjectFilter.Folder.Id);
				criteria.Add((ICriterion)(object)NHQueryExtensions.Sql("{Folder} in (" + sqlSubQuery.Sql + ")", sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes));
				if (!string.IsNullOrWhiteSpace(filter.Query))
				{
					SetupFilterQuery(criteria, filter, metadata, alias);
				}
			}
			else if (property.Name == "IsArchived")
			{
				bool flag = dmsObjectFilter.IsArchived.HasValue && dmsObjectFilter.IsArchived.Value;
				ITransformationProvider service = Locator.GetService<ITransformationProvider>();
				if (service != null)
				{
					criteria.Add((ICriterion)(object)Restrictions.EqProperty(Projections.SqlFunction(service.Dialect.GetIsNullFunctionName(), (IType)(object)NHibernateUtil.Boolean, (IProjection[])(object)new IProjection[2]
					{
						(IProjection)Projections.Property("IsArchived"),
						Projections.Constant((object)0)
					}), flag ? Projections.Constant((object)1) : Projections.Constant((object)0)));
				}
				else
				{
					criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("IsArchived"), (ICriterion)(object)Restrictions.Eq("IsArchived", (object)flag)));
				}
			}
			else
			{
				filterableType.ApplyFilterValue(criteria, metadata, property, value, string.IsNullOrEmpty(alias) ? DefaultCriteriaAlias : alias);
			}
		}
		if (!string.IsNullOrWhiteSpace(filter.Query))
		{
			SetupFilterQuery(criteria, filter, metadata, alias);
		}
	}

	public List<EleWise.ELMA.Security.Models.IUser> GetUsersHasAccess(T obj)
	{
		List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
		foreach (IDmsObjectPermission item in (IEnumerable<IDmsObjectPermission>)obj.Permissions)
		{
			if (item == null || item.Assigned == null)
			{
				continue;
			}
			if (item.Assigned is EleWise.ELMA.Security.Models.IUser)
			{
				list.Add((EleWise.ELMA.Security.Models.IUser)item.Assigned);
			}
			else if (item.Assigned is IUserGroup)
			{
				IEnumerable<long> usersByGroup = UserGroupManager.Instance.GetUsersByGroup(((IUserGroup)item.Assigned).Id);
				list.AddRange(usersByGroup.Select((long u) => UserManager.Instance.Load(u)));
			}
			else if (item.Assigned is IOrganizationItem)
			{
				list.AddRange((IEnumerable<EleWise.ELMA.Security.Models.IUser>)((IOrganizationItem)item.Assigned).Users);
				list.Add(((IOrganizationItem)item.Assigned).User);
			}
		}
		return list;
	}

	[Transaction]
	public virtual void EnableInheritPermissions(T dmsObject, bool enable)
	{
		if (enable)
		{
			dmsObject.InheritPermissions = true;
			if (dmsObject.Folder != null)
			{
				AddPermissionsFromParent(dmsObject);
			}
		}
		else
		{
			dmsObject.InheritPermissions = false;
			if (dmsObject.Folder != null)
			{
				RemovePermissionDuplicates(dmsObject, (IDmsObjectPermission p) => new { p.DmsObject, p.PermissionId, p.User, p.Group, p.OrganizationItemPosition, p.OrganizationItemEmployee, p.UserSecuritySetCacheId, p.PermissionRole }, delegate(IDmsObjectPermission p)
				{
					if (p.InheritedFromFolder == null)
					{
						DmsObjectPermissionPatcherService.AddPermissionPatch(p, DmsObjectPermissionPatcherService.PatchType.Remove, ignored: true);
					}
				});
				((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).ForEach(delegate(IDmsObjectPermission p)
				{
					p.InheritedFromFolder = null;
				});
			}
		}
		ContextVars.Set("EleWise.ELMA.Documents.Managers.DmsObjectManager.EnableInheritPermissions" + dmsObject.GetId(), enable);
		Save(dmsObject);
	}

	[Transaction]
	public virtual void MoveTo(IFolder newFolder, List<TId> objectsId, List<IDmsObject> objects = null, bool toEvent = true)
	{
		if (newFolder == null || objectsId == null || objectsId.Count == 0)
		{
			return;
		}
		if (objects == null)
		{
			objects = FindByIdArray(objectsId.ToArray()).Cast<IDmsObject>().ToList();
		}
		ITransformationProvider transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		transformationProvider.ExecuteNonQuery(string.Format("update DmsObject set {2} = {0} where {3} in ({1})", newFolder.Id, string.Join(",", objectsId.Select((TId o) => Convert.ToString(o)).ToArray()), transformationProvider.Dialect.QuoteIfNeeded("Folder"), transformationProvider.Dialect.QuoteIfNeeded("Id")));
		List<IDmsObject> list = objects.Where((IDmsObject o) => o is IFolder).ToList();
		DmsObjectRelationService.Move(list, newFolder);
		DmsObjectTreeNodeStateService.SetNodeParentExpanded(list.Select((IDmsObject f) => f.Id).ToList(), expanded: false);
		objects.ForEach(delegate(IDmsObject o)
		{
			if (toEvent)
			{
				DmsObjectMoveActionEventArgs e2 = new DmsObjectMoveActionEventArgs(o, o, DmsObjectActions.MoveGuid, new DmsObjectMoveInfo
				{
					OldFolderId = o.Folder.Id,
					NewFolderId = newFolder.Id
				});
				EntityActionHandler.ActionExecuted(e2);
			}
			ContextVars.Set("EleWise.ELMA.Documents.Managers.DmsObjectManager.MoveTo" + o.Id, value: true);
			o.Folder = newFolder;
			((IEnumerable<IDmsObjectPermission>)o.Permissions).Where((IDmsObjectPermission p) => p.InheritedFromFolder != null).ToArray().ForEach(delegate(IDmsObjectPermission p)
			{
				p.Delete();
				((ICollection<IDmsObjectPermission>)o.Permissions).Remove(p);
			});
			if (o.InheritPermissions)
			{
				AddPermissionsFromParent((T)o, newFolder);
			}
		});
		base.Session.Flush();
		DmsObjectPermissionPatcherService.RunPatchingNow(objects);
		FolderManager.Instance.ClearFolderTreeCache();
		if (toEvent)
		{
			objects.ForEach(delegate(IDmsObject o)
			{
				DmsObjectMoveActionEventArgs e = new DmsObjectMoveActionEventArgs(o, o, DmsObjectActions.MoveGuid, new DmsObjectMoveInfo
				{
					OldFolderId = o.Folder.Id,
					NewFolderId = newFolder.Id
				});
				EntityActionHandler.ActionExecuted(e);
			});
		}
		BackgroundTask task = new BackgroundTask(delegate
		{
			IFullTextSearchService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchService>();
			DocumentsFullTextSearchSettingsModule serviceNotNull2 = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
			if (serviceNotNull.IndexingIsWorking() && serviceNotNull2.Settings != null && serviceNotNull2.Settings.Indexing)
			{
				foreach (IDmsObject @object in objects)
				{
					if (@object is IFolder || @object is IDocument)
					{
						ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(@object.GetType());
						if (classMetadata != null)
						{
							Guid uid = classMetadata.Uid;
							List<KeyValuePair<string, object>> list2 = new List<KeyValuePair<string, object>>
							{
								new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Folder)), newFolder.Id)
							};
							try
							{
								FieldIndexList indexField = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>().GetIndexField(newFolder.Id, InterfaceActivator.LoadPropertyMetadata((IDmsObject m) => m.Folder), reindex: true);
								if (indexField != null)
								{
									list2.AddRange(from f in indexField
										where !string.IsNullOrWhiteSpace(f.Field)
										select f into fieldIndexListItem
										select new KeyValuePair<string, object>(fieldIndexListItem.Field, fieldIndexListItem));
								}
							}
							catch (Exception)
							{
							}
							if (@object is IFolder)
							{
								KeyValuePair<string, object> item = new KeyValuePair<string, object>("Permissions", new List<long>());
								list2.Add(item);
							}
							if (@object is IDocument)
							{
								List<long> list3 = new List<long>();
								try
								{
									string sql = string.Format("SELECT DISTINCT dop.{1} as {2} FROM {0} WHERE (dop.{3} = {4})", transformationProvider.NoLockTableExpression("DmsObjectPermission", "dop"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.QuoteIfNeeded("ObjId"), transformationProvider.Dialect.QuoteIfNeeded("DmsObject"), @object.Id);
									using IDataReader dataReader = transformationProvider.ExecuteQuery(sql);
									while (dataReader.Read())
									{
										if (!(dataReader["ObjId"] is DBNull))
										{
											long item2 = Convert.ToInt64(dataReader["ObjId"]);
											if (!list3.Contains(item2))
											{
												list3.Add(item2);
											}
										}
									}
								}
								catch
								{
								}
								KeyValuePair<string, object> item3 = new KeyValuePair<string, object>("Permissions", list3);
								list2.Add(item3);
							}
							IndexQueueManager.Instance.AddReindexObjectPartItem(typeof(IDocumentsFullTextSearchObject), @object.Id, uid, list2, visualData: true);
						}
					}
				}
			}
		}, typeof(DmsObjectManager), "IndexUpdate", SR.T("Обновление индексов"));
		new Thread((ThreadStart)delegate
		{
			task.Execute();
		}).Start();
	}

	[Transaction]
	public virtual void Rename(T dmsObject, string newName)
	{
		dmsObject.Name = newName;
		dmsObject.Save();
	}

	[Transaction]
	public virtual void UpdatePermissions(IDmsObject dmsObject)
	{
		bool onlyChildren = !dmsObject.InheritPermissions;
		UpdatePermissions(dmsObject, onlyChildren);
	}

	[Transaction]
	public virtual void UpdatePermissions(IDmsObject dmsObject, bool onlyChildren)
	{
		long id = dmsObject.Id;
		IQuery namedQuery = base.Session.GetNamedQuery("ExecUpdateInheritDmsObjectPermissions");
		namedQuery.SetTimeout(TransformationProviderBase.DefaultCommandTimeout);
		namedQuery.SetParameter<long>("objId", id);
		namedQuery.SetParameter<bool>("onlyChildren", onlyChildren);
		namedQuery.ExecuteUpdate(cleanUpCache: false);
		base.Session.CleanUpCache(typeof(IDmsObjectPermission));
	}

	[Transaction]
	public virtual void AddPermissionToUser(T obj, Permission permission, EleWise.ELMA.Security.Models.IUser user)
	{
		if (!base.SecurityService.HasPermission(user, permission, obj))
		{
			ISet<IDmsObjectPermission> permissions = obj.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
			instanceOf.New.DmsObject = obj;
			instanceOf.New.PermissionId = permission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf.New.User = user;
			permissions.Add(instanceOf.New);
			obj.Save();
		}
	}

	[Transaction]
	public virtual void AddPermissionsToUser(T obj, IEnumerable<Permission> permissions, EleWise.ELMA.Security.Models.IUser user)
	{
		IEnumerable<IDmsObjectPermission> items = permissions.Where((Permission p) => !base.SecurityService.HasPermission(user, p, obj)).Select(delegate(Permission p)
		{
			InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
			instanceOf.New.DmsObject = obj;
			instanceOf.New.PermissionId = p.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf.New.User = user;
			return instanceOf.New;
		});
		((ICollection<IDmsObjectPermission>)obj.Permissions).AddRange(items);
		Save(obj);
	}

	[Transaction]
	public virtual void AddPermissionWithDependencies(T dmsObject, Permission permission, EleWise.ELMA.Security.Models.IUser user)
	{
		if (AddPermissionsDependencies(dmsObject, permission, user))
		{
			dmsObject.Save();
		}
	}

	[Transaction]
	internal virtual bool AddPermissionsDependencies(T dmsObject, Permission permission, EleWise.ELMA.Security.Models.IUser user)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException("Объект документооборота не может быть null");
		}
		if (user == null)
		{
			throw new ArgumentNullException("Пользователь не может быть null");
		}
		if (((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == user && a.PermissionRole == CommonRoleTypes.User.Id && a.PermissionId == permission.Id) != null)
		{
			return false;
		}
		bool result = false;
		if (permission == PermissionProvider.DocumentLoadPermission || permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission || permission == PermissionProvider.DocumentViewPermission)
		{
			ISet<IDmsObjectPermission> permissions = dmsObject.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
			instanceOf.New.DmsObject = dmsObject;
			instanceOf.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf.New.User = user;
			permissions.Add(instanceOf.New);
			result = true;
		}
		if (permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission || permission == PermissionProvider.DocumentLoadPermission)
		{
			ISet<IDmsObjectPermission> permissions2 = dmsObject.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf2 = new InstanceOf<IDmsObjectPermission>();
			instanceOf2.New.DmsObject = dmsObject;
			instanceOf2.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf2.New.User = user;
			permissions2.Add(instanceOf2.New);
			result = true;
		}
		if (permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission)
		{
			ISet<IDmsObjectPermission> permissions3 = dmsObject.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf3 = new InstanceOf<IDmsObjectPermission>();
			instanceOf3.New.DmsObject = dmsObject;
			instanceOf3.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf3.New.User = user;
			permissions3.Add(instanceOf3.New);
			result = true;
		}
		if (permission == PermissionProvider.DocumentManagerAccessPermission || permission == PermissionProvider.DocumentFullAccessPermission)
		{
			ISet<IDmsObjectPermission> permissions4 = dmsObject.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf4 = new InstanceOf<IDmsObjectPermission>();
			instanceOf4.New.DmsObject = dmsObject;
			instanceOf4.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf4.New.User = user;
			permissions4.Add(instanceOf4.New);
			result = true;
		}
		if (permission == PermissionProvider.DocumentFullAccessPermission)
		{
			ISet<IDmsObjectPermission> permissions5 = dmsObject.Permissions;
			InstanceOf<IDmsObjectPermission> instanceOf5 = new InstanceOf<IDmsObjectPermission>();
			instanceOf5.New.DmsObject = dmsObject;
			instanceOf5.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
			instanceOf5.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf5.New.User = user;
			permissions5.Add(instanceOf5.New);
			result = true;
		}
		return result;
	}

	public virtual void AddPermissionsFromParent(T dmsObject)
	{
		AddPermissionsFromParent(dmsObject, null);
	}

	public virtual void AddPermissionsFromParent(T dmsObject, IFolder parent)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException("dmsObject");
		}
		if (dmsObject.Folder == null)
		{
			throw new ArgumentException("dmsObject.Folder");
		}
		if (parent == null)
		{
			parent = dmsObject.Folder;
		}
		foreach (IDmsObjectPermission s in (IEnumerable<IDmsObjectPermission>)parent.Permissions)
		{
			if (!((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Any(delegate(IDmsObjectPermission p)
			{
				Guid? permissionRole = p.PermissionRole;
				Guid? permissionRole2 = s.PermissionRole;
				return permissionRole.HasValue == permissionRole2.HasValue && (!permissionRole.HasValue || permissionRole.GetValueOrDefault() == permissionRole2.GetValueOrDefault()) && p.PermissionId == s.PermissionId && p.TypeRoleId == s.TypeRoleId && p.User == s.User && p.Group == s.Group && p.OrganizationItemEmployee == s.OrganizationItemEmployee && p.OrganizationItemPosition == s.OrganizationItemPosition && ((s.InheritedFromFolder == null && EntityHelper.Equals(p.InheritedFromFolder, parent)) || (p.InheritedFromFolder != null && EntityHelper.Equals(p.InheritedFromFolder, s.InheritedFromFolder)));
			}))
			{
				InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
				instanceOf.New.DmsObject = dmsObject;
				instanceOf.New.User = s.User;
				instanceOf.New.Group = s.Group;
				instanceOf.New.InheritedFromFolder = s.InheritedFromFolder ?? parent.Cast<IFolder, IDmsObject>();
				instanceOf.New.OrganizationItemEmployee = s.OrganizationItemEmployee;
				instanceOf.New.OrganizationItemPosition = s.OrganizationItemPosition;
				instanceOf.New.PermissionId = s.PermissionId;
				instanceOf.New.TypeRoleId = s.TypeRoleId;
				instanceOf.New.PermissionRole = s.PermissionRole;
				IDmsObjectPermission @new = instanceOf.New;
				if (@new.TypeRoleId == CommonRoleTypes.Author.Id)
				{
					@new.User = dmsObject.CreationAuthor;
				}
				dmsObject.Permissions.Add(@new);
			}
		}
	}

	[Transaction]
	public virtual void Archive(List<T> objects)
	{
		IFolder archiveFolder = SystemFoldersService.ArchiveFolder;
		objects.ForEach(delegate(T d)
		{
			d.ArchiveAuthor = (EleWise.ELMA.Security.Models.IUser)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
			d.ArchiveDate = DateTime.Now;
			d.IsArchived = true;
			d.OldFolder = d.Folder;
			d.Save();
			if (d.InheritPermissions)
			{
				DmsObjectManager.Instance.EnableInheritPermissions(d, enable: false);
			}
			EntityActionEventArgs e = new EntityActionEventArgs(null, d, DmsObjectActions.ArchiveGuid);
			EntityActionHandler.ActionExecuted(e);
		});
		base.Session.Flush();
		DocumentManager.Instance.MoveTo(archiveFolder, objects.Select((T o) => Convert.ToInt64(o.GetId())).ToList(), null, toEvent: false);
	}

	[Transaction]
	public virtual void UnArchive(List<T> objects)
	{
		objects.ForEach(delegate(T d)
		{
			d.ArchiveAuthor = (EleWise.ELMA.Security.Models.IUser)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
			d.ArchiveDate = DateTime.Now;
			d.IsArchived = false;
			d.Save();
			base.Session.Flush();
			DocumentManager.Instance.MoveTo(d.OldFolder, new List<long> { Convert.ToInt64(d.GetId()) }, null, toEvent: false);
			EntityActionEventArgs e = new EntityActionEventArgs(null, d, DmsObjectActions.UnArchiveGuid);
			EntityActionHandler.ActionExecuted(e);
		});
	}

	[Transaction]
	[PublicApiMember]
	public override void Delete(T obj)
	{
		obj.DeleteAuthor = (EleWise.ELMA.Security.Models.IUser)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		base.Session.Delete((object)obj);
		EntityActionEventArgs e = new EntityActionEventArgs(null, obj, DefaultEntityActions.DeleteGuid);
		EntityActionHandler.ActionExecuted(e);
	}

	[Transaction]
	public virtual void SendChangeAccess(T dmsObject, List<IDmsObjectPermission> oldPermissions, List<IDmsObjectPermission> newPermissions)
	{
		DmsObjectChangeAccessActionEventArgs dmsObjectChangeAccessActionEventArgs = new DmsObjectChangeAccessActionEventArgs(null, dmsObject, DmsObjectActions.ChangeAccessGuid);
		dmsObjectChangeAccessActionEventArgs.FillInfo(oldPermissions, newPermissions);
		EntityActionHandler.ActionExecuted(dmsObjectChangeAccessActionEventArgs);
	}

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

	[PublicApiMember]
	public override T Load(TId id)
	{
		Guid typeUid = GetTypeUid(id);
		if (typeUid == Guid.Empty)
		{
			return base.Load(id);
		}
		Type entityType = ModelHelper.GetEntityType(typeUid);
		if (ModelHelper.GetEntityType(MetadataLoader.LoadMetadata(typeof(T)).Uid) != entityType)
		{
			IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(entityType);
			if (entityManagerOrNull != null && entityManagerOrNull != this)
			{
				return (T)entityManagerOrNull.Load(id);
			}
		}
		return base.Load(id);
	}

	protected virtual Guid GetTypeUid(TId id)
	{
		return ComplexCacheService.GetOrAdd("DMSOBJECTTYPEUID" + id, "DMSOBJECTTYPEUIDTIMESTAMP" + id, () => CreateCriteria(new Filter
		{
			DisableSecurity = true
		}).Add((ICriterion)(object)Restrictions.IdEq((object)id)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(base.EntityTypeUidPropertyName) }).UniqueResult<Guid?>() ?? Guid.Empty, TimeSpan.FromDays(7.0));
	}

	protected virtual void RefreshTypeUidCache(object id)
	{
		ComplexCacheService.RefreshTimestamp("DMSOBJECTTYPEUIDTIMESTAMP" + id);
	}

	private void RemovePermissionDuplicates(IDmsObject dmsObject, Func<IDmsObjectPermission, object> keySelector = null, Action<IDmsObjectPermission> duplicateAction = null)
	{
		if (dmsObject == null)
		{
			return;
		}
		((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).OrderBy((IDmsObjectPermission p) => !p.IsNew()).GroupBy(keySelector ?? ((Func<IDmsObjectPermission, object>)((IDmsObjectPermission p) => new { p.DmsObject, p.PermissionId, p.User, p.Group, p.OrganizationItemPosition, p.OrganizationItemEmployee, p.UserSecuritySetCacheId, p.PermissionRole, p.InheritedFromFolder }))).ForEach(delegate(IGrouping<object, IDmsObjectPermission> g)
		{
			g.Skip(1).ForEach(delegate(IDmsObjectPermission p)
			{
				p.Delete();
				((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(p);
				if (duplicateAction != null)
				{
					duplicateAction(p);
				}
			});
		});
	}

	public List<Guid> GetTypeUids(List<TId> ids)
	{
		Filter filter = new Filter
		{
			DisableSecurity = true
		};
		ICriteria val = CreateCriteria(filter);
		List<List<TId>> list = new List<List<TId>>();
		if (ids.Count < 1200)
		{
			list.Add(ids);
		}
		else
		{
			List<TId> list2 = new List<TId>();
			foreach (TId id in ids)
			{
				if (list2.Count >= 1200)
				{
					List<TId> list3 = new List<TId>();
					list3.AddRange(list2);
					list.Add(list3);
					list2 = new List<TId>();
				}
				list2.Add(id);
			}
			if (list2.Count > 0)
			{
				List<TId> list4 = new List<TId>();
				list4.AddRange(list2);
				list.Add(list4);
			}
		}
		List<AbstractCriterion> list5 = new List<AbstractCriterion>();
		foreach (List<TId> item in list)
		{
			list5.Add(Restrictions.In("Id", (ICollection)item));
		}
		val = val.Add((ICriterion)(object)NHibernateHelper.Or((IEnumerable<AbstractCriterion>)list5)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(base.EntityTypeUidPropertyName) });
		return val.List<Guid>().ToList();
	}

	public void CopyPermission(T source, T target)
	{
		target.InheritPermissions = source.InheritPermissions;
		foreach (IDmsObjectPermission item in (IEnumerable<IDmsObjectPermission>)source.Permissions)
		{
			IDmsObjectPermission permission = item;
			if (!((IEnumerable<IDmsObjectPermission>)target.Permissions).Any(delegate(IDmsObjectPermission p)
			{
				if (p.PermissionId == permission.PermissionId)
				{
					Guid? permissionRole = p.PermissionRole;
					Guid? permissionRole2 = permission.PermissionRole;
					if (permissionRole.HasValue == permissionRole2.HasValue && (!permissionRole.HasValue || permissionRole.GetValueOrDefault() == permissionRole2.GetValueOrDefault()) && p.UserSecuritySetCacheId == permission.UserSecuritySetCacheId && p.User == permission.User && p.Group == permission.Group && p.OrganizationItemEmployee == permission.OrganizationItemEmployee)
					{
						return p.OrganizationItemPosition == permission.OrganizationItemPosition;
					}
				}
				return false;
			}))
			{
				ISet<IDmsObjectPermission> permissions = target.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
				instanceOf.New.PermissionId = permission.PermissionId;
				instanceOf.New.PermissionRole = permission.PermissionRole;
				instanceOf.New.UserSecuritySetCacheId = permission.UserSecuritySetCacheId;
				instanceOf.New.DmsObject = target;
				instanceOf.New.Group = permission.Group;
				instanceOf.New.User = permission.User;
				instanceOf.New.OrganizationItemPosition = permission.OrganizationItemPosition;
				instanceOf.New.OrganizationItemEmployee = permission.OrganizationItemEmployee;
				instanceOf.New.InheritedFromFolder = permission.InheritedFromFolder;
				permissions.Add(instanceOf.New);
			}
		}
	}

	public List<ObjectExtendedPermission> GetPermissionToAdd(long leftObject, long rightObject)
	{
		return base.Session.GetNamedQuery("GetPermissionToAdd").CleanUpCache(cleanUpCache: false).SetParameter<long>("leftObject", leftObject)
			.SetParameter<long>("rightObject", rightObject)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ObjectExtendedPermission)))
			.List<ObjectExtendedPermission>()
			.ToList();
	}

	internal IEnumerable<long> GetUserSecuritySetCacheHasViewAccess(IDmsObject dmsObject)
	{
		if (dmsObject == null)
		{
			return Enumerable.Empty<long>();
		}
		return GetUserSecuritySetCacheHasViewAccess(dmsObject.Id);
	}

	internal IEnumerable<long> GetUserSecuritySetCacheHasViewAccess(long dmsObjectId)
	{
		return base.Session.CreateCriteria<IDmsObjectPermission>().Add((ICriterion)(object)Restrictions.Eq("DmsObject.Id", (object)dmsObjectId)).Add((ICriterion)(object)Restrictions.Eq(LinqUtils.NameOf((Expression<Func<IDmsObjectPermission, object>>)((IDmsObjectPermission a) => a.PermissionId)), (object)PermissionProvider.DocumentViewPermission.Id))
			.SetProjection((IProjection[])(object)new IProjection[1] { Projections.Distinct((IProjection)(object)Projections.Property(LinqUtils.NameOf((Expression<Func<IDmsObjectPermission, object>>)((IDmsObjectPermission a) => a.UserSecuritySetCacheId)))) })
			.List<long>()
			.ToList();
	}

	internal List<DmsObjectDTO> GetAllChilds(long folderId)
	{
		return (from o in ((IQuery)(object)base.Session.CreateSQLQuery(string.Format("select dms.{2}, dms.{4}, p.{5} from {3} dms\r\n                      inner join (select {2} from {1}) sub on sub.{2}=dms.{2}\r\n                      left join {0} p on dms.{2}=p.{3}\r\n                    ", TransformationProvider.Dialect.QuoteIfNeeded("DmsObjectPermission"), TransformationProvider.TableFunction("GetSubDmsObjectsQuery", ":folderId"), TransformationProvider.Dialect.QuoteIfNeeded("Id"), TransformationProvider.Dialect.QuoteIfNeeded("DmsObject"), TransformationProvider.Dialect.QuoteIfNeeded("Folder"), TransformationProvider.Dialect.QuoteIfNeeded("UserSecuritySetCacheId")))).CleanUpCache(cleanUpCache: false).SetParameter<long>("folderId", folderId).List<object[]>()
			select new
			{
				Id = (long)o[0],
				FolderId = (long?)o[1],
				UserSecuritySetCacheId = (long?)o[2]
			} into o
			group o by new { o.Id, o.FolderId } into g
			select new DmsObjectDTO
			{
				Id = g.Key.Id,
				FolderId = g.Key.FolderId,
				UserSecuritySetCacheIds = (from v in g
					where v.UserSecuritySetCacheId.HasValue
					select v.UserSecuritySetCacheId.Value).ToList()
			}).ToList();
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public class DmsObjectManager : DmsObjectManager<IDmsObject, long>
{
	public new static DmsObjectManager Instance => Locator.GetServiceNotNull<DmsObjectManager>();

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	[Transaction]
	public virtual void AddPermissionWithDependencies(IDmsObject dmsObject, Permission permission, IUserGroup userGroup)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException(SR.T("Объект документооборота не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		if (!((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Where((IDmsObjectPermission a) => a.Assigned == userGroup && a.PermissionRole == CommonRoleTypes.Group.Id && a.PermissionId == permission.Id).Any())
		{
			if (permission == PermissionProvider.DocumentLoadPermission || permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission || permission == PermissionProvider.DocumentViewPermission)
			{
				ISet<IDmsObjectPermission> permissions = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
				instanceOf.New.DmsObject = dmsObject;
				instanceOf.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
				instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
				instanceOf.New.Assigned = userGroup;
				permissions.Add(instanceOf.New);
			}
			if (permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission || permission == PermissionProvider.DocumentLoadPermission)
			{
				ISet<IDmsObjectPermission> permissions2 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf2 = new InstanceOf<IDmsObjectPermission>();
				instanceOf2.New.DmsObject = dmsObject;
				instanceOf2.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
				instanceOf2.New.TypeRoleId = CommonRoleTypes.Group.Id;
				instanceOf2.New.Assigned = userGroup;
				permissions2.Add(instanceOf2.New);
			}
			if (permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission)
			{
				ISet<IDmsObjectPermission> permissions3 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf3 = new InstanceOf<IDmsObjectPermission>();
				instanceOf3.New.DmsObject = dmsObject;
				instanceOf3.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
				instanceOf3.New.TypeRoleId = CommonRoleTypes.Group.Id;
				instanceOf3.New.Assigned = userGroup;
				permissions3.Add(instanceOf3.New);
			}
			if (permission == PermissionProvider.DocumentManagerAccessPermission || permission == PermissionProvider.DocumentFullAccessPermission)
			{
				ISet<IDmsObjectPermission> permissions4 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf4 = new InstanceOf<IDmsObjectPermission>();
				instanceOf4.New.DmsObject = dmsObject;
				instanceOf4.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
				instanceOf4.New.TypeRoleId = CommonRoleTypes.Group.Id;
				instanceOf4.New.Assigned = userGroup;
				permissions4.Add(instanceOf4.New);
			}
			if (permission == PermissionProvider.DocumentFullAccessPermission)
			{
				ISet<IDmsObjectPermission> permissions5 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf5 = new InstanceOf<IDmsObjectPermission>();
				instanceOf5.New.DmsObject = dmsObject;
				instanceOf5.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
				instanceOf5.New.TypeRoleId = CommonRoleTypes.Group.Id;
				instanceOf5.New.Assigned = userGroup;
				permissions5.Add(instanceOf5.New);
			}
			dmsObject.Save();
		}
	}

	[Transaction]
	public virtual void AddPermissionWithDependencies(IDmsObject dmsObject, Permission permission, IOrganizationItem orgItem)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException(SR.T("Объект документооборота не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Элемент оргструктуры не может быть null"));
		}
		if (!((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Where((IDmsObjectPermission a) => a.Assigned == orgItem && a.PermissionRole == CommonRoleTypes.OrganizationItem.Id && a.PermissionId == permission.Id).Any())
		{
			if (permission == PermissionProvider.DocumentLoadPermission || permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission || permission == PermissionProvider.DocumentViewPermission)
			{
				ISet<IDmsObjectPermission> permissions = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
				instanceOf.New.DmsObject = dmsObject;
				instanceOf.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
				instanceOf.New.TypeRoleId = CommonRoleTypes.OrganizationItem.Id;
				instanceOf.New.Assigned = orgItem;
				permissions.Add(instanceOf.New);
			}
			if (permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission || permission == PermissionProvider.DocumentLoadPermission)
			{
				ISet<IDmsObjectPermission> permissions2 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf2 = new InstanceOf<IDmsObjectPermission>();
				instanceOf2.New.DmsObject = dmsObject;
				instanceOf2.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
				instanceOf2.New.TypeRoleId = CommonRoleTypes.OrganizationItem.Id;
				instanceOf2.New.Assigned = orgItem;
				permissions2.Add(instanceOf2.New);
			}
			if (permission == PermissionProvider.DocumentEditPermission || permission == PermissionProvider.DocumentFullAccessPermission)
			{
				ISet<IDmsObjectPermission> permissions3 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf3 = new InstanceOf<IDmsObjectPermission>();
				instanceOf3.New.DmsObject = dmsObject;
				instanceOf3.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
				instanceOf3.New.TypeRoleId = CommonRoleTypes.OrganizationItem.Id;
				instanceOf3.New.Assigned = orgItem;
				permissions3.Add(instanceOf3.New);
			}
			if (permission == PermissionProvider.DocumentManagerAccessPermission || permission == PermissionProvider.DocumentFullAccessPermission)
			{
				ISet<IDmsObjectPermission> permissions4 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf4 = new InstanceOf<IDmsObjectPermission>();
				instanceOf4.New.DmsObject = dmsObject;
				instanceOf4.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
				instanceOf4.New.TypeRoleId = CommonRoleTypes.OrganizationItem.Id;
				instanceOf4.New.Assigned = orgItem;
				permissions4.Add(instanceOf4.New);
			}
			if (permission == PermissionProvider.DocumentFullAccessPermission)
			{
				ISet<IDmsObjectPermission> permissions5 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf5 = new InstanceOf<IDmsObjectPermission>();
				instanceOf5.New.DmsObject = dmsObject;
				instanceOf5.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
				instanceOf5.New.TypeRoleId = CommonRoleTypes.OrganizationItem.Id;
				instanceOf5.New.Assigned = orgItem;
				permissions5.Add(instanceOf5.New);
			}
			dmsObject.Save();
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddViewPermission(IDmsObject dmsObject, EleWise.ELMA.Security.Models.IUser user)
	{
		Permission documentViewPermission = PermissionProvider.DocumentViewPermission;
		Instance.AddPermissionWithDependencies(dmsObject, documentViewPermission, user);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddLoadPermission(IDmsObject dmsObject, EleWise.ELMA.Security.Models.IUser user)
	{
		Permission documentLoadPermission = PermissionProvider.DocumentLoadPermission;
		Instance.AddPermissionWithDependencies(dmsObject, documentLoadPermission, user);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddEditPermission(IDmsObject dmsObject, EleWise.ELMA.Security.Models.IUser user)
	{
		Permission documentEditPermission = PermissionProvider.DocumentEditPermission;
		Instance.AddPermissionWithDependencies(dmsObject, documentEditPermission, user);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddFullAccessPermission(IDmsObject dmsObject, EleWise.ELMA.Security.Models.IUser user)
	{
		Permission documentFullAccessPermission = PermissionProvider.DocumentFullAccessPermission;
		Instance.AddPermissionWithDependencies(dmsObject, documentFullAccessPermission, user);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddManageAccessPermission(IDmsObject dmsObject, EleWise.ELMA.Security.Models.IUser user)
	{
		Permission documentManagerAccessPermission = PermissionProvider.DocumentManagerAccessPermission;
		Instance.AddPermissionWithDependencies(dmsObject, documentManagerAccessPermission, user);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddViewPermission(IDmsObject dmsObject, IUserGroup userGroup)
	{
		Permission documentViewPermission = PermissionProvider.DocumentViewPermission;
		AddPermissionWithDependencies(dmsObject, documentViewPermission, userGroup);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddLoadPermission(IDmsObject dmsObject, IUserGroup userGroup)
	{
		Permission documentLoadPermission = PermissionProvider.DocumentLoadPermission;
		AddPermissionWithDependencies(dmsObject, documentLoadPermission, userGroup);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddEditPermission(IDmsObject dmsObject, IUserGroup userGroup)
	{
		Permission documentEditPermission = PermissionProvider.DocumentEditPermission;
		AddPermissionWithDependencies(dmsObject, documentEditPermission, userGroup);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddFullAccessPermission(IDmsObject dmsObject, IUserGroup userGroup)
	{
		Permission documentFullAccessPermission = PermissionProvider.DocumentFullAccessPermission;
		AddPermissionWithDependencies(dmsObject, documentFullAccessPermission, userGroup);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddManageAccessPermission(IDmsObject dmsObject, IUserGroup userGroup)
	{
		Permission documentManagerAccessPermission = PermissionProvider.DocumentManagerAccessPermission;
		AddPermissionWithDependencies(dmsObject, documentManagerAccessPermission, userGroup);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddViewPermission(IDmsObject dmsObject, IOrganizationItem orgItem)
	{
		Permission documentViewPermission = PermissionProvider.DocumentViewPermission;
		AddPermissionWithDependencies(dmsObject, documentViewPermission, orgItem);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddLoadPermission(IDmsObject dmsObject, IOrganizationItem orgItem)
	{
		Permission documentLoadPermission = PermissionProvider.DocumentLoadPermission;
		AddPermissionWithDependencies(dmsObject, documentLoadPermission, orgItem);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddEditPermission(IDmsObject dmsObject, IOrganizationItem orgItem)
	{
		Permission documentEditPermission = PermissionProvider.DocumentEditPermission;
		AddPermissionWithDependencies(dmsObject, documentEditPermission, orgItem);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddFullAccessPermission(IDmsObject dmsObject, IOrganizationItem orgItem)
	{
		Permission documentFullAccessPermission = PermissionProvider.DocumentFullAccessPermission;
		AddPermissionWithDependencies(dmsObject, documentFullAccessPermission, orgItem);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public virtual void AddManageAccessPermission(IDmsObject dmsObject, IOrganizationItem orgItem)
	{
		Permission documentManagerAccessPermission = PermissionProvider.DocumentManagerAccessPermission;
		AddPermissionWithDependencies(dmsObject, documentManagerAccessPermission, orgItem);
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public void DeletePermissions(IDmsObject dmsObject, EleWise.ELMA.Security.Models.IUser user)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException(SR.T("Документ не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		foreach (IDmsObjectPermission item in ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Where((IDmsObjectPermission a) => a.Assigned == user).ToList())
		{
			((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(item);
		}
		dmsObject.Save();
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public void DeletePermissions(IDmsObject dmsObject, IOrganizationItem orgItem)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException(SR.T("Документ не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Элемент оргструктуры не может быть null"));
		}
		foreach (IDmsObjectPermission item in ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Where((IDmsObjectPermission a) => a.Assigned == orgItem).ToList())
		{
			((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(item);
		}
		dmsObject.Save();
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public void DeletePermissions(IDmsObject dmsObject, IUserGroup userGroup)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException(SR.T("Документ не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		foreach (IDmsObjectPermission item in ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Where((IDmsObjectPermission a) => a.Assigned == userGroup).ToList())
		{
			((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(item);
		}
		dmsObject.Save();
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public void DeletePermission(IDmsObject dmsObject, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException(SR.T("Объект документооборота не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		IDmsObjectPermission dmsObjectPermission = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == user && a.PermissionRole == CommonRoleTypes.User.Id && a.PermissionId == permission.Id);
		if (dmsObjectPermission == null)
		{
			return;
		}
		((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission);
		if (permission == PermissionProvider.DocumentViewPermission)
		{
			IDmsObjectPermission dmsObjectPermission2 = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == user && a.PermissionRole == CommonRoleTypes.User.Id && a.PermissionId == PermissionProvider.DocumentEditPermission.Id);
			if (dmsObjectPermission2 != null)
			{
				((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission2);
			}
			IDmsObjectPermission dmsObjectPermission3 = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == user && a.PermissionRole == CommonRoleTypes.User.Id && a.PermissionId == PermissionProvider.DocumentLoadPermission.Id);
			if (dmsObjectPermission3 != null)
			{
				((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission3);
			}
		}
		dmsObject.Save();
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public void DeletePermission(IDmsObject dmsObject, IUserGroup userGroup, Permission permission)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException(SR.T("Объект документооборота не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		IDmsObjectPermission dmsObjectPermission = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == userGroup && a.PermissionRole == CommonRoleTypes.Group.Id && a.PermissionId == permission.Id);
		if (dmsObjectPermission == null)
		{
			return;
		}
		((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission);
		if (permission == PermissionProvider.DocumentViewPermission)
		{
			IDmsObjectPermission dmsObjectPermission2 = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == userGroup && a.PermissionRole == CommonRoleTypes.Group.Id && a.PermissionId == PermissionProvider.DocumentEditPermission.Id);
			if (dmsObjectPermission2 != null)
			{
				((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission2);
			}
			IDmsObjectPermission dmsObjectPermission3 = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == userGroup && a.PermissionRole == CommonRoleTypes.Group.Id && a.PermissionId == PermissionProvider.DocumentLoadPermission.Id);
			if (dmsObjectPermission3 != null)
			{
				((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission3);
			}
		}
		dmsObject.Save();
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsDocflowApi")]
	public void DeletePermission(IDmsObject dmsObject, IOrganizationItem orgItem, Permission permission)
	{
		if (dmsObject == null)
		{
			throw new ArgumentNullException(SR.T("Объект документооборота не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Элемент оргструктуры не может быть null"));
		}
		IDmsObjectPermission dmsObjectPermission = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == orgItem && a.PermissionRole == CommonRoleTypes.OrganizationItem.Id && a.PermissionId == permission.Id);
		if (dmsObjectPermission == null)
		{
			return;
		}
		((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission);
		if (permission == PermissionProvider.DocumentViewPermission)
		{
			IDmsObjectPermission dmsObjectPermission2 = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == orgItem && a.PermissionRole == CommonRoleTypes.OrganizationItem.Id && a.PermissionId == PermissionProvider.DocumentEditPermission.Id);
			if (dmsObjectPermission2 != null)
			{
				((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission2);
			}
			IDmsObjectPermission dmsObjectPermission3 = ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).FirstOrDefault((IDmsObjectPermission a) => a.Assigned == orgItem && a.PermissionRole == CommonRoleTypes.OrganizationItem.Id && a.PermissionId == PermissionProvider.DocumentLoadPermission.Id);
			if (dmsObjectPermission3 != null)
			{
				((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Remove(dmsObjectPermission3);
			}
		}
		dmsObject.Save();
	}
}
