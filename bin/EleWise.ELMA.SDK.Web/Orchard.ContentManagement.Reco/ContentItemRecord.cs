using System.Collections.Generic;
using Orchard.ContentManagement.FieldStorage.InfosetStorage;

namespace Orchard.ContentManagement.Records;

public class ContentItemRecord
{
	public virtual int Id { get; set; }

	public virtual ContentTypeRecord ContentType { get; set; }

	public virtual IList<ContentItemVersionRecord> Versions { get; set; }

	public virtual string Data
	{
		get
		{
			return Infoset.Data;
		}
		set
		{
			Infoset.Data = value;
		}
	}

	public virtual Infoset Infoset { get; protected set; }

	public ContentItemRecord()
	{
		Versions = new List<ContentItemVersionRecord>();
		Infoset = new Infoset();
	}
}
