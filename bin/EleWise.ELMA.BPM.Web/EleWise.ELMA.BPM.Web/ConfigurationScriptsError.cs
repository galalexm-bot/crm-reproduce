using System;
using System.Globalization;
using System.Threading;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web;

public class ConfigurationScriptsError : Page
{
	protected HtmlForm htmlForm;

	protected Label lblFilename;

	protected HtmlGenericControl errorDiv;

	protected HtmlInputText password;

	protected Button btnSubmit;

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
			lblFilename.Text = Locator.GetServiceNotNull<IConfigurationScriptsErrorService>().GetFileAbsolutePath();
		}
	}

	protected void Submit(object sender, EventArgs e)
	{
		if (Locator.GetServiceNotNull<IConfigurationScriptsErrorService>().Validate(password.Value))
		{
			base.Response.Redirect("~/WebDesigner", endResponse: true);
		}
		else
		{
			errorDiv.Visible = true;
		}
	}
}
