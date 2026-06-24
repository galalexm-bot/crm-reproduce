namespace Orchard.ContentManagement;

public interface IContent
{
	ContentItem ContentItem { get; }

	int Id { get; }
}
