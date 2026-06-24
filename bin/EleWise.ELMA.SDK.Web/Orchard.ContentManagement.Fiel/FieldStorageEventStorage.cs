using System.Collections.Generic;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.FieldStorage;

public class FieldStorageEventStorage : IFieldStorage
{
	private readonly IFieldStorage _concreteStorage;

	private readonly ContentPartFieldDefinition _contentPartFieldDefinition;

	private readonly ContentPart _contentPart;

	private readonly IEnumerable<IFieldStorageEvents> _events;

	public FieldStorageEventStorage(IFieldStorage concreteStorage, ContentPartFieldDefinition contentPartFieldDefinition, ContentPart contentPart, IEnumerable<IFieldStorageEvents> events)
	{
		_concreteStorage = concreteStorage;
		_contentPartFieldDefinition = contentPartFieldDefinition;
		_contentPart = contentPart;
		_events = events;
	}

	public T Get<T>(string name)
	{
		return _concreteStorage.Get<T>(name);
	}

	public void Set<T>(string name, T value)
	{
		_concreteStorage.Set(name, value);
		FieldStorageEventContext called = new FieldStorageEventContext
		{
			FieldName = _contentPartFieldDefinition.Name,
			PartName = _contentPart.PartDefinition.Name,
			Value = value,
			ValueName = name,
			ValueType = typeof(T),
			Content = _contentPart
		};
		foreach (IFieldStorageEvents @event in _events)
		{
			@event.SetCalled(called);
		}
	}
}
