using System;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.History.Models;

internal sealed class EntityActionEventTuple
{
	public Guid Uid { get; set; }

	public EntityActionEventArgs EntityActionEventArgs { get; set; }

	public bool IsRelatedEvent { get; set; }
}
