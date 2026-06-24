using System;
using Orchard.ContentManagement.Handlers;
using Orchard.Core.Settings.Models;

namespace Orchard.Core.Settings.Handlers;

public class SiteSettingsPartHandler : ContentHandler
{
	public SiteSettingsPartHandler()
	{
		base.Filters.Add(new ActivatingFilter<SiteSettingsPart>("Site"));
		OnInitializing<SiteSettingsPart>(InitializeSiteSettings);
	}

	private static void InitializeSiteSettings(InitializingContentContext initializingContentContext, SiteSettingsPart siteSettingsPart)
	{
		siteSettingsPart.SiteSalt = Guid.NewGuid().ToString("N");
		siteSettingsPart.SiteName = "My Orchard Project Application";
		siteSettingsPart.PageTitleSeparator = " - ";
		siteSettingsPart.SiteTimeZone = TimeZoneInfo.Local.Id;
	}
}
