using System;
using System.Globalization;
using System.Threading;
using System.Web;

namespace EleWise.ELMA.Packaging;

public abstract class PackageOperationStatusHandlerBase : IHttpHandler
{
	protected readonly int _serverType;

	public bool IsReusable => false;

	public PackageOperationStatusHandlerBase(int serverType)
	{
		SR.DesignMode = false;
		_serverType = serverType;
	}

	public void ProcessRequest(HttpContext context)
	{
		Guid updatingUid = Guid.Empty;
		if (context.Request["updatingUid"] != null)
		{
			updatingUid = Guid.Parse(context.Request["updatingUid"]);
		}
		CultureInfo cultureFromSettings = SR.GetCultureFromSettings();
		if (cultureFromSettings != null)
		{
			Thread.CurrentThread.CurrentUICulture = cultureFromSettings;
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureFromSettings.Name);
		}
		PackageOperationStatus status = LoadStatus(updatingUid);
		context.Response.ContentType = "text/plain";
		context.Response.StatusCode = 200;
		context.Response.Write(FormatStatus(status, _serverType));
		context.Response.Flush();
		context.ApplicationInstance.CompleteRequest();
	}

	protected abstract PackageOperationStatus LoadStatus(Guid updatingUid);

	public static string FormatStatus(PackageOperationStatus status, int serverType)
	{
		if (status != null)
		{
			return serverType + ";" + (int)status.Type + ";" + status.Message;
		}
		return serverType + ";0;" + SR.T("Информация о текущей операции отсутствует");
	}
}
