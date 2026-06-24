using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.CRM.Audit;

[Component]
internal sealed class ContractorDefaultEditActionEventAggregator : IEntityActionEventAggregator
{
	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		foreach (ActionEventAggregatorResult result in previousResults)
		{
			if (result.EventArgs != null && result.EventArgs.Action != null && result.EventArgs.New != null && result.EventArgs.Action.Uid == DefaultEntityActions.UpdateGuid && typeof(IContractor).IsAssignableFrom(result.EventArgs.EntityType) && previousResults.All(delegate(ActionEventAggregatorResult a)
			{
				Guid? guid = a.EventArgs?.UnitOfWorkUid;
				Guid unitOfWorkUid = result.EventArgs.UnitOfWorkUid;
				return !guid.HasValue || (guid.HasValue && guid.GetValueOrDefault() != unitOfWorkUid) || a.EventArgs?.EntityType != result.EventArgs.EntityType || (a.EventArgs?.Action?.Uid != ContractorActions.EditGuid && a.EventArgs?.Action?.Uid != ContractorActions.AddCommentGuid) || !result.EventArgs.New.GetId().Equals(a.EventArgs?.New?.GetId());
			}))
			{
				EntityActionEventArgs eventArgs = new EntityActionEventArgs(null, result.EventArgs.New, "c7b89bfd-dc8f-440d-82a9-da1ee469afd9");
				yield return new ActionEventAggregatorResult(this, eventArgs, persist: true);
			}
		}
	}
}
