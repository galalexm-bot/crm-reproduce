using System;

namespace EleWise.ELMA.CRM.Models;

public class MarketingTreeItem
{
	public long Id { get; set; }

	public string Name { get; set; }

	public int ChildrenCount { get; set; }

	public Guid TypeUid { get; set; }
}
