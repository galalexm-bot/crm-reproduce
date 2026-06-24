namespace Orchard.ContentManagement;

public static class ContentGetExtensions
{
	public static T Get<T>(this IContentManager manager, int id, VersionOptions options) where T : class, IContent
	{
		ContentItem contentItem = manager.Get(id, options);
		if (contentItem != null)
		{
			return contentItem.Get<T>();
		}
		return null;
	}
}
