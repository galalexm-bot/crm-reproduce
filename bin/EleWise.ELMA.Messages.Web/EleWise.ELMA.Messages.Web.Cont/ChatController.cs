using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Content;
using Orchard.Themes;

namespace EleWise.ELMA.Messages.Web.Controllers;

public sealed class ChatController : BPMController
{
	private readonly IJwtAuthTokenService jwtAuthTokenService;

	private const string ApplicationToken = "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424";

	public ChatController(IJwtAuthTokenService jwtAuthTokenService)
	{
		this.jwtAuthTokenService = jwtAuthTokenService;
	}

	[ContentItem(Name = "SR.M('Чат')")]
	[Themed(false)]
	public ActionResult Index(bool debug = false)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (!SR.GetSetting("ELMAChat.Enabled", defaultValue: false))
		{
			return (ActionResult)new HttpNotFoundResult();
		}
		ChatApplicationModel chatApplicationModel = CreateModel(debug);
		return (ActionResult)(object)((Controller)this).PartialView((object)chatApplicationModel);
	}

	private ChatApplicationModel CreateModel(bool debug)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser();
		JwtTokenContainer jwtTokenContainer = jwtAuthTokenService.CreateToken(new AuthInfoContainer((long)currentUser.GetId(), "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424"));
		return new ChatApplicationModel
		{
			JwtAuthToken = jwtTokenContainer.JwtToken,
			RefreshToken = jwtTokenContainer.RefreshToken,
			Debug = debug
		};
	}
}
