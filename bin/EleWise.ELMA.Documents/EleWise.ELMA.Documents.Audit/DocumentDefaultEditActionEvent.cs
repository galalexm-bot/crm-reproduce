using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Audit;

[Component]
internal sealed class DocumentDefaultEditActionEventAggregator : IEntityActionEventAggregator
{
	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		foreach (ActionEventAggregatorResult result in previousResults)
		{
			if (result.EventArgs != null && result.EventArgs.Action != null && result.EventArgs.New != null && result.EventArgs.Action.Uid == DefaultEntityActions.UpdateGuid && typeof(IDocument).IsAssignableFrom(result.EventArgs.EntityType) && previousResults.All(delegate(ActionEventAggregatorResult a)
			{
				Guid? guid = a.EventArgs?.UnitOfWorkUid;
				Guid unitOfWorkUid = result.EventArgs.UnitOfWorkUid;
				return !guid.HasValue || (guid.HasValue && guid.GetValueOrDefault() != unitOfWorkUid) || a.EventArgs?.EntityType != result.EventArgs.EntityType || (a.EventArgs?.Action?.Uid != DmsObjectActions.EditGuid && a.EventArgs?.Action?.Uid != DocumentActions.AddCommentGuid) || !result.EventArgs.New.GetId().Equals(a.EventArgs?.New?.GetId());
			}))
			{
				EntityActionEventArgs eventArgs = new EntityActionEventArgs(null, result.EventArgs.New, DmsObjectActions.EditGuid);
				yield return new ActionEventAggregatorResult(this, eventArgs, persist: true);
			}
		}
	}
}
