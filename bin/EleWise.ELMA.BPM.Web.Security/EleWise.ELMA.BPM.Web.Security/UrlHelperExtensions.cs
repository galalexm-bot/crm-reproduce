using System.Web.Mvc;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Help;

namespace EleWise.ELMA.BPM.Web.Security.Extensions;

public static class UrlHelperExtensions
{
	public static string GetHelpLink(this UrlHelper urlHelper, string pageId)
	{
		return Locator.GetServiceNotNull<WebHelpService>().GetPageUrl(urlHelper.get_RequestContext().HttpContext, pageId);
	}

	public static string GetGroupMemberIcon(this UrlHelper urlHelper, AssignedRoleTypeModel role)
	{
		if (role == null)
		{
			return null;
		}
		return urlHelper.GetMemberIcon(role.Value);
	}

	public static string GetMemberIcon(this UrlHelper urlHelper, IEntity entity)
	{
		IUser user = entity as IUser;
		bool num = entity is IUserGroup;
		bool flag = entity is IOrganizationItem;
		if (!num)
		{
			if (!flag)
			{
				if (user == null || user.Status != UserStatus.Blocked)
				{
					return "#user.svg";
				}
				return urlHelper.ObjectIcon(ObjectIconFormat.x16, user.Status);
			}
			return "#company.svg";
		}
		return "#users.svg";
	}
}
