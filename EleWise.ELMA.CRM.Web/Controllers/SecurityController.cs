// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.SecurityController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  public class SecurityController : BPMController
  {
    public PermissionsModelService PermissionsModelService { get; set; }

    public IPermissionManagmentService PermissionManagmentService { get; set; }

    public GroupPermissionManager GroupPermissionManager { get; set; }

    [Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
    public ActionResult Permissions()
    {
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      IEnumerable<ICategory> allCategories = CategoryManager.Instance.GetAllCategories();
      return View((object) new SecurityPermissionModel(allCategories.Select<ICategory, CrmCustomPermissionsModel>(new Func<ICategory, CrmCustomPermissionsModel>(this.CreateLeadPermissionsModel)), allCategories.Select<ICategory, CrmCustomPermissionsModel>(new Func<ICategory, CrmCustomPermissionsModel>(this.CreateContractorPermissionsModel)), new GlobalPermissionsModel(this.GetGlobalCRMPermissionns(), nameof (Permissions), "Security", "EleWise.ELMA.CRM.Web", false)
      {
        Title = EleWise.ELMA.SR.T("Права доступа к модулю «Работа с клиентами»"),
        ShowHeader = true
      }));
    }

    public ActionResult PropertiesPermissions()
    {
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      return View();
    }

    private IEnumerable<Tuple<Permission, IEnumerable<IUserGroup>>> GetGlobalCRMPermissionns() => this.PermissionManagmentService.GetPermissions().Where<Permission>((Func<Permission, bool>) (p => p.PermissionType == PermissionType.Global && p.ModuleUid == "EleWise.ELMA.CRM.Web")).ToList<Permission>().Select<Permission, Tuple<Permission, IEnumerable<IUserGroup>>>((Func<Permission, Tuple<Permission, IEnumerable<IUserGroup>>>) (p => Tuple.Create<Permission, IEnumerable<IUserGroup>>(p, this.GroupPermissionManager.GetGroupsByPermission(p))));

    [HttpPost]
    [TransactionAction]
    [Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
    public ActionResult SetPermissionsCrmCategory(
      ICategory category,
      string modelType,
      EditableListModel editableListModel)
    {
      this.SetCrmPermissions(category, modelType, editableListModel);
      return Redirect(((Controller) this).Url.ReturnUrl());
    }

    private CrmCustomPermissionsModel CreateLeadPermissionsModel(ICategory category)
    {
      IEnumerable<AssignedRoleTypeModel> assignedRoleTypeModel = this.PermissionsModelService.CreateAssignedRoleTypeModel(this.GetEntitiesList(category.LeadPermissions));
      IEnumerable<CrmPermissionData> leadPermissionsData = this.CreateLeadPermissionsData(category);
      return new CrmCustomPermissionsModel(category, CrmCustomPermissionsModel.ModelTypeLead, assignedRoleTypeModel, leadPermissionsData);
    }

    private IEnumerable<IEntity> GetEntitiesList(Iesi.Collections.Generic.ISet<ILeadPermission> leadPermissions)
    {
      List<IEntity> entitiesList = new List<IEntity>();
      foreach (ILeadPermission leadPermission in (IEnumerable<ILeadPermission>) leadPermissions)
      {
        IEntity entity = (IEntity) null;
        if (leadPermission.User != null)
          entity = (IEntity) leadPermission.User;
        if (leadPermission.UserGroup != null)
          entity = (IEntity) leadPermission.UserGroup;
        if (leadPermission.OrganizationItem != null)
          entity = (IEntity) leadPermission.OrganizationItem;
        entitiesList.Add(entity);
      }
      return (IEnumerable<IEntity>) entitiesList;
    }

    private IEnumerable<CrmPermissionData> CreateLeadPermissionsData(ICategory category)
    {
      List<CrmPermissionData> leadPermissionsData = new List<CrmPermissionData>();
      foreach (ILeadPermission leadPermission in (IEnumerable<ILeadPermission>) category.LeadPermissions)
      {
        CrmPermissionData crmPermissionData = new CrmPermissionData();
        if (leadPermission.User != null)
        {
          crmPermissionData.ObjectType = CommonRoleTypes.User.UID;
          crmPermissionData.Id = leadPermission.User.Id;
        }
        if (leadPermission.UserGroup != null)
        {
          crmPermissionData.ObjectType = CommonRoleTypes.Group.UID;
          crmPermissionData.Id = leadPermission.UserGroup.Id;
        }
        if (leadPermission.OrganizationItem != null)
        {
          crmPermissionData.ObjectType = CommonRoleTypes.OrganizationItem.UID;
          crmPermissionData.Id = leadPermission.OrganizationItem.Id;
        }
        crmPermissionData.CanRead = leadPermission.CanRead;
        crmPermissionData.CanEdit = leadPermission.CanEdit;
        crmPermissionData.FullAccess = leadPermission.FullAccess;
        leadPermissionsData.Add(crmPermissionData);
      }
      return (IEnumerable<CrmPermissionData>) leadPermissionsData;
    }

    private CrmCustomPermissionsModel CreateContractorPermissionsModel(ICategory category)
    {
      IEnumerable<AssignedRoleTypeModel> assignedRoleTypeModel = this.PermissionsModelService.CreateAssignedRoleTypeModel(this.GetEntitiesList(category.ContractorPermissions));
      IEnumerable<CrmPermissionData> contractorPermissionsData = this.CreateContractorPermissionsData(category);
      return new CrmCustomPermissionsModel(category, CrmCustomPermissionsModel.ModelTypeContractor, assignedRoleTypeModel, contractorPermissionsData);
    }

    private IEnumerable<IEntity> GetEntitiesList(Iesi.Collections.Generic.ISet<IContractorPermission> leadPermissions)
    {
      List<IEntity> entitiesList = new List<IEntity>();
      foreach (IContractorPermission leadPermission in (IEnumerable<IContractorPermission>) leadPermissions)
      {
        IEntity entity = (IEntity) null;
        if (leadPermission.User != null)
          entity = (IEntity) leadPermission.User;
        if (leadPermission.UserGroup != null)
          entity = (IEntity) leadPermission.UserGroup;
        if (leadPermission.OrganizationItem != null)
          entity = (IEntity) leadPermission.OrganizationItem;
        entitiesList.Add(entity);
      }
      return (IEnumerable<IEntity>) entitiesList;
    }

    private IEnumerable<CrmPermissionData> CreateContractorPermissionsData(ICategory category)
    {
      List<CrmPermissionData> contractorPermissionsData = new List<CrmPermissionData>();
      foreach (IContractorPermission contractorPermission in (IEnumerable<IContractorPermission>) category.ContractorPermissions)
      {
        CrmPermissionData crmPermissionData = new CrmPermissionData();
        if (contractorPermission.User != null)
        {
          crmPermissionData.ObjectType = CommonRoleTypes.User.UID;
          crmPermissionData.Id = contractorPermission.User.Id;
        }
        if (contractorPermission.UserGroup != null)
        {
          crmPermissionData.ObjectType = CommonRoleTypes.Group.UID;
          crmPermissionData.Id = contractorPermission.UserGroup.Id;
        }
        if (contractorPermission.OrganizationItem != null)
        {
          crmPermissionData.ObjectType = CommonRoleTypes.OrganizationItem.UID;
          crmPermissionData.Id = contractorPermission.OrganizationItem.Id;
        }
        crmPermissionData.CanRead = contractorPermission.CanRead;
        crmPermissionData.CanEdit = contractorPermission.CanEdit;
        crmPermissionData.FullAccess = contractorPermission.FullAccess;
        contractorPermissionsData.Add(crmPermissionData);
      }
      return (IEnumerable<CrmPermissionData>) contractorPermissionsData;
    }

    private PermissionRoleTypeSelectorModel MembersPopupModel(ICategory category, string modelType)
    {
      string str = "CategoryMembersPopup" + (object) category.Id + modelType;
      return new PermissionRoleTypeSelectorModel()
      {
        PopupId = str,
        Title = EleWise.ELMA.SR.T("Выбор участника"),
        TypeRoles = new PermissionRoleType[1]
        {
          CommonRoleTypes.Group
        },
        SelectedTypeRole = CommonRoleTypes.Group,
        ObjectId = "theCategoryId" + (object) category.Id + modelType,
        SubmitScript = "elma.appendFromPermissionPopup('CategoryMembers" + (object) category.Id + modelType + "')",
        CreatePopup = true,
        OrganizationTreeModel = this.PermissionsModelService.CreateOrganizationTreeModel(str),
        GroupsTreeModel = this.PermissionsModelService.CreateGroupsModel(str, (object) null, (Type) null),
        ExtGroupsTreeModel = this.PermissionsModelService.CreateExtGroupsModel(str, (object) null, (Type) null),
        UserModel = this.PermissionsModelService.CreateUserModel(str, ((Controller) this).Url)
      };
    }

    private void SetCrmPermissions(
      ICategory category,
      string modelType,
      EditableListModel editableListModel)
    {
      if (modelType == CrmCustomPermissionsModel.ModelTypeLead)
        category.LeadPermissions.Clear();
      else
        category.ContractorPermissions.Clear();
      foreach (ListItem listItem in editableListModel.Items)
      {
        CrmPermissionData objData = listItem.Value.FromJson<CrmPermissionData>();
        IUserGroup group = (IUserGroup) null;
        if (objData.ObjectType == CommonRoleTypes.Group.UID)
          group = UserGroupManager.Instance.Load(objData.Id);
        if (modelType == CrmCustomPermissionsModel.ModelTypeLead)
          this.AddLeadPermission(category, objData, group: group);
        else
          this.AddContractorPermission(category, objData, group: group);
      }
      category.Save();
    }

    private void AddLeadPermission(
      ICategory category,
      CrmPermissionData objData,
      EleWise.ELMA.Security.Models.IUser user = null,
      IUserGroup group = null,
      IOrganizationItem organizationItem = null)
    {
      ILeadPermission newPermission = InterfaceActivator.Create<ILeadPermission>();
      newPermission.User = user;
      newPermission.UserGroup = group;
      newPermission.OrganizationItem = organizationItem;
      newPermission.CanRead = objData.CanRead;
      newPermission.CanEdit = objData.CanEdit;
      newPermission.FullAccess = objData.FullAccess;
      newPermission.Category = category;
      if (this.LeadPermissionExists(category.LeadPermissions, newPermission))
        return;
      category.LeadPermissions.Add(newPermission);
    }

    private bool LeadPermissionExists(
      Iesi.Collections.Generic.ISet<ILeadPermission> leadPermissions,
      ILeadPermission newPermission)
    {
      foreach (ILeadPermission leadPermission in (IEnumerable<ILeadPermission>) leadPermissions)
      {
        if (leadPermission.User == newPermission.User && leadPermission.UserGroup == newPermission.UserGroup && leadPermission.OrganizationItem == newPermission.OrganizationItem)
          return true;
      }
      return false;
    }

    private void AddContractorPermission(
      ICategory category,
      CrmPermissionData objData,
      EleWise.ELMA.Security.Models.IUser user = null,
      IUserGroup group = null,
      IOrganizationItem organizationItem = null)
    {
      IContractorPermission newPermission = InterfaceActivator.Create<IContractorPermission>();
      newPermission.User = user;
      newPermission.UserGroup = group;
      newPermission.OrganizationItem = organizationItem;
      newPermission.CanRead = objData.CanRead;
      newPermission.CanEdit = objData.CanEdit;
      newPermission.FullAccess = objData.FullAccess;
      newPermission.Category = category;
      if (this.ContractorPermissionExists(category.ContractorPermissions, newPermission))
        return;
      category.ContractorPermissions.Add(newPermission);
    }

    private bool ContractorPermissionExists(
      Iesi.Collections.Generic.ISet<IContractorPermission> contractorPermissions,
      IContractorPermission newPermission)
    {
      foreach (IContractorPermission contractorPermission in (IEnumerable<IContractorPermission>) contractorPermissions)
      {
        if (contractorPermission.User == newPermission.User && contractorPermission.UserGroup == newPermission.UserGroup && contractorPermission.OrganizationItem == newPermission.OrganizationItem)
          return true;
      }
      return false;
    }

    [HttpGet]
    public ActionResult PermissionSettings(Guid uid)
    {
      string str = "crm-admin-menu";
      ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(uid);
      Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(uid);
      if (catalogProfile == null)
      {
        catalogProfile = InterfaceActivator.Create<ICatalogProfile>();
        catalogProfile.CatalogType = new ReferenceOnEntityType()
        {
          EntityType = typeByUid
        };
        catalogProfile.Name = catalogProfile.CatalogType.DisplayName;
        catalogProfile.Save();
      }
      return RedirectToAction("EntityPermissionSettings", "PermissionManagment", (object) new
      {
        area = "EleWise.ELMA.BPM.Web.Security",
        id = catalogProfile.Id,
        type = catalogProfile.GetType().AssemblyQualifiedName,
        catalog = false,
        activeMenuItemCode = str
      });
    }
  }
}
