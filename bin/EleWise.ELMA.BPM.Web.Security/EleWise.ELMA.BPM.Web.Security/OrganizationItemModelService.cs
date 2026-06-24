using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using Telerik.Web.Mvc.UI.DropDown;

namespace EleWise.ELMA.BPM.Web.Security.Services;

[Service(Scope = ServiceScope.Shell)]
public class OrganizationItemModelService
{
	private class OrgDropdownItem : DropDownSelectListItem
	{
		public long ParentKey { get; set; }

		public List<OrgDropdownItem> Items { get; set; }

		public OrgDropdownItem()
		{
			Items = new List<OrgDropdownItem>();
		}
	}

	private OrganizationItemManager Manager { get; set; }

	public OrganizationItemModelService(OrganizationItemManager manager)
	{
		Manager = manager;
	}

	public IEnumerable<SelectListItem> GetFullTree()
	{
		IEnumerable<IOrganizationItem> source = Manager.LoadFullList();
		IOrganizationItem[] array = source.Where((IOrganizationItem i) => i.ParentItem == null).Take(2).ToArray();
		if (array.Length != 1)
		{
			return new List<SelectListItem>();
		}
		long id = array.First().Id;
		Dictionary<long, OrgDropdownItem> dictionary = source.ToDictionary((IOrganizationItem i) => i.Id, (IOrganizationItem i) => GetNode(i));
		foreach (KeyValuePair<long, OrgDropdownItem> item2 in dictionary)
		{
			if (item2.Key != id && dictionary.TryGetValue(item2.Value.ParentKey, out var value))
			{
				value.Items.Add(item2.Value);
			}
		}
		List<OrgDropdownItem> list = new List<OrgDropdownItem>();
		ShiftText(list, dictionary[id], "");
		OrgDropdownItem orgDropdownItem = new OrgDropdownItem();
		((SelectListItem)orgDropdownItem).set_Value(string.Empty);
		((SelectListItem)orgDropdownItem).set_Text(string.Empty);
		((SelectListItem)orgDropdownItem).set_Selected(false);
		OrgDropdownItem item = orgDropdownItem;
		list.Insert(0, item);
		return (IEnumerable<SelectListItem>)list;
	}

	private OrgDropdownItem GetNode(IOrganizationItem item)
	{
		string text = "";
		if (item.ItemType == OrganizationItemType.Position)
		{
			if (item.User != null)
			{
				text = $" ({item.User.FullName})";
			}
		}
		else if (item.Users != null && ((ICollection<IUser>)item.Users).Count > 0)
		{
			text = string.Format(" ({1}: {0})", ((ICollection<IUser>)item.Users).Count, SR.Users);
		}
		OrgDropdownItem orgDropdownItem = new OrgDropdownItem();
		((SelectListItem)orgDropdownItem).set_Text(item.Name.HtmlEncode() ?? "");
		((DropDownSelectListItem)orgDropdownItem).set_DropDownText(HttpUtility.HtmlEncode(item.Name + text).Replace(" ", "&nbsp;"));
		((SelectListItem)orgDropdownItem).set_Value(item.Id.ToString());
		orgDropdownItem.ParentKey = ((item.ParentItem != null) ? item.ParentItem.Id : 0);
		return orgDropdownItem;
	}

	private void ShiftText(List<OrgDropdownItem> list, OrgDropdownItem root, string level)
	{
		root.Items.Sort((OrgDropdownItem g1, OrgDropdownItem g2) => ((SelectListItem)g1).get_Text().CompareTo(((SelectListItem)g2).get_Text()));
		((DropDownSelectListItem)root).set_DropDownText(string.Format("{1}{0}", ((DropDownSelectListItem)root).get_DropDownText(), level));
		list.Add(root);
		string level2 = string.Format("{0}{1}", level, "&nbsp;&nbsp;");
		foreach (OrgDropdownItem item in root.Items)
		{
			ShiftText(list, item, level2);
		}
	}
}
