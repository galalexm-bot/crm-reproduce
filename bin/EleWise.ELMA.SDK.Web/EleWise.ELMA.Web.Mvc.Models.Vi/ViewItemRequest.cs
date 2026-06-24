using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.ViewItem;

public class ViewItemRequest
{
	public string HtmlPrefix { get; set; }

	public Guid EntityTypeUid { get; set; }

	public long EntityId { get; set; }

	public List<string> RegisteredZones { get; set; } = new List<string>();

}
