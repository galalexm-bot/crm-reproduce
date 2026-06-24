using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.CRM.Descriptors;

public class AddressDescriptor : EntitySubTypeDescriptor<IAddress>
{
	public override Guid SubTypeUid => InterfaceActivator.UID<IAddress>();

	public override bool UseEntityFilterOnly => true;

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		if (val is IEnumerable<IAddress> source)
		{
			return source.All((IAddress a) => string.IsNullOrWhiteSpace(a.Name));
		}
		if (val is IAddress address)
		{
			return string.IsNullOrWhiteSpace(address.Name);
		}
		return true;
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		if (valueType == null)
		{
			throw new ArgumentNullException("valueType");
		}
		if (typeof(IEntity).IsAssignableFrom(valueType))
		{
			IEntity entity = value as IEntity;
			SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
			if (entity != null)
			{
				if (settings == null)
				{
					settings = new EntitySerializationSettings();
				}
				{
					foreach (KeyValuePair<string, object> item in (IDictionary<string, object>)new EntityJsonSerializer().ConvertToSerializable(entity, settings))
					{
						serializableDictionary.Add(item.Key, item.Value);
					}
					return serializableDictionary;
				}
			}
		}
		return null;
	}
}
