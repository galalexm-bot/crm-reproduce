using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Security.Services;

[Service(Scope = ServiceScope.Shell)]
public class PermissionsModelService
{
	private class IdAndTypeRole
	{
		public Guid ObjectType { get; set; }

		public string Id { get; set; }

		public long EntityId { get; set; }
	}

	private readonly Func<IEnumerable<IInstanceSettingsPermission>> instanceSettingsPermissionsList;

	private IEnumerable<IUnusedPermissions> unusedPermissions;

	public OrganizationItemManager OrganizationManager { get; set; }

	public UserGroupManager UserGroupManager { get; set; }

	public IAuthenticationService AuthenticationService { get; set; }

	public IPermissionTypeRoleService PermissionTypeRoleService { get; set; }

	public IEnumerable<IInstanceSettingsPermission> InstanceSettingsPermissions
	{
		get
		{
			return instanceSettingsPermissionsList();
		}
		set
		{
		}
	}

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public IPermissionManagmentService PermissionManagmentService { get; set; }

	public IComponentManager ComponentManager { get; set; }

	public IEnumerable<IRoleTypeSelectorGroupsModelItems> RoleTypeSelectorGroupsModelItems { get; set; }

	private IEnumerable<IUnusedPermissions> UnusedPermissions
	{
		get
		{
			if (unusedPermissions == null)
			{
				unusedPermissions = ComponentManager.GetExtensionPoints<IUnusedPermissions>().ToList();
			}
			return unusedPermissions;
		}
	}

	public PermissionsModelService(Func<IEnumerable<IInstanceSettingsPermission>> instanceSettingsPermissionsList)
	{
		this.instanceSettingsPermissionsList = instanceSettingsPermissionsList;
	}

	public EntityAddPermissionModel GetEntityAddPermissionModel(Dictionary<object, List<IEntity>> entities, Type type, UrlHelper url, Guid[] defaultPermissionUids)
	{
		IEnumerable<Tuple<Permission, PermissionRoleType[]>> permissionRolesStereotype = PermissionTypeRoleService.GetPermissionRoles(type);
		List<Permission> defaultPermissions = defaultPermissionUids.Select((Guid defaultPermissionUid) => permissionRolesStereotype.Select((Tuple<Permission, PermissionRoleType[]> t) => t.Item1).FirstOrDefault((Permission p) => p.Id == defaultPermissionUid)).ToList();
		List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> items = new List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>();
		entities.ToList().ForEach(delegate(KeyValuePair<object, List<IEntity>> d)
		{
			items.AddRange(permissionRolesStereotype.Select(delegate(Tuple<Permission, PermissionRoleType[]> t)
			{
				Permission permission = t.Item1;
				List<IEntity> value = d.Value;
				List<AssignedRoleTypeModel> item = ((defaultPermissions.Any((Permission p) => p == permission) || (defaultPermissions != null && defaultPermissions.Any((Permission defaultPermission) => defaultPermission.Dependencies != null && defaultPermission.Dependencies.Contains(permission)))) ? value.Select(delegate(IEntity u)
				{
					if (u is EleWise.ELMA.Security.Models.IUser)
					{
						return new AssignedRoleTypeModel(CommonRoleTypes.User, u);
					}
					return (u is IUserGroup) ? new AssignedRoleTypeModel(CommonRoleTypes.Group, u) : new AssignedRoleTypeModel(CommonRoleTypes.OrganizationItem, u);
				}).ToList() : new List<AssignedRoleTypeModel>());
				return new Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>(permission, d.Key, item);
			}).ToList());
		});
		return new EntityAddPermissionModel(type, (EntityMetadata)MetadataLoader.LoadMetadata(type), items);
	}

	public EntityAddPermissionModel GetEntityAddPermissionModel(Dictionary<object, List<EleWise.ELMA.Security.Models.IUser>> objects, Type type, UrlHelper url, Guid[] defaultPermissionUids)
	{
		IEnumerable<Tuple<Permission, PermissionRoleType[]>> permissionRolesStereotype = PermissionTypeRoleService.GetPermissionRoles(type);
		List<Permission> defaultPermissions = defaultPermissionUids.Select((Guid defaultPermissionUid) => permissionRolesStereotype.Select((Tuple<Permission, PermissionRoleType[]> t) => t.Item1).FirstOrDefault((Permission p) => p.Id == defaultPermissionUid)).ToList();
		List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> items = new List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>();
		objects.ToList().ForEach(delegate(KeyValuePair<object, List<EleWise.ELMA.Security.Models.IUser>> d)
		{
			items.AddRange(permissionRolesStereotype.Select(delegate(Tuple<Permission, PermissionRoleType[]> t)
			{
				Permission permission = t.Item1;
				List<EleWise.ELMA.Security.Models.IUser> value = d.Value;
				List<AssignedRoleTypeModel> item = ((defaultPermissions.Any((Permission p) => p == permission) || (defaultPermissions != null && defaultPermissions.Any((Permission defaultPermission) => defaultPermission.Dependencies != null && defaultPermission.Dependencies.Contains(permission)))) ? value.Select((EleWise.ELMA.Security.Models.IUser u) => new AssignedRoleTypeModel(CommonRoleTypes.User, u)).ToList() : new List<AssignedRoleTypeModel>());
				return new Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>(permission, d.Key, item);
			}).ToList());
		});
		return new EntityAddPermissionModel(type, (EntityMetadata)MetadataLoader.LoadMetadata(type), items);
	}

	public EntityAddPermissionModel GetEntityAddPermissionModel(Dictionary<object, List<EleWise.ELMA.Security.Models.IUser>> objects, Type type, UrlHelper url, Guid defaultPermissionUid)
	{
		return GetEntityAddPermissionModel(objects, type, url, new Guid[1] { defaultPermissionUid });
	}

	public EntityPermissionRoleTypeSelectorModel GetEntityPermissionRoleTypeSelectorModel(object instance, Type type, UrlHelper url, Func<IInstanceSettingsPermissionHolder, bool> filter = null, bool loadData = true, string ppid = null)
	{
		return GetEntityPermissionRoleTypeSelectorModel(instance, type, url, filter, null, loadData, ppid);
	}

	public EntityPermissionRoleTypeSelectorModel GetEntityPermissionRoleTypeSelectorModel(object instance, Type type, UrlHelper url, Func<IInstanceSettingsPermissionHolder, bool> filter, Func<Permission, bool> permissionRolesStereotypeFilter, bool loadData = true, string ppid = null)
	{
		filter = filter ?? ((Func<IInstanceSettingsPermissionHolder, bool>)((IInstanceSettingsPermissionHolder h) => true));
		List<Permission> unusedPermissionsList = UnusedPermissions.SelectMany((IUnusedPermissions permission) => permission.Permissions(instance) ?? Enumerable.Empty<Permission>()).Distinct().ToList();
		permissionRolesStereotypeFilter = permissionRolesStereotypeFilter ?? ((Func<Permission, bool>)((Permission pp) => true));
		IEnumerable<Tuple<Permission, PermissionRoleType[]>> source = ((PermissionTypeRoleService is IInstancePermissionTypeRoleService instancePermissionTypeRoleService) ? instancePermissionTypeRoleService.GetInstancePermissionRoles(instance) : PermissionTypeRoleService.GetPermissionRoles(type));
		IInstanceSettingsPermission settingsPermission = GetSettingsPermission(instance);
		List<IInstanceSettingsPermissionHolder> holders = settingsPermission.GetPermissionCollection(instance).Where(filter).ToList();
		bool canGrandPermissions = settingsPermission.CanGrandPermissions(AuthenticationService.GetCurrentUser(), instance);
		ICollection<Permission> grandPermission = settingsPermission.CanGrandLevel(AuthenticationService.GetCurrentUser(), instance);
		List<Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>>> stereotypes = source.Where((Tuple<Permission, PermissionRoleType[]> t) => permissionRolesStereotypeFilter(t.Item1) && unusedPermissionsList.All((Permission up) => up.Id != t.Item1.Id)).Select(delegate(Tuple<Permission, PermissionRoleType[]> t)
		{
			Permission permission2 = t.Item1;
			PermissionRoleTypeSelectorModel item = null;
			if (canGrandPermissions)
			{
				string text = UIExtensions.PrepareId("RoleSelector" + permission2.Id.ToString());
				item = ((!loadData && (text == null || !(text == ppid))) ? new PermissionRoleTypeSelectorModel
				{
					PopupId = text,
					Title = SR.T("Выбор объекта для назначения прав доступа"),
					TypeRoles = t.Item2,
					SelectedTypeRole = t.Item2.First(),
					ObjectId = permission2.Id.ToString(),
					SubmitScript = null,
					CreatePopup = true,
					OrganizationTreeModel = null,
					GroupsTreeModel = null,
					ExtGroupsTreeModel = null,
					UserModel = CreateUserModel(text, url)
				} : new PermissionRoleTypeSelectorModel
				{
					PopupId = text,
					Title = SR.T("Выбор объекта для назначения прав доступа"),
					TypeRoles = t.Item2,
					SelectedTypeRole = t.Item2.First(),
					ObjectId = permission2.Id.ToString(),
					SubmitScript = null,
					CreatePopup = true,
					OrganizationTreeModel = CreateOrganizationTreeModel(text),
					GroupsTreeModel = CreateGroupsModel(text, instance, type),
					ExtGroupsTreeModel = CreateExtGroupsModel(text, instance, type),
					UserModel = CreateUserModel(text, url)
				});
			}
			List<AssignedRoleTypeModel> item2 = (from h in holders
				where h.PermissionId == permission2.Id
				select new AssignedRoleTypeModel(PermissionTypeRoleService.Get(h.TypeRoleId), h.Assigned)).ToList();
			return new Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>>(permission2, item, item2);
		}).ToList();
		return new EntityPermissionRoleTypeSelectorModel(instance, type, (EntityMetadata)MetadataLoader.LoadMetadata(type), stereotypes)
		{
			Edit = canGrandPermissions,
			GrandPermission = grandPermission,
			PermissionCanGrantResolver = settingsPermission.CanGrandToElement,
			IsSystemRole = settingsPermission.IsSystemRole
		};
	}

	public EntityPermissionRoleTypeSelectorModel GetPropertyPermissionRoleTypeSelectorModel(IAbstractPropertyProfile instance, Type type, UrlHelper url, IPropertyOwnerProfile owner, Func<IInstanceSettingsPermissionHolder, bool> filter = null)
	{
		return GetPropertyPermissionRoleTypeSelectorModel(instance, type, url, owner, filter, null);
	}

	public EntityPermissionRoleTypeSelectorModel GetPropertyPermissionRoleTypeSelectorModel(IAbstractPropertyProfile instance, Type type, UrlHelper url, IPropertyOwnerProfile owner, Func<IInstanceSettingsPermissionHolder, bool> filter, Func<Permission, bool> permissionRolesStereotypeFilter)
	{
		filter = filter ?? ((Func<IInstanceSettingsPermissionHolder, bool>)((IInstanceSettingsPermissionHolder h) => true));
		permissionRolesStereotypeFilter = permissionRolesStereotypeFilter ?? ((Func<Permission, bool>)((Permission pp) => true));
		IEnumerable<Tuple<Permission, PermissionRoleType[]>> source = ((PermissionTypeRoleService is IInstancePermissionTypeRoleService instancePermissionTypeRoleService) ? instancePermissionTypeRoleService.GetInstancePermissionRoles(instance) : PermissionTypeRoleService.GetPermissionRoles(type));
		IInstanceSettingsPermission settingsPermission = GetSettingsPermission(instance);
		List<IInstanceSettingsPermissionHolder> holders = settingsPermission.GetPermissionCollection(instance).Where(filter).ToList();
		bool canGrandPermissions = settingsPermission.CanGrandPermissions(AuthenticationService.GetCurrentUser(), instance);
		ICollection<Permission> grandPermission = settingsPermission.CanGrandLevel(AuthenticationService.GetCurrentUser(), instance);
		IPropertyInstanceService service = Locator.GetService<IPropertyInstanceService>();
		ClassMetadata md = service.GetClassMetadata(instance);
		List<Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>>> stereotypes = source.Where((Tuple<Permission, PermissionRoleType[]> t) => permissionRolesStereotypeFilter(t.Item1)).Select(delegate(Tuple<Permission, PermissionRoleType[]> t)
		{
			Permission permission = t.Item1;
			PermissionRoleTypeSelectorModel item = null;
			if (canGrandPermissions)
			{
				string popupId = UIExtensions.PrepareId("RoleSelector" + permission.Id.ToString());
				item = new PermissionRoleTypeSelectorModel
				{
					PopupId = popupId,
					Title = SR.T("Выбор объекта для назначения прав доступа"),
					TypeRoles = t.Item2,
					SelectedTypeRole = t.Item2.First(),
					ObjectId = permission.Id.ToString(),
					SubmitScript = null,
					CreatePopup = true,
					OrganizationTreeModel = CreateOrganizationTreeModel(popupId),
					GroupsTreeModel = CreateGroupsModel(popupId, instance, type),
					ExtGroupsTreeModel = CreateExtGroupsModel(popupId, instance, type),
					UserModel = CreateUserModel(popupId, url),
					EntityMetadata = md,
					PropertyModel = CreatePropertyModel(popupId, url, (IEntityMetadata)md)
				};
			}
			List<AssignedRoleTypeModel> item2 = (from h in holders
				where h.PermissionId == permission.Id
				select new AssignedRoleTypeModel(PermissionTypeRoleService.Get(h.TypeRoleId), h.Assigned)).ToList();
			return new Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>>(permission, item, item2);
		}).ToList();
		return new EntityPermissionRoleTypeSelectorModel(instance, type, (EntityMetadata)MetadataLoader.LoadMetadata(type), stereotypes)
		{
			Edit = canGrandPermissions,
			GrandPermission = grandPermission,
			PermissionCanGrantResolver = settingsPermission.CanGrandToElement,
			IsSystemRole = settingsPermission.IsSystemRole,
			HidePropertyPermissionId = service.GetHidePermissionId(owner),
			ViewPropertyPermissionId = service.GetViewPermissionId(owner),
			EditPropertyPermissionId = service.GetEditPermissionId(owner)
		};
	}

	public IEnumerable<Tuple<IEntity, PermissionRoleType>> GetAssignedEntities(EditableListModel model, object instance)
	{
		return model.Items.Select((EditableListItem i) => GetAssignedEntity(i, instance));
	}

	public Tuple<IEntity, PermissionRoleType> GetAssignedEntity(EditableListItem i, object instance)
	{
		IdAndTypeRole idAndTypeRole = i.Value.FromJson<IdAndTypeRole>();
		PermissionRoleType permissionRoleType = PermissionTypeRoleService.Load(idAndTypeRole.ObjectType);
		IEntity item = null;
		if (permissionRoleType == CommonRoleTypes.Property)
		{
			if (Guid.TryParse(idAndTypeRole.Id, out var pUid))
			{
				EntityMetadata entityMetadata = permissionRoleType.AssignedEntityEvalutor(instance) as EntityMetadata;
				PropertyMetadata propertyMetadata = entityMetadata?.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == pUid);
				item = new PropertyMetadataReference(entityMetadata, propertyMetadata);
			}
		}
		else if (permissionRoleType.AssignedEntityEvalutor != null)
		{
			item = permissionRoleType.AssignedEntityEvalutor(instance);
		}
		else if (!string.IsNullOrEmpty(idAndTypeRole.Id))
		{
			Type linkedEntityType = permissionRoleType.LinkedEntityType;
			if (linkedEntityType == null)
			{
				throw new InvalidOperationException(SR.T("LinkedEntityType == null для permissionRoleType {0} id={1}", permissionRoleType.Name, idAndTypeRole.Id));
			}
			item = (IEntity)EntityHelper.GetEntityManager(linkedEntityType).Load(idAndTypeRole.Id);
		}
		return new Tuple<IEntity, PermissionRoleType>(item, permissionRoleType);
	}

	public object GetEntity(EditableListItem i, Type type)
	{
		IEntityManager entityManager = EntityHelper.GetEntityManager(type);
		long entityId = i.Value.FromJson<IdAndTypeRole>().EntityId;
		if (entityId > 0)
		{
			return entityManager.Load(entityId);
		}
		return null;
	}

	public IEnumerable<AssignedRoleTypeModel> CreateAssignedRoleTypeModel(IEnumerable<IEntity> entities)
	{
		foreach (IEntity entity in entities)
		{
			if (entity is EleWise.ELMA.Security.Models.IUser)
			{
				yield return new AssignedRoleTypeModel(CommonRoleTypes.User, entity);
			}
			else if (entity is IUserGroup)
			{
				yield return new AssignedRoleTypeModel(CommonRoleTypes.Group, entity);
			}
			else if (entity is IOrganizationItem)
			{
				yield return new AssignedRoleTypeModel(CommonRoleTypes.OrganizationItem, entity);
			}
		}
	}

	public IInstanceSettingsPermission GetSettingsPermission(object instance)
	{
		Type type = EntityHelper.GetType(instance);
		IInstanceSettingsPermission instanceSettingsPermission = InstanceSettingsPermissions.FirstOrDefault((IInstanceSettingsPermission p) => type.IsInheritOrSame(p.EntityType));
		if (instanceSettingsPermission == null)
		{
			throw new InvalidOperationException(SR.T("Не удалось найти IInstanceSettingsPermission для типа {0}", type.Name));
		}
		return instanceSettingsPermission;
	}

	public void BindPermissionsFromModel(object instance, EditableListModel access, Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>> sync = null)
	{
		ICollection<IInstanceSettingsPermissionHolder> permissionCollection = GetSettingsPermission(instance).GetPermissionCollection(instance);
		List<InstanceSettingsPermissionHolder> source = access.Items.Select((EditableListItem i) => new
		{
			a = GetAssignedEntity(i, instance),
			i = i
		}).SelectMany(v => (string.IsNullOrWhiteSpace(v.i.Data) ? new Guid[0] : v.i.Data.FromJson<Guid[]>()).Select((Guid pid) => new InstanceSettingsPermissionHolder
		{
			Assigned = v.a.Item1,
			TypeRoleId = v.a.Item2.Id,
			PermissionId = PermissionManagmentService.GetPermission(pid).Id,
			Target = instance
		})).ToList();
		if (sync == null)
		{
			permissionCollection.SyncFrom(source, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
			{
				if (v is IEntity)
				{
					((IEntity)v).Delete();
				}
			});
		}
		else
		{
			sync(permissionCollection, source.Cast<IInstanceSettingsPermissionHolder>());
		}
	}

	public static void ParseItem(EditableListItem item, out Guid objectType, out string id)
	{
		Contract.ArgumentNotNull(item, "item");
		IdAndTypeRole idAndTypeRole = item.Value.FromJson<IdAndTypeRole>();
		objectType = idAndTypeRole.ObjectType;
		id = idAndTypeRole.Id;
	}

	public TreeModel CreateOrganizationTreeModel(string popupId)
	{
		List<TreeMenuNode> children = BuildFullTreeFromRootDTO(new long[0]);
		return new TreeModel
		{
			Id = popupId + "OrganizationTree",
			Children = children,
			ShowCheckBox = true,
			HtmlAttributes = new
			{
				style = "height:360px;"
			},
			SaveState = false,
			HighlightPath = false,
			ShowExpandCollapseButtons = true
		};
	}

	public AutocompleteComboBox CreateUserModel(string popupId, UrlHelper url)
	{
		return new AutocompleteComboBox
		{
			Name = popupId + "UserComboBox",
			MultiSelect = true,
			ActionName = "Select",
			ControllerName = "Entity",
			AutocompleteActionUrl = url.Action("Select", "Entity", (object)new
			{
				uid = InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>()
			}),
			RouteValueDictionary = 
			{
				{
					"area",
					(object)"EleWise.ELMA.BPM.Web.Common"
				},
				{
					"uid",
					(object)InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>()
				}
			}
		};
	}

	public AutocompleteComboBox CreatePropertyModel(string popupId, UrlHelper url, IEntityMetadata md)
	{
		if (md == null)
		{
			return null;
		}
		return new AutocompleteComboBox
		{
			Name = popupId + "PropertyComboBox",
			MultiSelect = true,
			ActionName = "FilteringPropertyAjax",
			ControllerName = "PermissionManagment",
			AutocompleteActionUrl = url.Action("FilteringPropertyAjax", "PermissionManagment", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security",
				uid = md.Uid
			}),
			RouteValueDictionary = 
			{
				{
					"area",
					(object)"EleWise.ELMA.BPM.Web.Security"
				},
				{
					"uid",
					(object)md.Uid
				}
			}
		};
	}

	public TreeModel CreateGroupsModel(string popupId, object instance = null, Type type = null)
	{
		ICollection<IUserGroup> items = UserGroupManager.FindAll();
		List<TreeMenuNode> children = BuildTreeNodes(items, new long[0]);
		return new TreeModel
		{
			Id = popupId + "GroupsTree",
			Children = children,
			ShowCheckBox = true,
			HtmlAttributes = new
			{
				style = "height:386px;"
			},
			SaveState = false,
			HighlightPath = false,
			ShowExpandCollapseButtons = false
		};
	}

	public List<ExtTreeModel> CreateExtGroupsModel(string popupId, object instance = null, Type type = null)
	{
		List<ExtTreeModel> list = new List<ExtTreeModel>();
		if (instance != null && type != null)
		{
			Dictionary<IRoleTypeSelectorGroupsCategory, List<IRoleTypeSelectorGroupsModelItems>> dictionary = (from i in RoleTypeSelectorGroupsModelItems
				where i.EntityType == type && i.Category != null
				select i into g
				group g by g.Category).ToDictionary((IGrouping<IRoleTypeSelectorGroupsCategory, IRoleTypeSelectorGroupsModelItems> g) => g.Key, (IGrouping<IRoleTypeSelectorGroupsCategory, IRoleTypeSelectorGroupsModelItems> g) => g.ToList());
			if (dictionary.Count > 0)
			{
				foreach (IRoleTypeSelectorGroupsCategory item2 in dictionary.Keys.OrderBy((IRoleTypeSelectorGroupsCategory key) => key.Name))
				{
					List<TreeMenuNode> children = dictionary[item2].SelectMany((IRoleTypeSelectorGroupsModelItems i) => i.GetItems(instance, type)).ToList();
					ExtTreeModel item = new ExtTreeModel
					{
						Id = popupId + "GroupsTree" + item2.Id,
						Name = item2.Name,
						Uid = item2.Uid,
						Children = children,
						ShowCheckBox = true,
						HtmlAttributes = new
						{
							style = "height:386px;"
						},
						SaveState = false,
						HighlightPath = false,
						ShowExpandCollapseButtons = false
					};
					list.Add(item);
				}
				return list;
			}
		}
		return list;
	}

	public List<TreeMenuNode> BuildTreeNodes(IEnumerable<IUserGroup> items, long[] selected)
	{
		return items.Select((IUserGroup item) => new TreeMenuNode
		{
			id = item.Id.ToString(),
			text = item.Name,
			Checked = selected.Contains(item.Id),
			checkable = true,
			tag = item
		}).ToList();
	}

	public List<TreeMenuNode> BuildFullTreeFromRoot(long[] selected, bool allowAll = false)
	{
		IOrderedEnumerable<IOrganizationItem> source = from i in OrganizationItemManager.Instance.LoadFullList()
			orderby i.Name
			select i;
		IEnumerable<IOrganizationItem> source2 = source.Where((IOrganizationItem i) => i.ParentItem == null);
		int num = source2.Count();
		if (num == 0)
		{
			return new List<TreeMenuNode>();
		}
		if (num > 1)
		{
			throw new InvalidOperationException(SR.T("Оргструктура содержит более одного корневого элемента"));
		}
		IOrganizationItem organizationItem = source2.First();
		Dictionary<IOrganizationItem, TreeMenuNode> dictionary = source.ToDictionary((IOrganizationItem i) => i, (IOrganizationItem i) => GetNode(i, selected, allowAll));
		foreach (KeyValuePair<IOrganizationItem, TreeMenuNode> item in dictionary)
		{
			if (item.Key != organizationItem && dictionary.TryGetValue(item.Key.ParentItem, out var value))
			{
				value.children.Add(item.Value);
			}
		}
		dictionary.ForEach(delegate(KeyValuePair<IOrganizationItem, TreeMenuNode> n)
		{
			n.Value.expanded = n.Key.ParentItem == null || n.Value.HasChecked();
		});
		return new List<TreeMenuNode> { dictionary[organizationItem] };
	}

	public List<TreeMenuNode> BuildFullTreeFromRootDTO(long[] selected, bool allowAll = false)
	{
		IOrderedEnumerable<OrganizationItemDTO> source = from i in OrganizationItemManager.Instance.LoadRootList()
			orderby i.Name
			select i;
		IEnumerable<OrganizationItemDTO> source2 = source.Where((OrganizationItemDTO i) => i.ParentItemId == 0);
		int num = source2.Count();
		if (num == 0)
		{
			return new List<TreeMenuNode>();
		}
		if (num > 1)
		{
			throw new InvalidOperationException(SR.T("Оргструктура содержит более одного корневого элемента"));
		}
		OrganizationItemDTO organizationItemDTO = source2.First();
		Dictionary<long, Tuple<long, TreeMenuNode>> dictionary = source.ToDictionary((OrganizationItemDTO i) => i.Id, (OrganizationItemDTO i) => new Tuple<long, TreeMenuNode>(i.ParentItemId, GetNode(i, selected, allowAll)));
		foreach (KeyValuePair<long, Tuple<long, TreeMenuNode>> item in dictionary)
		{
			if (item.Key != organizationItemDTO.Id && dictionary.TryGetValue(item.Value.Item1, out var value))
			{
				value.Item2.children.Add(item.Value.Item2);
			}
		}
		dictionary.Values.ForEach(delegate(Tuple<long, TreeMenuNode> n)
		{
			n.Item2.expanded = n.Item1 == 0L || n.Item2.HasChecked();
		});
		return new List<TreeMenuNode> { dictionary[organizationItemDTO.Id].Item2 };
	}

	public List<TreeMenuNode> BuildFullTreeNodes(IEnumerable<IOrganizationItem> items, long[] selected, bool allowAll = false)
	{
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		if (items != null)
		{
			items = items.OrderBy((IOrganizationItem _) => _.Name);
		}
		foreach (IOrganizationItem item in items)
		{
			TreeMenuNode node = GetNode(item, selected, allowAll);
			if (((ICollection<IOrganizationItem>)item.SubItems).Count > 0)
			{
				node.children = BuildFullTreeNodes((IEnumerable<IOrganizationItem>)item.SubItems, selected);
			}
			node.expanded = item.ParentItem == null || node.HasChecked();
			list.Add(node);
		}
		return list;
	}

	public List<TreeMenuNode> BuildTreeNodes(IEnumerable<OrganizationItemDTO> items, long[] selected, bool allowAll = false)
	{
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		if (items != null)
		{
			items = items.OrderBy((OrganizationItemDTO _) => _.Name);
		}
		foreach (OrganizationItemDTO item in items)
		{
			TreeMenuNode node = GetNode(item, selected, allowAll);
			if (item.Items.Count > 0)
			{
				node.children = BuildTreeNodes(item.Items, selected, allowAll);
			}
			node.expanded = item.ParentItemId == 0L || node.HasChecked();
			list.Add(node);
		}
		return list;
	}

	private TreeMenuNode GetNode(IOrganizationItem item, long[] selected, bool allowed)
	{
		TreeMenuNode treeMenuNode = new TreeMenuNode();
		treeMenuNode.id = item.Id.ToString();
		treeMenuNode.text = item.Name;
		if (item.ItemType == OrganizationItemType.Position)
		{
			if (item.User != null)
			{
				treeMenuNode.textAdditional = $"&nbsp;(<a href=\"javascript:showUserInfo('{item.User.Id}');\">{item.User.FullName.HtmlEncode()}</a>)";
			}
		}
		else
		{
			string[] array = item.UsersHash?.Split(',');
			if (array != null && array.Length != 0)
			{
				treeMenuNode.textAdditional = $" ({SR.Users}: {array.Length})";
			}
		}
		switch (item.ItemType)
		{
		case OrganizationItemType.Department:
			treeMenuNode.icon = "#department.svg";
			break;
		case OrganizationItemType.EmployeeGroup:
			treeMenuNode.icon = "#users.svg";
			break;
		case OrganizationItemType.NestedStructure:
			treeMenuNode.icon = "#company.svg";
			break;
		default:
			treeMenuNode.icon = "#user.svg";
			break;
		}
		treeMenuNode.Checked = selected.Contains(item.Id);
		treeMenuNode.checkable = allowed || (item.ItemType != 0 && OrganizationItemType.NestedStructure != item.ItemType);
		return treeMenuNode;
	}

	private TreeMenuNode GetNode(OrganizationItemDTO item, long[] selected, bool allowed)
	{
		TreeMenuNode treeMenuNode = new TreeMenuNode();
		treeMenuNode.id = item.Id.ToString();
		treeMenuNode.text = item.Name;
		switch (item.ItemType)
		{
		case OrganizationItemType.Department:
			treeMenuNode.icon = "#department.svg";
			break;
		case OrganizationItemType.EmployeeGroup:
			treeMenuNode.icon = "#users.svg";
			break;
		case OrganizationItemType.NestedStructure:
			treeMenuNode.icon = "#company.svg";
			break;
		default:
			treeMenuNode.icon = "#user.svg";
			break;
		}
		treeMenuNode.Checked = selected.Contains(item.Id);
		treeMenuNode.Selected = selected.Contains(item.Id);
		treeMenuNode.checkable = allowed || (item.ItemType != 0 && OrganizationItemType.NestedStructure != item.ItemType);
		treeMenuNode.children = new List<TreeMenuNode>();
		return treeMenuNode;
	}
}
