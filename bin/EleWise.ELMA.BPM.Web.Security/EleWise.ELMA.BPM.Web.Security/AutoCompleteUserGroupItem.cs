using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class AutoCompleteUserGroupItem : AutoCompleteEntityItem
{
	public const string LastItemValue = "986EFA40-0955-42E2-A21B-5B7969033AC9";

	public override string ObjectValuePrefix => BaseEntityUserTypeSelector.GetFullPrefix("UserGroup");

	[JsonIgnore]
	public override string SelectedItemTemplateJs => HttpUtility.HtmlEncode("<div class=\"userphoto-item-display {item.ListItemClass}\"><div class=\"userphoto-item-image user-photo-container\">" + HtmlExtensions.Image("{item.IconUrl}", new
	{
		align = "absmiddle"
	}) + "</div><div class=\"userphoto-item-content\">{item.Text}</div></div>");

	public string Name { get; set; }

	public static AutoCompleteUserGroupItem[] GetItems(UrlHelper helper, IEnumerable<IUserGroup> users, bool valueWithType = false)
	{
		return (from u in users
			where u != null
			select GetItem(helper, u, valueWithType) into i
			where !string.IsNullOrEmpty(i.Text)
			select i).ToArray();
	}

	public static AutoCompleteUserGroupItem GetItem(UrlHelper helper, IUserGroup group, bool valueWithType = false)
	{
		if (group == null)
		{
			return null;
		}
		string userGroupIcon = "#users.svg";
		Func<string, string> func = (string @class) => string.Format("<div class=\"{0}\"><div class=\"userphoto-item-image user-photo-container\">{2}</div><div class=\"userphoto-item-content\">{1}</div></div>", @class, HttpUtility.HtmlEncode(group.Name), HtmlExtensions.Image(helper.Image(userGroupIcon), new
		{
			align = "absmiddle"
		}));
		return new AutoCompleteUserGroupItem
		{
			Value = (valueWithType ? BaseEntityUserTypeSelector.GetFullPrefix("UserGroup") : null) + group.Id,
			Text = HttpUtility.HtmlEncode(group.Name),
			DropDownText = func("userphoto-item"),
			ViewText = func("userphoto-item-display"),
			Name = group.Name,
			IconUrl = helper.Image(userGroupIcon)
		};
	}

	public static AutoCompleteUserGroupItem GetLastItem(string popupId, string url, string text)
	{
		url += string.Format("&ObjectPrefix={0}&SearchString={1}", "UserGroup", text);
		return new AutoCompleteUserGroupItem
		{
			Value = "986EFA40-0955-42E2-A21B-5B7969033AC9",
			Text = "...",
			DropDownText = string.Format("<div class=\"userphoto-item-button\"><div class=\"userphoto-item-image\"></div><div class=\"userphoto-item-content-button\"><div class=\"comment\" onclick=\"openEntitySelectPopup('{0}','{1}')\">{2}</div></div></div>", popupId, url, SR.T("Показать все...")),
			ViewText = "",
			VirtualItem = true
		};
	}
}
