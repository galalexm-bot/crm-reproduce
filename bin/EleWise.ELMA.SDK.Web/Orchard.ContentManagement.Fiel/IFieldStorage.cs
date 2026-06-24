namespace Orchard.ContentManagement.FieldStorage;

public interface IFieldStorage
{
	T Get<T>(string name);

	void Set<T>(string name, T value);
}
