using System;
using System.Collections.Generic;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class GlobalPermissionsModel
{
	public IEnumerable<Tuple<Permission, IEnumerable<IUserGroup>>> Groups { get; set; }

	public string RedirectAction { get; set; }

	public string RedirectController { get; set; }

	public string RedirectArea { get; set; }

	public bool ShowHeader { get; set; }

	public string SearchString { get; set; }

	public string Title { get; set; }

	public string Callback { get; set; }

	public GlobalPermissionsModel(IEnumerable<Tuple<Permission, IEnumerable<IUserGroup>>> groups, string redirectAction = "GlobalPermissions", string redirectController = "PermissionManagment", string redirectArea = "EleWise.ELMA.BPM.Web.Security", bool showHeader = true)
	{
		Groups = groups;
		RedirectAction = redirectAction;
		RedirectController = redirectController;
		RedirectArea = redirectArea;
		ShowHeader = showHeader;
	}
}
