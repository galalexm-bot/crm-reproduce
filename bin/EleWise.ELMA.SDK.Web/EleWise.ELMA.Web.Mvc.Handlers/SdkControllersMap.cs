using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Handlers;

public class SdkControllersMap
{
	public const string PREFIX = "SDK.Action";

	public string Route => "SDK.Action/{controller}/{action}/{id}";

	public string[] Namespaces => new string[1] { typeof(DefaultController).Namespace };

	public object Defaults => new
	{
		controller = "Default",
		action = "StatusCode",
		id = 404
	};

	public object Constraints => null;
}
