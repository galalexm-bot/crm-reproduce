using System;

namespace EleWise.ELMA.History.Models;

internal sealed class HistoryUpdateQueueItem
{
	public long Id { get; set; }

	public long ObjectId { get; set; }

	public Guid ObjectTypeUid { get; set; }

	public long? LastActionDate { get; set; }

	public bool DeleteRelated { get; set; }

	public DateTime CreationDate { get; set; }

	public int Attempt { get; set; }

	public DateTime? LastUpdateDate { get; set; }

	public DateTime NextUpdateDate { get; set; }

	public Guid? ServerConnectionUid { get; set; }
}
