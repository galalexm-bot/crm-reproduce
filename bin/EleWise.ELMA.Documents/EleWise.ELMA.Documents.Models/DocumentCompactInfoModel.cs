using System;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Models;

public class DocumentCompactInfoModel
{
	public string FileId { get; set; }

	public string DocumentName { get; set; }

	public long? CurrentVersion { get; set; }

	public Guid DocumentUid { get; set; }

	public long CreationAuthorId { get; set; }

	public Guid CreationAuthorUid { get; set; }

	public string CreationAuthorLastName { get; set; }

	public string CreationAuthorFirstName { get; set; }

	public string CreationAuthorMiddleName { get; set; }

	public string CreationAuthorName { get; set; }

	public string CreationAuthorShortName => UserExtensions.GetShortName(CreationAuthorUid, CreationAuthorLastName, CreationAuthorFirstName, CreationAuthorMiddleName, CreationAuthorName);

	public DateTime CreationDate { get; set; }

	public long DocumentId { get; set; }

	public Guid DocumentTypeUid { get; set; }

	public Guid DocumentAttachmentUid { get; set; }

	public bool IsArchived { get; set; }

	public bool IsDeleted { get; set; }

	public string Highlight { get; set; }
}
