using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.History.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EleWise.ELMA.History.Services;

[Service]
internal sealed class EventSerializationService : IEventSerializationService
{
	private readonly EntityJsonSerializer entitySerializer = new EntityJsonSerializer();

	private readonly string[] excludedPropList = new string[7] { "New", "Old", "ActionAuthor", "Action", "Object", "EntityType", "ExtendedProperties" };

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public IAuditManager AuditManager { get; set; }

	public IEnumerable<IEntityActionEventMapping> EventMappings { get; set; }

	public string Serialize(EntityActionEventArgs eventArgs)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		EventSerializationModel eventSerializationModel = new EventSerializationModel(eventArgs, EventMappings);
		string result = null;
		try
		{
			JsonSerializerSettings val = new JsonSerializerSettings();
			val.set_TypeNameHandling((TypeNameHandling)1);
			val.set_TypeNameAssemblyFormatHandling((TypeNameAssemblyFormatHandling)0);
			val.set_Converters((IList<JsonConverter>)(object)new JsonConverter[1] { NHibernateProxyJsonConverter.Instance });
			result = JsonConvert.SerializeObject((object)eventSerializationModel, (Formatting)0, val);
			return result;
		}
		catch (Exception exception)
		{
			object obj = (eventArgs.ExtendedProperties.ContainsKey("EntityActionHistory_Uid") ? eventArgs.ExtendedProperties["EntityActionHistory_Uid"] : null);
			Logger.Log.Warn(SR.T("Ошибка сериализации события истории Uid={0}", obj), exception);
			return result;
		}
	}

	public EntityActionEventArgs Deserialize(string serializedData)
	{
		JObject val = JObject.Parse(serializedData);
		object obj = DeserializeEntityOrNull(((object)val.get_Item("NewEntitySerialized")).ToString());
		if (obj == null)
		{
			throw new ArgumentNullException("New");
		}
		Guid guid = val.get_Item("ActionUid").ToObject<Guid>();
		Guid guid2 = val.get_Item("ObjectUid").ToObject<Guid>();
		Type type = val.get_Item("OriginalEvent").get_Item((object)"$type").ToObject<Type>() ?? typeof(EntityActionEventArgs);
		GetCtorOrThrow(type);
		EntityActionEventArgs entityActionEventArgs = (EntityActionEventArgs)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[3] { obj, guid2, guid }, null);
		if (entityActionEventArgs.Action == null)
		{
			entityActionEventArgs.Action = AuditManager.GetAction(guid);
		}
		if (entityActionEventArgs.Object == null)
		{
			entityActionEventArgs.Object = AuditManager.GetObject(guid2);
		}
		entityActionEventArgs.ActionAuthor = (IUser)DeserializeEntityOrNull(((object)val.get_Item("ActionAuthorSerialized")).ToString());
		entityActionEventArgs.EntityType = val.get_Item("EntityType").ToObject<Type>();
		IDictionary<string, object> dictionary = entitySerializer.DeserializeJson(((object)val.get_Item("OriginalEvent")).ToString());
		PropertyInfo[] properties = type.GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (dictionary.TryGetValue(propertyInfo.Name, out var value) && !excludedPropList.Contains(propertyInfo.Name) && propertyInfo.CanWrite)
			{
				propertyInfo.SetValue(entityActionEventArgs, ConvertValueFromSerializable(value, propertyInfo.PropertyType));
			}
		}
		JToken val2 = default(JToken);
		if (val.TryGetValue("AdditionalData", ref val2))
		{
			entityActionEventArgs.SetAdditionalData(val2.ToObject<byte[]>());
		}
		ExpandoObject expandoObject = entitySerializer.DeserializeJson(((object)val.get_Item("ExtendedProperties")).ToString());
		IDictionary<string, Type> dictionary2 = val.get_Item("ExtendedPropertiesTypes").ToObject<IDictionary<string, Type>>();
		foreach (KeyValuePair<string, object> item in (IEnumerable<KeyValuePair<string, object>>)expandoObject)
		{
			if (!entityActionEventArgs.ExtendedProperties.ContainsKey(item.Key) && dictionary2.ContainsKey(item.Key))
			{
				object value2 = ConvertValueFromSerializable(item.Value, dictionary2[item.Key]);
				entityActionEventArgs.ExtendedProperties.Add(item.Key, value2);
			}
		}
		return entityActionEventArgs;
	}

	private void GetCtorOrThrow(Type originalEventType)
	{
		if (originalEventType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new Type[3]
		{
			typeof(IEntity),
			typeof(Guid),
			typeof(Guid)
		}, null) == null)
		{
			throw new InvalidOperationException(SR.T("Ошибка восстановления истории объектов. Тип {0} не имеет конструктора с параметрами [{1}, {2}, {3}]", originalEventType.FullName, typeof(IEntity).FullName, typeof(Guid).FullName, typeof(Guid).FullName));
		}
	}

	private object DeserializeEntityOrNull(string serializedEntity)
	{
		IDictionary<string, object> dictionary = entitySerializer.DeserializeJson(serializedEntity);
		object result = null;
		if (dictionary != null)
		{
			Guid uid = Guid.Parse(dictionary["TypeUid"].ToString());
			bool orDefault = ContextVars.GetOrDefault<bool>("LoadEntitiesInner");
			ContextVars.Set("LoadEntitiesInner", value: true);
			try
			{
				return entitySerializer.ConvertFromSerializable(dictionary, MetadataRuntimeService.GetTypeByUid(uid), loadEntityIfExists: false);
			}
			finally
			{
				ContextVars.Set("LoadEntitiesInner", orDefault);
			}
		}
		return result;
	}

	private object ConvertValueFromSerializable(object value, Type type)
	{
		if (value is IDictionary<string, object> serObj)
		{
			bool orDefault = ContextVars.GetOrDefault<bool>("LoadEntitiesInner");
			ContextVars.Set("LoadEntitiesInner", value: true);
			try
			{
				return entitySerializer.ConvertFromSerializable(serObj, type, loadEntityIfExists: false);
			}
			finally
			{
				ContextVars.Set("LoadEntitiesInner", orDefault);
			}
		}
		if (value == null)
		{
			return null;
		}
		Type type2 = value.GetType();
		TypeConverter converter = TypeDescriptor.GetConverter(type);
		if (converter.CanConvertFrom(type2))
		{
			return converter.ConvertFrom(value);
		}
		try
		{
			return Convert.ChangeType(value, type);
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Не удалось преобразовать тип для восстановления события истории"), exception);
			return null;
		}
	}
}
