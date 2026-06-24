using System.IO;
using System.Web;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web;

public class ProcessHandler : IHttpHandler
{
	private const string rootPath = "Processes/Documentation/View/";

	public bool IsReusable => false;

	public void ProcessRequest(HttpContext context)
	{
		IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
		int num = context.Request.RawUrl.ToUpper().IndexOf("Processes/Documentation/View/".ToUpper());
		if (num < 0)
		{
			context.Response.StatusCode = 400;
			context.Response.Flush();
			return;
		}
		num += "Processes/Documentation/View/".Length;
		string arg = context.Request.RawUrl.Substring(num).Replace("/", "\\");
		string text = $"{Path.GetDirectoryName(service.Configuration.Config.FilePath)}\\Documentation\\{arg}";
		if (File.Exists(text))
		{
			context.Response.TransmitFile(text);
			return;
		}
		context.Response.StatusCode = 404;
		context.Response.Flush();
	}
}
