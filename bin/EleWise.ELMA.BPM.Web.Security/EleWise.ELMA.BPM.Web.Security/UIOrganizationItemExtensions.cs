using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Models;
using Telerik.Web.Mvc.UI.DropDown;

namespace EleWise.ELMA.BPM.Web.Security;

public static class UIOrganizationItemExtensions
{
	public static IEnumerable<SelectListItem> GetTree(this OrganizationItemDTO item)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		List<SelectListItem> list = new List<SelectListItem>(GetTree(new OrganizationItemDTO[1] { item }, ""));
		SelectListItem val = new SelectListItem();
		val.set_Value(string.Empty);
		val.set_Text(string.Empty);
		val.set_Selected(item == null);
		SelectListItem item2 = val;
		list.Insert(0, item2);
		return list;
	}

	private static IEnumerable<SelectListItem> GetTree(IEnumerable<OrganizationItemDTO> items, string level)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<OrganizationItemDTO> list = new List<OrganizationItemDTO>(items);
		list.Sort((OrganizationItemDTO g1, OrganizationItemDTO g2) => g1.Name.CompareTo(g2.Name));
		List<SelectListItem> list2 = new List<SelectListItem>();
		foreach (OrganizationItemDTO item in list)
		{
			string text = ((item.Name != null) ? item.Name.HtmlEncode() : "");
			DropDownSelectListItem val = new DropDownSelectListItem();
			((SelectListItem)val).set_Text(text);
			val.set_DropDownText(string.Format("{1}{0}", text.Replace(" ", "&nbsp;"), level));
			((SelectListItem)val).set_Value(item.Id.ToString());
			list2.Add((SelectListItem)val);
			list2.AddRange(GetTree(item.Items, $"{level}&nbsp;&nbsp;"));
		}
		return list2;
	}

	public static IEnumerable<SelectListItem> GetTree(this IOrganizationItem item)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		List<SelectListItem> list = new List<SelectListItem>(GetTree(new IOrganizationItem[1] { item }, ""));
		SelectListItem val = new SelectListItem();
		val.set_Value(string.Empty);
		val.set_Text(string.Empty);
		val.set_Selected(item == null);
		SelectListItem item2 = val;
		list.Insert(0, item2);
		return list;
	}

	private static IEnumerable<SelectListItem> GetTree(IEnumerable<IOrganizationItem> items, string level)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		List<IOrganizationItem> list = new List<IOrganizationItem>(items);
		list.Sort((IOrganizationItem g1, IOrganizationItem g2) => g1.Name.CompareTo(g2.Name));
		List<SelectListItem> list2 = new List<SelectListItem>();
		foreach (IOrganizationItem item in list)
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
			DropDownSelectListItem val = new DropDownSelectListItem();
			((SelectListItem)val).set_Text(item.Name ?? "");
			val.set_DropDownText(string.Format("{1}{0}", HttpUtility.HtmlEncode(item.Name + text).Replace(" ", "&nbsp;"), level));
			((SelectListItem)val).set_Value(item.Id.ToString());
			list2.Add((SelectListItem)val);
			if (((ICollection<IOrganizationItem>)item.SubItems).Count > 0)
			{
				list2.AddRange(GetTree((IEnumerable<IOrganizationItem>)item.SubItems, $"{level}&nbsp;&nbsp;"));
			}
		}
		return list2;
	}
}
