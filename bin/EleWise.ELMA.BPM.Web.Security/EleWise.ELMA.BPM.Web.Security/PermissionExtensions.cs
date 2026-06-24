using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Security;

public static class PermissionExtensions
{
	public static MvcHtmlString DisplayPermissionItem(this HtmlHelper html, PermissionModel item, string jsonInput, bool deleted)
	{
		string text = "pi" + item.Id + "_" + item.ObjectType.GetHashCode();
		MvcHtmlString arg = (deleted ? html.Image("#delete.svg", SR.T("Удалить участника"), "", new
		{
			@class = "permission-delete-img",
			onclick = $"elma.RemovePermissionItem('{text}', '{jsonInput}', {item.Id}, {item.ObjectType.GetHashCode()})"
		}) : MvcHtmlString.Empty);
		return MvcHtmlString.Create($"<div class=\"permission-item-div\" id=\"{text}\">{arg} {item.Text}</div>");
	}

	public static MvcHtmlString SelectOrgstructurePopup(this HtmlHelper html, EleWise.ELMA.Security.Models.IUser model)
	{
		return PartialExtensions.Partial(html, "User/PermissionUserSelector", (object)model);
	}

	public static MvcHtmlString SelectOrgstructureProfilePopup(this HtmlHelper html, EleWise.ELMA.Security.Models.IUser model)
	{
		EditUserModel editUserModel = new EditUserModel(model);
		return PartialExtensions.Partial(html, "User/PermissionUserProfileSelector", (object)editUserModel);
	}

	[Obsolete("следует использовать PermissionRoleSelector")]
	public static MvcHtmlString PermissionPopupSelector(this HtmlHelper html, string popupId, string title, PermissionObjectType[] objectTypes, PermissionObjectType selectObjectType, long objectId, string submitScript, bool createPopup = true)
	{
		PermissionPopupModel permissionPopupModel = new PermissionPopupModel
		{
			PopupId = popupId,
			Title = title,
			ObjectTypes = objectTypes,
			SelectObjectType = selectObjectType,
			ObjectId = objectId,
			SubmitScript = submitScript,
			CreatePopup = createPopup
		};
		return PartialExtensions.Partial(html, "Permission/PopupSelector", (object)permissionPopupModel);
	}

	public static MvcHtmlString PermissionRoleSelector(this HtmlHelper html, string popupId, string title, PermissionRoleType[] roleTypes, object objectId, string submitScript, bool createPopup = true)
	{
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = new PermissionRoleTypeSelectorModel
		{
			PopupId = UIExtensions.PrepareId(popupId),
			Title = title,
			TypeRoles = roleTypes,
			SelectedTypeRole = roleTypes.FirstOrDefault(),
			ObjectId = objectId.ToString(),
			SubmitScript = submitScript,
			CreatePopup = createPopup
		};
		return PartialExtensions.Partial(html, "Permission/PermissionTypeRoleSelector", (object)permissionRoleTypeSelectorModel);
	}

	public static MvcHtmlString PermissionRoleSelector(this HtmlHelper html, PermissionRoleTypeSelectorModel model)
	{
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("");
		return PartialExtensions.Partial(html, "Permission/PermissionTypeRoleSelector", (object)model);
	}

	public static MvcHtmlString PropertyPermissionRoleSelector(this HtmlHelper html, PermissionRoleTypeSelectorModel model)
	{
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("");
		return PartialExtensions.Partial(html, "Permission/PropertyPermissionTypeRoleSelector", (object)model);
	}

	public static bool HasPermission(this HtmlHelper htmlHelper, Permission permission)
	{
		return Locator.GetServiceNotNull<ISecurityService>().HasPermission(permission);
	}

	public static bool HasPermission(this HtmlHelper htmlHelper, Permission permission, object target)
	{
		return Locator.GetServiceNotNull<ISecurityService>().HasPermission(permission, target);
	}
}
