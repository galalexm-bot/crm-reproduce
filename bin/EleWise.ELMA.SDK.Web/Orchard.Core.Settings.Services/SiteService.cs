using System.Linq;
using Orchard.Caching;
using Orchard.ContentManagement;
using Orchard.Core.Settings.Models;
using Orchard.Settings;

namespace Orchard.Core.Settings.Services;

public class SiteService : ISiteService, IDependency
{
	private readonly IContentManager _contentManager;

	private readonly ICacheManager _cacheManager;

	public SiteService(IContentManager contentManager, ICacheManager cacheManager)
	{
		_contentManager = contentManager;
		_cacheManager = cacheManager;
	}

	public ISite GetSiteSettings()
	{
		int id = _cacheManager.Get("SiteId", preventConcurrentCalls: true, delegate
		{
			ContentItem contentItem = _contentManager.Query("Site").List().FirstOrDefault();
			if (contentItem == null)
			{
				contentItem = _contentManager.Create<SiteSettingsPart>("Site").ContentItem;
			}
			return contentItem.Id;
		});
		return _contentManager.Get<ISite>(id, VersionOptions.Published);
	}
}
