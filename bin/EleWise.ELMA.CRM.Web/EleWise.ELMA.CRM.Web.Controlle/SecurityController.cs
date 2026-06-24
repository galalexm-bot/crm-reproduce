using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Security;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class SecurityController : BPMController
{
	public PermissionsModelService PermissionsModelService { get; set; }

	public IPermissionManagmentService PermissionManagmentService { get; set; }

	public GroupPermissionManager GroupPermissionManager { get; set; }

	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Permissions()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		IEnumerable<ICategory> allCategories = CategoryManager.Instance.GetAllCategories();
		IEnumerable<CrmCustomPermissionsModel> leadPermissionsModels = allCategories.Select(CreateLeadPermissionsModel);
		IEnumerable<CrmCustomPermissionsModel> contractorPermissionsModels = allCategories.Select(CreateContractorPermissionsModel);
		GlobalPermissionsModel globalPermissionsModel = new GlobalPermissionsModel(GetGlobalCRMPermissionns(), "Permissions", "Security", "EleWise.ELMA.CRM.Web", showHeader: false);
		globalPermissionsModel.Title = SR.T("Права доступа к модулю «Работа с клиентами»");
		globalPermissionsModel.ShowHeader = true;
		SecurityPermissionModel securityPermissionModel = new SecurityPermissionModel(leadPermissionsModels, contractorPermissionsModels, globalPermissionsModel);
		return (ActionResult)(object)((Controller)this).View((object)securityPermissionModel);
	}

	public ActionResult PropertiesPermissions()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		return (ActionResult)(object)((Controller)this).View();
	}

	private IEnumerable<Tuple<Permission, IEnumerable<IUserGroup>>> GetGlobalCRMPermissionns()
	{
		return from p in (from p in PermissionManagmentService.GetPermissions()
				where p.PermissionType == PermissionType.Global && p.ModuleUid == "EleWise.ELMA.CRM.Web"
				select p).ToList()
			select Tuple.Create(p, GroupPermissionManager.GetGroupsByPermission(p));
	}

	[HttpPost]
	[TransactionAction]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult SetPermissionsCrmCategory(ICategory category, string modelType, EditableListModel editableListModel)
	{
		SetCrmPermissions(category, modelType, editableListModel);
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	private CrmCustomPermissionsModel CreateLeadPermissionsModel(ICategory category)
	{
		IEnumerable<IEntity> entitiesList = GetEntitiesList(category.LeadPermissions);
		IEnumerable<AssignedRoleTypeModel> assignedRoleTypeModels = PermissionsModelService.CreateAssignedRoleTypeModel(entitiesList);
		IEnumerable<CrmPermissionData> leadPermissionData = CreateLeadPermissionsData(category);
		return new CrmCustomPermissionsModel(category, CrmCustomPermissionsModel.ModelTypeLead, assignedRoleTypeModels, leadPermissionData);
	}

	private IEnumerable<IEntity> GetEntitiesList(ISet<ILeadPermission> leadPermissions)
	{
		List<IEntity> list = new List<IEntity>();
		foreach (ILeadPermission item2 in (IEnumerable<ILeadPermission>)leadPermissions)
		{
			IEntity item = null;
			if (item2.User != null)
			{
				item = item2.User;
			}
			if (item2.UserGroup != null)
			{
				item = item2.UserGroup;
			}
			if (item2.OrganizationItem != null)
			{
				item = item2.OrganizationItem;
			}
			list.Add(item);
		}
		return list;
	}

	private IEnumerable<CrmPermissionData> CreateLeadPermissionsData(ICategory category)
	{
		List<CrmPermissionData> list = new List<CrmPermissionData>();
		foreach (ILeadPermission item in (IEnumerable<ILeadPermission>)category.LeadPermissions)
		{
			CrmPermissionData crmPermissionData = new CrmPermissionData();
			if (item.User != null)
			{
				crmPermissionData.ObjectType = CommonRoleTypes.User.UID;
				crmPermissionData.Id = item.User.Id;
			}
			if (item.UserGroup != null)
			{
				crmPermissionData.ObjectType = CommonRoleTypes.Group.UID;
				crmPermissionData.Id = item.UserGroup.Id;
			}
			if (item.OrganizationItem != null)
			{
				crmPermissionData.ObjectType = CommonRoleTypes.OrganizationItem.UID;
				crmPermissionData.Id = item.OrganizationItem.Id;
			}
			crmPermissionData.CanRead = item.CanRead;
			crmPermissionData.CanEdit = item.CanEdit;
			crmPermissionData.FullAccess = item.FullAccess;
			list.Add(crmPermissionData);
		}
		return list;
	}

	private CrmCustomPermissionsModel CreateContractorPermissionsModel(ICategory category)
	{
		IEnumerable<IEntity> entitiesList = GetEntitiesList(category.ContractorPermissions);
		IEnumerable<AssignedRoleTypeModel> assignedRoleTypeModels = PermissionsModelService.CreateAssignedRoleTypeModel(entitiesList);
		IEnumerable<CrmPermissionData> leadPermissionData = CreateContractorPermissionsData(category);
		return new CrmCustomPermissionsModel(category, CrmCustomPermissionsModel.ModelTypeContractor, assignedRoleTypeModels, leadPermissionData);
	}

	private IEnumerable<IEntity> GetEntitiesList(ISet<IContractorPermission> leadPermissions)
	{
		List<IEntity> list = new List<IEntity>();
		foreach (IContractorPermission item2 in (IEnumerable<IContractorPermission>)leadPermissions)
		{
			IEntity item = null;
			if (item2.User != null)
			{
				item = item2.User;
			}
			if (item2.UserGroup != null)
			{
				item = item2.UserGroup;
			}
			if (item2.OrganizationItem != null)
			{
				item = item2.OrganizationItem;
			}
			list.Add(item);
		}
		return list;
	}

	private IEnumerable<CrmPermissionData> CreateContractorPermissionsData(ICategory category)
	{
		List<CrmPermissionData> list = new List<CrmPermissionData>();
		foreach (IContractorPermission item in (IEnumerable<IContractorPermission>)category.ContractorPermissions)
		{
			CrmPermissionData crmPermissionData = new CrmPermissionData();
			if (item.User != null)
			{
				crmPermissionData.ObjectType = CommonRoleTypes.User.UID;
				crmPermissionData.Id = item.User.Id;
			}
			if (item.UserGroup != null)
			{
				crmPermissionData.ObjectType = CommonRoleTypes.Group.UID;
				crmPermissionData.Id = item.UserGroup.Id;
			}
			if (item.OrganizationItem != null)
			{
				crmPermissionData.ObjectType = CommonRoleTypes.OrganizationItem.UID;
				crmPermissionData.Id = item.OrganizationItem.Id;
			}
			crmPermissionData.CanRead = item.CanRead;
			crmPermissionData.CanEdit = item.CanEdit;
			crmPermissionData.FullAccess = item.FullAccess;
			list.Add(crmPermissionData);
		}
		return list;
	}

	private PermissionRoleTypeSelectorModel MembersPopupModel(ICategory category, string modelType)
	{
		string popupId = "CategoryMembersPopup" + category.Id + modelType;
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = new PermissionRoleTypeSelectorModel();
		permissionRoleTypeSelectorModel.PopupId = popupId;
		permissionRoleTypeSelectorModel.Title = SR.T("Выбор участника");
		permissionRoleTypeSelectorModel.TypeRoles = new PermissionRoleType[1] { CommonRoleTypes.Group };
		permissionRoleTypeSelectorModel.SelectedTypeRole = CommonRoleTypes.Group;
		permissionRoleTypeSelectorModel.ObjectId = "theCategoryId" + category.Id + modelType;
		permissionRoleTypeSelectorModel.SubmitScript = "elma.appendFromPermissionPopup('CategoryMembers" + category.Id + modelType + "')";
		permissionRoleTypeSelectorModel.CreatePopup = true;
		permissionRoleTypeSelectorModel.OrganizationTreeModel = PermissionsModelService.CreateOrganizationTreeModel(popupId);
		permissionRoleTypeSelectorModel.GroupsTreeModel = PermissionsModelService.CreateGroupsModel(popupId);
		permissionRoleTypeSelectorModel.ExtGroupsTreeModel = PermissionsModelService.CreateExtGroupsModel(popupId);
		permissionRoleTypeSelectorModel.UserModel = PermissionsModelService.CreateUserModel(popupId, ((Controller)this).get_Url());
		return permissionRoleTypeSelectorModel;
	}

	private void SetCrmPermissions(ICategory category, string modelType, EditableListModel editableListModel)
	{
		if (modelType == CrmCustomPermissionsModel.ModelTypeLead)
		{
			((ICollection<ILeadPermission>)category.LeadPermissions).Clear();
		}
		else
		{
			((ICollection<IContractorPermission>)category.ContractorPermissions).Clear();
		}
		foreach (EditableListItem item in editableListModel.Items)
		{
			CrmPermissionData crmPermissionData = item.Value.FromJson<CrmPermissionData>();
			IUserGroup group = null;
			if (crmPermissionData.ObjectType == CommonRoleTypes.Group.UID)
			{
				group = UserGroupManager.Instance.Load(crmPermissionData.Id);
			}
			if (modelType == CrmCustomPermissionsModel.ModelTypeLead)
			{
				AddLeadPermission(category, crmPermissionData, null, group);
			}
			else
			{
				AddContractorPermission(category, crmPermissionData, null, group);
			}
		}
		category.Save();
	}

	private void AddLeadPermission(ICategory category, CrmPermissionData objData, EleWise.ELMA.Security.Models.IUser user = null, IUserGroup group = null, IOrganizationItem organizationItem = null)
	{
		ILeadPermission leadPermission = InterfaceActivator.Create<ILeadPermission>();
		leadPermission.User = user;
		leadPermission.UserGroup = group;
		leadPermission.OrganizationItem = organizationItem;
		leadPermission.CanRead = objData.CanRead;
		leadPermission.CanEdit = objData.CanEdit;
		leadPermission.FullAccess = objData.FullAccess;
		leadPermission.Category = category;
		if (!LeadPermissionExists(category.LeadPermissions, leadPermission))
		{
			category.LeadPermissions.Add(leadPermission);
		}
	}

	private bool LeadPermissionExists(ISet<ILeadPermission> leadPermissions, ILeadPermission newPermission)
	{
		foreach (ILeadPermission item in (IEnumerable<ILeadPermission>)leadPermissions)
		{
			if (item.User == newPermission.User && item.UserGroup == newPermission.UserGroup && item.OrganizationItem == newPermission.OrganizationItem)
			{
				return true;
			}
		}
		return false;
	}

	private void AddContractorPermission(ICategory category, CrmPermissionData objData, EleWise.ELMA.Security.Models.IUser user = null, IUserGroup group = null, IOrganizationItem organizationItem = null)
	{
		IContractorPermission contractorPermission = InterfaceActivator.Create<IContractorPermission>();
		contractorPermission.User = user;
		contractorPermission.UserGroup = group;
		contractorPermission.OrganizationItem = organizationItem;
		contractorPermission.CanRead = objData.CanRead;
		contractorPermission.CanEdit = objData.CanEdit;
		contractorPermission.FullAccess = objData.FullAccess;
		contractorPermission.Category = category;
		if (!ContractorPermissionExists(category.ContractorPermissions, contractorPermission))
		{
			category.ContractorPermissions.Add(contractorPermission);
		}
	}

	private bool ContractorPermissionExists(ISet<IContractorPermission> contractorPermissions, IContractorPermission newPermission)
	{
		foreach (IContractorPermission item in (IEnumerable<IContractorPermission>)contractorPermissions)
		{
			if (item.User == newPermission.User && item.UserGroup == newPermission.UserGroup && item.OrganizationItem == newPermission.OrganizationItem)
			{
				return true;
			}
		}
		return false;
	}

	[HttpGet]
	public ActionResult PermissionSettings(Guid uid)
	{
		string activeMenuItemCode = "crm-admin-menu";
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(uid);
		Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(uid);
		if (catalogProfile == null)
		{
			catalogProfile = InterfaceActivator.Create<ICatalogProfile>();
			catalogProfile.CatalogType = new ReferenceOnEntityType
			{
				EntityType = typeByUid
			};
			catalogProfile.Name = catalogProfile.CatalogType.DisplayName;
			catalogProfile.Save();
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityPermissionSettings", "PermissionManagment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = catalogProfile.Id,
			type = catalogProfile.GetType().AssemblyQualifiedName,
			catalog = false,
			activeMenuItemCode = activeMenuItemCode
		});
	}
}
