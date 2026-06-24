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

public class RelationshipUserDescriptor : EntitySubTypeDescriptor<IRelationshipUser>
{
	public override Guid SubTypeUid => InterfaceActivator.UID<IRelationshipUser>();

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		if (val is IEnumerable<IRelationshipUser> source)
		{
			return source.All((IRelationshipUser a) => a.User == null);
		}
		if (val is IRelationshipUser relationshipUser)
		{
			return relationshipUser.User == null;
		}
		return false;
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
			if (entity != null && settings != null)
			{
				foreach (KeyValuePair<string, object> item in (IDictionary<string, object>)new EntityJsonSerializer().ConvertToSerializable(entity, settings))
				{
					if (!(item.Value is string value2) || !string.IsNullOrEmpty(value2))
					{
						serializableDictionary.Add(item.Key, item.Value);
					}
				}
				return serializableDictionary;
			}
		}
		return null;
	}
}
