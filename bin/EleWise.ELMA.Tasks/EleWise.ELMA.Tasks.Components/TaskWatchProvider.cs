using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class TaskWatchProvider : BaseWatchProvider
{
	public override IEnumerable<Guid> TypeUid
	{
		get
		{
			yield return InterfaceActivator.UID<ITask>();
		}
	}

	public override IEnumerable<Guid> ActionUids
	{
		get
		{
			yield return DefaultEntityActions.CreateGuid;
			yield return DefaultEntityActions.DeleteGuid;
			yield return TaskBaseActions.EditGuid;
			yield return TaskBaseActions.AddCommentGuid;
			yield return TaskBaseActions.StartWorkGuid;
			yield return TaskBaseActions.ActivateGuid;
			yield return TaskBaseActions.ScheduleGuid;
			yield return TaskBaseActions.RedirectGuid;
			yield return TaskBaseActions.CreateSubTaskGuid;
			yield return TaskBaseActions.TerminateGuid;
			yield return TaskBaseActions.ChangeEndDateGuid;
			yield return TaskBaseActions.CompleteGuid;
			yield return TaskBaseActions.IncompleteGuid;
			yield return TaskActions.ChangeControlGuid;
			yield return TaskActions.ControlCompleteGuid;
			yield return TaskActions.CloseGuid;
			yield return TaskActions.ReopenGuid;
			yield return TaskActions.ConfirmApprovalGuid;
			yield return TaskActions.RefuseApprovalGuid;
		}
	}

	public override string WatchDescription => SR.T("Вы будете получать оповещения по всем изменениям задачи \"{0}\"");

	public override bool NeedConfirmFromDelete(Guid entityTypeUid, object entityId)
	{
		IEntityManager entityManager = ModelHelper.GetEntityManager(ModelHelper.GetEntityType(entityTypeUid));
		if (entityManager == null)
		{
			return false;
		}
		if (!(entityManager.LoadOrNull(entityId).CastAsRealType() is ITask task))
		{
			return false;
		}
		return !Locator.GetServiceNotNull<TaskWorkflowActions>().IsAvailableDeleteWatches(task, Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>());
	}

	public override string TextConfirmFromDelete(Guid entityTypeUid, object entityId)
	{
		return SR.T("Отписаться от задачи?");
	}
}
