using System;
using System.Net;
using EleWise.ELMA.Logging;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Core.Settings.Models;
using Orchard.Core.Settings.ViewModels;
using Orchard.Exceptions;
using Orchard.Localization;
using Orchard.Localization.Services;
using Orchard.Logging;
using Orchard.Security;
using Orchard.Settings;
using Orchard.UI.Notify;

namespace Orchard.Core.Settings.Drivers;

public class SiteSettingsPartDriver : ContentPartDriver<SiteSettingsPart>
{
	private readonly ISiteService _siteService;

	private readonly ICultureManager _cultureManager;

	private readonly ICalendarManager _calendarProvider;

	private readonly IMembershipService _membershipService;

	private readonly INotifier _notifier;

	private readonly IAuthorizer _authorizer;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	protected override string Prefix => "SiteSettings";

	public SiteSettingsPartDriver(ISiteService siteService, ICultureManager cultureManager, ICalendarManager calendarProvider, IMembershipService membershipService, INotifier notifier, IAuthorizer authorizer)
	{
		_siteService = siteService;
		_cultureManager = cultureManager;
		_calendarProvider = calendarProvider;
		_membershipService = membershipService;
		_notifier = notifier;
		_authorizer = authorizer;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	protected override DriverResult Editor(SiteSettingsPart part, dynamic shapeHelper)
	{
		SiteSettingsPart site = _siteService.GetSiteSettings().As<SiteSettingsPart>();
		SiteSettingsPartViewModel model = new SiteSettingsPartViewModel
		{
			Site = site,
			SiteCultures = _cultureManager.ListCultures(),
			SiteCalendars = _calendarProvider.ListCalendars(),
			TimeZones = TimeZoneInfo.GetSystemTimeZones()
		};
		return ContentShape("Parts_Settings_SiteSettingsPart", () => shapeHelper.EditorTemplate(TemplateName: "Parts.Settings.SiteSettingsPart", Model: model, Prefix: Prefix));
	}

	protected override DriverResult Editor(SiteSettingsPart part, IUpdateModel updater, dynamic shapeHelper)
	{
		SiteSettingsPart site = _siteService.GetSiteSettings().As<SiteSettingsPart>();
		SiteSettingsPartViewModel model = new SiteSettingsPartViewModel
		{
			Site = site,
			SiteCultures = _cultureManager.ListCultures(),
			SiteCalendars = _calendarProvider.ListCalendars(),
			TimeZones = TimeZoneInfo.GetSystemTimeZones()
		};
		string baseUrl = model.Site.BaseUrl;
		updater.TryUpdateModel(model, Prefix, null, new string[4] { "Site.SuperUser", "Site.MaxPageSize", "Site.BaseUrl", "Site.MaxPagedCount" });
		if (_authorizer.Authorize(StandardPermissions.SiteOwner))
		{
			updater.TryUpdateModel(model, Prefix, new string[4] { "Site.SuperUser", "Site.MaxPageSize", "Site.BaseUrl", "Site.MaxPagedCount" }, null);
			if (string.IsNullOrEmpty(model.SuperUser))
			{
				model.SuperUser = string.Empty;
			}
			else if (_membershipService.GetUser(model.SuperUser) == null)
			{
				updater.AddModelError("SuperUser", T("The user {0} was not found", model.SuperUser));
			}
			if (!string.IsNullOrWhiteSpace(model.Site.BaseUrl))
			{
				if (!Uri.IsWellFormedUriString(model.Site.BaseUrl, UriKind.Absolute))
				{
					updater.AddModelError("BaseUrl", T("The base url must be absolute."));
				}
				else if (!string.Equals(baseUrl, model.Site.BaseUrl, StringComparison.OrdinalIgnoreCase))
				{
					try
					{
						if (WebRequest.Create(model.Site.BaseUrl) is HttpWebRequest httpWebRequest)
						{
							using (httpWebRequest.GetResponse() as HttpWebResponse)
							{
							}
						}
					}
					catch (Exception ex)
					{
						if (ex.IsFatal())
						{
							throw;
						}
						_notifier.Warning(T("The base url you entered could not be requested from current location."));
						Logger.Warning(ex, "Could not query base url: {0}", model.Site.BaseUrl);
					}
				}
			}
		}
		return ContentShape("Parts_Settings_SiteSettingsPart", () => shapeHelper.EditorTemplate(TemplateName: "Parts.Settings.SiteSettingsPart", Model: model, Prefix: Prefix));
	}

	protected override void Exporting(SiteSettingsPart part, ExportContentContext context)
	{
		context.Element(part.PartDefinition.Name).SetAttributeValue("SupportedCultures", string.Join(";", _cultureManager.ListCultures()));
	}

	protected override void Importing(SiteSettingsPart part, ImportContentContext context)
	{
		if (context.Data.Element(part.PartDefinition.Name) == null)
		{
			return;
		}
		context.ImportAttribute(part.PartDefinition.Name, "SupportedCultures", delegate(string supportedCultures)
		{
			string[] array = supportedCultures.Split(';');
			foreach (string cultureName in array)
			{
				_cultureManager.AddCulture(cultureName);
			}
		});
	}
}
