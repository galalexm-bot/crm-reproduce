using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Serialization;

[Component(Order = 2147483646)]
internal sealed class EntityDeserialization : IDeserialization
{
	private readonly System.Type entityType = typeof(Entity);

	private readonly System.Collections.Generic.IEnumerable<IEntityTypeFinder> entityTypeFinders;

	public EntityDeserialization(System.Collections.Generic.IEnumerable<IEntityTypeFinder> entityTypeFinders)
	{
		this.entityTypeFinders = entityTypeFinders;
	}

	public bool Check(System.Type type)
	{
		if (type != entityType)
		{
			return type == typeof(Entity[]);
		}
		return true;
	}

	public object Deserialize(System.Type type, string json)
	{
		object obj = ObjectDeserialization.Parse(json);
		if (type == typeof(Entity[]))
		{
			Entity[] array = new Entity[0];
			object[] array2 = ObjectExtensions.As<object[]>(obj);
			foreach (object obj2 in array2)
			{
				if (obj2 == null)
				{
					ArrayExtensions.Push<Entity>(array, (Entity[])null);
					continue;
				}
				System.Type type2 = GetEntityType(obj2);
				Entity entity = ObjectExtensions.As<Entity>(SerializationHelper.DeserializeObjectFromJson(ObjectExtensions.As<string>(obj2), type2));
				ArrayExtensions.Push<Entity>(array, new Entity[1] { entity });
			}
			return array;
		}
		System.Type type3 = GetEntityType(obj);
		return SerializationHelper.DeserializeObjectFromJson(ObjectExtensions.As<string>(obj), type3);
	}

	private System.Type GetEntityType(object item)
	{
		System.Type type = null;
		System.Collections.Generic.IEnumerator<IEntityTypeFinder> enumerator = entityTypeFinders.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				type = enumerator.get_Current().GetRealType(item);
				if (type != null)
				{
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (type == null)
		{
			type = entityType;
		}
		return type;
	}
}
