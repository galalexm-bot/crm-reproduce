using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.FileProvider.Distributed.Web.Components;

[Component]
internal class DistributedStorageSetupExtensionZone : IExtensionZone
{
	private const string ZoneId = "EleWise.ELMA.BPM.Web.Security.User.Actions";

	private readonly IAuthenticationService authenticationService;

	private readonly IFileManager fileManager;

	private bool IsDistributedFileProviderImplementation => fileManager is DistributedFileStoreProvider;

	public DistributedStorageSetupExtensionZone(IAuthenticationService authenticationService, IFileManager fileManager)
	{
		this.authenticationService = authenticationService;
		this.fileManager = fileManager;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		if ("EleWise.ELMA.BPM.Web.Security.User.Actions" == zoneId)
		{
			return IsDistributedFileProviderImplementation;
		}
		return false;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if ("EleWise.ELMA.BPM.Web.Security.User.Actions" == zoneId && IsDistributedFileProviderImplementation)
		{
			IUser user = (html.get_ViewData().get_Model() as IUser) ?? authenticationService.GetCurrentUser();
			((dynamic)html.get_ViewBag()).UserId = (long)user.GetId();
			RenderPartialExtensions.RenderPartial(html, "Settings/AddUserGatewayPopup");
		}
	}
}
