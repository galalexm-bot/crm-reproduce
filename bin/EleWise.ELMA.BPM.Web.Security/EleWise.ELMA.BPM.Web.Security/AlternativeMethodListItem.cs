using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using Telerik.Web.Mvc.UI.DropDown;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class AlternativeMethodListItem : DropDownSelectListItem
{
	public static DropDownSelectListItem Item(string text, string value, string img)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		text = $"{HtmlExtensions.Image(img, (object)null)}<span>{text}</span>";
		DropDownSeparatorItem val = new DropDownSeparatorItem();
		((DropDownSelectListItem)val).set_DropDownText(text);
		((SelectListItem)val).set_Value(value);
		((SelectListItem)val).set_Text(text);
		((DropDownSelectListItem)val).set_VirtualItem(false);
		((DropDownSelectListItem)val).set_ListItemClass("alt-method-list-item");
		return (DropDownSelectListItem)val;
	}
}
