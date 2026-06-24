using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
public class UserGroupController : BPMController<IUserGroup, long>
{
	public PermissionsModelService PermissionsModelService { get; set; }

	public IPermissionManagmentService PermissionManagmentService { get; set; }

	public GroupPermissionManager GroupPermissionManager { get; set; }

	public new IAuthenticationService AuthenticationService { get; set; }

	public UserGroupManager UserGroupManager { get; set; }

	[ContentItem(Name = "SR.M('Группы')", Image24 = "~/Content/IconPack/users.svg")]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Create()
	{
		return (ActionResult)(object)((Controller)this).View((object)new UserGroupModel(base.Manager.Create(), MembersPopupModel(), new AssignedRoleTypeModel[0]));
	}

	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Edit(IUserGroup group)
	{
		if (UserGroupManager.LoadOrNull(group.Uid) == null)
		{
			IUserGroup userGroup = base.Manager.Create();
			userGroup.Name = group.Name;
			userGroup.Description = group.Description;
			UserGroupModel userGroupModel = new UserGroupModel(userGroup, MembersPopupModel(), new AssignedRoleTypeModel[0]);
			return (ActionResult)(object)((Controller)this).View("Create", (object)userGroupModel);
		}
		UserGroupModel userGroupModel2 = CreateModel(group);
		return (ActionResult)(object)((Controller)this).View("Edit", (object)userGroupModel2);
	}

	private UserGroupModel CreateModel(IUserGroup group, bool isPopup = false)
	{
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = MembersPopupModel();
		IOrderedEnumerable<AssignedRoleTypeModel> assignedRoleTypeModels = from a in PermissionsModelService.CreateAssignedRoleTypeModel(((IEnumerable)@group.Users).Cast<IEntity>().Union((IEnumerable<IEntity>)@group.Groups).Union((IEnumerable<IEntity>)@group.OrganizationItems))
			orderby a.Value.ToString()
			select a;
		UserGroupModel userGroupModel = new UserGroupModel(group, permissionRoleTypeSelectorModel, assignedRoleTypeModels);
		if (!isPopup && base.SecurityService.HasPermission(PermissionProvider.AccessManagmentPermission))
		{
			IEnumerable<Guid> groupPermissions = GroupPermissionManager.GetGroupPermissions(group);
			Permission[] array2 = (userGroupModel.Permissions = (from p in PermissionManagmentService.GetPermissions()
				where p.PermissionType == PermissionType.Global && groupPermissions.Any((Guid gp) => gp == p.Id)
				select p).ToArray());
			userGroupModel.ShowPermissions = true;
		}
		uint? maxGroupUsersCount = UserGroupManager.GetMaxGroupUsersCount(group);
		if (maxGroupUsersCount.HasValue)
		{
			userGroupModel.LicenseTotalCount = (int)maxGroupUsersCount.Value;
			userGroupModel.LicenseUsedCount = ((ICollection<EleWise.ELMA.Security.Models.IUser>)group.Users).Count;
			userGroupModel.PermissionRoleTypeSelectorModel.GroupsTreeModel = null;
			userGroupModel.PermissionRoleTypeSelectorModel.OrganizationTreeModel = null;
			userGroupModel.PermissionRoleTypeSelectorModel.TypeRoles = new PermissionRoleType[1] { CommonRoleTypes.User };
		}
		userGroupModel.IsPopup = isPopup;
		return userGroupModel;
	}

	private PermissionRoleTypeSelectorModel MembersPopupModel()
	{
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = new PermissionRoleTypeSelectorModel();
		permissionRoleTypeSelectorModel.PopupId = "membersPopup";
		permissionRoleTypeSelectorModel.Title = SR.T("Выбор участника");
		permissionRoleTypeSelectorModel.TypeRoles = new PermissionRoleType[3]
		{
			CommonRoleTypes.User,
			CommonRoleTypes.Group,
			CommonRoleTypes.OrganizationItem
		};
		permissionRoleTypeSelectorModel.SelectedTypeRole = CommonRoleTypes.User;
		permissionRoleTypeSelectorModel.ObjectId = "theGriupId";
		permissionRoleTypeSelectorModel.SubmitScript = "elma.appendFromPermissionPopup('members')";
		permissionRoleTypeSelectorModel.CreatePopup = true;
		permissionRoleTypeSelectorModel.OrganizationTreeModel = PermissionsModelService.CreateOrganizationTreeModel("membersPopup");
		permissionRoleTypeSelectorModel.GroupsTreeModel = PermissionsModelService.CreateGroupsModel("membersPopup");
		permissionRoleTypeSelectorModel.ExtGroupsTreeModel = PermissionsModelService.CreateExtGroupsModel("membersPopup");
		permissionRoleTypeSelectorModel.UserModel = PermissionsModelService.CreateUserModel("membersPopup", ((Controller)this).get_Url());
		return permissionRoleTypeSelectorModel;
	}

	[EntityLink(ParametrName = "id")]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult View(IUserGroup group)
	{
		UserGroupModel userGroupModel = CreateModel(group);
		return (ActionResult)(object)((Controller)this).View((object)userGroupModel);
	}

	[HttpGet]
	public ActionResult ViewInfo(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		IUserGroup userGroup = base.Manager.LoadOrNull(id.Value);
		if (userGroup == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		UserGroupModel userGroupModel = CreateModel(userGroup, isPopup: true);
		return (ActionResult)(object)((Controller)this).PartialView("UserGroup/Info", (object)userGroupModel);
	}

	[HttpPost]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Delete(IUserGroup model)
	{
		if (UserGroupManager.LoadOrNull(model.Uid) != null)
		{
			try
			{
				UserGroupManager.Delete(model);
			}
			catch (Exception ex)
			{
				base.Logger.Error(SR.T("Ошибка при удалении группы"), ex);
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = false,
					error = ex.Message
				});
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[HttpPost]
	[TransactionAction]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public virtual ActionResult Save([NotNull] IUserGroup group, [Bind(Prefix = "members")] EditableListModel members)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (!ReValidateModel(group, "group"))
		{
			return Edit(group);
		}
		IEnumerable<IEntity> source = from a in PermissionsModelService.GetAssignedEntities(members, @group)
			select a.Item1;
		((ICollection<IUserGroup>)group.Groups).SyncFrom(source.OfType<IUserGroup>());
		((ICollection<EleWise.ELMA.Security.Models.IUser>)group.Users).SyncFrom(source.OfType<EleWise.ELMA.Security.Models.IUser>());
		((ICollection<IOrganizationItem>)group.OrganizationItems).SyncFrom(source.OfType<IOrganizationItem>());
		if (UserGroupManager.HasCircle(group))
		{
			Locator.GetServiceNotNull<IUnitOfWorkManager>().RollbackCurrent("");
			base.Notifier.Error(SR.T("Циклическая зависимоcть между группами."));
			return Edit(group);
		}
		try
		{
			UserGroupManager.Save(group);
		}
		catch (LicenseException exception)
		{
			Locator.GetServiceNotNull<IUnitOfWorkManager>().RollbackCurrent("");
			FormNotifierExtensions.Error(base.Notifier, exception);
			return Edit(group);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "UserGroup", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = group.Id
		});
	}

	[CustomGridAction]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IUserFilter filter)
	{
		GridData<IUserGroup, IEntityFilter> gridData = ((IEntityManager<IUserGroup>)base.Manager).CreateGridData(command, (IEntityFilter)filter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}
}
