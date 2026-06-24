using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Extensions;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Portlets;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class OrgStructureController : BPMController<IOrganizationItem, long>
{
	protected OrganizationItemManager OrganizationManager => Locator.GetServiceNotNull<OrganizationItemManager>();

	private TreeModel BuildTreeModel(List<TreeMenuNode> nodes, string id = "OrganizationTree", string style = "height:100%;")
	{
		return new TreeModel
		{
			Id = id,
			Children = nodes,
			ShowCheckBox = false,
			HtmlAttributes = new { style },
			SaveState = false,
			HighlightPath = false,
			ShowExpandCollapseButtons = true,
			MultiSelect = false
		};
	}

	public ActionResult Tree(OrgStructurePersonalization settings)
	{
		IOrderedEnumerable<IOrganizationItem> orderedEnumerable = from i in OrganizationManager.LoadFullList()
			orderby i.Name
			select i;
		IOrganizationItem organizationItem = orderedEnumerable.FirstOrDefault((IOrganizationItem i) => i.ParentItem == null);
		if (organizationItem == null)
		{
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"emptyOrgStructure\">{0}</div>", SR.T("Оргструктура не опубликована, либо не имеет элементов")));
		}
		long[] selected = new long[0];
		bool allowAll = false;
		bool showUsers = settings.ShowUsers;
		List<TreeMenuNode> nodes = BuildFullTreeNodesWithUsers(orderedEnumerable, organizationItem, selected, allowAll, showUsers);
		((ControllerBase)this).get_ViewData().set_Item("showUsers", (object)showUsers);
		((ControllerBase)this).get_ViewData().set_Item("onSearchTextChangeUrl", (object)((Controller)this).get_Url().Action("OrganizationTreeUpdate", "OrgStructure"));
		return (ActionResult)(object)((Controller)this).PartialView("Organization/OrganizationTree", (object)BuildTreeModel(nodes));
	}

	public ActionResult OrganizationTreeUpdate(string treeId, string text, bool? showUsers)
	{
		IOrderedEnumerable<IOrganizationItem> orderedEnumerable = from i in OrganizationManager.LoadFullList()
			orderby i.Name
			select i;
		IOrganizationItem organizationItem = orderedEnumerable.FirstOrDefault((IOrganizationItem i) => i.ParentItem == null);
		if (organizationItem == null)
		{
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"emptyOrgStructure\">{0}</div>", SR.T("Нет элементов, удовлетворяющих строке поиска")));
		}
		long[] selected = new long[0];
		bool allowAll = false;
		Func<TreeMenuNode, string, bool> additionalCheck = delegate(TreeMenuNode node, string name)
		{
			string textAdditional = node.textAdditional;
			if (!textAdditional.IsNullOrEmpty())
			{
				int num = textAdditional.IndexOf('>');
				if (num > -1)
				{
					int num2 = textAdditional.IndexOf('<', num);
					if (num2 > -1)
					{
						return textAdditional.Substring(num, num2 - num).ToLower().Contains(name);
					}
				}
			}
			return false;
		};
		List<TreeMenuNode> tree = BuildFullTreeNodesWithUsers(orderedEnumerable, organizationItem, selected, allowAll, showUsers ?? false);
		return (ActionResult)(object)((Controller)this).PartialView("Tree", (object)BuildTreeModel(tree.FilterTreeNodes(text, additionalCheck), treeId));
	}

	private List<TreeMenuNode> BuildFullTreeNodesWithUsers(IEnumerable<IOrganizationItem> items, IOrganizationItem rootNode, long[] selected, bool allowAll = false, bool showUsers = false)
	{
		Dictionary<IOrganizationItem, TreeMenuNode> dictionary = items.ToDictionary((IOrganizationItem i) => i, (IOrganizationItem i) => GetNode(i, selected, allowAll, showUsers));
		foreach (KeyValuePair<IOrganizationItem, TreeMenuNode> item in dictionary)
		{
			if (item.Key != rootNode && dictionary.TryGetValue(item.Key.ParentItem, out var value))
			{
				value.children.Add(item.Value);
			}
		}
		dictionary.ForEach(delegate(KeyValuePair<IOrganizationItem, TreeMenuNode> n)
		{
			n.Value.expanded = n.Key.ParentItem == null || n.Value.HasChecked();
		});
		return new List<TreeMenuNode> { dictionary[rootNode] };
	}

	private TreeMenuNode GetNode(IOrganizationItem item, long[] selected, bool allowAll, bool showUsers)
	{
		TreeMenuNode treeMenuNode = new TreeMenuNode();
		treeMenuNode.id = item.Id.ToString();
		treeMenuNode.text = item.Name;
		if (item.ItemType == OrganizationItemType.Position)
		{
			EleWise.ELMA.Security.Models.IUser user = item.User;
			if (user != null && user.Status != UserStatus.Blocked && user.Status != UserStatus.System)
			{
				treeMenuNode.textAdditional = $"&nbsp;(<a href=\"javascript:showUserInfo('{item.User.Id}');\">{item.User.FullName.HtmlEncode()}</a>)";
			}
		}
		else if (item.Users != null)
		{
			int num = ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)item.Users).Count((EleWise.ELMA.Security.Models.IUser u) => u.Status != UserStatus.Blocked && u.Status != UserStatus.System);
			if (num > 0)
			{
				treeMenuNode.textAdditional = string.Format("&nbsp;(<a href=\"javascript:showOrgItemInfo('{2}');\">{1}: {0}</a>)", num, SR.Users, item.Id);
			}
		}
		treeMenuNode.Checked = selected.Contains(item.Id);
		treeMenuNode.checkable = allowAll || (item.ItemType != 0 && OrganizationItemType.NestedStructure != item.ItemType);
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
		if (showUsers && item.ItemType == OrganizationItemType.EmployeeGroup)
		{
			IEnumerable<EleWise.ELMA.Security.Models.IUser> usersByDepartament = UserManager.Instance.GetUsersByDepartament(item);
			if (usersByDepartament != null)
			{
				foreach (EleWise.ELMA.Security.Models.IUser item2 in usersByDepartament)
				{
					treeMenuNode.children.Add(new TreeMenuNode
					{
						textAdditional = $"&nbsp;<a href=\"javascript:showUserInfo('{item2.Id}');\">{item2.FullName}</a>",
						icon = "#user.svg"
					});
				}
				return treeMenuNode;
			}
		}
		return treeMenuNode;
	}

	[HttpGet]
	public ActionResult Info(long id)
	{
		IOrganizationItem organizationItem = OrganizationManager.LoadOrNull(id);
		if (organizationItem == null)
		{
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div style=\"padding: 5px; width: 330px;\">{0}</div>", SR.T("Элемент оргструктуры не найден")));
		}
		OrgItemModel orgItemModel = new OrgItemModel
		{
			OrgItem = organizationItem
		};
		return (ActionResult)(object)((Controller)this).PartialView("OrgStructure/Info", (object)orgItemModel);
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IUserFilter filter, long id)
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IUserFilter>();
			filter.OrganizationItemFindMode = OrganizationItemFindMode.ByItem;
			filter.OrganizationItem = OrganizationManager.LoadOrNull(id);
		}
		GridData<EleWise.ELMA.Security.Models.IUser, IUserFilter> gridData = UserManager.Instance.CreateGridData(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView("OrgStructure/Grid", (object)gridData);
	}

	public ActionResult Parents(long id)
	{
		IOrganizationItem organizationItem = OrganizationManager.LoadOrNull(id);
		if (organizationItem == null)
		{
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div style=\"padding: 5px; width: 330px;\">{0}</div>", SR.T("Элемент оргструктуры не найден")));
		}
		OrgItemModel orgItemModel = new OrgItemModel
		{
			OrgItem = organizationItem,
			ParentsTree = OrgParents(organizationItem).Reverse().ToList(),
			HasUserViewPermission = base.SecurityService.HasPermission(PermissionProvider.UserViewPermission)
		};
		return (ActionResult)(object)((Controller)this).PartialView("OrgStructure/Parents", (object)orgItemModel);
	}

	public IList<string> OrgParents(IOrganizationItem item)
	{
		List<string> list = new List<string>();
		list.Add(item.Name);
		if (item.ParentItem != null)
		{
			list.AddRange(OrgParents(item.ParentItem));
		}
		return list;
	}
}
