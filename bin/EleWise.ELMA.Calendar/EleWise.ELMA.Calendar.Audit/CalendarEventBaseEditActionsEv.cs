using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;

namespace EleWise.ELMA.Calendar.Audit;

[Component]
internal class CalendarEventBaseEditActionsEventAggregator : BaseEntityUpdateEventAggregator
{
	protected override IEnumerable<Guid> ProcessedActions
	{
		get
		{
			yield return CalendarEventActions.ChangeTimeGuid;
			yield return CalendarEventActions.CompleteGuid;
			yield return CalendarEventActions.EditGuid;
		}
	}
}
