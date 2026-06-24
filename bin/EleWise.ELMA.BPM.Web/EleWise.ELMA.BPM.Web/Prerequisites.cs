using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.BPM.Web;

public class Prerequisites : Page
{
	protected HtmlHead Head1;

	protected void Page_Load(object sender, EventArgs e)
	{
	}

	public override void ProcessRequest(HttpContext context)
	{
		if (StartInformation.Root.Status != StartStatus.PrerequisitesCheckFault)
		{
			context.Response.Redirect("~/", endResponse: false);
			context.ApplicationInstance.CompleteRequest();
		}
		else if (context.Request.HttpMethod == "POST" && context.Request["ContinueCheck"] == "True")
		{
			ELMAEnviromentStarter.Continue();
			context.Response.Redirect("~/StartInfo.aspx", endResponse: false);
			context.ApplicationInstance.CompleteRequest();
		}
		else
		{
			base.ProcessRequest(context);
		}
	}

	protected string GetVersion()
	{
		return "ELMA " + VersionInfo.GetInfoVersion<SR>();
	}
}
