using System.Collections.Generic;
using System.Linq;

namespace Orchard.ContentManagement;

public static class ContentExtensions
{
	public static bool Is<T>(this IContent content)
	{
		return content?.ContentItem.Has(typeof(T)) ?? false;
	}

	public static T As<T>(this IContent content) where T : IContent
	{
		if (content != null)
		{
			return (T)content.ContentItem.Get(typeof(T));
		}
		return default(T);
	}

	public static bool Has<T>(this IContent content)
	{
		return content?.ContentItem.Has(typeof(T)) ?? false;
	}

	public static T Get<T>(this IContent content) where T : IContent
	{
		if (content != null)
		{
			return (T)content.ContentItem.Get(typeof(T));
		}
		return default(T);
	}

	public static IEnumerable<T> AsPart<T>(this IEnumerable<ContentItem> items) where T : IContent
	{
		return (from item in items?.Where((ContentItem item) => item.Is<T>())
			select item.As<T>());
	}

	public static bool IsPublished(this IContent content)
	{
		if (content.ContentItem.VersionRecord != null)
		{
			return content.ContentItem.VersionRecord.Published;
		}
		return false;
	}
}
