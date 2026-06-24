using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.BPM.Web;

public class StartInfo : Page
{
	protected string startInfoStr;

	protected HtmlForm form1;

	protected void Page_Load(object sender, EventArgs e)
	{
		CultureInfo requestCultureInfo = OrchardApplication.GetRequestCultureInfo();
		if (requestCultureInfo != null)
		{
			Thread.CurrentThread.CurrentUICulture = requestCultureInfo;
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(requestCultureInfo.Name);
		}
		StartInformation root = StartInformation.Root;
		if (base.Request["mode"] == "fortest")
		{
			root.Message = DateTime.Now.ToString();
			root.Percent = Math.Min(root.Percent, 95.0);
			root.Status = StartStatus.Running;
		}
		startInfoStr = StartInfoHandler.FormatStartInformation(root);
		startInfoStr = startInfoStr.Replace("\\", "\\\\").Replace("'", "\\'").Replace("\n", "\\n")
			.Replace("\r", "\\r")
			.Replace("\t", "\\t");
	}

	protected string GetVersion()
	{
		return SR.M("ELMA") + " " + VersionInfo.GetInfoVersion<SR>();
	}

	protected void lbIgnoreErrors_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(base.Request.QueryString["ReturnUrl"]) && !string.IsNullOrEmpty(base.Request.QueryString["user"]))
		{
			base.Response.Redirect("~/Login.aspx?ReturnUrl=" + HttpUtility.UrlEncode(base.Request.QueryString["ReturnUrl"], base.Request.ContentEncoding) + "&user=" + base.Request.QueryString["user"], endResponse: false);
		}
		else
		{
			base.Response.Redirect(string.IsNullOrEmpty(base.Request.QueryString["ReturnUrl"]) ? "~" : base.Request.QueryString["ReturnUrl"], endResponse: false);
		}
		HttpContext.Current.ApplicationInstance.CompleteRequest();
	}

	protected string GetRedirectUrl()
	{
		if (!string.IsNullOrEmpty(base.Request.QueryString["ReturnUrl"]) && !string.IsNullOrEmpty(base.Request.QueryString["user"]))
		{
			return ResolveClientUrl("~/Login.aspx?ReturnUrl=" + HttpUtility.UrlEncode(base.Request.QueryString["ReturnUrl"], base.Request.ContentEncoding) + "&user=" + base.Request.QueryString["user"]);
		}
		string text = base.Request.QueryString["ReturnUrl"];
		if (!string.IsNullOrWhiteSpace(text))
		{
			if (Regex.IsMatch(text, "['\"<>]"))
			{
				return ResolveClientUrl("~" + HttpUtility.UrlEncode(text));
			}
			return ResolveClientUrl("~" + text);
		}
		return ResolveClientUrl("~");
	}

	protected string GetActivationUrl()
	{
		return ResolveClientUrl("~/" + OrchardApplication.ActivationPage);
	}

	protected string GetPrerequisitesUrl()
	{
		return ResolveClientUrl("~/" + OrchardApplication.PrerequisitesPage);
	}

	protected string GetMakeBackupUrl()
	{
		return ResolveClientUrl("~/" + OrchardApplication.MakeBackupPage);
	}
}
