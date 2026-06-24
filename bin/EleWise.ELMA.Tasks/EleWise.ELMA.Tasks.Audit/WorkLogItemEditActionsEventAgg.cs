using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit;

[Component]
internal class WorkLogItemEditActionsEventAggregator : BaseEntityUpdateEventAggregator
{
	protected override IEnumerable<Guid> ProcessedActions
	{
		get
		{
			yield return WorkLogItemActions.ConfirmApprovalGuid;
			yield return WorkLogItemActions.RefuseApprovalGuid;
			yield return WorkLogItemActions.RedirectGuid;
			yield return WorkLogItemActions.EditGuid;
			yield return WorkLogItemActions.SendToApproveGuid;
			yield return WorkLogItemActions.ChangeStatusGuid;
		}
	}
}
