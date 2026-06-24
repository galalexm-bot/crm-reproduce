using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Services;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Extensions;
using EleWise.ELMA.Web.Mvc.Modules;

namespace EleWise.ELMA.BPM.Web;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class StartInfoHandler : IHttpHandler
{
	public bool IsReusable => false;

	public static string FormatStartInformation(StartInformation si)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append((int)si.Status);
		stringBuilder.Append(";");
		stringBuilder.Append((int)si.Percent);
		stringBuilder.Append(";");
		stringBuilder.Append(si.HasErrors ? "1" : "0");
		stringBuilder.Append(";");
		stringBuilder.Append((!string.IsNullOrEmpty(si.UpdateFromVersion)) ? SR.T("(обновление с версии {0})", si.UpdateFromVersion) : string.Empty);
		stringBuilder.Append(";");
		stringBuilder.Append(si.Backup.IsVisible ? "1" : "0");
		stringBuilder.Append(";");
		stringBuilder.Append(si.Backup.IsCurrentStatusDetermined ? "Green" : "Orange");
		stringBuilder.Append(";");
		stringBuilder.Append(si.Backup.CurrentDescription);
		stringBuilder.Append(";");
		stringBuilder.Append(StartInformationExtension.GetCurrentDBConversionStage());
		stringBuilder.Append(";");
		stringBuilder.Append(si.Message);
		return stringBuilder.ToString();
	}

	public void ProcessRequest(HttpContext context)
	{
		ELMASessionStateModule.DisableSession = true;
		CultureInfo requestCultureInfo = OrchardApplication.GetRequestCultureInfo(context);
		if (requestCultureInfo != null)
		{
			Thread.CurrentThread.CurrentUICulture = requestCultureInfo;
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(requestCultureInfo.Name);
		}
		context.Response.ContentType = "text/plain";
		if (context.Request["type"] == "Availability")
		{
			context.Response.StatusCode = ((StartInformation.Root.Status == StartStatus.Started) ? 200 : 503);
			context.Response.Flush();
			context.ApplicationInstance.CompleteRequest();
			return;
		}
		if (context.Request["type"] == "StartInfo")
		{
			StartInformation root = StartInformation.Root;
			if (context.Request["mode"] == "fortest")
			{
				root.Message = DateTime.Now.ToString();
				root.Percent = Math.Min(root.Percent, 95.0);
				root.Status = StartStatus.Running;
			}
			string text = FormatStartInformation(root);
			if (text != null)
			{
				context.Response.Write(text);
			}
		}
		else
		{
			_ = context.Request["type"] == "Errors";
		}
		context.Response.Flush();
		context.ApplicationInstance.CompleteRequest();
	}
}
