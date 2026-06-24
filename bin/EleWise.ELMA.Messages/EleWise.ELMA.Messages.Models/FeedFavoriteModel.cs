using System;

namespace EleWise.ELMA.Messages.Models;

public sealed class FeedFavoriteModel
{
	public long Id { get; set; }

	public long Recipient { get; set; }

	public Guid ActionObjectUid { get; set; }

	public long ActionObjectId { get; set; }

	public bool IsDelete { get; set; }

	public string ChangeDateHash { get; set; }
}
