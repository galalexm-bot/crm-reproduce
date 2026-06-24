using System.Web;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web;

public class ActivationHandler : IHttpHandler
{
	public bool IsReusable => false;

	public void ProcessRequest(HttpContext context)
	{
		string text = context.Request["ActivationKey"];
		if (string.IsNullOrEmpty(text))
		{
			context.Response.Redirect("~/StartInfo.aspx?message=" + HttpUtility.UrlEncode(SR.T("Введите ключ активации")), endResponse: false);
			context.ApplicationInstance.CompleteRequest();
			return;
		}
		ComponentManager.Current.LicenseManager.AddActivationKey(text);
		ELMAEnviromentStarter.Continue();
		context.Response.Redirect("~/StartInfo.aspx", endResponse: false);
		context.ApplicationInstance.CompleteRequest();
	}
}
