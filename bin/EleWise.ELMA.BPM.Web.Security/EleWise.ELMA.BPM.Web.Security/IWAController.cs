using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EleWise.ELMA.Web.Mvc.Services;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class IWAController : Controller
{
	public ActionResult LogOn(string returnUrl)
	{
		try
		{
			string value = SspiTicketService.CreateSspiTicket(new TicketRequest
			{
				IdentityName = ((Controller)this).get_Request().LogonUserIdentity.Name,
				UserAgent = ((((Controller)this).get_HttpContext() != null) ? ((Controller)this).get_HttpContext().Request.UserAgent.Replace(';', ',') : null),
				RemoteAddress = ((((Controller)this).get_HttpContext() != null) ? ((Controller)this).get_HttpContext().Request.UserHostAddress : null),
				CreateTime = DateTime.UtcNow.ToLocalTime()
			});
			string cookieName = WindowsAuthenticationSettings.GetCookieName();
			HttpCookie cookie = new HttpCookie(cookieName, value)
			{
				HttpOnly = true,
				Expires = DateTime.Now.AddSeconds(WindowsAuthenticationSettings.GetTicketLifetime()),
				Secure = FormsAuthentication.RequireSSL,
				Path = FormsAuthentication.FormsCookiePath
			};
			if (((Controller)this).get_HttpContext() != null)
			{
				((Controller)this).get_HttpContext().Response.Cookies.Remove(cookieName);
				((Controller)this).get_HttpContext().Response.Cookies.Add(cookie);
			}
		}
		catch (Exception)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("/Security/Account/Logon");
			if (!string.IsNullOrEmpty(returnUrl))
			{
				stringBuilder.Append("?ReturnUrl=");
				stringBuilder.Append(HttpUtility.UrlEncode(returnUrl));
			}
			return (ActionResult)(object)((Controller)this).Redirect(stringBuilder.ToString());
		}
		return (ActionResult)(object)((Controller)this).Redirect(returnUrl ?? "/");
	}
}
