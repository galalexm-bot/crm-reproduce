using Orchard.ContentManagement.Records;

namespace Orchard.ContentManagement.Handlers;

public class UpdateContentContext : ContentContextBase
{
	public ContentItemVersionRecord UpdatingItemVersionRecord { get; set; }

	public UpdateContentContext(ContentItem contentItem)
		: base(contentItem)
	{
		UpdatingItemVersionRecord = contentItem.VersionRecord;
	}
}
