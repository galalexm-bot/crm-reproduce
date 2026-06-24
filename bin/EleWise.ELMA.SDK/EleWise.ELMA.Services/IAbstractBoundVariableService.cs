namespace EleWise.ELMA.Services;

public interface IAbstractBoundVariableService
{
	bool Contains(string name);

	T Get<T>(string name);

	bool TryGetValue<T>(string name, out T value);

	void Set(string name, object value);

	void Remove(string key);
}
