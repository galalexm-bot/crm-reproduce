using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.UIBuilder.Model;
using EleWise.ELMA.UIBuilder.Services;
using EleWise.ELMA.UIBuilder.Web.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Designer.Web.Controllers;

[RouteArea("EleWise.ELMA.Designer.Web")]
[Permission("8DD067A9-9DDF-4FE7-9241-6989B59A6AEA")]
public class HomeController : BaseController
{
	private readonly Guid DesignerAppUid = new Guid("8485c478-017f-473c-ba5d-05683323e4d4");

	private readonly IJwtAuthTokenService jwtAuthTokenService;

	private readonly IInstallationChecker installationChecker;

	private readonly IComponentTestService componentTestService;

	private const string ApplicationToken = "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424";

	public HomeController(IJwtAuthTokenService jwtAuthTokenService, IInstallationChecker installationChecker, IComponentTestService componentTestService)
	{
		this.jwtAuthTokenService = jwtAuthTokenService;
		this.installationChecker = installationChecker;
		this.componentTestService = componentTestService;
	}

	[ContentItem(Name = "SR.M('Дизайнер')", Image24 = "#designer.svg")]
	public ActionResult Index(bool debug = false)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (!SR.GetSetting("Designer.Enabled", defaultValue: false))
		{
			return (ActionResult)new HttpNotFoundResult();
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)CreateModel(debug));
	}

	private DesignerModel CreateModel(bool debug)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser();
		JwtTokenContainer jwtTokenContainer = jwtAuthTokenService.CreateToken(new AuthInfoContainer((long)currentUser.GetId(), "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424"));
		return new DesignerModel
		{
			JwtAuthToken = jwtTokenContainer.JwtToken,
			RefreshToken = jwtTokenContainer.RefreshToken,
			PageUid = DesignerAppUid,
			Debug = debug,
			InstallationState = GetInstallationRunning(),
			TestMode = componentTestService.GetTestMode()
		};
	}

	[HttpGet]
	public JsonResult GetInstallationState()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		JsonResult val = new JsonResult();
		val.set_Data((object)GetInstallationRunning());
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val;
	}

	private InstallationState GetInstallationRunning()
	{
		Task<Task<InstallationState>> task = Task.Factory.StartNew(async delegate
		{
			InstallationState installState = await installationChecker.GetDesignerInstallationState();
			if (!installState.InstallationRunning)
			{
				installState = await installationChecker.GetDesignerTestState();
			}
			return installState;
		});
		return task.Unwrap().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter()
			.GetResult();
	}
}
