using System;
using EleWise.ELMA.Extensions;
using Newtonsoft.Json;
using NHibernate.Proxy;

namespace EleWise.ELMA.History.Serialization;

internal class NHibernateProxyJsonConverter : JsonConverter
{
	public static NHibernateProxyJsonConverter Instance = new NHibernateProxyJsonConverter();

	public override bool CanConvert(Type objectType)
	{
		return typeof(INHibernateProxy).IsAssignableFrom(objectType);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		if (value is INHibernateProxy)
		{
			serializer.Serialize(writer, value.CastAsRealType());
		}
	}
}
