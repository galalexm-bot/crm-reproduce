using System.Diagnostics;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Orchard.Environment;

namespace EleWise.ELMA.Web.Orchard;

[Service(Type = ComponentType.WebServer, EnableInterceptors = false)]
internal class WebHostEnvironmentService : IWebHostEnvironmentService
{
	public void RestartHost()
	{
		ILogger logger = Logger.GetLogger("ElmaDiagnostics");
		if (logger.IsFatalEnabled())
		{
			IUser user = Locator.GetService<IAuthenticationService>()?.GetCurrentUser();
			HttpContextBase httpContextBase = Locator.GetService<IHttpContextAccessor>()?.Current();
			string text = new StackTrace().ToString();
			logger.Fatal(SR.T("Веб-сервер перезапущен пользователем: {0} ( id: {1}, login: {2}, ip: {3} ) из\n\r {4}", (user != null) ? user.FullName : "undefined", (user != null) ? user.GetId() : "undefined", (user != null) ? user.UserName : "undefined", (httpContextBase != null) ? httpContextBase.Request.UserHostAddress : "undefined", text));
		}
		Locator.GetService<IRuntimeApplication>()?.DbPreUpdater.EndUpdating();
		Locator.GetServiceNotNull<IHostEnvironment>().RestartAppDomain();
	}
}
