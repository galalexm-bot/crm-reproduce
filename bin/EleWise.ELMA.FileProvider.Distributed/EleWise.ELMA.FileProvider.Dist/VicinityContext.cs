using System.Web;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.FileProvider.Distributed.Models;

public class VicinityContext
{
	public IUser CurrentUser { get; set; }

	public HttpContextBase HttpContext { get; set; }
}
