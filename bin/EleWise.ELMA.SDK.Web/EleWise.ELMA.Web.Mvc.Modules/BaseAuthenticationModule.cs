using System;
using System.Security;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using EleWise.ELMA.Text;

namespace EleWise.ELMA.Web.Mvc.Modules;

public class BaseAuthenticationModule : IHttpModule, IRequiresSessionState
{
	protected string Realm { get; set; }

	protected virtual string DefaultUnauthorizedResponseHtml => "\r\n                        <html>\r\n                            <head>\r\n                                <title>401 Authorization Required</title>\r\n                            </head>\r\n                            <body>\r\n                                <h1>Authorization Required</h1>\r\n                                <p>This server could not verify that you are authorized to access the document\r\n                                    requested.  Either you supplied the wrong credentials (e.g., bad password), or your\r\n                                    browser doesn't understand how to supply the credentials required.</p>\r\n                            </body>\r\n                        </html>";

	public void Init(HttpApplication application)
	{
		application.AuthenticateRequest += OnAuthenticateRequest;
		application.EndRequest += OnEndRequest;
	}

	public void Dispose()
	{
	}

	protected bool NeedBasic(HttpApplication app)
	{
		return app.Request.QueryString.Get("basic") != null;
	}

	public void OnAuthenticateRequest(object source, EventArgs eventArgs)
	{
		if (!(source is HttpApplication httpApplication) || !NeedBasic(httpApplication))
		{
			return;
		}
		HttpContext.Current = httpApplication.Context;
		string text = httpApplication.Request.Headers["Authorization"];
		if (string.IsNullOrEmpty(text))
		{
			AccessDenied(httpApplication);
			return;
		}
		text = text.Trim();
		if (text.IndexOf("Basic", 0, StringComparison.Ordinal) != 0)
		{
			AccessDenied(httpApplication);
			return;
		}
		byte[] bytes = Convert.FromBase64String(text.Substring(6));
		string @string = EncodingCache.Win1251Encoding.GetString(bytes);
		int num = @string.IndexOf(':');
		string text2 = @string.Substring(0, num);
		string password = @string.Substring(num + 1, @string.Length - num - 1);
		if (AuthenticateAgent(httpApplication, text2, password, out var groups))
		{
			FormsAuthentication.SetAuthCookie(text2, createPersistentCookie: true);
			httpApplication.Context.User = new GenericPrincipal(new GenericIdentity(text2, "ElmaWebControlLibrary.Authentication.AuthBasic"), groups);
		}
		else
		{
			AccessDenied(httpApplication);
		}
	}

	public void OnEndRequest(object source, EventArgs eventArgs)
	{
		if (!(source is HttpApplication httpApplication) || !NeedBasic(httpApplication))
		{
			return;
		}
		if (httpApplication.Response.StatusCode == 302)
		{
			AccessDenied(httpApplication);
			httpApplication.Response.RedirectLocation = null;
			httpApplication.Response.Clear();
			httpApplication.Response.ContentType = "text/html";
			string text = new HttpException(401, null, new SecurityException()).GetHtmlErrorMessage();
			if (string.IsNullOrEmpty(text))
			{
				text = DefaultUnauthorizedResponseHtml;
			}
			httpApplication.Response.Write(text);
		}
		if (httpApplication.Response.StatusCode == 401)
		{
			string value = $"Basic Realm=\"{Realm}\"";
			httpApplication.Response.AppendHeader("WWW-Authenticate", value);
		}
	}

	private static void AccessDenied(HttpApplication app)
	{
		app.Response.StatusCode = 401;
		app.Response.StatusDescription = "Access Denied";
		app.CompleteRequest();
	}

	protected virtual bool AuthenticateAgent(HttpApplication app, string username, string password, out string[] groups)
	{
		groups = null;
		return true;
	}
}
