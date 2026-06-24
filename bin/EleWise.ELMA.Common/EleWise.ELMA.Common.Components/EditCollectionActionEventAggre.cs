using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Audit;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Components;

[Component]
internal class EditCollectionActionEventAggregator : IEntityActionEventAggregator
{
	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		List<ActionEventAggregatorResult> list = new List<ActionEventAggregatorResult>();
		foreach (ActionEventAggregatorResult result in previousResults)
		{
			if (result.EventArgs == null || result.EventArgs.Action == null || result.EventArgs.New == null || !(result.EventArgs is EditCollectionActionEventArgs editCollectionActionEventArgs) || editCollectionActionEventArgs.PropertyUid.Equals(Guid.Empty) || !(editCollectionActionEventArgs.Action.Uid == DefaultEntityActions.EditCollectionGuid) || !editCollectionActionEventArgs.Temporary)
			{
				continue;
			}
			result.Persist = false;
			if (previousResults.FirstOrDefault(delegate(ActionEventAggregatorResult a)
			{
				Guid? guid2 = a.EventArgs?.UnitOfWorkUid;
				Guid unitOfWorkUid2 = result.EventArgs.UnitOfWorkUid;
				return guid2.HasValue && (!guid2.HasValue || guid2.GetValueOrDefault() == unitOfWorkUid2) && a.EventArgs?.EntityType == result.EventArgs.EntityType && a.EventArgs?.Action?.Uid == DefaultEntityActions.CreateGuid && result.EventArgs.New.GetId().Equals(a.EventArgs?.New?.GetId());
			}) != null)
			{
				continue;
			}
			string dirtyPropertyName = GetDirtyPropertyName(editCollectionActionEventArgs);
			if (!(previousResults.Union(list).FirstOrDefault(delegate(ActionEventAggregatorResult a)
			{
				Guid? guid = a.EventArgs?.UnitOfWorkUid;
				Guid unitOfWorkUid = result.EventArgs.UnitOfWorkUid;
				return guid.HasValue && (!guid.HasValue || guid.GetValueOrDefault() == unitOfWorkUid) && a.EventArgs?.EntityType == result.EventArgs.EntityType && a.EventArgs?.Action?.Uid == DefaultEntityActions.UpdateGuid && result.EventArgs.New.GetId().Equals(a.EventArgs?.New?.GetId());
			})?.EventArgs is EditEntityActionEventArgs editEntityActionEventArgs))
			{
				EditEntityActionEventArgs eventArgs = new EditEntityActionEventArgs(result.EventArgs.Old, result.EventArgs.New, new string[1] { dirtyPropertyName });
				list.Add(new ActionEventAggregatorResult(this, eventArgs, persist: true));
				continue;
			}
			object propertyValue = editCollectionActionEventArgs.Old.GetPropertyValue(editCollectionActionEventArgs.PropertyUid);
			try
			{
				editEntityActionEventArgs.Old.SetPropertyValue(editCollectionActionEventArgs.PropertyUid, propertyValue);
				editEntityActionEventArgs.SetPropertyDirty(new string[1] { dirtyPropertyName });
			}
			catch (Exception ex)
			{
				Logger.Log.Error(SR.T("Не удалось установить значение свойства до изменения", ex));
			}
		}
		return list;
	}

	private string GetDirtyPropertyName(EditCollectionActionEventArgs eventArgs)
	{
		return eventArgs.Metadata.Properties.FirstOrDefault((PropertyMetadata prop) => prop.Uid == eventArgs.PropertyUid)?.Name;
	}
}
