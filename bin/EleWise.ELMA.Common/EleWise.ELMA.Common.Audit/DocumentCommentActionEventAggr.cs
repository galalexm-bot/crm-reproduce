using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Common.Audit;

[Component]
internal class DocumentCommentActionEventAggregator : IEntityActionEventAggregator
{
	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		foreach (var item in (from e in previousResults
			where e != null && e.Persist && e.EventArgs != null && e.EventArgs.Action != null && e.EventArgs.Action.Uid == DefaultEntityActions.CreateGuid && e.EventArgs.New != null && e.EventArgs.New is IComment && e.EventArgs.New.GetId() != null && e.EventArgs.Object != null && e.EventArgs.Object.Uid == InterfaceActivator.UID<IComment>()
			orderby e.EventArgs.ActionDate
			group e by new
			{
				UoW = e.EventArgs.UnitOfWorkUid,
				Id = e.EventArgs.New.GetId().ToString()
			}).ToList())
		{
			item.Skip(1).ForEach(delegate(ActionEventAggregatorResult e)
			{
				e.Persist = false;
			});
		}
		return Enumerable.Empty<ActionEventAggregatorResult>();
	}
}
