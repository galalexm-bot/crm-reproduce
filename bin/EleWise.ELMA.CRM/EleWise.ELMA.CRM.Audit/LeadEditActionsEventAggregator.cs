using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit.Impl;

namespace EleWise.ELMA.CRM.Audit;

[Component]
internal class LeadEditActionsEventAggregator : BaseEntityUpdateEventAggregator
{
	protected override IEnumerable<Guid> ProcessedActions
	{
		get
		{
			yield return LeadActions.ActivatedGuid;
			yield return LeadActions.InHandGuid;
			yield return LeadActions.DublicateGuid;
			yield return LeadActions.QualifiedGuid;
			yield return LeadActions.UnqualifiedGuid;
		}
	}
}
