using System.Web.Mvc;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class UserSecurityActionsModel
{
	public IUser User { get; set; }

	public bool IsCurrentUser { get; set; }

	public UserSecurityActionsModel(HtmlHelper html, IUser user)
	{
		IAuthenticationService serviceNotNull = Locator.GetServiceNotNull<IAuthenticationService>();
		User = user;
		IsCurrentUser = serviceNotNull.GetCurrentUser() == user;
	}
}
