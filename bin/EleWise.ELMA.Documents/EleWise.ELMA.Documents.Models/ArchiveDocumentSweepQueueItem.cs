using System;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
internal class ArchiveDocumentSweepQueueItem
{
	public long DocumentId { get; set; }

	public bool Holded { get; set; }

	public DateTime UpdateDate { get; set; }
}
