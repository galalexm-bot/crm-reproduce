using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Messages.Models;

public sealed class FeedMessageInfoModel
{
	public long Id { get; set; }

	public long Recipient { get; set; }

	public Guid ActionObjectUid { get; set; }

	public long ActionObjectId { get; set; }

	public DateTime ChangeDate { get; set; }

	public List<WebData> Data { get; set; }
}
