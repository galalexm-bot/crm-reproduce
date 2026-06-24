using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class RoleMapPageController : BPMController<IRoleMapPage, long>
{
	public RoleMapPageManager RoleMapPageManager { get; set; }

	public EntityManager<IRoleMapPageItem, long> RoleMapPageItemManager { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	[HttpGet]
	public PartialViewResult CreateMapItemPopup(long pageId, long? id = null)
	{
		IRoleMapPage parent = RoleMapPageManager.Load(pageId);
		IRoleMapPageItem roleMapPageItem = InterfaceActivator.Create<IRoleMapPageItem>();
		roleMapPageItem.Parent = parent;
		if (id.HasValue)
		{
			roleMapPageItem = RoleMapPageItemManager.Load(id.Value);
		}
		RoleMapPageItemCreateModel roleMapPageItemCreateModel = new RoleMapPageItemCreateModel
		{
			Entity = roleMapPageItem,
			MapItemRoleTypeSelectorModel = MembersPopupModel(),
			AssignedRoleTypeModels = GetMapItems(roleMapPageItem)
		};
		return ((Controller)this).PartialView((object)roleMapPageItemCreateModel);
	}

	[TransactionAction]
	[HttpPost]
	public ActionResult EditMapItem([Bind(Prefix = "Entity")] IRoleMapPageItem roleMapPageItem, [Bind(Prefix = "roleMapPageItemMembers")] EditableListModel roleMapPageItemMembers)
	{
		if (((Controller)this).get_ModelState().get_IsValid() && roleMapPageItemMembers != null && roleMapPageItemMembers.Items != null)
		{
			((ICollection<EleWise.ELMA.Security.Models.IUser>)roleMapPageItem.Users).Clear();
			((ICollection<IOrganizationItem>)roleMapPageItem.OrganizationItems).Clear();
			((ICollection<IUserGroup>)roleMapPageItem.UserGroups).Clear();
			roleMapPageItemMembers.Items.ForEach(delegate(EditableListItem i)
			{
				Tuple<IEntity, PermissionRoleType> assignedEntity = PermissionsModelService.GetAssignedEntity(i, roleMapPageItem.Parent);
				if (assignedEntity.Item2 == CommonRoleTypes.User)
				{
					roleMapPageItem.Users.Add(assignedEntity.Item1.Cast<EleWise.ELMA.Security.Models.IUser, IEntity>());
				}
				else if (assignedEntity.Item2 == CommonRoleTypes.OrganizationItem)
				{
					roleMapPageItem.OrganizationItems.Add(assignedEntity.Item1.Cast<IOrganizationItem, IEntity>());
				}
				else if (assignedEntity.Item2 == CommonRoleTypes.Group)
				{
					roleMapPageItem.UserGroups.Add(assignedEntity.Item1.Cast<IUserGroup, IEntity>());
				}
			});
			roleMapPageItem.Save();
			base.Notifier.Information(SR.T("Привязка к странице сохранена"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("ConfigureRoleMapPage", "Page", (object)new
		{
			id = roleMapPageItem.Parent.Id
		});
	}

	[TransactionAction]
	[HttpPost]
	public JsonResult UpdateItemsOrder(long id, long[] data)
	{
		try
		{
			foreach (IRoleMapPageItem item in (IEnumerable<IRoleMapPageItem>)RoleMapPageManager.Load(id).MapItems)
			{
				item.Order = Array.IndexOf(data, item.Id);
				item.Save();
			}
			return ((Controller)this).Json((object)new
			{
				success = true,
				message = SR.T("Порядок элементов сохранен")
			});
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка обновления порядка элементов ролевой страницы"), exception);
			base.UnitOfWorkManager.RollbackCurrent("");
			return ((Controller)this).Json((object)new
			{
				success = false,
				message = SR.T("Ошибка обновления порядка элементов ролевой страницы")
			});
		}
	}

	[TransactionAction]
	[HttpPost]
	public JsonResult DeleteItem(IRoleMapPageItem roleMapPageItem)
	{
		long id = roleMapPageItem.Id;
		try
		{
			roleMapPageItem.Delete();
			return ((Controller)this).Json((object)new
			{
				success = true,
				message = SR.T("Привязка удалена"),
				value = id
			});
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка удаления привязки"), exception);
			base.UnitOfWorkManager.RollbackCurrent("");
			return ((Controller)this).Json((object)new
			{
				success = false,
				message = SR.T("Ошибка удаления привязки"),
				value = id
			});
		}
	}

	private IEnumerable<AssignedRoleTypeModel> GetMapItems(IRoleMapPageItem mapItem)
	{
		return PermissionsModelService.CreateAssignedRoleTypeModel(((IEnumerable)mapItem.Users).Cast<IEntity>().Union((IEnumerable<IEntity>)mapItem.OrganizationItems).Union((IEnumerable<IEntity>)mapItem.UserGroups));
	}

	private PermissionRoleTypeSelectorModel MembersPopupModel()
	{
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = new PermissionRoleTypeSelectorModel();
		permissionRoleTypeSelectorModel.PopupId = "membersMapItemInstancePopup";
		permissionRoleTypeSelectorModel.Title = SR.T("Выбор участника");
		permissionRoleTypeSelectorModel.TypeRoles = new PermissionRoleType[3]
		{
			CommonRoleTypes.User,
			CommonRoleTypes.Group,
			CommonRoleTypes.OrganizationItem
		};
		permissionRoleTypeSelectorModel.SelectedTypeRole = CommonRoleTypes.User;
		permissionRoleTypeSelectorModel.ObjectId = "theGroupId";
		permissionRoleTypeSelectorModel.SubmitScript = "elma.appendFromPermissionPopup('roleMapPageItemMembers')";
		permissionRoleTypeSelectorModel.CreatePopup = true;
		permissionRoleTypeSelectorModel.OrganizationTreeModel = PermissionsModelService.CreateOrganizationTreeModel("membersMapItemInstancePopup");
		permissionRoleTypeSelectorModel.GroupsTreeModel = PermissionsModelService.CreateGroupsModel("membersMapItemInstancePopup");
		permissionRoleTypeSelectorModel.ExtGroupsTreeModel = PermissionsModelService.CreateExtGroupsModel("membersMapItemInstancePopup");
		permissionRoleTypeSelectorModel.UserModel = PermissionsModelService.CreateUserModel("membersMapItemInstancePopup", ((Controller)this).get_Url());
		return permissionRoleTypeSelectorModel;
	}
}
