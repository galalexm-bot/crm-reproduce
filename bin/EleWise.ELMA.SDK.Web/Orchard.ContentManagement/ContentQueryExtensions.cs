namespace Orchard.ContentManagement;

public static class ContentQueryExtensions
{
	public static IContentQuery<ContentItem> Query(this IContentManager manager, params string[] contentTypeNames)
	{
		return manager.Query().ForType(contentTypeNames);
	}
}
