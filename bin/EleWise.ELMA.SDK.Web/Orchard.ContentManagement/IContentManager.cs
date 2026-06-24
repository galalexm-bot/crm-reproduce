namespace Orchard.ContentManagement;

public interface IContentManager : IDependency
{
	ContentItem New(string contentType);

	void Create(ContentItem contentItem);

	void Create(ContentItem contentItem, VersionOptions options);

	ContentItem Get(int id, VersionOptions options);

	ContentItem Get(int id, VersionOptions options, QueryHints hints);

	IContentQuery<ContentItem> Query();

	ContentItemMetadata GetItemMetadata(IContent contentItem);

	ContentItem ResolveIdentity(ContentIdentity contentIdentity);
}
