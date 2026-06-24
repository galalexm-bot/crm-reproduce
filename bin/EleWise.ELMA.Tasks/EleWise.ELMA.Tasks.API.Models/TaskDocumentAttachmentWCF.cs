using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskDocumentAttachment")]
public class TaskDocumentAttachmentWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public long DocumentId { get; set; }

	[DataMember]
	public long CreationAuthorId { get; set; }

	[DataMember]
	public DateTime CreationDate { get; set; }

	[DataMember]
	public string DocumentName { get; set; }

	[DataMember]
	public long VersionId { get; set; }

	[DataMember]
	public long? VersionNumber { get; set; }

	[DataMember]
	public DateTime? VersionChangeDate { get; set; }

	[DataMember]
	public long VersionAuthorId { get; set; }

	[DataMember]
	public string VersionContent { get; set; }

	[DataMember]
	public Guid VersionFileUid { get; set; }

	[DataMember]
	public string VersionFileName { get; set; }

	[DataMember]
	public long VersionFileSize { get; set; }
}
