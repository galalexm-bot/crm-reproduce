using System.Collections.Generic;

namespace EleWise.ELMA.Common.Models;

internal class EntityRestriction
{
	public List<string> EntityName { get; set; }

	public List<string> ActionNames { get; set; }

	public EntityHistoryType? HistoryType { get; set; }

	public EntityRestriction()
	{
		ActionNames = new List<string>();
		EntityName = new List<string>();
	}
}
