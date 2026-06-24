using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit.Impl;

namespace EleWise.ELMA.CRM.Audit;

[Component]
internal class RelationshipEditActionsEventAggregator : BaseEntityUpdateEventAggregator
{
	protected override IEnumerable<Guid> ProcessedActions
	{
		get
		{
			yield return RelationshipActions.ChangeTimeGuid;
			yield return RelationshipActions.EditGuid;
		}
	}
}
