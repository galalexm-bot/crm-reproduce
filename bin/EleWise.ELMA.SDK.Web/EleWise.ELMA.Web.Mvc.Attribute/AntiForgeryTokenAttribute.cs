using System;
using System.Security.Principal;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class AntiForgeryTokenAttribute : FilterAttribute, IAuthorizationFilter
{
	public const string AntiForgeryTokenName = "__RequestVerificationToken";

	internal Action ValidateAction { get; private set; }

	internal bool Disabled { get; private set; }

	public AntiForgeryTokenAttribute(bool disabled)
		: this()
	{
		Disabled = disabled;
	}

	public AntiForgeryTokenAttribute()
		: this((Action)AntiForgery.Validate)
	{
	}

	internal AntiForgeryTokenAttribute(Action validateAction)
	{
		ValidateAction = validateAction;
	}

	public void OnAuthorization(AuthorizationContext filterContext)
	{
		if (filterContext == null)
		{
			throw new ArgumentNullException("filterContext");
		}
		if (!Disabled && ((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod.Equals("post", StringComparison.InvariantCultureIgnoreCase))
		{
			HttpContextBase httpContext = ((ControllerContext)filterContext).get_HttpContext();
			HttpCookie httpCookie = httpContext.Request.Cookies[AntiForgeryConfig.get_CookieName()];
			string text = httpContext.Request.Headers["__RequestVerificationToken"];
			UserValidation(httpContext);
			if (text != null)
			{
				AntiForgery.Validate(httpCookie?.Value, text);
			}
			else
			{
				ValidateAction();
			}
		}
	}

	private void UserValidation(HttpContextBase httpContext)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		IIdentity identity = httpContext.User.Identity;
		string[] values = httpContext.Request.Form.GetValues("login");
		string text = ((values != null && values.Length != 0) ? values[0] : null);
		string text2 = HttpUtility.UrlDecode((identity != null) ? identity.Name : string.Empty);
		if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text) && !string.Equals(text, text2, StringComparison.InvariantCultureIgnoreCase) && identity != null && !(identity is WindowsIdentity))
		{
			throw new HttpAntiForgeryException(SR.T("Предоставленный токен анти-подделки предназначен для пользователя \"{0}\", но текущий пользователь\"{1}\".", text, text2));
		}
	}
}
