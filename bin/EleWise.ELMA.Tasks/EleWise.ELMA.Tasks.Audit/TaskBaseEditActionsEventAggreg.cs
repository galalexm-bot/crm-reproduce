using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit;

[Component]
internal class TaskBaseEditActionsEventAggregator : BaseEntityUpdateEventAggregator
{
	protected override IEnumerable<Guid> ProcessedActions
	{
		get
		{
			yield return TaskBaseActions.StartWorkGuid;
			yield return TaskBaseActions.RedirectGuid;
			yield return TaskBaseActions.CompleteGuid;
			yield return TaskBaseActions.IncompleteGuid;
			yield return TaskBaseActions.ChangeEndDateGuid;
			yield return TaskBaseActions.EditGuid;
			yield return TaskBaseActions.TerminateGuid;
			yield return TaskActions.ControlCompleteGuid;
			yield return TaskActions.ChangeControlGuid;
			yield return TaskActions.CloseGuid;
			yield return TaskActions.ConfirmApprovalGuid;
			yield return TaskActions.RefuseApprovalGuid;
			yield return TaskActions.ReopenGuid;
			yield return AccessRequestTaskActions.CloseGuid;
			yield return AccessRequestTaskActions.ApproveAccessRequestGuid;
			yield return AccessRequestTaskActions.RefuseAccessRequestGuid;
		}
	}
}
