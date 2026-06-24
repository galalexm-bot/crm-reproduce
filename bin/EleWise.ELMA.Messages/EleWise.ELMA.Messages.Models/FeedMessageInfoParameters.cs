using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Messages.Models;

public class FeedMessageInfoParameters
{
	public Guid ObjectUid { get; set; }

	public long ObjectId { get; set; }

	public Guid ActionUid { get; set; }

	public List<long> Recipients { get; set; }
}
