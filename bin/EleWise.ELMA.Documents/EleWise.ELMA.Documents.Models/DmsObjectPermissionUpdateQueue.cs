using System;

namespace EleWise.ELMA.Documents.Models;

internal class DmsObjectPermissionUpdateQueueItem
{
	public long Id { get; set; }

	public byte[] Patch { get; set; }

	public DateTime CreationDate { get; set; }

	public long DmsObject { get; set; }

	public long FolderId { get; set; }

	public string FolderName { get; set; }

	public int Attempt { get; set; }

	public DateTime? LastUpdateDate { get; set; }

	public DateTime NextUpdateDate { get; set; }

	public Guid? ServerConnectionUid { get; set; }

	public long User { get; set; }
}
