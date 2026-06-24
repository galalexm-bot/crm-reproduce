using System.Web;
using System.Web.Services;

namespace EleWise.ELMA.BPM.Web;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Version : IHttpHandler
{
	public bool IsReusable => false;

	public void ProcessRequest(HttpContext context)
	{
		context.Response.ContentType = "text/plain";
		context.Response.Write(VersionInfo.GetVersion<SR>().ToString());
	}
}
