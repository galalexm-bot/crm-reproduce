using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.History.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.History.Models;

internal class HistoryModelResultTransformer : AliasToBeanResultTransformer
{
	private class HistoryModelInternal
	{
		public Guid Uid { get; set; }

		public string Model { get; set; }

		public bool IsRelatedEvent { get; set; }
	}

	private IEventSerializationService eventSerializationService;

	private IEventSerializationService EventSerializationService => eventSerializationService ?? (eventSerializationService = Locator.GetServiceNotNull<IEventSerializationService>());

	public HistoryModelResultTransformer()
		: base(typeof(HistoryModelInternal))
	{
	}

	public HistoryModelResultTransformer(IEventSerializationService eventSerializationService)
		: this()
	{
		this.eventSerializationService = eventSerializationService;
	}

	public override IList TransformList(IList collection)
	{
		IList source = base.TransformList(collection);
		IEventSerializationService serializationService = EventSerializationService;
		return (from HistoryModelInternal model in source
			select new EntityActionEventTuple
			{
				Uid = model.Uid,
				EntityActionEventArgs = serializationService.Deserialize(model.Model),
				IsRelatedEvent = model.IsRelatedEvent
			} into x
			where x.EntityActionEventArgs != null
			select x).ToList();
	}
}
