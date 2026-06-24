using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Documents.API.Models;

[DataContract]
public class DocumentVersionModel
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public long? Version { get; set; }

	[DataMember]
	public DateTime? CreationDate { get; set; }

	[DataMember]
	public long? CreationAuthor { get; set; }

	[DataMember]
	public DateTime? ChangeDate { get; set; }

	[DataMember]
	public long? ChangeAuthor { get; set; }

	[DataMember]
	public DocumentVersionStatus Status { get; set; }

	[DataMember]
	public bool IsBlocked { get; set; }

	[DataMember]
	public long? BlockAuthor { get; set; }

	[DataMember]
	public DateTime? BlockDate { get; set; }

	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public Guid? FileUid { get; set; }
}
