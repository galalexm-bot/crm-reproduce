using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Extensions;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Portlets;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class PermissionController : BPMController
{
	public IPermissionTypeRoleService PermissionTypeRoleService { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	protected OrganizationItemManager OrganizationManager => Locator.GetServiceNotNull<OrganizationItemManager>();

	public ActionResult PermissionPopup(string popupId, PermissionObjectType[] objectTypes, PermissionObjectType selectObjectType, long objectId, string submitScript, string action, string controller, string area, string callback)
	{
		PermissionPopupModel permissionPopupModel = new PermissionPopupModel
		{
			PopupId = popupId,
			Action = action,
			Controller = controller,
			Area = area,
			ObjectId = objectId,
			Callback = callback,
			SubmitScript = submitScript,
			ObjectTypes = objectTypes,
			SelectObjectType = selectObjectType
		};
		if (objectTypes.Contains(PermissionObjectType.Organization))
		{
			permissionPopupModel.OrganizationTreeModel = PermissionsModelService.CreateOrganizationTreeModel(popupId);
		}
		if (objectTypes.Contains(PermissionObjectType.Group))
		{
			permissionPopupModel.GroupsTreeModel = PermissionsModelService.CreateGroupsModel(popupId);
		}
		if (objectTypes.Contains(PermissionObjectType.User))
		{
			AutocompleteComboBox autocompleteComboBox2 = (permissionPopupModel.UserModel = PermissionsModelService.CreateUserModel(popupId, ((Controller)this).get_Url()));
		}
		return (ActionResult)(object)((Controller)this).PartialView("Permission/Popup", (object)permissionPopupModel);
	}

	public ActionResult PermissionTypeRoleSelectorPopup(string popupId, Guid[] typeRoles, Guid typeRole, string objectId, string submitScript, string action, string controller, string area, string callback)
	{
		PermissionRoleType[] array = typeRoles.Select((Guid id) => PermissionTypeRoleService.Get(id)).ToArray();
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = new PermissionRoleTypeSelectorModel
		{
			PopupId = popupId,
			Action = action,
			Controller = controller,
			Area = area,
			ObjectId = objectId,
			Callback = callback,
			SubmitScript = submitScript,
			TypeRoles = array,
			SelectedTypeRole = array.FirstOrDefault()
		};
		return (ActionResult)(object)((Controller)this).PartialView("Permission/PermissionTypeRoleSelectorPopup", (object)permissionRoleTypeSelectorModel);
	}

	private PermissionPopupModel CreatePopupModelFor(long userId, bool showUsers, string callback, string action = "SaveUserOrganization", TreeModel defaultTreeModel = null)
	{
		long[] selected = OrganizationManager.GetItemsByUser(userId).ToArray();
		List<TreeMenuNode> nodeList = BuildOrganizationTree(showUsers, selected);
		return new PermissionPopupModel
		{
			PopupId = "PermissionUserPopup" + userId,
			Action = action,
			Callback = callback,
			ObjectId = userId,
			Controller = "User",
			Area = "EleWise.ELMA.BPM.Web.Security",
			OrganizationTreeModel = ((OrganizationManager.LoadOrgStructRoot() == null) ? defaultTreeModel : BuildTreeModel("UserOrganizationTree" + userId, nodeList, multiselect: true, showCheckBox: true))
		};
	}

	public ActionResult SelectFullUserOrganization(int userId)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Organization/OrganizationPopup", (object)CreatePopupModelFor(userId, showUsers: true, "elma.openPleaseWait(true);\r\n                          refreshGrid('UserListGrit', function closeWin(e) { \r\n                            elma.closePleaseWait(); \r\n                        });"));
	}

	public ActionResult SelectUserOrganization(int userId)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Organization/OrganizationPopup", (object)CreatePopupModelFor(userId, showUsers: false, "refreshGrid('UserListGrit')"));
	}

	public ActionResult SelectUserOrganizationProfile(int userId)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Organization/OrganizationPopup", (object)CreatePopupModelFor(userId, showUsers: true, "refreshUserOrganizationProfile(data);", "SetUserOrganization"));
	}

	private List<TreeMenuNode> BuildOrganizationTree(bool showUsers, long[] selected)
	{
		selected = selected ?? new long[0];
		((ControllerBase)this).get_ViewData().set_Item("checked", (object)selected);
		((ControllerBase)this).get_ViewData().set_Item("showUsers", (object)showUsers);
		((ControllerBase)this).get_ViewData().set_Item("onSearchTextChangeUrl", (object)((Controller)this).get_Url().Action("PopupOrganizationUpdate", "Permission"));
		if (!showUsers)
		{
			return PermissionsModelService.BuildFullTreeFromRootDTO(selected);
		}
		return PermissionsModelService.BuildFullTreeFromRoot(selected);
	}

	private TreeModel BuildTreeModel(string id, List<TreeMenuNode> nodeList, bool multiselect, bool showCheckBox)
	{
		return new TreeModel
		{
			Id = id,
			Children = nodeList,
			MultiSelect = multiselect,
			ShowCheckBox = showCheckBox,
			HtmlAttributes = new
			{
				style = "height:360px;"
			},
			SaveState = false,
			HighlightPath = false,
			ShowExpandCollapseButtons = true,
			KeepChildNodes = true
		};
	}

	public ActionResult PopupOrganization(string inputId, [JsonBinder] ISet<SelectListItem> selected, bool multiselect, bool showUsers, string selectedElementId = null)
	{
		List<TreeMenuNode> nodeList = BuildOrganizationTree(showUsers, selected.Select((SelectListItem i) => long.Parse(i.get_Value())).ToArray());
		OrganizationItemPopupSelectorModel organizationItemPopupSelectorModel = new OrganizationItemPopupSelectorModel
		{
			InputId = inputId,
			OrganizationTree = BuildTreeModel(inputId + "OrganizationTree", nodeList, multiselect, multiselect),
			MultiSelect = multiselect
		};
		if (!selectedElementId.IsNullOrEmpty())
		{
			((ControllerBase)this).get_ViewData().set_Item("selectedElementId", (object)selectedElementId);
		}
		return (ActionResult)(object)((Controller)this).PartialView("Organization/PopupOrganization", (object)organizationItemPopupSelectorModel);
	}

	public ActionResult PopoverOrganization(string inputId, [JsonBinder] ISet<SelectListItem> selected, bool multiselect, bool showUsers, string selectedElementId = null, string popoverId = null)
	{
		List<TreeMenuNode> nodeList = BuildOrganizationTree(showUsers, selected.Select((SelectListItem i) => long.Parse(i.get_Value())).ToArray());
		OrganizationItemPopupSelectorModel organizationItemPopupSelectorModel = new OrganizationItemPopupSelectorModel
		{
			InputId = inputId,
			OrganizationTree = BuildTreeModel(inputId + "OrganizationTree", nodeList, multiselect, multiselect),
			MultiSelect = multiselect
		};
		if (!selectedElementId.IsNullOrEmpty())
		{
			((ControllerBase)this).get_ViewData().set_Item("selectedElementId", (object)selectedElementId);
		}
		if (!popoverId.IsNullOrEmpty())
		{
			organizationItemPopupSelectorModel.OrganizationTree.OnSelectFunction = $"function(e) {{ elma.tree.onSelect(e); elma.userPopup.ClosePopover(); closePopoverWindow('{popoverId}')}}";
			((ControllerBase)this).get_ViewData().set_Item("popoverId", (object)popoverId);
		}
		((ControllerBase)this).get_ViewData().set_Item("onSearchTextChangeUrl", (object)((Controller)this).get_Url().Action("PopoverOrganizationUpdate", "Permission"));
		return (ActionResult)(object)((Controller)this).PartialView("Organization/OrganizationPopover", (object)organizationItemPopupSelectorModel);
	}

	public string GetOrgItemName(string id)
	{
		if (!string.IsNullOrWhiteSpace(id))
		{
			long result = 0L;
			long.TryParse(id, out result);
			if (result != 0L)
			{
				IOrganizationItem organizationItem = OrganizationManager.Load(result);
				if (organizationItem != null)
				{
					return organizationItem.Name;
				}
			}
		}
		return "";
	}

	[HttpPost]
	public ActionResult PopupOrganizationUpdate(string treeId, string text, long[] selected, bool? multiselect, bool? showUsers, bool? showCheckBox, bool? keepChildNodes)
	{
		bool valueOrDefault = showUsers.GetValueOrDefault();
		bool valueOrDefault2 = multiselect.GetValueOrDefault();
		bool valueOrDefault3 = showCheckBox.GetValueOrDefault();
		bool valueOrDefault4 = keepChildNodes.GetValueOrDefault();
		List<TreeMenuNode> tree = BuildOrganizationTree(valueOrDefault, selected);
		TreeModel treeModel = BuildTreeModel(treeId, tree.FilterTreeNodes(text, null, valueOrDefault4), valueOrDefault2, valueOrDefault3);
		return (ActionResult)(object)((Controller)this).PartialView("Tree", (object)treeModel);
	}

	[HttpPost]
	public ActionResult PopoverOrganizationUpdate(string treeId, string text, long[] selected, bool? multiselect, bool? showUsers, bool? showCheckBox, string popoverId = null)
	{
		bool valueOrDefault = showUsers.GetValueOrDefault();
		bool valueOrDefault2 = multiselect.GetValueOrDefault();
		bool valueOrDefault3 = showCheckBox.GetValueOrDefault();
		List<TreeMenuNode> tree = BuildOrganizationTree(valueOrDefault, selected);
		TreeModel treeModel = BuildTreeModel(treeId, tree.FilterTreeNodes(text), valueOrDefault2, valueOrDefault3);
		if (!popoverId.IsNullOrEmpty())
		{
			treeModel.OnSelectFunction = $"function(e) {{ elma.tree.onSelect(e); elma.userPopup.ClosePopover(); closePopoverWindow('{popoverId}')}}";
		}
		((ControllerBase)this).get_ViewData().set_Item("onSearchTextChangeUrl", (object)((Controller)this).get_Url().Action("PopoverOrganizationUpdate", "Permission"));
		return (ActionResult)(object)((Controller)this).PartialView("Tree", (object)treeModel);
	}

	public PartialViewResult PermissionsHomePortlet(PermissionsHomePortletPersonalization settings)
	{
		return ((Controller)this).PartialView("Permission/PermissionsHomePortlet", (object)settings);
	}
}
