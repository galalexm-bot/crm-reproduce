using System;
using System.Web;
using System.Web.Security;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Code;

public static class TrustedDeviceTokenHelper
{
	public const string TrustedDeviceCookieName = "TrustedDeviceToken";

	public static string GetContextDeviceInfo(HttpContextBase httpContext)
	{
		return httpContext.Request.Browser.Browser + httpContext.Request.UserHostAddress;
	}

	public static HttpCookie GetContextDeviceTokenCookie(HttpContextBase httpContext, string login)
	{
		string name = string.Format("{0}_{1}", "TrustedDeviceToken", login);
		return httpContext.Request.Cookies[name];
	}

	public static string GetContextDeviceToken(HttpContextBase httpContext, string login)
	{
		return GetContextDeviceTokenCookie(httpContext, login)?.Value;
	}

	public static void CreateDeviceTokenCookie(HttpContextBase httpContext, string login, string token)
	{
		string name = string.Format("{0}_{1}", "TrustedDeviceToken", login);
		HttpCookie cookie = new HttpCookie(name, token)
		{
			HttpOnly = true,
			Expires = DateTime.Now.AddYears(10)
		};
		httpContext.Response.Cookies.Remove(name);
		httpContext.Response.Cookies.Add(cookie);
	}

	public static void RemoveDeviceTokenCookie(HttpContextBase httpContext, string login)
	{
		HttpCookie contextDeviceTokenCookie = GetContextDeviceTokenCookie(httpContext, login);
		if (contextDeviceTokenCookie != null)
		{
			contextDeviceTokenCookie.Expires = DateTime.Now.AddDays(-1.0);
			httpContext.Response.Cookies.Add(contextDeviceTokenCookie);
		}
	}

	public static TrustedDeviceTicketInfo GetTrustedDeviceTicketInfo(this HttpContextBase httpContext)
	{
		if (!(httpContext.User.Identity is FormsIdentity formsIdentity))
		{
			return null;
		}
		string[] array = formsIdentity.Ticket.UserData.Split(";".ToCharArray());
		if (array.Length >= 3)
		{
			string text = array[2];
			int num = text.IndexOf(':');
			if (num >= 0 && int.TryParse(text.Substring(0, num), out var result))
			{
				return new TrustedDeviceTicketInfo((TrustedDeviceType)result, text.Substring(num + 1));
			}
		}
		return null;
	}
}
