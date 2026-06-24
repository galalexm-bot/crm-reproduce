using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.History.Models;

internal class EventSerializationModel
{
	private readonly EntityJsonSerializer entitySerializer = new EntityJsonSerializer();

	private readonly string[] extendedPropertiesExcludedKeys = new string[5] { "New", "Old", "EntityType", "Metadata", "ActionAuthor" };

	public EntityActionEventArgs OriginalEvent { get; private set; }

	public byte[] AdditionalData { get; set; }

	public IDictionary<string, Type> ExtendedPropertiesTypes { get; set; }

	public IDictionary<string, object> ExtendedProperties { get; set; }

	public object NewEntitySerialized { get; set; }

	public object ActionAuthorSerialized { get; set; }

	public Guid ActionUid { get; set; }

	public Guid ObjectUid { get; set; }

	public Type EntityType { get; set; }

	public EventSerializationModel()
	{
	}

	public EventSerializationModel(EntityActionEventArgs eventArgs, IEnumerable<IEntityActionEventMapping> eventMappings)
	{
		EventSerializationModel eventSerializationModel = this;
		Contract.ArgumentNotNull(eventArgs, "eventArgs");
		OriginalEvent = eventArgs;
		AdditionalData = eventArgs.GetAdditionalData();
		ExtendedProperties = eventArgs.ExtendedProperties?.Where((KeyValuePair<string, object> x) => !eventSerializationModel.extendedPropertiesExcludedKeys.Contains(x.Key)).ToDictionary((KeyValuePair<string, object> x) => x.Key, (KeyValuePair<string, object> x) => x.Value);
		ExtendedPropertiesTypes = ExtendedProperties?.ToDictionary((KeyValuePair<string, object> x) => x.Key, (KeyValuePair<string, object> x) => x.Value.GetType());
		EntitySerializationSettings settings = ((eventArgs.EntityType != null) ? eventMappings.Select((IEntityActionEventMapping x) => x.GetEntitySerializationSettings(eventArgs.EntityType)).FirstOrDefault((EntitySerializationSettings x) => x != null) : null);
		NewEntitySerialized = ((eventArgs.New != null) ? entitySerializer.ConvertToSerializable(eventArgs.New, settings) : null);
		ActionAuthorSerialized = ((eventArgs.ActionAuthor != null) ? entitySerializer.ConvertToSerializable(eventArgs.ActionAuthor) : null);
		ActionUid = ((eventArgs.Action != null) ? eventArgs.Action.Uid : default(Guid));
		ObjectUid = ((eventArgs.Object != null) ? eventArgs.Object.Uid : default(Guid));
		EntityType = eventArgs.EntityType;
	}
}
