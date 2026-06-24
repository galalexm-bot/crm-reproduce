using System.Collections.Generic;

namespace Orchard.Core.Settings.Metadata.Records;

public class ContentTypeDefinitionRecord
{
	public virtual int Id { get; set; }

	public virtual string Name { get; set; }

	public virtual string DisplayName { get; set; }

	public virtual bool Hidden { get; set; }

	public virtual string Settings { get; set; }

	public virtual IList<ContentTypePartDefinitionRecord> ContentTypePartDefinitionRecords { get; set; }

	public ContentTypeDefinitionRecord()
	{
		ContentTypePartDefinitionRecords = new List<ContentTypePartDefinitionRecord>();
	}
}
