using System;
using System.Globalization;
using System.Threading;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.BPM.Web;

public class MakeBackup : Page
{
	private static readonly ILogger BackupLog = Logger.GetLogger("Backup");

	private const string PassPhrasePath = "ConfirmationCode.txt";

	private static PassPhrase confirmationCode;

	protected HtmlForm form1;

	protected Label lblFilename;

	protected HtmlGenericControl errorDiv;

	protected HtmlGenericControl hiddenDiv;

	protected HtmlTableRow phraseRow;

	protected void Page_Init(object sender, EventArgs e)
	{
		CultureInfo requestCultureInfo = OrchardApplication.GetRequestCultureInfo();
		if (requestCultureInfo != null)
		{
			Thread.CurrentThread.CurrentUICulture = requestCultureInfo;
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(requestCultureInfo.Name);
		}
		if (!Page.IsPostBack)
		{
			BackupLog.Info("Manual backup confirmation page is initializing...");
			if (confirmationCode == null)
			{
				confirmationCode = new PassPhrase("ConfirmationCode.txt");
			}
			lblFilename.Text = confirmationCode.AbsolutePath;
		}
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (base.Request.HttpMethod == "GET")
		{
			if (string.IsNullOrEmpty(base.Request["ShowError"]))
			{
				errorDiv.Style.Add("display", "none");
			}
		}
		else
		{
			if (!(base.Request.HttpMethod == "POST"))
			{
				return;
			}
			string value = base.Request["password"];
			if (confirmationCode.IsValid(value))
			{
				BackupLog.Info("Presence of manual backup is confirmed:");
				BackupLog.Info("  User host IP: " + base.Request.UserHostAddress);
				BackupLog.Info("  User host DNS Name: " + base.Request.UserHostName);
				BackupLog.Info("  User agent: " + base.Request.UserAgent);
				string[] allKeys = base.Request.Cookies.AllKeys;
				foreach (string text in allKeys)
				{
					BackupLog.Info("  Cookie '" + text + "': " + base.Request.Cookies[text].Value);
				}
				confirmationCode.Delete();
				ELMAEnviromentStarter.Continue();
				base.Response.Redirect("~/StartInfo.aspx", endResponse: false);
			}
			else
			{
				BackupLog.Error("Pass phrase validation error while confirming manual backup presence");
				base.Response.Redirect("~/MakeBackup.aspx?ShowError=1", endResponse: false);
			}
			base.Response.Flush();
		}
	}
}
