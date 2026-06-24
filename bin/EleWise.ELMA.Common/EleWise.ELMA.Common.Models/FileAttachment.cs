using System;

namespace EleWise.ELMA.Common.Models;

public class FileAttachment
{
	public Guid TypeUid { get; set; }

	public string Id { get; set; }

	public string Name { get; set; }

	public FileAttachmentInfo AttachmentInfo { get; set; }
}
