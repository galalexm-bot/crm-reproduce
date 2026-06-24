using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class UserCardModel : UserModel
{
	public bool Reverse { get; set; }

	public bool Hovered { get; set; }

	public string ClassList { get; set; }

	public string OnClickCard { get; set; }

	public string OnClickNameUrl { get; set; }

	public string OnSelectPhoto { get; set; }

	public Func<HtmlHelper, MvcHtmlString> RenderActions { get; set; }

	public Func<HtmlHelper, MvcHtmlString> ContentZone { get; set; }

	public Func<HtmlHelper, MvcHtmlString> PersonZone { get; set; }

	public Func<HtmlHelper, MvcHtmlString> UserZone { get; set; }

	public Func<HtmlHelper, MvcHtmlString> CustomZone { get; set; }

	public IList<UserCardExtensionZone> ExtensionZones { get; set; }

	public bool HasUserInfo()
	{
		if (base.User == null)
		{
			return false;
		}
		if (base.User.MobilePhone.IsNullOrEmpty() && base.User.EMail.IsNullOrEmpty())
		{
			return !base.User.Skype.IsNullOrEmpty();
		}
		return true;
	}

	public UserCardModel()
	{
		ExtensionZones = new List<UserCardExtensionZone>();
	}

	public UserCardModel(UserModel model)
		: this()
	{
		base.User = model.User;
		base.IsAbsence = model.IsAbsence;
		base.DateEndAbsence = model.DateEndAbsence;
		base.IsReplacement = model.IsReplacement;
		base.ReplacementUser = model.ReplacementUser;
		base.IsCurrentProfile = model.IsCurrentProfile;
		base.HasUserManagmentPermission = model.HasUserManagmentPermission;
		base.TrustedDevicesManagementPermission = model.TrustedDevicesManagementPermission;
		base.CanEdit = model.CanEdit;
		base.IsDisallowLogon = model.IsDisallowLogon;
		base.ShowGroups = model.ShowGroups;
		base.ShowActions = model.ShowActions;
		base.Groups = model.Groups;
		base.UserGroups = model.UserGroups;
		base.ShowPermissions = model.ShowPermissions;
		base.Permissions = model.Permissions;
		base.Blocks = model.Blocks;
	}
}
