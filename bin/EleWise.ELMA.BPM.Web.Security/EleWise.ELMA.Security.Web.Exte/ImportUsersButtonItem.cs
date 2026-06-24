using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Security.Web.Extensions;

public sealed class ImportUsersButtonItem : ActionToolbarItem
{
	public const string IMPORTUSERSBUTTON_GUID = "UserList_ImportUsersButton";

	public ImportUsersButtonItem(HtmlHelper htmlHelper)
		: base("UserList_ImportUsersButton")
	{
		Uid = "toolbar-click-ImportUser";
		Text = SR.T("Импорт");
		ToolTip = SR.T("Импортировать пользователей из различных провайдеров авторизации");
		foreach (KeyValuePair<Guid, string> item in Locator.GetServiceNotNull<IExternalMembershipManager>().GetAllName())
		{
			Items.Add(new ActionToolbarItem($"btnImportUsers{item.Key}")
			{
				Text = SR.T("Пользователи из {0}", item.Value),
				Url = htmlHelper.Url().Action("Import", "ImportUser", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Security",
					authProviderGuid = item.Key
				})
			});
		}
		Visible = htmlHelper.HasPermission(PermissionProvider.UserManagmentPermission) && Items.Any();
	}
}
