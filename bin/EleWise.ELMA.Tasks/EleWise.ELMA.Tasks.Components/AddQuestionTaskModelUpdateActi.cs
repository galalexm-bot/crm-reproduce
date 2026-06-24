using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

internal class AddQuestionTaskModelUpdateActionHandler : BaseTaskModelUpdateActionHandler
{
	protected override bool IsTaskUpdated(EntityActionEventArgs e)
	{
		return e.Action.Uid == TaskBaseActions.AddQuestionGuid;
	}
}
