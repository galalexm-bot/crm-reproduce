using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Orchard.Services;

public class DefaultJsonConverter : IJsonConverter, IDependency
{
	public string Serialize(object o)
	{
		return JsonConvert.SerializeObject(o);
	}

	public string Serialize(object o, JsonFormat format)
	{
		return JsonConvert.SerializeObject(o, (Formatting)(format == JsonFormat.Indented));
	}

	public dynamic Deserialize(string json)
	{
		return JObject.Parse(json);
	}

	public T Deserialize<T>(string json)
	{
		return JsonConvert.DeserializeObject<T>(json);
	}
}
