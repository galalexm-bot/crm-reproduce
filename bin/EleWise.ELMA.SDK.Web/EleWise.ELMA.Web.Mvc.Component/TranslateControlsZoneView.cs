using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Translate;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
internal class TranslateControlsZoneView : IExtensionZone
{
	private const string ZONE_ID = "BeforeContentZone";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "BeforeContentZone";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "BeforeContentZone" && TranslateService.Instance.Initialized && TranslateService.Instance.IsTranslationModeEnabled())
		{
			TranslateSettings translateSettings = new TranslateSettings
			{
				CurrentLocal = SR.GetCurrentCulture().Name
			};
			long value = Convert.ToInt64(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId());
			string text = (translateSettings.TargetLocal = TranslateService.Instance.GetTranslateLocalization(value));
			RenderPartialExtensions.RenderPartial(html, "Translate/TranslateScripts", (object)translateSettings);
		}
	}
}
