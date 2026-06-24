using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class FormRenderExtensions
{
	private const string ApplicationToken = "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424";

	private static IAuthenticationService AuthenticationService => Locator.GetServiceNotNull<IAuthenticationService>();

	private static IJwtAuthTokenService JwtAuthTokenService => Locator.GetServiceNotNull<IJwtAuthTokenService>();

	private static JSScriptCachedMergerService ScriptService => Locator.GetServiceNotNull<JSScriptCachedMergerService>();

	private static CSSStylesCachedMergerService CssService => Locator.GetServiceNotNull<CSSStylesCachedMergerService>();

	private static ComponentMetadataItemHeaderManager ComponentMetadataItemHeaderManager => ComponentMetadataItemHeaderManager.Instance;

	private static IModuleReferenceManager ModuleReferenceManager => Locator.GetServiceNotNull<IModuleReferenceManager>();

	private static ModuleMetadataItemHeaderManager ModuleMetadataItemHeaderManager => ModuleMetadataItemHeaderManager.Instance;

	public static MvcHtmlString RenderPageV2(this HtmlHelper htmlHelper, Guid pageUid)
	{
		return htmlHelper.RenderPageV2(new PageApplicationData(pageUid));
	}

	public static MvcHtmlString RenderPageV2(this HtmlHelper htmlHelper, Guid pageUid, Dictionary<string, object> inputModel)
	{
		return htmlHelper.RenderPageV2(pageUid, inputModel, singlePage: true);
	}

	public static MvcHtmlString RenderPageV2(this HtmlHelper htmlHelper, Guid pageUid, Dictionary<string, object> inputModel, bool singlePage)
	{
		return htmlHelper.RenderPageV2(new PageApplicationData(pageUid, inputModel), singlePage);
	}

	public static MvcHtmlString RenderPageV2(this HtmlHelper htmlHelper, PageApplicationData applicationData)
	{
		return htmlHelper.RenderPageV2(applicationData, singlePage: true);
	}

	public static MvcHtmlString RenderPageV2(this HtmlHelper htmlHelper, PageApplicationData applicationData, bool singlePage = true)
	{
		if (htmlHelper != null && applicationData != null && applicationData.PageUid != Guid.Empty)
		{
			PageApplicationViewModel pageApplicationViewModel = CreateModel(applicationData);
			pageApplicationViewModel.ContentUrl = ScriptService.GetPageAppContentUrl(htmlHelper);
			pageApplicationViewModel.CssUrl = CssService.GetPageAppContentUrl(htmlHelper);
			pageApplicationViewModel.Single = singlePage;
			return PartialExtensions.Partial(htmlHelper, "Shared/UI/PageApp", (object)pageApplicationViewModel);
		}
		return MvcHtmlString.Empty;
	}

	private static PageApplicationViewModel CreateModel(PageApplicationData applicationData)
	{
		IUser currentUser = AuthenticationService.GetCurrentUser();
		JwtTokenContainer jwtTokenContainer = JwtAuthTokenService.CreateToken(new AuthInfoContainer((long)currentUser.GetId(), "F2ED2D0B2B848DE05BF7A9B1FF9F510316A4B4EAC1EF3F535E19BB490B0B0293CA11FEA6A2F17E24E958AF7380E0D4263653DE78A845C34379D999B2E3203424"));
		Guid pageUid = applicationData.PageUid;
		Guid guid = ModuleReferenceManager.LoadOrNull(pageUid)?.ModuleUid ?? Guid.Empty;
		if (guid == Guid.Empty)
		{
			if (ComponentMetadataItemHeaderManager.Load(pageUid).Published == null)
			{
				throw new Exception(SR.T("Компонент не опубликован: {0}", pageUid));
			}
		}
		else if (ModuleMetadataItemHeaderManager.Load(guid).Published == null)
		{
			throw new Exception(SR.T("Модуль не опубликован: {0}", guid));
		}
		JsonSerializer jsonSerializer = new JsonSerializer();
		return new PageApplicationViewModel
		{
			JwtAuthToken = jwtTokenContainer.JwtToken,
			RefreshToken = jwtTokenContainer.RefreshToken,
			PageUid = pageUid,
			ApplicationId = applicationData.ApplicationId,
			InputModelStr = MvcHtmlString.Create((applicationData.InputModel.Count > 0) ? jsonSerializer.Serialize(applicationData.InputModel) : "null")
		};
	}
}
