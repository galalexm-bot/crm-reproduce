using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Cache;
using EleWise.ELMA.CRM.Exceptions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class CategoryController : BPMController<ICategory, long>
{
	public ICacheService CacheService { get; set; }

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	public ActionResult Index()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
		categoryFilter.ShowNoCategory = true;
		GridData<ICategory, ICategoryFilter> gridData = CreateGridData(null, categoryFilter);
		EleWise.ELMA.Security.Models.IUser currentUser = GetCurrentUser();
		bool showAccess = base.SecurityService.HasPermission(currentUser, PermissionProvider.AccessManagmentPermission);
		return (ActionResult)(object)((Controller)this).View((object)new CategoryIndexModel
		{
			CurrentUser = currentUser,
			GridData = gridData,
			ShowAccess = showAccess,
			CheckUpdatePermission = CategoryManager.Instance.CheckUpdateCategoryPermission(),
			LockEditPermission = CategoryManager.Instance.CheckLockEditPermission(),
			LastRecalculatePermissionsError = CacheService.Get<string>("34839AAF-916F-4FEF-917D-21EA38656268")
		});
	}

	[HttpPost]
	public ActionResult GetRecalculateCategoryPermissionStatus()
	{
		string lastErr = CacheService.Get<string>("34839AAF-916F-4FEF-917D-21EA38656268");
		bool blocking = CategoryManager.Instance.CheckLockEditPermission();
		return (ActionResult)(object)((Controller)this).Json((object)new { blocking, lastErr }, "text/html");
	}

	public ActionResult Create()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		ICategory category = InterfaceActivator.Create<ICategory>();
		CategoryEditModel categoryEditModel = new CategoryEditModel
		{
			Category = category
		};
		if (!(categoryEditModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking))
		{
			CategoryManager.Instance.CreateContainerPermission(category, save: false);
		}
		categoryEditModel.CheckUpdatePermission = CategoryManager.Instance.CheckUpdateCategoryPermission(category);
		categoryEditModel.ContractorPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(category.ContainerContractorPermission, InterfaceActivator.TypeOf<IContContractorPermission>(), ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder h) => h is ITemplateContractorPermission && ((ITemplateContractorPermission)h).ContainerContractor == category.ContainerContractorPermission && !((ITemplateContractorPermission)h).DelPermission);
		categoryEditModel.ContractorPermissionsModel.ShowSaveButton = false;
		categoryEditModel.ContractorPermissionsModel.NoForm = true;
		categoryEditModel.ContractorPermissionsModel.BindModelName = "contractor";
		categoryEditModel.ContractorPermissionsModel.Edit = !categoryEditModel.LockEditPermission;
		categoryEditModel.LeadPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(category.ContainerLeadPermission, InterfaceActivator.TypeOf<IContLeadPermission>(), ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder h) => h is ITemplateLeadPermission && ((ITemplateLeadPermission)h).ContainerLead == category.ContainerLeadPermission && !((ITemplateLeadPermission)h).DelPermission);
		categoryEditModel.LeadPermissionsModel.NoForm = true;
		categoryEditModel.LeadPermissionsModel.ShowSaveButton = false;
		categoryEditModel.LeadPermissionsModel.BindModelName = "lead";
		categoryEditModel.LeadPermissionsModel.Edit = !categoryEditModel.LockEditPermission;
		categoryEditModel.Category = category;
		return (ActionResult)(object)((Controller)this).View("EditForm", (object)categoryEditModel);
	}

	[HttpPost]
	public ActionResult SaveCategory(ICategory category, EditableListModel lead, EditableListModel contractor)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return EditCategory(category);
		}
		if (CategoryManager.Instance.GetAllCategories().Any((ICategory c) => c.Name == category.Name && c.Uid != category.Uid))
		{
			string text = SR.T("Категория с именем \"{0}\" уже существует", category.Name);
			base.Notifier.Error(text);
			return EditCategory(category);
		}
		updateTemplatePermission(category, lead, contractor);
		try
		{
			category.Save();
		}
		catch (BlockedPermissionException)
		{
			return EditCategory(category);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[HttpPost]
	public ActionResult RecalculateCategoryPermission()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (CategoryManager.Instance.RecalculateCategoryPermissionInThread())
		{
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				Ok = true
			});
			return (ActionResult)val;
		}
		JsonResult val2 = new JsonResult();
		val2.set_Data((object)new
		{
			Error = SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже.")
		});
		return (ActionResult)val2;
	}

	[TransactionAction]
	private void updateTemplatePermission(ICategory category, EditableListModel lead, EditableListModel contractorTemplateModel)
	{
		CategoryManager.Instance.CreateContainerPermission(category, save: true);
		if (contractorTemplateModel != null && contractorTemplateModel.Items != null)
		{
			PermissionsModelService.BindPermissionsFromModel(category.ContainerContractorPermission, contractorTemplateModel, SyncFromContractor);
		}
		if (lead != null && lead.Items != null)
		{
			PermissionsModelService.BindPermissionsFromModel(category.ContainerLeadPermission, lead, SyncFromLead);
		}
	}

	public static void SyncFromContractor(ICollection<IInstanceSettingsPermissionHolder> target, IEnumerable<IInstanceSettingsPermissionHolder> source)
	{
		List<IInstanceSettingsPermissionHolder> list = target.ToList();
		List<IInstanceSettingsPermissionHolder> list2 = source.ToList();
		foreach (IInstanceSettingsPermissionHolder v2 in list2)
		{
			if (!target.Any((IInstanceSettingsPermissionHolder v1) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned)))
			{
				target.Add(v2);
			}
			foreach (IInstanceSettingsPermissionHolder item in target.Where((IInstanceSettingsPermissionHolder v1) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned) && (!(v1 is ITemplateContractorPermission) || (((ITemplateContractorPermission)v1).DelPermission ? true : false))))
			{
				if (item is ITemplateContractorPermission templateContractorPermission)
				{
					templateContractorPermission.DelPermission = false;
					templateContractorPermission.AddPermission = true;
				}
			}
		}
		foreach (IInstanceSettingsPermissionHolder v3 in list)
		{
			if (!list2.Any((IInstanceSettingsPermissionHolder v1) => v1.TypeRoleId == v3.TypeRoleId && v1.PermissionId == v3.PermissionId && object.Equals(v1.Assigned, v3.Assigned)) && v3 is ITemplateContractorPermission)
			{
				ITemplateContractorPermission obj = v3 as ITemplateContractorPermission;
				obj.DelPermission = true;
				obj.AddPermission = false;
			}
		}
	}

	public static void SyncFromLead(ICollection<IInstanceSettingsPermissionHolder> target, IEnumerable<IInstanceSettingsPermissionHolder> source)
	{
		List<IInstanceSettingsPermissionHolder> list = target.ToList();
		List<IInstanceSettingsPermissionHolder> list2 = source.ToList();
		foreach (IInstanceSettingsPermissionHolder v2 in list2)
		{
			if (!target.Any((IInstanceSettingsPermissionHolder v1) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned)))
			{
				target.Add(v2);
			}
			foreach (IInstanceSettingsPermissionHolder item in target.Where((IInstanceSettingsPermissionHolder v1) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned) && (!(v1 is ITemplateLeadPermission) || (((ITemplateLeadPermission)v1).DelPermission ? true : false))))
			{
				if (item is ITemplateLeadPermission templateLeadPermission)
				{
					templateLeadPermission.DelPermission = false;
					templateLeadPermission.AddPermission = true;
				}
			}
		}
		foreach (IInstanceSettingsPermissionHolder v3 in list)
		{
			if (!list2.Any((IInstanceSettingsPermissionHolder v1) => v1.TypeRoleId == v3.TypeRoleId && v1.PermissionId == v3.PermissionId && object.Equals(v1.Assigned, v3.Assigned)) && v3 is ITemplateLeadPermission)
			{
				ITemplateLeadPermission obj = v3 as ITemplateLeadPermission;
				obj.DelPermission = true;
				obj.AddPermission = false;
			}
		}
	}

	private ActionResult EditCategory(ICategory category)
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		CategoryEditModel categoryEditModel = new CategoryEditModel
		{
			Category = category
		};
		if (!(categoryEditModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking))
		{
			CategoryManager.Instance.CreateContainerPermission(category, save: true);
		}
		categoryEditModel.CheckUpdatePermission = CategoryManager.Instance.CheckUpdateCategoryPermission(category);
		categoryEditModel.ContractorPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(category.ContainerContractorPermission, InterfaceActivator.TypeOf<IContContractorPermission>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (h is ITemplateContractorPermission templateContractorPermission && templateContractorPermission.User == null && templateContractorPermission.Group == null && templateContractorPermission.OrganizationItemPosition == null && templateContractorPermission.OrganizationItemEmployee == null)
			{
				return false;
			}
			return (h is ITemplateContractorPermission && ((ITemplateContractorPermission)h).ContainerContractor == category.ContainerContractorPermission && !((ITemplateContractorPermission)h).DelPermission) ? true : false;
		});
		categoryEditModel.ContractorPermissionsModel.ShowSaveButton = false;
		categoryEditModel.ContractorPermissionsModel.NoForm = true;
		categoryEditModel.ContractorPermissionsModel.BindModelName = "contractor";
		categoryEditModel.ContractorPermissionsModel.Edit = !categoryEditModel.LockEditPermission;
		categoryEditModel.LeadPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(category.ContainerLeadPermission, InterfaceActivator.TypeOf<IContLeadPermission>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (h is ITemplateLeadPermission templateLeadPermission && templateLeadPermission.User == null && templateLeadPermission.Group == null && templateLeadPermission.OrganizationItemPosition == null && templateLeadPermission.OrganizationItemEmployee == null)
			{
				return false;
			}
			return (h is ITemplateLeadPermission && ((ITemplateLeadPermission)h).ContainerLead == category.ContainerLeadPermission && !((ITemplateLeadPermission)h).DelPermission) ? true : false;
		});
		categoryEditModel.LeadPermissionsModel.NoForm = true;
		categoryEditModel.LeadPermissionsModel.ShowSaveButton = false;
		categoryEditModel.LeadPermissionsModel.BindModelName = "lead";
		categoryEditModel.LeadPermissionsModel.Edit = !categoryEditModel.LockEditPermission;
		categoryEditModel.Category = category;
		return (ActionResult)(object)((Controller)this).View("EditForm", (object)categoryEditModel);
	}

	public ActionResult Edit(ICategory category)
	{
		return EditCategory(category);
	}

	public ActionResult Delete(ICategory category)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return EditCategory(category);
		}
		category.Delete();
		ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
		categoryFilter.ShowNoCategory = true;
		GridData<ICategory, ICategoryFilter> gridData = CreateGridData(null, categoryFilter);
		return (ActionResult)(object)((Controller)this).PartialView("Grid", (object)gridData);
	}

	[CustomGridAction]
	public virtual ActionResult Grid(GridCommand command)
	{
		ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
		categoryFilter.ShowNoCategory = true;
		GridData<ICategory, ICategoryFilter> gridData = CreateGridData(command, categoryFilter);
		return GridView(gridData);
	}
}
