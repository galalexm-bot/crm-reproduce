using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IBoundVariableService
{
	bool Contains(string name);

	T Get<T>(string name);

	bool TryGetValue<T>(string name, out T value);

	void Set(string name, object value);

	void Remove(string key);
}
