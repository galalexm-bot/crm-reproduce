using System;

namespace EleWise.ELMA.Messages.Web.Models;

public class FeedParentSubjectModel
{
	public string Subject { get; set; }

	public Guid ObjectUid { get; set; }

	public string Url { get; set; }

	public bool IsWatch { get; set; }
}
