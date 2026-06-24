using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using Newtonsoft.Json;

namespace EleWise.ELMA.RPA.Services;

[Service]
internal class RPASerializationService : IRPASerializationService
{
	public string Serialize(object obj)
	{
		return ClassSerializationHelper.SerializeObjectByJsonNet(obj, RPASerializationDefaultJsonNetSettings.Converters);
	}

	public T Deserialize<T>(string json)
	{
		return JsonConvert.DeserializeObject<T>(json, RPASerializationDefaultJsonNetSettings.SerializerSettings);
	}
}
