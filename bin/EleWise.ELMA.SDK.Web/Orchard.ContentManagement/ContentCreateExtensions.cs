using System;

namespace Orchard.ContentManagement;

public static class ContentCreateExtensions
{
	public static T New<T>(this IContentManager manager, string contentType) where T : class, IContent
	{
		ContentItem contentItem = manager.New(contentType);
		if (contentItem == null)
		{
			return null;
		}
		return contentItem.Get<T>() ?? throw new InvalidCastException();
	}

	public static T Create<T>(this IContentManager manager, string contentType) where T : class, IContent
	{
		T val = manager.New<T>(contentType);
		if (val == null)
		{
			return null;
		}
		manager.Create(val.ContentItem);
		return val;
	}

	public static ContentItem Create(this IContentManager manager, string contentType, VersionOptions options)
	{
		ContentItem contentItem = manager.New<ContentItem>(contentType);
		if (contentItem == null)
		{
			return null;
		}
		manager.Create(((IContent)contentItem).ContentItem, options);
		return contentItem;
	}
}
