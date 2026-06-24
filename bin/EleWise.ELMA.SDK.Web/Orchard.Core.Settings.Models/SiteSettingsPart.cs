using System;
using System.Linq.Expressions;
using Orchard.ContentManagement;
using Orchard.Settings;

namespace Orchard.Core.Settings.Models;

public sealed class SiteSettingsPart : ContentPart, ISite, IContent
{
	public const int DefaultPageSize = 10;

	public string PageTitleSeparator
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.PageTitleSeparator), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.PageTitleSeparator, value, versioned: false);
		}
	}

	public string SiteName
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.SiteName), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.SiteName, value, versioned: false);
		}
	}

	public string SiteSalt
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.SiteSalt), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.SiteSalt, value, versioned: false);
		}
	}

	public string SuperUser
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.SuperUser), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.SuperUser, value, versioned: false);
		}
	}

	public string HomePage
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.HomePage), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.HomePage, value, versioned: false);
		}
	}

	public string SiteCulture
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.SiteCulture), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.SiteCulture, value, versioned: false);
		}
	}

	public string SiteCalendar
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.SiteCalendar), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.SiteCalendar, value, versioned: false);
		}
	}

	public ResourceDebugMode ResourceDebugMode
	{
		get
		{
			return this.Retrieve((SiteSettingsPart x) => x.ResourceDebugMode, ResourceDebugMode.FromAppSetting);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.ResourceDebugMode, value, versioned: false);
		}
	}

	public bool UseCdn
	{
		get
		{
			return this.Retrieve((SiteSettingsPart x) => x.UseCdn, defaultValue: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.UseCdn, value, versioned: false);
		}
	}

	public int PageSize
	{
		get
		{
			return this.Retrieve((SiteSettingsPart x) => x.PageSize, 10);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.PageSize, value, versioned: false);
		}
	}

	public int MaxPageSize
	{
		get
		{
			return this.Retrieve((SiteSettingsPart x) => x.MaxPageSize, 0);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.MaxPageSize, value, versioned: false);
		}
	}

	public int MaxPagedCount
	{
		get
		{
			return this.Retrieve((SiteSettingsPart x) => x.MaxPagedCount, 0);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.MaxPagedCount, value, versioned: false);
		}
	}

	public string SiteTimeZone
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.SiteTimeZone), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.SiteTimeZone, value, versioned: false);
		}
	}

	public string BaseUrl
	{
		get
		{
			return this.Retrieve((Expression<Func<SiteSettingsPart, string>>)((SiteSettingsPart x) => x.BaseUrl), (string)null, versioned: false);
		}
		set
		{
			this.Store((SiteSettingsPart x) => x.BaseUrl, value, versioned: false);
		}
	}
}
