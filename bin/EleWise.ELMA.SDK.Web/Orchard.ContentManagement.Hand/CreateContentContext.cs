using Orchard.ContentManagement.Records;

namespace Orchard.ContentManagement.Handlers;

public class CreateContentContext : ContentContextBase
{
	public ContentItemVersionRecord ContentItemVersionRecord { get; set; }

	public CreateContentContext(ContentItem contentItem)
		: base(contentItem)
	{
		ContentItemVersionRecord = contentItem.VersionRecord;
	}
}
