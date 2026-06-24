using System.Collections.Generic;

namespace EleWise.ELMA.Common.Models;

internal class EntityHistoryRestriction
{
	public bool RestrictAllModel { get; set; }

	public bool RestrictAllAction { get; set; }

	public List<EntityRestriction> EntityRestrictions { get; set; }

	public EntityHistoryRestriction()
	{
		EntityRestrictions = new List<EntityRestriction>();
	}
}
