using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Security;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class PermissionManagmentController : BPMController
{
	private IEnumerable<IUnusedPermissions> unusedPermissions;

	public new ISecurityService SecurityService { get; set; }

	public IPermissionManagmentService PermissionManagmentService { get; set; }

	public IEntityPermissionService EntityPermissionService { get; set; }

	public GroupPermissionManager GroupPermissionManager { get; set; }

	public UserGroupManager UserGroupManager { get; set; }

	public IEnumerable<IModulePermissionsPageProvider> ModulePermissionsPage { get; set; }

	public IModuleService ModuleService { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	public IPermissionTypeRoleService PermissionTypeRoleService { get; set; }

	public IEnumerable<IEntityPermissionsPageProvider> PermissionsPageProviders { get; set; }

	public IEnumerable<IModulePermissionsPageProvider> ModulePermissionsPageProvider { get; set; }

	public IComponentManager ComponentManager { get; set; }

	public IEnumerable<IEntityPermissionsTypeExtensionPoint> EntityPermissionsTypeService { get; set; }

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

	private IPropertyInstanceService propertyInstanceService { get; set; }

	public PermissionManagmentController(IPropertyInstanceService propertyInstanceService)
	{
		this.propertyInstanceService = propertyInstanceService;
	}

	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult GlobalPermissions(string search = null, string currentMenu = null, string title = null, string module = null, string callback = null)
	{
		if (!string.IsNullOrEmpty(callback))
		{
			string[] array = callback.Split(";".ToCharArray());
			currentMenu = ((array.Length != 0) ? array[0] : "");
			title = ((array.Length > 1) ? array[1] : "");
			module = ((array.Length > 2) ? array[2] : "");
			return (ActionResult)(object)((Controller)this).RedirectToAction("GlobalPermissions", "PermissionManagment", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security",
				currentMenu = currentMenu,
				title = title,
				module = module
			});
		}
		if (!string.IsNullOrEmpty(currentMenu))
		{
			((Controller)(object)this).SetCurrentMenuItem(currentMenu);
		}
		GlobalPermissionsModel globalPermissionsModel = new GlobalPermissionsModel(from p in (from p in PermissionManagmentService.GetPermissions()
				where p.PermissionType == PermissionType.Global && p.ShowInGlobalSettings && (string.IsNullOrEmpty(module) || p.ModuleUid == module)
				select p).ToList()
			select Tuple.Create(p, GroupPermissionManager.GetGroupsByPermission(p)))
		{
			SearchString = search,
			Title = title,
			Callback = $"{currentMenu};{title};{module}"
		};
		globalPermissionsModel.Title = (string.IsNullOrEmpty(title) ? SR.T("Глобальные настройки доступа") : title);
		return (ActionResult)(object)((Controller)this).View((object)globalPermissionsModel);
	}

	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	[ContentItem(Name = "SR.M('Настройки доступа')", Image24 = "~/Content/IconPack/access.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View("ModuleSettingsPage", (object)ModulePermissionsPageProvider.ToList());
	}

	[HttpGet]
	public ActionResult EntityPermissionSettings(long id, Type type, bool catalog = true, string activeMenuItemCode = null)
	{
		if (!string.IsNullOrEmpty(activeMenuItemCode))
		{
			((Controller)(object)this).SetCurrentMenuItem(activeMenuItemCode);
		}
		((ControllerBase)this).get_ViewData().set_Item("ActiveMenuItemCode", (object)activeMenuItemCode);
		IEntityManager entityManager = EntityHelper.GetEntityManager(type);
		object instance = entityManager.Load(id);
		CheckEntityPermissionSettingsAccess(instance);
		EntityPermissionRoleTypeSelectorModel entityPermissionRoleTypeSelectorModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, type, ((Controller)this).get_Url(), null, loadData: false);
		entityPermissionRoleTypeSelectorModel.IsCatalog = catalog;
		IPropertyOwnerProfile propertyOwner = instance as IPropertyOwnerProfile;
		IEnumerable<IAbstractPropertyProfile> enumerable = ((propertyOwner != null) ? propertyInstanceService.GetPropertyProfiles(propertyOwner) : null);
		if (enumerable != null)
		{
			entityPermissionRoleTypeSelectorModel.PropertyPermissionRoleTypeSelectorList = (from l in enumerable
				where l != null
				select PermissionsModelService.GetPropertyPermissionRoleTypeSelectorModel(l, l.GetType(), ((Controller)this).get_Url(), propertyOwner)).ToList();
		}
		entityPermissionRoleTypeSelectorModel.IsInstancePermissionSupport = EntityPermissionsTypeService.Any((IEntityPermissionsTypeExtensionPoint p) => p.IsInstancePermissionMode(instance));
		return (ActionResult)(object)((Controller)this).View((object)entityPermissionRoleTypeSelectorModel);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult EntityPermissionSettings(long id, Type type, FormCollection formCollection, string propertySettings, bool isCatalog = true, string activeMenuItemCode = null)
	{
		if (!string.IsNullOrEmpty(propertySettings))
		{
			PropertyPermissionSave(propertySettings, type, id);
		}
		if (!isCatalog)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("EntityPermissionSettings", (object)new
			{
				id = id,
				type = type.AssemblyQualifiedName,
				catalog = isCatalog,
				activeMenuItemCode = activeMenuItemCode
			});
		}
		IEntityManager entityManager = EntityHelper.GetEntityManager(type);
		object instance = entityManager.Load(id);
		CheckEntityPermissionSettingsAccess(instance);
		ICollection<IInstanceSettingsPermissionHolder> permissionCollection = PermissionsModelService.GetSettingsPermission(instance).GetPermissionCollection(instance);
		EntityPermissionRoleTypeSelectorModel entityPermissionRoleTypeSelectorModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, type, ((Controller)this).get_Url(), null, loadData: false);
		entityPermissionRoleTypeSelectorModel.Edit = true;
		IEnumerable<InstanceSettingsPermissionHolder> source = entityPermissionRoleTypeSelectorModel.PermissionTypeRolesModels.SelectMany(delegate(Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>> p)
		{
			Permission permission = p.Item1;
			string text2 = permission.Id.ToString();
			EditableListModel editableListModel = new EditableListModel();
			((Controller)this).UpdateModel<EditableListModel>(editableListModel, text2);
			return from t in PermissionsModelService.GetAssignedEntities(editableListModel, instance)
				select new InstanceSettingsPermissionHolder
				{
					Assigned = t.Item1,
					PermissionId = permission.Id,
					TypeRoleId = t.Item2.Id
				};
		});
		List<Permission> unusedPermissionsList = UnusedPermissions.SelectMany((IUnusedPermissions p) => p.Permissions(instance) ?? Enumerable.Empty<Permission>()).Distinct().ToList();
		permissionCollection.SyncFrom(source, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => unusedPermissionsList.Any((Permission p) => p.Id == v2.PermissionId) || (v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned)), null, delegate(IInstanceSettingsPermissionHolder v)
		{
			if (v is IEntity)
			{
				((IEntity)v).Delete();
			}
		});
		permissionCollection.ForEach(delegate(IInstanceSettingsPermissionHolder h)
		{
			h.Target = instance;
		});
		entityManager.Save(instance);
		string text = ((ControllerBase)this).get_TempData().get_Item("ReturnUrl") as string;
		if (!string.IsNullOrEmpty(text))
		{
			return (ActionResult)(object)((Controller)this).Redirect(text);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityPermissionSettings", (object)new
		{
			type = type.AssemblyQualifiedName,
			activeMenuItemCode = activeMenuItemCode
		});
	}

	private List<EleWise.ELMA.Security.Models.IUser> AddReplacementUsers(List<EleWise.ELMA.Security.Models.IUser> users)
	{
		List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
		foreach (EleWise.ELMA.Security.Models.IUser user in users)
		{
			if (user.ReplacementUser != null)
			{
				list.AddIfNotContains(user.ReplacementUser);
			}
		}
		return users.Union(list).ToList();
	}

	private void CheckEntityPermissionSettingsAccess(object instance)
	{
		IEntityPermissionsPageProvider entityPermissionsPageProvider = ((PermissionsPageProviders != null) ? PermissionsPageProviders.FirstOrDefault((IEntityPermissionsPageProvider p) => p.IsSupported(instance)) : null);
		if (entityPermissionsPageProvider != null)
		{
			entityPermissionsPageProvider.CheckAccess(instance);
			return;
		}
		throw new SecurityException(SR.T("Нельзя настроить права доступа к объекту на данной странице"));
	}

	public static void FillUsersByPrefixed(List<EleWise.ELMA.Security.Models.IUser> users, string[] prefixedUserIds)
	{
		for (int i = 0; i < prefixedUserIds.Length; i++)
		{
			foreach (EleWise.ELMA.Security.Models.IUser prefixedUser in BaseEntityUserTypeSelector.GetUsers(prefixedUserIds[i]))
			{
				if (users.All((EleWise.ELMA.Security.Models.IUser u) => !u.Equals(prefixedUser)) && prefixedUser.Status == UserStatus.Active)
				{
					users.Add(prefixedUser);
				}
			}
		}
	}

	public ActionResult NeedAddPermissionToEntity(long[] id, Type type, long[] userIds, string[] prefixedUserIds, Guid permission, bool needReplacement = false)
	{
		bool result = EntityPermissionService.CheckIfPermissionNeededForEntity(id, type, userIds, prefixedUserIds, permission, needReplacement);
		return (ActionResult)(object)((Controller)this).Json((object)new { result });
	}

	public ActionResult EntityAddPermission(long[] id, Type type, long[] userIds, string[] prefixedUserIds, Guid permission, string submitScript, string labelText = "", string popupId = "", string saveButtonText = "", Guid[] defaultPermissions = null, bool needReplacement = false)
	{
		AddPermissionModel addPermissionModel = EntityPermissionService.EntityAddPermission(id, type, userIds, prefixedUserIds, permission, defaultPermissions, needReplacement);
		EntityAddPermissionModel entityAddPermissionModel = new EntityAddPermissionModel
		{
			PopupId = popupId,
			LabelText = labelText,
			ButtonText = saveButtonText,
			SubmitScript = submitScript,
			Edit = addPermissionModel.HasGrantPermission,
			GrandPermission = addPermissionModel.GrandPermissions,
			PermissionTypeRolesModels = addPermissionModel.PermissionTypeRolesModels,
			EntityMetadata = addPermissionModel.EntityMetadata,
			EntityType = addPermissionModel.EntityType
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)entityAddPermissionModel);
	}

	[HttpPost]
	public ActionResult EntityAddPermissionSave(long[] id, Type type, EditableListModel accessBindList)
	{
		if (id == null || type == null || accessBindList == null)
		{
			return SuccessJson();
		}
		EntityPermissionService.EntityAddPermissionSave(id, type, accessBindList);
		return SuccessJson();
	}

	[HttpGet]
	public ActionResult EntityDependedPermissionSettings(long id, Type type, string popupId = "", string bindModelName = "", bool showSaveButton = true, bool noForm = false, bool disabledNotUserGroup = false, bool ajax = false, bool readOnly = false, string prefix = "", string onClosePopupFunction = "")
	{
		object instance = EntityHelper.GetEntityManager(type).Load(id);
		EntityPermissionRoleTypeSelectorModel entityPermissionRoleTypeSelectorModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, type, ((Controller)this).get_Url());
		entityPermissionRoleTypeSelectorModel.PopupId = popupId;
		entityPermissionRoleTypeSelectorModel.ShowSaveButton = showSaveButton;
		entityPermissionRoleTypeSelectorModel.NoForm = noForm;
		entityPermissionRoleTypeSelectorModel.DisabledNotUserGroup = disabledNotUserGroup;
		entityPermissionRoleTypeSelectorModel.Ajax = ajax;
		entityPermissionRoleTypeSelectorModel.Edit = !readOnly;
		entityPermissionRoleTypeSelectorModel.OnClosePopupFunction = onClosePopupFunction;
		if (!string.IsNullOrEmpty(bindModelName))
		{
			entityPermissionRoleTypeSelectorModel.BindModelName = bindModelName;
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)entityPermissionRoleTypeSelectorModel);
	}

	[HttpPost]
	public ActionResult EntityDependedPermissionSettings(long id, Type type, EditableListModel access)
	{
		EntityDependedPermissionSettingsInnerLogic(id, type, access);
		Uri urlReferrer = ((Controller)this).get_HttpContext().Request.UrlReferrer;
		return (ActionResult)(object)((Controller)this).Redirect((urlReferrer != null && !string.IsNullOrWhiteSpace(urlReferrer.ToString())) ? urlReferrer.ToString() : "/");
	}

	[HttpPost]
	public ActionResult EntityDependedPermissionSettingsAjax(long id, Type type, EditableListModel access)
	{
		EntityDependedPermissionSettingsInnerLogic(id, type, access);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}

	private void EntityDependedPermissionSettingsInnerLogic(long id, Type type, EditableListModel access)
	{
		IEntityManager entityManager = EntityHelper.GetEntityManager(type);
		object obj = entityManager.Load(id);
		PermissionsModelService.BindPermissionsFromModel(obj, access);
		entityManager.Save(obj);
	}

	public void PropertyPermissionSave(string settings, Type type, long id)
	{
		if (!(EntityHelper.GetEntityManager(type).Load(id) is IPropertyOwnerProfile owner))
		{
			return;
		}
		object obj = JsonConvert.DeserializeObject(settings, typeof(List<PropertySettings>));
		List<IAbstractPropertyProfile> list = new List<IAbstractPropertyProfile>();
		IUserGroup userGroup = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		Guid viewPermissionId = propertyInstanceService.GetViewPermissionId(owner);
		Guid hidePermissionId = propertyInstanceService.GetHidePermissionId(owner);
		foreach (PropertySettings item in obj as List<PropertySettings>)
		{
			EditableListModel editableListModel = new EditableListModel();
			EditableListItem[] array = (EditableListItem[])(editableListModel.Items = JsonConvert.DeserializeObject(item.access_value, typeof(EditableListItem[])) as EditableListItem[]);
			IEntityManager entityManager = EntityHelper.GetEntityManager(item.type);
			IAbstractPropertyProfile abstractPropertyProfile = ((item.id > 0) ? ((IAbstractPropertyProfile)entityManager.Load(item.id)) : propertyInstanceService.CreateProfile(owner, item.prop_guid));
			if (item.prop_guid != Guid.Empty)
			{
				bool flag = false;
				EditableListItem[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					PermissionsModelService.ParseItem(array2[i], out var objectType, out var id2);
					if (objectType == CommonRoleTypes.Group.UID && id2 == userGroup.Id.ToString())
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					bool flag2 = !item.prop_guid.Equals(Guid.Empty) && propertyInstanceService.IsTitleProperty(abstractPropertyProfile);
					EditableListItem editableListItem = new EditableListItem
					{
						Data = $"[\"{(flag2 ? viewPermissionId : hidePermissionId)}\"]",
						Value = $"{{\"ObjectType\":\"{CommonRoleTypes.Group.UID}\",\"Id\":{userGroup.Id}}}"
					};
					editableListModel.Items = new EditableListItem[1] { editableListItem }.Union(array).ToList();
				}
			}
			PermissionsModelService.BindPermissionsFromModel(abstractPropertyProfile, editableListModel);
			entityManager.Save(abstractPropertyProfile);
			list.Add(abstractPropertyProfile);
		}
		propertyInstanceService.SaveProfiles(owner, list);
	}

	public string GetProperties(long id, Type type)
	{
		if (!(EntityHelper.GetEntityManager(type).Load(id) is IPropertyOwnerProfile owner))
		{
			return null;
		}
		IEnumerable<IPropertyMetadata> propertyMetadataList = propertyInstanceService.GetPropertyMetadataList(owner);
		Guid titleUid = propertyInstanceService.GetTitlePropertyGuid(owner);
		Dictionary<Guid, PropertyMetaLite> dict = new Dictionary<Guid, PropertyMetaLite>();
		dict.Add(Guid.Empty, new PropertyMetaLite
		{
			DisplayName = SR.T("ВСЕ СВОЙСТВА"),
			IsRequired = false,
			IsTitle = false
		});
		propertyMetadataList.ForEach(delegate(IPropertyMetadata i)
		{
			dict.Add(i.Uid, new PropertyMetaLite
			{
				DisplayName = i.DisplayName,
				IsRequired = i.Required,
				IsTitle = i.Uid.Equals(titleUid),
				Uid = i.Uid
			});
		});
		return JsonConvert.SerializeObject((object)dict);
	}

	[HttpPost]
	public ActionResult PropertyAddPopUp(string list, string exist)
	{
		List<Guid> obj = JsonConvert.DeserializeObject(exist, typeof(List<Guid>)) as List<Guid>;
		Dictionary<Guid, PropertyMetaLite> propList = JsonConvert.DeserializeObject(list, typeof(Dictionary<Guid, PropertyMetaLite>)) as Dictionary<Guid, PropertyMetaLite>;
		obj.ForEach(delegate(Guid i)
		{
			if (propList.ContainsKey(i))
			{
				propList.Remove(i);
			}
		});
		AutoCompletePropertyItem[] items = AutoCompletePropertyItem.GetItems(((Controller)this).get_Url(), propList);
		return (ActionResult)(object)((Controller)this).PartialView("PropertyAddPopUp", (object)JsonConvert.SerializeObject((object)items));
	}

	public ActionResult AddPropertyToTable(Guid guid, Type type, long id)
	{
		IPropertyOwnerProfile owner = (IPropertyOwnerProfile)EntityHelper.GetEntityManager(type).Load(id);
		IAbstractPropertyProfile abstractPropertyProfile = Locator.GetService<IPropertyInstanceService>().CreateProfile(owner, guid);
		EntityPermissionRoleTypeSelectorModel propertyPermissionRoleTypeSelectorModel = PermissionsModelService.GetPropertyPermissionRoleTypeSelectorModel(abstractPropertyProfile, abstractPropertyProfile.GetType(), ((Controller)this).get_Url(), owner);
		return (ActionResult)(object)((Controller)this).PartialView("PermissionManagment/PropertiesPermissionSettings", (object)propertyPermissionRoleTypeSelectorModel);
	}

	[HttpPost]
	public ActionResult FilteringPropertyAjax(Guid uid)
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		if (!(MetadataLoader.LoadMetadata(uid) is EntityMetadata entityMetadata) || entityMetadata.Properties == null)
		{
			return null;
		}
		List<Guid> uids = new List<Guid>();
		uids.Add((InterfaceActivator.LoadMetadata(typeof(EleWise.ELMA.Security.Models.IUser)) as EntityMetadata).ImplementationUid);
		uids.Add((InterfaceActivator.LoadMetadata(typeof(IUserGroup)) as EntityMetadata).ImplementationUid);
		uids.Add((InterfaceActivator.LoadMetadata(typeof(IOrganizationItem)) as EntityMetadata).ImplementationUid);
		SelectList data = new SelectList((IEnumerable)(from p in entityMetadata.Properties
			where uids.Contains(p.SubTypeUid) && p.Settings is EntitySettings && ((EntitySettings)p.Settings).RelationType == RelationType.OneToOne
			select new
			{
				id = p.Uid,
				text = p.DisplayName
			} into t
			orderby t.text
			select t).ToList(), "id", "text");
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		return (ActionResult)val;
	}

	[HttpPost]
	public ActionResult GetOrgTree(long id, Type type, string popupid, bool catalog = true)
	{
		object instance = EntityHelper.GetEntityManager(type).Load(id);
		CheckEntityPermissionSettingsAccess(instance);
		Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>> tuple = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, type, ((Controller)this).get_Url(), null, loadData: false, popupid).PermissionTypeRolesModels.FirstOrDefault((Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>> t) => t.Item2.PopupId == popupid);
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = null;
		if (tuple != null && tuple.Item2 != null)
		{
			permissionRoleTypeSelectorModel = tuple.Item2;
		}
		if (permissionRoleTypeSelectorModel != null)
		{
			permissionRoleTypeSelectorModel.SubmitScript = "elma.appendFromPermissionPopup('" + popupid.Replace("RoleSelector", "").Replace("_", "-") + "')";
		}
		return (ActionResult)(object)((Controller)this).PartialView("Permission/PermissionTypeRoleSelectorPopup", (object)permissionRoleTypeSelectorModel);
	}

	[HttpGet]
	public ActionResult RecalculatePermission(Type type, long id)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		foreach (IEntityPermissionsTypeExtensionPoint item in EntityPermissionsTypeService)
		{
			try
			{
				item.UpdatePermissions(type, id, needDropOldData: true);
			}
			catch (Exception message)
			{
				base.Logger.Error(message);
				JsonResult val = new JsonResult();
				val.set_Data((object)new
				{
					Error = SR.T("Ошибка при попытке пересчета прав доступа. Подбробные сведения записаны в лог файл.")
				});
				val.set_JsonRequestBehavior((JsonRequestBehavior)0);
				return (ActionResult)val;
			}
		}
		JsonResult val2 = new JsonResult();
		val2.set_Data((object)new
		{
			Ok = true
		});
		val2.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)val2;
	}
}
