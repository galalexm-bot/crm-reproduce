using System.Collections.Generic;

namespace Orchard.Core.Settings.Metadata.Records;

public class ContentPartDefinitionRecord
{
	public virtual int Id { get; set; }

	public virtual string Name { get; set; }

	public virtual bool Hidden { get; set; }

	public virtual string Settings { get; set; }

	public virtual IList<ContentPartFieldDefinitionRecord> ContentPartFieldDefinitionRecords { get; set; }

	public ContentPartDefinitionRecord()
	{
		ContentPartFieldDefinitionRecords = new List<ContentPartFieldDefinitionRecord>();
	}
}
