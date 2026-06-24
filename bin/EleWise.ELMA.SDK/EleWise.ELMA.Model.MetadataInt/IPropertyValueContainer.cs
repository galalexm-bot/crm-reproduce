using System;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

public interface IPropertyValueContainer
{
	Type PropertyType { get; }

	object Get(object obj);

	void Set(object obj, object value);
}
public interface IPropertyValueContainer<T> : IPropertyValueContainer
{
	new T Get(object obj);

	void Set(object obj, T value);
}
