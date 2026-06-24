namespace Orchard.Services;

public interface IJsonConverter : IDependency
{
	string Serialize(object o);

	string Serialize(object o, JsonFormat format);

	dynamic Deserialize(string json);

	T Deserialize<T>(string json);
}
