using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Security;

public static class UIUserExtensions
{
	public static IUser GetCurrentUser(this HtmlHelper html)
	{
		return AuthenticationService.GetCurrentUser<IUser>();
	}

	public static IUser GetUserFromModel(this HtmlHelper html)
	{
		if (html.get_ViewData().get_Model() is ISecurityUserModel securityUserModel)
		{
			return securityUserModel.User;
		}
		return null;
	}
}
