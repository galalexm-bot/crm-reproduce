using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UIBuilder.Services;
using EleWise.ELMA.UIBuilder.Web.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Controllers;
using Orchard.Themes;

namespace EleWise.ELMA.UIBuilder.Web.Controllers;

[RouteArea("EleWise.ELMA.UIBuilder.Web")]
[Themed]
public class HomeController : BaseController
{
	private readonly IJwtAuthTokenService jwtAuthTokenService;

	private readonly IOmniSharpWorker omniSharpWorker;

	private readonly IComponentTestService componentTestService;

	private const string ApplicationToken = "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424";

	public HomeController(IJwtAuthTokenService jwtAuthTokenService, IOmniSharpWorker omniSharpWorker, IComponentTestService componentTestService)
	{
		this.jwtAuthTokenService = jwtAuthTokenService;
		this.omniSharpWorker = omniSharpWorker;
		this.componentTestService = componentTestService;
	}

	[ContentItem(Name = "SR.M('Конструктор интерфейсов')", Image24 = "#elma.svg")]
	[Themed(false)]
	public ActionResult Index(Guid? pageUid = null, bool debug = false)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (!SR.GetSetting("UiBuilder.Enabled", defaultValue: false))
		{
			return (ActionResult)new HttpNotFoundResult();
		}
		DesignerModel model = CreateModel(debug, pageUid);
		Task.Run(delegate
		{
			omniSharpWorker.Start(needRestart: false);
		});
		return RenderModel(model);
	}

	public ActionResult PartialIndex(Guid? pageUid = null, bool debug = false)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (!SR.GetSetting("UiBuilder.Enabled", defaultValue: false))
		{
			return (ActionResult)new HttpNotFoundResult();
		}
		DesignerModel designerModel = CreateModel(debug, pageUid);
		return (ActionResult)(object)((Controller)this).View("Page", (object)designerModel);
	}

	public ActionResult RenderModel(DesignerModel model)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Index", (object)model);
	}

	[Themed(false)]
	public ActionResult TestRunner(bool debug = false)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (!SR.GetSetting("Designer.Enabled", defaultValue: false))
		{
			return (ActionResult)new HttpNotFoundResult();
		}
		DesignerModel designerModel = CreateModel(debug);
		return (ActionResult)(object)((Controller)this).PartialView("TestRunner/Index", (object)designerModel);
	}

	private DesignerModel CreateModel(bool debug, Guid? pageUid = null)
	{
		long num = (long)base.AuthenticationService.GetCurrentUserId();
		JwtTokenContainer jwtTokenContainer = jwtAuthTokenService.CreateToken(new AuthInfoContainer(num, "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424"));
		DesignerModel designerModel = new DesignerModel
		{
			JwtAuthToken = jwtTokenContainer.JwtToken,
			RefreshToken = jwtTokenContainer.RefreshToken,
			Debug = debug,
			CurrentUser = num,
			TestMode = componentTestService.GetTestMode()
		};
		if (pageUid.HasValue)
		{
			designerModel.PageUid = pageUid.Value;
		}
		return designerModel;
	}
}
